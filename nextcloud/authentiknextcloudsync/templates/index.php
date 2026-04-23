<?php

declare(strict_types=1);

use OCP\Util;

Util::addScript(OCA\AuthentikNextcloudSync\AppInfo\Application::APP_ID, OCA\AuthentikNextcloudSync\AppInfo\Application::APP_ID . '-main');
Util::addStyle(OCA\AuthentikNextcloudSync\AppInfo\Application::APP_ID, OCA\AuthentikNextcloudSync\AppInfo\Application::APP_ID . '-main');

?>

<div id="authentiknextcloudsync"></div>
