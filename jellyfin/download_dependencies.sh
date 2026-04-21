#!/usr/bin/env bash
set -euo pipefail

SCRIPT_DIR="$(cd "$(dirname "${BASH_SOURCE[0]}")" && pwd)"
DEPS_DIR="$SCRIPT_DIR/.dependencies"

# --- SSO-Auth plugin ---
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

# --- Authentik C# client ---
AUTHENTIK_REPO="https://github.com/jandie1505/Authentik-CSharp-Client.git"
AUTHENTIK_SRC_DIR="/tmp/Authentik-CSharp-Client"
AUTHENTIK_CSPROJ="$AUTHENTIK_SRC_DIR/authentik-client/src/Authentik.Client/Authentik.Client.csproj"

echo "→ Cloning Authentik C# client..."
rm -rf "$AUTHENTIK_SRC_DIR"
git clone --depth 1 "$AUTHENTIK_REPO" "$AUTHENTIK_SRC_DIR"

echo "→ Building Authentik.Client..."
dotnet build "$AUTHENTIK_CSPROJ" -c Release

BUILD_OUTPUT_DIR="$(dirname "$AUTHENTIK_CSPROJ")/bin/Release"
AUTHENTIK_DLL="$(find "$BUILD_OUTPUT_DIR" -name Authentik.Client.dll -print -quit)"

if [[ -z "$AUTHENTIK_DLL" ]]; then
    echo "✗ Authentik.Client.dll not found after build!" >&2
    exit 1
fi

echo "→ Copying Authentik.Client.dll to $DEPS_DIR ..."
mkdir -p "$DEPS_DIR"
cp "$AUTHENTIK_DLL" "$DEPS_DIR/"

echo "→ Cleaning up Authentik client sources..."
rm -rf "$AUTHENTIK_SRC_DIR"

echo "✓ Finished. Files are stored in: $DEPS_DIR"
