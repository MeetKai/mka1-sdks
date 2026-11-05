# OAuth access tokens with MKA1 SDKs

Interactive applications should sign in using authorization code + S256 PKCE,
then supply the **API access token** through the existing bearer credential
callback. Do not send an ID token or a browser session cookie as a bearer token.
API keys remain supported for scripts, services and automation.

The public-native provider and context endpoint must be deployed before using
native login. Register a separate public-native application for each app and
deployment. Distribute its client ID, issuer, API resource and requested API
scopes; public applications have no client secret. Discover authorization,
token and revocation endpoints from the issuer's OIDC discovery document.
The API resource is the configured issuer for this provider. Request
`openid profile email offline_access` plus the API scopes your app needs.
Native redirect URIs use `http://127.0.0.1/oauth/callback` with an ephemeral
port; register the exact path and exchange the exact redirect URI used.

## Use your application's token manager

These callbacks are called as requests are constructed. The token manager is
owned by your application, using your OAuth library and secure credential store.
It must serialize refreshes, refresh before expiry, persist a rotated refresh
token before returning the new access token, and clear an invalid or revoked
grant. A timeout, 5xx, or malformed response after a refresh request may mean
rotation already committed: discard that grant and require a fresh login rather
than replaying its predecessor. Discovery failures before submitting refresh can
retain the grant. Logout must acquire the same lock, reload the latest successor,
and revoke it before deleting it; offer explicit local-only deletion
when the provider is unavailable. Do not retry arbitrary mutations after a 401.

Keep token managers bound to the SDK's API resource/server. Never share one SDK
instance or token callback across different signed-in users. Browser session-only
operations remain session-only; a bearer callback does not change their security
requirements. The SDK does not initiate browser login or refresh by itself.

### TypeScript (asynchronous callback)

```ts
import { SDK } from "@meetkai/mka1";

// getAccessToken belongs to your application's OAuth manager.
const sdk = new SDK({
  serverURL: apiServer,
  bearerAuth: async () => await tokenManager.getAccessToken(),
});
```

### Python (synchronous callback)

```python
from meetkai_mka1 import SDK

sdk = SDK(
    server_url=api_server,
    bearer_auth=token_manager.get_access_token,
)
```

The generated Python callback is synchronous even for async SDK methods. Use
an already-refreshed, synchronized token cache if your OAuth library is async;
do not pass a coroutine as `bearer_auth`.

### Go (context-aware callback)

```go
import (
    "context"
    mka1 "github.com/MeetKai/mka1-sdks/go"
    "github.com/MeetKai/mka1-sdks/go/models/components"
)

sdk := mka1.New(
    mka1.WithServerURL(apiServer),
    mka1.WithSecuritySource(func(ctx context.Context) (components.Security, error) {
        token, err := tokenManager.AccessToken(ctx)
        if err != nil { return components.Security{}, err }
        return components.Security{BearerAuth: &token}, nil
    }),
)
```

### C# (synchronous callback)

```csharp
using MeetKai.MKA1;

var sdk = new SDK(
    serverUrl: apiServer,
    bearerAuthSource: () => tokenManager.GetAccessToken()
);
```

The C# callback returns `string`, not `Task<string>`. An async OAuth library should
refresh a synchronized token cache before the SDK call. These examples describe
integration contracts; `tokenManager` is your application's implementation.

## Method-specific security alternatives

Some management methods declare an explicit security argument because they allow
either a bearer credential or a browser session cookie. These methods do not use
the global bearer callback. Obtain a fresh token from your manager immediately
before the call and pass the method's bearer field:

```ts
await sdk.auth.orgs.getById(
  { bearerAuth: await tokenManager.getAccessToken() },
  { orgId: organizationId },
);
```

The corresponding generated security argument in Python, Go and C# has a bearer
field as well; use its generated method signature. Existing callers passing the
session-cookie alternative continue to work. Methods declaring **only** session
security still require that session. A callback never expands which credentials
an operation accepts.

## Optional local development using the MKA1 CLI

After installing a CLI release containing native OAuth support:

```sh
mka1 auth login --issuer "$MKA1_OAUTH_ISSUER" \
  --client-id "$MKA1_OAUTH_CLIENT_ID" \
  --scope openid,profile,email,offline_access,read:responses
mka1 auth whoami
```

An explicit `mka1 auth token --resource <expected-resource>` command prints only
the current access token and refreshes under a cross-process credential lock.
If the issuer and API origins differ, bind the CLI login with
`--api-origin <api-origin>`. Include the same `--api-origin` on `auth token` to
verify the credential is intended for your SDK destination.
This is an optional local credential provider, not a runtime SDK dependency:

```ts
import { execFile } from "node:child_process";
import { promisify } from "node:util";
import { SDK } from "@meetkai/mka1";
const run = promisify(execFile);
const sdk = new SDK({
  serverURL: apiServer,
  bearerAuth: async () => {
    const { stdout } = await run("mka1", ["auth", "token", "--resource", resource, "--api-origin", new URL(apiServer).origin], {
      timeout: 45_000,
      maxBuffer: 64 * 1024,
    });
    return stdout.trim();
  },
});
```

Use a trusted installed `mka1` executable (or an absolute path). Do not log the
callback output. `mka1 auth logout` revokes the stored refresh token; issued JWT access tokens
remain valid until their provider-controlled expiry. Existing
static API-key SDK constructors continue working unchanged.

## Generation and validation

This directory is maintained upstream beside the generator and copied to the
public mirror. No generated SDK file is patched. The bearer-description overlay
clarifies both supported credential types without renaming `bearerAuth` or
changing any operation's security requirements. Offline contract tests verify
fresh callbacks, bearer transport, API-key compatibility, and session-only
security boundaries against the actual generated SDK. They do not prove a
provider deployment or an end-to-end browser login.

Speakeasy documents [security callbacks](https://www.speakeasy.com/docs/sdks/customize/authentication/security-callbacks)
and [custom token refresh](https://www.speakeasy.com/docs/sdks/customize/authentication/oauth).
