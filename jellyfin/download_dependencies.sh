#!/usr/bin/env bash
set -euo pipefail

SCRIPT_DIR="$(cd "$(dirname "${BASH_SOURCE[0]}")" && pwd)"
DEPS_DIR="$SCRIPT_DIR/.dependencies"

ZIP_URL="https://github.com/9p4/jellyfin-plugin-sso/releases/download/v4.0.0.3/sso-authentication_4.0.0.3.zip"
SHA_URL="https://github.com/9p4/jellyfin-plugin-sso/releases/download/v4.0.0.3/sso-authentication_4.0.0.3.sha256"

ZIP_FILE="/tmp/sso-authentication_4.0.0.3.zip"
SHA_FILE="/tmp/sso-authentication_4.0.0.3.sha256"

echo "→ Downloading..."
curl -fsSL "$ZIP_URL" -o "$ZIP_FILE"
curl -fsSL "$SHA_URL" -o "$SHA_FILE"

echo "→ Verifying checksum..."
EXPECTED=$(cat "$SHA_FILE" | awk '{print $1}')
ACTUAL=$(sha256sum "$ZIP_FILE" | awk '{print $1}')

if [[ "$EXPECTED" != "$ACTUAL" ]]; then
    echo "✗ Checksums do not match!" >&2
    echo "  Expected: $EXPECTED" >&2
    echo "  Actual: $ACTUAL" >&2
    rm -f "$ZIP_FILE" "$SHA_FILE"
    exit 1
fi
echo "✓ Checksum OK ($ACTUAL)"

echo "→ Extracting to $DEPS_DIR ..."
mkdir -p "$DEPS_DIR"
unzip -o "$ZIP_FILE" -d "$DEPS_DIR"

echo "→ Cleaning up..."
rm -f "$ZIP_FILE" "$SHA_FILE"

echo "✓ Finished. Files are stored in: $DEPS_DIR"