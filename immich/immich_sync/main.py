import argparse
import os
import sys

from authentik_client import Configuration

from immich_sync.authentik_tools import SubClaimType, get_sub_claim_type_from_string
from immich_sync.database_client import DatabaseClient
from immich_sync.sync_client import SyncClient

from apscheduler.schedulers.blocking import BlockingScheduler
from apscheduler.triggers.cron import CronTrigger


def build_sync_client() -> SyncClient:
    authentik_config = Configuration(
        host=os.environ["AUTHENTIK_URL"],
        access_token=os.environ["AUTHENTIK_TOKEN"]
    )

    application_slug: str = os.environ["AUTHENTIK_APPLICATION_SLUG"]

    sub_claim: SubClaimType = get_sub_claim_type_from_string(os.environ.get("AUTHENTIK_SUB_CLAIM"))
    if not isinstance(sub_claim, SubClaimType):
        raise TypeError(f"sub_claim must be of type {SubClaimType}")

    database_client: DatabaseClient = DatabaseClient(os.environ["IMMICH_DB_DSN"])

    return SyncClient(database_client, authentik_config, application_slug, sub_claim)


def cmd_run(_args) -> None:
    build_sync_client().sync()


def cmd_schedule(_args) -> None:
    sync_cron: str | None = os.environ.get("SYNC_CRON")

    if not sync_cron:
        print("Error: schedule mode requires SYNC_CRON to be set.", file=sys.stderr)
        sys.exit(1)

    sync_client = build_sync_client()
    if not isinstance(sync_client, SyncClient):
        raise TypeError(f"sync_client must be of type {SyncClient}")

    scheduler = BlockingScheduler()
    scheduler.add_job(sync_client.sync, CronTrigger.from_crontab(sync_cron))
    print(f"Starting scheduler with cron expression: {sync_cron}")
    try:
        scheduler.start()
    except KeyboardInterrupt:
        print("Scheduler stopped.")
        scheduler.shutdown()


def main() -> None:
    parser = argparse.ArgumentParser(description="Immich Authentik Sync")
    subparsers = parser.add_subparsers(dest="command", required=True)

    subparsers.add_parser("run", help="Run sync once and exit")
    subparsers.add_parser("schedule", help="Run sync on a schedule (requires SYNC_CRON or SYNC_INTERVAL env var)")

    args = parser.parse_args()

    if args.command == "run":
        cmd_run(args)
    elif args.command == "schedule":
        cmd_schedule(args)
    else:
        print("Error: unknown command", file=sys.stderr)


if __name__ == "__main__":
    main()
