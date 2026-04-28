<?php
?>

<div class="section" id="authentikaccesssync">
    <h2><?php p($l->t('Authentik Access Sync')); ?></h2>

    <form id="authentikaccesssync-admin" method="POST"
          action="<?php p(\OC::$server->getURLGenerator()->linkToRoute('authentikaccesssync.settings.save')); ?>">
        <input type="hidden" name="requesttoken" value="<?php p(\OCP\Util::callRegister()); ?>">

        <p>
            <label for="authentik_url"><?php p($l->t('Authentik URL')); ?></label>
            <input type="url" id="authentik_url" name="authentik_url"
                   value="<?php p($_['authentik_url']); ?>"
                   placeholder="https://authentik.example.com/api/v3/">
        </p>

        <p>
            <label for="authentik_token"><?php p($l->t('API token')); ?></label>
            <input type="password" id="authentik_token" name="authentik_token"
                   placeholder="<?php p($_['token_set'] ? $l->t('(token set — leave empty to keep)') : $l->t('paste token')); ?>">
        </p>

        <p>
            <label for="application_slug"><?php p($l->t('Application slug')); ?></label>
            <input type="text" id="application_slug" name="application_slug"
                   value="<?php p($_['application_slug']); ?>">
        </p>

        <fieldset style="margin-top: 1em; padding: 0.5em 0; border: none; border-top: 1px solid var(--color-border);">
            <h3><?php p($l->t('User Identification Settings')); ?></h3>
            <p>The following settings <b>MUST</b> match with the settings in the OpenID Connect user backend plugin.</p>

            <p>
                <label for="subject_mode"><?php p($l->t('Subject mode')); ?></label>
                <select id="subject_mode" name="subject_mode">
                    <?php foreach (['pk', 'uuid', 'hashed_pk_uuid', 'username', 'email'] as $m): ?>
                        <option value="<?php p($m); ?>" <?php if ($_['subject_mode'] === $m) p('selected'); ?>>
                            <?php p($m); ?>
                        </option>
                    <?php endforeach; ?>
                </select>
                <br>
                <small><?php p($l->t('Selects which field in Authentik is used as sub-claim. Please note that the option User-ID Mapping in the OIDC plugin <b>MUST</b> be set to sub.')); ?></small>
            </p>

            <p>
                <label for="user_id_mode"><?php p($l->t('User ID Mode')); ?></label>
                <select id="user_id_mode" name="user_id_mode">
                    <?php foreach ([
                        'unique' => $l->t('Use unique user ID'),
                        'prefixed' => $l->t('Use provider identifier as prefix'),
                        'off' => $l->t('Aus'),
                    ] as $value => $label): ?>
                        <option value="<?php p($value); ?>" <?php if ($_['user_id_mode'] === $value) p('selected'); ?>>
                            <?php p($label); ?>
                        </option>
                    <?php endforeach; ?>
                </select>
                <br>
                <small><?php p($l->t('Controls how the Nextcloud User ID is created from the sub claim. You need to set this option according to the options in the OpenID Connect user backend plugin.')); ?></small>
            </p>
        </fieldset>

        <button type="submit"><?php p($l->t('Save')); ?></button>
    </form>
</div>