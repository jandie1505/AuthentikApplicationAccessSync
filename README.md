# AuthentikAccountActiveStatusSync
Synchronizes the account active status from authentik with services using Authentik as SSO provider.

## Immich

### Build
Since there is no public docker image, you need to build it yourself:
```shell
docker build -t immich-authentik-sync:latest immich/
```

If you have built the image on your computer, but you want to run it on a server, you can export and import the image:
```shell
docker save -o immich-authentik-sync.tar immich-authentik-sync:latest   # <-- Export
docker load -i immich-authentik-sync.tar                                # <-- Import
```

### Usage
Add this to your `docker-compose.yml` of your immich server:
```yaml
services:
  immich-authentik-sync:
    image: immich-authentik-sync:latest
    pull_policy: never # The image is not on docker hub, this is here to prevent spoofing attacks.
    depends_on:
      - database
    restart: unless-stopped
    environment:
      IMMICH_DB_DSN: "postgresql://${DB_USERNAME}:${DB_PASSWORD}@database:5432/${DB_DATABASE_NAME}"
      AUTHENTIK_URL: ${AUTHENTIK_URL:?AUTHENTIK_URL is not set}
      AUTHENTIK_TOKEN: ${AUTHENTIK_TOKEN:?AUTHENTIK_TOKEN is not set}
      AUTHENTIK_APPLICATION_SLUG: ${AUTHENTIK_APPLICATION_SLUG:?AUTHENTIK_APPLICATION_SLUG is not set}
      AUTHENTIK_SUB_CLAIM: ${AUTHENTIK_SUB_CLAIM:?AUTHENTIK_SUB_CLAIM is not set}
      SYNC_CRON: ${SYNC_CRON:?SYNC_CRON is not set}
```

Add the additional required environment variables to your `.env` file of immich:
```dotenv
# AUTHENTIK SYNC
AUTHENTIK_APPLICATION_SLUG=immich
AUTHENTIK_URL="https://authentik.company/api/v3/"
AUTHENTIK_TOKEN=authentik_api_token
AUTHENTIK_SUB_CLAIM=uuid
SYNC_CRON="0 0 * * * "
```

The Authentik token needs the following permissions:
- Can view User
- View applications the user has access to

### How it works
Since Immich has no feature to disable accounts without marking them for deletion, this tool clears the sessions, shared links and api keys from the database for users that do not have access to Immich.
  
This happens if one of the tree conditions are met:
- The Authentik user does not exist
- The Authentik user is disabled
- The Authentik user has no access to this application

Since users can't log in via Oauth2 if one of those conditions are met, the account is effectively disabled.

## Jellyfin
The plugin [SSO-Auth](https://github.com/9p4/jellyfin-plugin-sso/) is required.

### Build and Install
To build the plugin, `dotnet` is required.
```shell
cd jellyfin/
./download_dependencies.sh
cd AuthentikJellyfinSync/
dotnet clean
dotnet build
```
To install the plugin, you need to stop the Jellyfin server.
Then copy the dll files from `bin/Debug/net9.0/` to `jellyfin-docker-compose-directory/config/plugins/AuthentikJellyfinSync`.
After that, start the Jellyfin server and stop it again.

### Configuration
After installing and restarting the Jellyfin server, a config file should have been created here: `jellyfin-docker-compose-directory/config/plugins/configurations/AuthentikJellyfinSync.xml`.
Inside this config file, replace the `<ProviderConfigs><ProviderConfigs/>` (or `<ProviderConfigs/>`) section with the following:
```xml
  <ProviderConfigs>
    <ProviderConfig>
      <Id>authentik</Id>
      <AuthentikApiUrl>https://authentik.company/api/v3/</AuthentikApiUrl>
      <AuthentikApiToken>insert-access-token-here</AuthentikApiToken>
      <UserIdentifierType>Uuid</UserIdentifierType>
      <ApplicationSlug>jellyfin</ApplicationSlug>
      <ReEnableAccount>true</ReEnableAccount>
      <SyncEnabled>true</SyncEnabled>
    </ProviderConfig>
  </ProviderConfigs>
```

Replace the `Id` with the provider ID from the SSO-Auth plugin.  
Replace the `ApplicationSlug` with the slug of your Jellyfin application in Authentik.  
Replace the `UserIdentifierType` with your configured `Subject mode` in Authentik. Read more in the [next section](#subject-mode-and-username-claim).
  
### Subject Mode and username claim
This plugin requires that the "Username claim" in the SSO-Auth settings is set to `sub`.
The `sub` claim is a unique identifier for users.
  
Authentik sets the sub claim to the value configured in `Subject mode` (Provider Settings --> Advanced protocol settings --> Subject mode).
It defaults to "Based on the User's hashed ID", which is not supported by this plugin.  
  
For this plugin, the Subject mode has to be set to "Based on the User's ID" (UserIdentifierType: `Pk`), "Based on the User's UUID" (UserIdentifierType: `Uuid`), "Based on the User's username" (UserIdentifierType: `Username`) and "Based on the User's Email (UserIdentifierType: `Email`)".  
**Using the Username or Email as Subject mode claim is NOT recommended, since it might not be unique.** I would recommend using the UUID.
  
You then need to set the `UserIdentifierType` to the value you have configured in Subject mode in Authentik.
  
Since the `sub` claim is configured as Username-Claim, the Jellyfin usernames might get long random IDs.
To "fix" this, you can change the Jellyfin usernames later. The SSO link stays the same.

### How it works
The plugin registers a task which checks for all users of the configured providers whether they have access to Jellyfin or not.
  
A Jellyfin user will be disabled, if one of the following conditions is true:

- The Authentik user does not exist.
- The Authentik user is disabled.
- The Authentik user has no access to the Jellyfin application in Authentik.
- The Authentik user does not match the configured "Role claim" of the SSO-Auth plugin.

A Jellyfin user will be enabled, if `ReEnableAccount` is enabled in the plugin config and none of the disable conditions above are met.

### Important note
This plugin uses Reflection to access the contents of the SSO-Auth plugin. The plugin has been tested with version `4.0.0.4` of the SSO-Auth plugin.
  
This plugin is only using read requests for the Authentik API. But for security, NEVER use an Authentik API token which has write permissions!
  
I am not responsible for broken Jellyfin or Authentik servers, use at your own Risk.
If you are unsure, check the source code.
