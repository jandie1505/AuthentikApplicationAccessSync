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
            'token_set' => $this->appConfig->getValueString(self::APP_ID, 'authentik_token', '') !== '',
            'application_slug' => $this->appConfig->getValueString(self::APP_ID, 'application_slug', ''),
            'subject_mode' => $this->appConfig->getValueString(self::APP_ID, 'subject_mode', 'pk'),
            'user_id_mode' => $this->appConfig->getValueString(self::APP_ID, 'user_id_mode', 'unique'),
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