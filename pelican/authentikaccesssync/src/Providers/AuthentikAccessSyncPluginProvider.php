<?php

namespace Jandie1505\AuthentikAccessSync\Providers;

use App\Models\User;
use Jandie1505\AuthentikAccessSync\Support\OidcOnly;
use Filament\Notifications\Notification;
use Filament\Support\Exceptions\Halt;
use Illuminate\Http\Request;
use Illuminate\Support\ServiceProvider;
use Laravel\Passkeys\Exceptions\InvalidPasskeyException;
use Laravel\Passkeys\Passkey;
use Laravel\Passkeys\Passkeys;

class AuthentikAccessSyncPluginProvider extends ServiceProvider
{
    public function register(): void {}

    public function boot(): void
    {
        // Enable managed externally for new users created by OIDC login
        User::creating(function (User $user) {
            if (OidcOnly::isLinked($user)) {
                $user->is_managed_externally = true;
            }
        });

        User::updating(function (User $user) {
            if (!$user->isDirty('oauth')) {
                return;
            }

            $wasLinked = filled(($user->getOriginal('oauth') ?? [])[OidcOnly::PROVIDER] ?? null);
            $isLinked = OidcOnly::isLinked($user);

            // Enable managed externally for a user that links the Authentik account after the registration
            if (!$wasLinked && $isLinked && !$user->isAdmin()) {
                $user->is_managed_externally = true;
            }

            // Prevent users from unlinking their account from Authentik
            if ($wasLinked && !$isLinked
                && $user->getOriginal('is_managed_externally')
                && auth()->id() === $user->getKey()) {
                Notification::make()
                    ->title('Authentik cannot be disconnected')
                    ->body('Your account is managed by Authentik and cannot be unlinked from it manually. Please contact an admin if you think this is an error.')
                    ->danger()
                    ->send();

                throw new Halt();
            }
        });

        // Reject passkey login for Authentik users
        Passkeys::authorizeLoginUsing(
            fn (Request $request, $user) => !OidcOnly::applies($user instanceof User ? $user : null)
        );

        // Prevent adding passkeys for Authentik users
        Passkeys::passkeyModel()::creating(function (Passkey $passkey) {
            $user = User::find($passkey->user_id);

            if (OidcOnly::applies($user)) {
                throw InvalidPasskeyException::make('Passkeys are disabled for Authentik users.');
            }
        });
    }
}
