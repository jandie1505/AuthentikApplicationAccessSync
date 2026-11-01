<?php

namespace Jandie1505\AuthentikAccessSync\Support;

use App\Models\User;

final class OidcOnly
{
    public const PROVIDER = 'authentik';

    /**
     * Checks if the user is linked with Authentik.
     */
    public static function isLinked(User $user): bool
    {
        return filled(($user->oauth ?? [])[self::PROVIDER] ?? null);
    }

    /**
     * Are the OIDC rules applied (managed externally AND linked to Authentik).
     */
    public static function applies(?User $user): bool
    {
        return $user instanceof User
            && $user->is_managed_externally
            && self::isLinked($user);
    }
}
