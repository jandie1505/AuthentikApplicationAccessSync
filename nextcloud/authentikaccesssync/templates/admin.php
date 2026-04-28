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

        <p>
            <label for="subject_mode"><?php p($l->t('Subject mode')); ?></label>
            <select id="subject_mode" name="subject_mode">
                <?php foreach (['uuid', 'pk', 'username', 'email'] as $m): ?>
                    <option value="<?php p($m); ?>" <?php if ($_['subject_mode'] === $m) p('selected'); ?>>
                        <?php p($m); ?>
                    </option>
                <?php endforeach; ?>
            </select>
        </p>

        <button type="submit"><?php p($l->t('Save')); ?></button>
    </form>
</div>