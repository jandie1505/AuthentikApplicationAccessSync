<?php

namespace Jandie1505\AuthentikAccessSync;

use Jandie1505\AuthentikAccessSync\Auth\OidcOnlyLogin;
use Filament\Contracts\Plugin;
use Filament\Panel;

class AuthentikAccessSyncPlugin implements Plugin
{
    public function getId(): string
    {
        return 'authentikaccesssync';
    }

    public function register(Panel $panel): void
    {
        $panel->login(OidcOnlyLogin::class); // Replaces the login page
    }

    public function boot(Panel $panel): void {}
}
