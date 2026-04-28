<?php

namespace OCA\AuthentikAccessSync\Settings;

use OCP\AppFramework\Http\TemplateResponse;
use OCP\IAppConfig;
use OCP\Settings\ISettings;

class Admin implements ISettings {
    private const APP_ID = 'authentikaccesssync';

    public function __construct(
        private IAppConfig $appConfig,
    ) {}

    public function getForm(): TemplateResponse {
        $params = [
            'authentik_url' => $this->appConfig->getValueString(self::APP_ID, 'authentik_url', ''),
            'authentik_token' => $this->appConfig->getValueString(self::APP_ID, 'authentik_token', ''),
            'application_slug' => $this->appConfig->getValueString(self::APP_ID, 'application_slug', '') !== '',
        ];
        return new TemplateResponse(self::APP_ID, 'admin', $params, TemplateResponse::RENDER_AS_BLANK);
    }

    public function getSection(): string {
        return 'authentikaccesssync';
    }

    public function getPriority(): int {
        return 50;
    }

}