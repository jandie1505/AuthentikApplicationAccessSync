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