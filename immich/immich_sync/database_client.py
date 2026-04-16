import psycopg2


class DatabaseClient:

    def __init__(self, dsn: str):
        self.dsn = dsn

    def get_oauth_users(self) -> list[dict[str, str]]:
        """Get all Immich users that have an oauthId set (i.e. linked via OIDC)."""
        with psycopg2.connect(self.dsn) as conn:
            with conn.cursor() as cur:
                cur.execute(
                    'SELECT id, "oauthId" FROM "user" WHERE "oauthId" != \'\''
                )
                return [{"id": row[0], "oauthId": row[1]} for row in cur.fetchall()]

    def delete_sessions(self, user_id: str) -> int:
        """Delete all sessions for a user. Returns number of deleted rows."""
        with psycopg2.connect(self.dsn) as conn:
            with conn.cursor() as cur:
                cur.execute('DELETE FROM "session" WHERE "userId" = %s', (user_id,))
                conn.commit()
                return cur.rowcount

    def delete_api_keys(self, user_id: str) -> int:
        """Delete all API keys for a user. Returns number of deleted rows."""
        with psycopg2.connect(self.dsn) as conn:
            with conn.cursor() as cur:
                cur.execute('DELETE FROM "api_key" WHERE "userId" = %s', (user_id,))
                conn.commit()
                return cur.rowcount

    def delete_shared_links(self, user_id: str) -> int:
        """Delete all shared links for a user. Returns number of deleted rows."""
        with psycopg2.connect(self.dsn) as conn:
            with conn.cursor() as cur:
                cur.execute('DELETE FROM "shared_link" WHERE "userId" = %s', (user_id,))
                conn.commit()
                return cur.rowcount
