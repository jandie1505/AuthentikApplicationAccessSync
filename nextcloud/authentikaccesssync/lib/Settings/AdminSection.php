<?php

namespace OCA\AuthentikAccessSync\Settings;

use OCP\IL10N;
use OCP\IURLGenerator;
use OCP\Settings\IIconSection;

class AdminSection implements IIconSection {

    public function __construct(
        private IL10N $l,
        private IURLGenerator $urlGenerator,
    ) {}

    public function getID(): string {
        return 'authentikaccesssync';
    }

    public function getName(): string {
        return $this->l->t('Authentik Access Sync');
    }

    public function getPriority(): int {
        return 75;
    }

    public function getIcon(): string {
        return $this->urlGenerator->imagePath("authentikaccesssync", "app-dark.svg");
    }

}