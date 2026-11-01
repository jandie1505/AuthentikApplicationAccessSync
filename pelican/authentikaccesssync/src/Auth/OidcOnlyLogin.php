<?php

namespace Jandie1505\AuthentikAccessSync\Auth;

use App\Filament\Pages\Auth\Login;
use App\Models\User;
use Jandie1505\AuthentikAccessSync\Support\OidcOnly;
use Illuminate\Contracts\Auth\Authenticatable;
use Illuminate\Validation\ValidationException;

/**
 * Login page with blocks login for OIDC-only users.
 */
class OidcOnlyLogin extends Login
{
    protected function isUserAllowedToAccessPanel(Authenticatable $user): bool
    {
        if ($user instanceof User && OidcOnly::applies($user)) {
            $this->dispatch('reset-captcha');

            throw ValidationException::withMessages([
                'data.login' => 'Dieses Konto kann sich nur über Authentik anmelden.',
            ]);
        }

        return parent::isUserAllowedToAccessPanel($user);
    }
}
