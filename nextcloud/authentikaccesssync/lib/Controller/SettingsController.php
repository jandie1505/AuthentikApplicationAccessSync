<?php

namespace OCA\AuthentikAccessSync\Controller;

use OCP\AppFramework\Controller;
use OCP\AppFramework\Http\Attribute\AuthorizedAdminSetting;
use OCP\AppFramework\Http\DataResponse;
use OCP\IAppConfig;
use OCP\IRequest;

class SettingsController extends Controller {
    private const APP_ID = 'authentikaccesssync';

    public function __construct(
        IRequest $request,
        private IAppConfig $appConfig,
    ) {
        parent::__construct(self::APP_ID, $request);
    }

    #[AuthorizedAdminSetting(settings: Admin::class)]
    public function save(
        string $authentik_url,
        string $authentik_token,
        string $application_slug,
        string $subject_mode,
    ): DataResponse {
        $this->appConfig->setValueString(self::APP_ID, 'authentik_url', $authentik_url);
        $this->appConfig->setValueString(self::APP_ID, 'application_slug', $application_slug);
        $this->appConfig->setValueString(self::APP_ID, 'subject_mode', $subject_mode);

        if ($authentik_token !== '') {
            $this->appConfig->setValueString(self::APP_ID, 'authentik_token', $authentik_token, lazy: false, sensitive: true);
        }

        return new DataResponse(['status' => 'ok']);
    }

}