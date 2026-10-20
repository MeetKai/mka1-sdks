# Sandbox

## Overview

### Available Operations

* [Create](#create) - Create Session
* [List](#list) - List Sessions
* [Get](#get) - Get Session
* [GetPricing](#getpricing) - Get Sandbox Pricing
* [SetPricing](#setpricing) - Set Sandbox Pricing
* [GetBrowserURL](#getbrowserurl) - Get Browser Session URL
* [~~GetURL~~](#geturl) - Get Browser Session URL (Deprecated) :warning: **Deprecated** Use [GetBrowserURL](docs/sdks/sandbox/README.md#getbrowserurl) instead.
* [ProxyBrowserPortRequest](#proxybrowserportrequest) - Proxy Browser Port Request
* [RunCommand](#runcommand) - Run Command
* [RunCode](#runcode) - Run Code
* [Terminate](#terminate) - Terminate Session
* [GetWorkspace](#getworkspace) - Get Workspace Manifest
* [DownloadFile](#downloadfile) - Download Workspace File
* [UploadFile](#uploadfile) - Upload Workspace File
* [DownloadArchive](#downloadarchive) - Download Workspace Archive
* [UploadArchive](#uploadarchive) - Upload Workspace Archive

## Create

Create a sandbox session and return its public session metadata, session token, and provider. Set `session_kind` to `browser` to start a browser-backed session instead of a standard command/code sandbox. Set `queue_if_full` to `true` to queue the request instead of failing when runner capacity is temporarily unavailable. It does not queue requests for session kinds the deployment does not support. Browser sessions require a Firecracker-backed deployment; standard-only deployments reject them immediately with `browser_sessions_not_enabled`. An optional caller `network_policy` restricts outbound hostnames and is intersected with the organization, team and operator policies. An empty allowlist denies outbound access.

### Example Usage

<!-- UsageSnippet language="go" operationID="createSession" method="post" path="/api/v1/sandbox/sessions" -->
```go
package main

import(
	"context"
	mka1 "github.com/MeetKai/mka1-sdks/go"
	"github.com/MeetKai/mka1-sdks/go/models/components"
	"log"
)

func main() {
    ctx := context.Background()

    s := mka1.New(
        mka1.WithSecurity("<YOUR_BEARER_TOKEN_HERE>"),
    )

    res, err := s.Sandbox.Create(ctx, components.CreateSessionRequest{
        SessionID: "demo-python-20260316",
        SessionKind: components.SessionKindStandard.ToPointer(),
        SandboxFeatures: []components.SandboxFeature{},
        RuntimeProfile: components.SandboxRuntimeProfileStandard.ToPointer(),
    }, nil)
    if err != nil {
        log.Fatal(err)
    }
    if res.CreateSessionResponse != nil {
        // handle response
    }
}
```

### Parameters

| Parameter                                                                          | Type                                                                               | Required                                                                           | Description                                                                        |
| ---------------------------------------------------------------------------------- | ---------------------------------------------------------------------------------- | ---------------------------------------------------------------------------------- | ---------------------------------------------------------------------------------- |
| `ctx`                                                                              | [context.Context](https://pkg.go.dev/context#Context)                              | :heavy_check_mark:                                                                 | The context to use for the request.                                                |
| `body`                                                                             | [components.CreateSessionRequest](../../models/components/createsessionrequest.md) | :heavy_check_mark:                                                                 | N/A                                                                                |
| `xOnBehalfOf`                                                                      | `*string`                                                                          | :heavy_minus_sign:                                                                 | Optional external end-user identifier forwarded by the API gateway.                |
| `opts`                                                                             | [][operations.Option](../../models/operations/option.md)                           | :heavy_minus_sign:                                                                 | The options for this request.                                                      |

### Response

**[*operations.CreateSessionResponse](../../models/operations/createsessionresponse.md), error**

### Errors

| Error Type                    | Status Code                   | Content Type                  |
| ----------------------------- | ----------------------------- | ----------------------------- |
| apierrors.HTTPValidationError | 422                           | application/json              |
| apierrors.APIError            | 4XX, 5XX                      | \*/\*                         |

## List

List sandbox sessions visible to the authenticated caller.

### Example Usage

<!-- UsageSnippet language="go" operationID="listSessions" method="get" path="/api/v1/sandbox/sessions" -->
```go
package main

import(
	"context"
	mka1 "github.com/MeetKai/mka1-sdks/go"
	"github.com/MeetKai/mka1-sdks/go/optionalnullable"
	"log"
)

func main() {
    ctx := context.Background()

    s := mka1.New(
        mka1.WithSecurity("<YOUR_BEARER_TOKEN_HERE>"),
    )

    res, err := s.Sandbox.List(ctx, optionalnullable.From[string](nil), nil)
    if err != nil {
        log.Fatal(err)
    }
    if res.ResponseListSessionsApiv1SandboxSessionsGet != nil {
        // handle response
    }
}
```

### Parameters

| Parameter                                                           | Type                                                                | Required                                                            | Description                                                         |
| ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- |
| `ctx`                                                               | [context.Context](https://pkg.go.dev/context#Context)               | :heavy_check_mark:                                                  | The context to use for the request.                                 |
| `sessionKey`                                                        | optionalnullable.OptionalNullable[`string`]                         | :heavy_minus_sign:                                                  | Only sessions created with this session_key.                        |
| `xOnBehalfOf`                                                       | `*string`                                                           | :heavy_minus_sign:                                                  | Optional external end-user identifier forwarded by the API gateway. |
| `opts`                                                              | [][operations.Option](../../models/operations/option.md)            | :heavy_minus_sign:                                                  | The options for this request.                                       |

### Response

**[*operations.ListSessionsResponse](../../models/operations/listsessionsresponse.md), error**

### Errors

| Error Type                    | Status Code                   | Content Type                  |
| ----------------------------- | ----------------------------- | ----------------------------- |
| apierrors.HTTPValidationError | 422                           | application/json              |
| apierrors.APIError            | 4XX, 5XX                      | \*/\*                         |

## Get

Return the current state, configuration, and resource allocation for a sandbox session.

### Example Usage

<!-- UsageSnippet language="go" operationID="getSession" method="get" path="/api/v1/sandbox/sessions/{session_id}" -->
```go
package main

import(
	"context"
	mka1 "github.com/MeetKai/mka1-sdks/go"
	"log"
)

func main() {
    ctx := context.Background()

    s := mka1.New(
        mka1.WithSecurity("<YOUR_BEARER_TOKEN_HERE>"),
    )

    res, err := s.Sandbox.Get(ctx, "demo-python-20260316", nil)
    if err != nil {
        log.Fatal(err)
    }
    if res.SessionRecord != nil {
        // handle response
    }
}
```

### Parameters

| Parameter                                                           | Type                                                                | Required                                                            | Description                                                         | Example                                                             |
| ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- |
| `ctx`                                                               | [context.Context](https://pkg.go.dev/context#Context)               | :heavy_check_mark:                                                  | The context to use for the request.                                 |                                                                     |
| `sessionID`                                                         | `string`                                                            | :heavy_check_mark:                                                  | N/A                                                                 | demo-python-20260316                                                |
| `xOnBehalfOf`                                                       | `*string`                                                           | :heavy_minus_sign:                                                  | Optional external end-user identifier forwarded by the API gateway. |                                                                     |
| `opts`                                                              | [][operations.Option](../../models/operations/option.md)            | :heavy_minus_sign:                                                  | The options for this request.                                       |                                                                     |

### Response

**[*operations.GetSessionResponse](../../models/operations/getsessionresponse.md), error**

### Errors

| Error Type                    | Status Code                   | Content Type                  |
| ----------------------------- | ----------------------------- | ----------------------------- |
| apierrors.HTTPValidationError | 422                           | application/json              |
| apierrors.APIError            | 4XX, 5XX                      | \*/\*                         |

## GetPricing

Current sandbox pricing rate card, keyed by SKU (`standard`, `browser`, `eval-python`). Metered sandbox usage is billed `hours × (per_hour + reserved_memory_GiB × per_gib_hour)`; SKUs without a configured rate accrue no spend. Cluster admins only.

### Example Usage

<!-- UsageSnippet language="go" operationID="getSandboxPricing" method="get" path="/api/v1/sandbox/pricing" -->
```go
package main

import(
	"context"
	mka1 "github.com/MeetKai/mka1-sdks/go"
	"log"
)

func main() {
    ctx := context.Background()

    s := mka1.New(
        mka1.WithSecurity("<YOUR_BEARER_TOKEN_HERE>"),
    )

    res, err := s.Sandbox.GetPricing(ctx)
    if err != nil {
        log.Fatal(err)
    }
    if res.SandboxPricingCard != nil {
        // handle response
    }
}
```

### Parameters

| Parameter                                                | Type                                                     | Required                                                 | Description                                              |
| -------------------------------------------------------- | -------------------------------------------------------- | -------------------------------------------------------- | -------------------------------------------------------- |
| `ctx`                                                    | [context.Context](https://pkg.go.dev/context#Context)    | :heavy_check_mark:                                       | The context to use for the request.                      |
| `opts`                                                   | [][operations.Option](../../models/operations/option.md) | :heavy_minus_sign:                                       | The options for this request.                            |

### Response

**[*operations.GetSandboxPricingResponse](../../models/operations/getsandboxpricingresponse.md), error**

### Errors

| Error Type         | Status Code        | Content Type       |
| ------------------ | ------------------ | ------------------ |
| apierrors.APIError | 4XX, 5XX           | \*/\*              |

## SetPricing

Replace the sandbox pricing rate card. Full-replace semantics. Omitting a SKU that currently has a price is refused with 422 unless `allow_unpriced` is true: an unpriced SKU accrues no spend and its usage cannot be billed. A `currency` that differs from the stored one is saved only after the budgeting service accepts it as the cluster's billing currency (409 when it conflicts, 503 when it cannot be verified). Takes effect on the next meter window without a restart. Cluster admins only.

### Example Usage

<!-- UsageSnippet language="go" operationID="setSandboxPricing" method="put" path="/api/v1/sandbox/pricing" -->
```go
package main

import(
	"context"
	mka1 "github.com/MeetKai/mka1-sdks/go"
	"github.com/MeetKai/mka1-sdks/go/models/components"
	"log"
)

func main() {
    ctx := context.Background()

    s := mka1.New(
        mka1.WithSecurity("<YOUR_BEARER_TOKEN_HERE>"),
    )

    res, err := s.Sandbox.SetPricing(ctx, components.SandboxPricingUpdate{
        Rates: map[string]components.SandboxPriceRate{
            "standard": components.SandboxPriceRate{
                PerHour: mka1.Pointer[float64](0.1),
                PerGibHour: mka1.Pointer[float64](0.05),
            },
            "browser": components.SandboxPriceRate{
                PerHour: mka1.Pointer[float64](0.4),
                PerGibHour: mka1.Pointer[float64](0.05),
            },
            "eval-python": components.SandboxPriceRate{
                PerHour: mka1.Pointer[float64](0.2),
                PerGibHour: mka1.Pointer[float64](0.05),
            },
        },
    })
    if err != nil {
        log.Fatal(err)
    }
    if res.SandboxPricingCard != nil {
        // handle response
    }
}
```

### Parameters

| Parameter                                                                          | Type                                                                               | Required                                                                           | Description                                                                        |
| ---------------------------------------------------------------------------------- | ---------------------------------------------------------------------------------- | ---------------------------------------------------------------------------------- | ---------------------------------------------------------------------------------- |
| `ctx`                                                                              | [context.Context](https://pkg.go.dev/context#Context)                              | :heavy_check_mark:                                                                 | The context to use for the request.                                                |
| `request`                                                                          | [components.SandboxPricingUpdate](../../models/components/sandboxpricingupdate.md) | :heavy_check_mark:                                                                 | The request object to use for the request.                                         |
| `opts`                                                                             | [][operations.Option](../../models/operations/option.md)                           | :heavy_minus_sign:                                                                 | The options for this request.                                                      |

### Response

**[*operations.SetSandboxPricingResponse](../../models/operations/setsandboxpricingresponse.md), error**

### Errors

| Error Type                    | Status Code                   | Content Type                  |
| ----------------------------- | ----------------------------- | ----------------------------- |
| apierrors.HTTPValidationError | 422                           | application/json              |
| apierrors.APIError            | 4XX, 5XX                      | \*/\*                         |

## GetBrowserURL

Return the public gateway URL for a browser session's Chrome DevTools Protocol endpoint. Playwright can use this HTTP endpoint directly. For clients that require a WebSocket endpoint, request `json/version` and use its rewritten `webSocketDebuggerUrl`. Insert subpaths before the query string; for example, use `/ports/9222/json/version?session_token=...`. Send the same MKA1 API-key authorization header on the HTTP and WebSocket requests. Standard sessions do not expose a public URL; use the command, code, and workspace operations instead.

### Example Usage

<!-- UsageSnippet language="go" operationID="getBrowserSessionUrl" method="get" path="/api/v1/sandbox/sessions/{session_id}/browser-url" -->
```go
package main

import(
	"context"
	mka1 "github.com/MeetKai/mka1-sdks/go"
	"github.com/MeetKai/mka1-sdks/go/optionalnullable"
	"log"
)

func main() {
    ctx := context.Background()

    s := mka1.New(
        mka1.WithSecurity("<YOUR_BEARER_TOKEN_HERE>"),
    )

    res, err := s.Sandbox.GetBrowserURL(ctx, "browser-demo-20260318", optionalnullable.From(mka1.Pointer("sandbox_test_browser_20260318")), nil)
    if err != nil {
        log.Fatal(err)
    }
    if res.SessionURLResponse != nil {
        // handle response
    }
}
```

### Parameters

| Parameter                                                           | Type                                                                | Required                                                            | Description                                                         | Example                                                             |
| ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- |
| `ctx`                                                               | [context.Context](https://pkg.go.dev/context#Context)               | :heavy_check_mark:                                                  | The context to use for the request.                                 |                                                                     |
| `sessionID`                                                         | `string`                                                            | :heavy_check_mark:                                                  | N/A                                                                 | browser-demo-20260318                                               |
| `sessionToken`                                                      | optionalnullable.OptionalNullable[`string`]                         | :heavy_minus_sign:                                                  | N/A                                                                 | sandbox_test_browser_20260318                                       |
| `xOnBehalfOf`                                                       | `*string`                                                           | :heavy_minus_sign:                                                  | Optional external end-user identifier forwarded by the API gateway. |                                                                     |
| `opts`                                                              | [][operations.Option](../../models/operations/option.md)            | :heavy_minus_sign:                                                  | The options for this request.                                       |                                                                     |

### Response

**[*operations.GetBrowserSessionURLResponse](../../models/operations/getbrowsersessionurlresponse.md), error**

### Errors

| Error Type                    | Status Code                   | Content Type                  |
| ----------------------------- | ----------------------------- | ----------------------------- |
| apierrors.HTTPValidationError | 422                           | application/json              |
| apierrors.APIError            | 4XX, 5XX                      | \*/\*                         |

## ~~GetURL~~

Deprecated compatibility alias for `getBrowserUrl`. Return the public gateway URL for a browser session's Chrome DevTools Protocol endpoint. Standard sessions do not expose a public URL; use the command, code, and workspace operations instead.

> :warning: **DEPRECATED**: Use sandbox.getBrowserUrl instead.. Use `GetBrowserURL` instead.

### Example Usage

<!-- UsageSnippet language="go" operationID="getSessionUrl" method="get" path="/api/v1/sandbox/sessions/{session_id}/url" -->
```go
package main

import(
	"context"
	mka1 "github.com/MeetKai/mka1-sdks/go"
	"github.com/MeetKai/mka1-sdks/go/optionalnullable"
	"log"
)

func main() {
    ctx := context.Background()

    s := mka1.New(
        mka1.WithSecurity("<YOUR_BEARER_TOKEN_HERE>"),
    )

    res, err := s.Sandbox.GetURL(ctx, "browser-demo-20260318", optionalnullable.From(mka1.Pointer("sandbox_test_browser_20260318")), optionalnullable.From(mka1.Pointer[int64](9222)), nil)
    if err != nil {
        log.Fatal(err)
    }
    if res.SessionURLResponse != nil {
        // handle response
    }
}
```

### Parameters

| Parameter                                                           | Type                                                                | Required                                                            | Description                                                         | Example                                                             |
| ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- |
| `ctx`                                                               | [context.Context](https://pkg.go.dev/context#Context)               | :heavy_check_mark:                                                  | The context to use for the request.                                 |                                                                     |
| `sessionID`                                                         | `string`                                                            | :heavy_check_mark:                                                  | N/A                                                                 | browser-demo-20260318                                               |
| `sessionToken`                                                      | optionalnullable.OptionalNullable[`string`]                         | :heavy_minus_sign:                                                  | N/A                                                                 | sandbox_test_browser_20260318                                       |
| `port`                                                              | optionalnullable.OptionalNullable[`int64`]                          | :heavy_minus_sign:                                                  | N/A                                                                 | 9222                                                                |
| `xOnBehalfOf`                                                       | `*string`                                                           | :heavy_minus_sign:                                                  | Optional external end-user identifier forwarded by the API gateway. |                                                                     |
| `opts`                                                              | [][operations.Option](../../models/operations/option.md)            | :heavy_minus_sign:                                                  | The options for this request.                                       |                                                                     |

### Response

**[*operations.GetSessionURLResponse](../../models/operations/getsessionurlresponse.md), error**

### Errors

| Error Type                    | Status Code                   | Content Type                  |
| ----------------------------- | ----------------------------- | ----------------------------- |
| apierrors.HTTPValidationError | 422                           | application/json              |
| apierrors.APIError            | 4XX, 5XX                      | \*/\*                         |

## ProxyBrowserPortRequest

Proxy an HTTP request to an exposed browser-session port through the gateway. Use the URL returned by `GET /sessions/{session_id}/browser-url` as the base. Insert CDP subpaths such as `json/version` or `json/list` before its query string, preserving the `session_token` parameter. This low-level proxy is intended for browser sessions on port `9222` and still requires the normal MKA1 API-key authorization header.

### Example Usage

<!-- UsageSnippet language="go" operationID="proxyBrowserPortRequest" method="get" path="/api/v1/sandbox/sessions/{session_id}/ports/{port}/{subpath}" -->
```go
package main

import(
	"context"
	mka1 "github.com/MeetKai/mka1-sdks/go"
	"github.com/MeetKai/mka1-sdks/go/optionalnullable"
	"github.com/MeetKai/mka1-sdks/go/models/operations"
	"log"
)

func main() {
    ctx := context.Background()

    s := mka1.New(
        mka1.WithSecurity("<YOUR_BEARER_TOKEN_HERE>"),
    )

    res, err := s.Sandbox.ProxyBrowserPortRequest(ctx, operations.ProxyBrowserPortRequestRequest{
        SessionID: "browser-demo-20260318",
        Port: 9222,
        Subpath: "json/version",
        SessionToken: optionalnullable.From(mka1.Pointer("sandbox_test_browser_20260318")),
    })
    if err != nil {
        log.Fatal(err)
    }
    if res.Any != nil {
        // handle response
    }
}
```

### Parameters

| Parameter                                                                                              | Type                                                                                                   | Required                                                                                               | Description                                                                                            |
| ------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------ |
| `ctx`                                                                                                  | [context.Context](https://pkg.go.dev/context#Context)                                                  | :heavy_check_mark:                                                                                     | The context to use for the request.                                                                    |
| `request`                                                                                              | [operations.ProxyBrowserPortRequestRequest](../../models/operations/proxybrowserportrequestrequest.md) | :heavy_check_mark:                                                                                     | The request object to use for the request.                                                             |
| `opts`                                                                                                 | [][operations.Option](../../models/operations/option.md)                                               | :heavy_minus_sign:                                                                                     | The options for this request.                                                                          |

### Response

**[*operations.ProxyBrowserPortRequestResponse](../../models/operations/proxybrowserportrequestresponse.md), error**

### Errors

| Error Type                    | Status Code                   | Content Type                  |
| ----------------------------- | ----------------------------- | ----------------------------- |
| apierrors.HTTPValidationError | 422                           | application/json              |
| apierrors.APIError            | 4XX, 5XX                      | \*/\*                         |

## RunCommand

Run a command in the session workspace and return stdout, stderr, exit code, and changed files.

### Example Usage

<!-- UsageSnippet language="go" operationID="runCommand" method="post" path="/api/v1/sandbox/sessions/{session_id}/commands" -->
```go
package main

import(
	"context"
	mka1 "github.com/MeetKai/mka1-sdks/go"
	"github.com/MeetKai/mka1-sdks/go/optionalnullable"
	"github.com/MeetKai/mka1-sdks/go/models/components"
	"log"
)

func main() {
    ctx := context.Background()

    s := mka1.New(
        mka1.WithSecurity("<YOUR_BEARER_TOKEN_HERE>"),
    )

    res, err := s.Sandbox.RunCommand(ctx, "demo-python-20260316", components.CommandRequest{
        SessionID: "demo-python-20260316",
        SessionToken: optionalnullable.From(mka1.Pointer("sandbox_test_20260316_4f9c2b1a")),
        Command: "python3",
        Args: []string{
            "-c",
            "import math; print(math.sqrt(144))",
        },
        Cwd: optionalnullable.From[string](nil),
        Env: map[string]string{

        },
    }, nil)
    if err != nil {
        log.Fatal(err)
    }
    if res.CommandResult != nil {
        // handle response
    }
}
```

### Parameters

| Parameter                                                              | Type                                                                   | Required                                                               | Description                                                            | Example                                                                |
| ---------------------------------------------------------------------- | ---------------------------------------------------------------------- | ---------------------------------------------------------------------- | ---------------------------------------------------------------------- | ---------------------------------------------------------------------- |
| `ctx`                                                                  | [context.Context](https://pkg.go.dev/context#Context)                  | :heavy_check_mark:                                                     | The context to use for the request.                                    |                                                                        |
| `sessionID`                                                            | `string`                                                               | :heavy_check_mark:                                                     | N/A                                                                    | demo-python-20260316                                                   |
| `body`                                                                 | [components.CommandRequest](../../models/components/commandrequest.md) | :heavy_check_mark:                                                     | N/A                                                                    |                                                                        |
| `xOnBehalfOf`                                                          | `*string`                                                              | :heavy_minus_sign:                                                     | Optional external end-user identifier forwarded by the API gateway.    |                                                                        |
| `opts`                                                                 | [][operations.Option](../../models/operations/option.md)               | :heavy_minus_sign:                                                     | The options for this request.                                          |                                                                        |

### Response

**[*operations.RunCommandResponse](../../models/operations/runcommandresponse.md), error**

### Errors

| Error Type                    | Status Code                   | Content Type                  |
| ----------------------------- | ----------------------------- | ----------------------------- |
| apierrors.HTTPValidationError | 422                           | application/json              |
| apierrors.APIError            | 4XX, 5XX                      | \*/\*                         |

## RunCode

Execute source code in the session workspace using a supported runtime and return the execution result.

### Example Usage

<!-- UsageSnippet language="go" operationID="runCode" method="post" path="/api/v1/sandbox/sessions/{session_id}/code" -->
```go
package main

import(
	"context"
	mka1 "github.com/MeetKai/mka1-sdks/go"
	"github.com/MeetKai/mka1-sdks/go/optionalnullable"
	"github.com/MeetKai/mka1-sdks/go/models/components"
	"log"
)

func main() {
    ctx := context.Background()

    s := mka1.New(
        mka1.WithSecurity("<YOUR_BEARER_TOKEN_HERE>"),
    )

    res, err := s.Sandbox.RunCode(ctx, "demo-python-20260316", components.CodeRequest{
        SessionID: "demo-python-20260316",
        SessionToken: optionalnullable.From(mka1.Pointer("sandbox_test_20260316_4f9c2b1a")),
        Runtime: components.CodeRuntimePython.ToPointer(),
        Code: "from pathlib import Path; Path('live_check.txt').write_text('ok'); print('code-ran')",
        Cwd: optionalnullable.From[string](nil),
        Env: map[string]string{

        },
    }, nil)
    if err != nil {
        log.Fatal(err)
    }
    if res.CodeResult != nil {
        // handle response
    }
}
```

### Parameters

| Parameter                                                           | Type                                                                | Required                                                            | Description                                                         | Example                                                             |
| ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- |
| `ctx`                                                               | [context.Context](https://pkg.go.dev/context#Context)               | :heavy_check_mark:                                                  | The context to use for the request.                                 |                                                                     |
| `sessionID`                                                         | `string`                                                            | :heavy_check_mark:                                                  | N/A                                                                 | demo-python-20260316                                                |
| `body`                                                              | [components.CodeRequest](../../models/components/coderequest.md)    | :heavy_check_mark:                                                  | N/A                                                                 |                                                                     |
| `xOnBehalfOf`                                                       | `*string`                                                           | :heavy_minus_sign:                                                  | Optional external end-user identifier forwarded by the API gateway. |                                                                     |
| `opts`                                                              | [][operations.Option](../../models/operations/option.md)            | :heavy_minus_sign:                                                  | The options for this request.                                       |                                                                     |

### Response

**[*operations.RunCodeResponse](../../models/operations/runcoderesponse.md), error**

### Errors

| Error Type                    | Status Code                   | Content Type                  |
| ----------------------------- | ----------------------------- | ----------------------------- |
| apierrors.HTTPValidationError | 422                           | application/json              |
| apierrors.APIError            | 4XX, 5XX                      | \*/\*                         |

## Terminate

Stop a sandbox session and release the backing sandbox resources.

### Example Usage

<!-- UsageSnippet language="go" operationID="terminateSession" method="post" path="/api/v1/sandbox/sessions/{session_id}/terminate" -->
```go
package main

import(
	"context"
	mka1 "github.com/MeetKai/mka1-sdks/go"
	"github.com/MeetKai/mka1-sdks/go/optionalnullable"
	"github.com/MeetKai/mka1-sdks/go/models/components"
	"log"
)

func main() {
    ctx := context.Background()

    s := mka1.New(
        mka1.WithSecurity("<YOUR_BEARER_TOKEN_HERE>"),
    )

    res, err := s.Sandbox.Terminate(ctx, "demo-python-20260316", components.TerminateSessionRequest{
        SessionID: "demo-python-20260316",
        SessionToken: optionalnullable.From(mka1.Pointer("sandbox_test_20260316_4f9c2b1a")),
    }, nil)
    if err != nil {
        log.Fatal(err)
    }
    if res.TerminateSessionResponse != nil {
        // handle response
    }
}
```

### Parameters

| Parameter                                                                                | Type                                                                                     | Required                                                                                 | Description                                                                              | Example                                                                                  |
| ---------------------------------------------------------------------------------------- | ---------------------------------------------------------------------------------------- | ---------------------------------------------------------------------------------------- | ---------------------------------------------------------------------------------------- | ---------------------------------------------------------------------------------------- |
| `ctx`                                                                                    | [context.Context](https://pkg.go.dev/context#Context)                                    | :heavy_check_mark:                                                                       | The context to use for the request.                                                      |                                                                                          |
| `sessionID`                                                                              | `string`                                                                                 | :heavy_check_mark:                                                                       | N/A                                                                                      | demo-python-20260316                                                                     |
| `body`                                                                                   | [components.TerminateSessionRequest](../../models/components/terminatesessionrequest.md) | :heavy_check_mark:                                                                       | N/A                                                                                      |                                                                                          |
| `xOnBehalfOf`                                                                            | `*string`                                                                                | :heavy_minus_sign:                                                                       | Optional external end-user identifier forwarded by the API gateway.                      |                                                                                          |
| `opts`                                                                                   | [][operations.Option](../../models/operations/option.md)                                 | :heavy_minus_sign:                                                                       | The options for this request.                                                            |                                                                                          |

### Response

**[*operations.TerminateSessionResponse](../../models/operations/terminatesessionresponse.md), error**

### Errors

| Error Type                    | Status Code                   | Content Type                  |
| ----------------------------- | ----------------------------- | ----------------------------- |
| apierrors.HTTPValidationError | 422                           | application/json              |
| apierrors.APIError            | 4XX, 5XX                      | \*/\*                         |

## GetWorkspace

List files currently stored in the session workspace, including paths, sizes, and etags.

### Example Usage

<!-- UsageSnippet language="go" operationID="getWorkspace" method="get" path="/api/v1/sandbox/sessions/{session_id}/workspace" -->
```go
package main

import(
	"context"
	mka1 "github.com/MeetKai/mka1-sdks/go"
	"github.com/MeetKai/mka1-sdks/go/optionalnullable"
	"log"
)

func main() {
    ctx := context.Background()

    s := mka1.New(
        mka1.WithSecurity("<YOUR_BEARER_TOKEN_HERE>"),
    )

    res, err := s.Sandbox.GetWorkspace(ctx, "demo-python-20260316", optionalnullable.From(mka1.Pointer("sandbox_test_20260316_4f9c2b1a")), nil)
    if err != nil {
        log.Fatal(err)
    }
    if res.WorkspaceManifest != nil {
        // handle response
    }
}
```

### Parameters

| Parameter                                                           | Type                                                                | Required                                                            | Description                                                         | Example                                                             |
| ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- |
| `ctx`                                                               | [context.Context](https://pkg.go.dev/context#Context)               | :heavy_check_mark:                                                  | The context to use for the request.                                 |                                                                     |
| `sessionID`                                                         | `string`                                                            | :heavy_check_mark:                                                  | N/A                                                                 | demo-python-20260316                                                |
| `sessionToken`                                                      | optionalnullable.OptionalNullable[`string`]                         | :heavy_minus_sign:                                                  | N/A                                                                 | sandbox_test_20260316_4f9c2b1a                                      |
| `xOnBehalfOf`                                                       | `*string`                                                           | :heavy_minus_sign:                                                  | Optional external end-user identifier forwarded by the API gateway. |                                                                     |
| `opts`                                                              | [][operations.Option](../../models/operations/option.md)            | :heavy_minus_sign:                                                  | The options for this request.                                       |                                                                     |

### Response

**[*operations.GetWorkspaceResponse](../../models/operations/getworkspaceresponse.md), error**

### Errors

| Error Type                    | Status Code                   | Content Type                  |
| ----------------------------- | ----------------------------- | ----------------------------- |
| apierrors.HTTPValidationError | 422                           | application/json              |
| apierrors.APIError            | 4XX, 5XX                      | \*/\*                         |

## DownloadFile

Download raw bytes from a file in the session workspace.

### Example Usage

<!-- UsageSnippet language="go" operationID="downloadWorkspaceFile" method="get" path="/api/v1/sandbox/sessions/{session_id}/workspace/files/{file_path}" -->
```go
package main

import(
	"context"
	mka1 "github.com/MeetKai/mka1-sdks/go"
	"github.com/MeetKai/mka1-sdks/go/optionalnullable"
	"log"
)

func main() {
    ctx := context.Background()

    s := mka1.New(
        mka1.WithSecurity("<YOUR_BEARER_TOKEN_HERE>"),
    )

    res, err := s.Sandbox.DownloadFile(ctx, "demo-python-20260316", "outputs/report.txt", optionalnullable.From(mka1.Pointer("sandbox_test_20260316_4f9c2b1a")), nil)
    if err != nil {
        log.Fatal(err)
    }
    if res.ResponseStream != nil {
        // handle response
    }
}
```

### Parameters

| Parameter                                                           | Type                                                                | Required                                                            | Description                                                         | Example                                                             |
| ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- |
| `ctx`                                                               | [context.Context](https://pkg.go.dev/context#Context)               | :heavy_check_mark:                                                  | The context to use for the request.                                 |                                                                     |
| `sessionID`                                                         | `string`                                                            | :heavy_check_mark:                                                  | N/A                                                                 | demo-python-20260316                                                |
| `filePath`                                                          | `string`                                                            | :heavy_check_mark:                                                  | N/A                                                                 | outputs/report.txt                                                  |
| `sessionToken`                                                      | optionalnullable.OptionalNullable[`string`]                         | :heavy_minus_sign:                                                  | N/A                                                                 | sandbox_test_20260316_4f9c2b1a                                      |
| `xOnBehalfOf`                                                       | `*string`                                                           | :heavy_minus_sign:                                                  | Optional external end-user identifier forwarded by the API gateway. |                                                                     |
| `opts`                                                              | [][operations.Option](../../models/operations/option.md)            | :heavy_minus_sign:                                                  | The options for this request.                                       |                                                                     |

### Response

**[*operations.DownloadWorkspaceFileResponse](../../models/operations/downloadworkspacefileresponse.md), error**

### Errors

| Error Type                    | Status Code                   | Content Type                  |
| ----------------------------- | ----------------------------- | ----------------------------- |
| apierrors.HTTPValidationError | 422                           | application/json              |
| apierrors.APIError            | 4XX, 5XX                      | \*/\*                         |

## UploadFile

Upload raw bytes into the session workspace at the given path.

### Example Usage

<!-- UsageSnippet language="go" operationID="uploadWorkspaceFile" method="put" path="/api/v1/sandbox/sessions/{session_id}/workspace/files/{file_path}" -->
```go
package main

import(
	"context"
	mka1 "github.com/MeetKai/mka1-sdks/go"
	"github.com/MeetKai/mka1-sdks/go/optionalnullable"
	"github.com/MeetKai/mka1-sdks/go/models/operations"
	"log"
)

func main() {
    ctx := context.Background()

    s := mka1.New(
        mka1.WithSecurity("<YOUR_BEARER_TOKEN_HERE>"),
    )

    res, err := s.Sandbox.UploadFile(ctx, operations.UploadWorkspaceFileRequest{
        SessionID: "demo-python-20260316",
        FilePath: "inputs/config.json",
        SessionToken: optionalnullable.From(mka1.Pointer("sandbox_test_20260316_4f9c2b1a")),
    })
    if err != nil {
        log.Fatal(err)
    }
    if res.ResponsePutWorkspaceFileApiv1SandboxSessionsSessionIDWorkspaceFilesFilePathPut != nil {
        // handle response
    }
}
```

### Parameters

| Parameter                                                                                      | Type                                                                                           | Required                                                                                       | Description                                                                                    |
| ---------------------------------------------------------------------------------------------- | ---------------------------------------------------------------------------------------------- | ---------------------------------------------------------------------------------------------- | ---------------------------------------------------------------------------------------------- |
| `ctx`                                                                                          | [context.Context](https://pkg.go.dev/context#Context)                                          | :heavy_check_mark:                                                                             | The context to use for the request.                                                            |
| `request`                                                                                      | [operations.UploadWorkspaceFileRequest](../../models/operations/uploadworkspacefilerequest.md) | :heavy_check_mark:                                                                             | The request object to use for the request.                                                     |
| `opts`                                                                                         | [][operations.Option](../../models/operations/option.md)                                       | :heavy_minus_sign:                                                                             | The options for this request.                                                                  |

### Response

**[*operations.UploadWorkspaceFileResponse](../../models/operations/uploadworkspacefileresponse.md), error**

### Errors

| Error Type                    | Status Code                   | Content Type                  |
| ----------------------------- | ----------------------------- | ----------------------------- |
| apierrors.HTTPValidationError | 422                           | application/json              |
| apierrors.APIError            | 4XX, 5XX                      | \*/\*                         |

## DownloadArchive

Download a zip archive containing the selected workspace paths.

### Example Usage

<!-- UsageSnippet language="go" operationID="downloadWorkspaceArchive" method="post" path="/api/v1/sandbox/sessions/{session_id}/workspace/archive" -->
```go
package main

import(
	"context"
	mka1 "github.com/MeetKai/mka1-sdks/go"
	"github.com/MeetKai/mka1-sdks/go/models/components"
	"github.com/MeetKai/mka1-sdks/go/optionalnullable"
	"log"
)

func main() {
    ctx := context.Background()

    s := mka1.New(
        mka1.WithSecurity("<YOUR_BEARER_TOKEN_HERE>"),
    )

    res, err := s.Sandbox.DownloadArchive(ctx, "demo-python-20260316", components.WorkspaceArchiveRequest{
        Paths: []string{
            "outputs/report.txt",
        },
    }, optionalnullable.From(mka1.Pointer("sandbox_test_20260316_4f9c2b1a")), nil)
    if err != nil {
        log.Fatal(err)
    }
    if res.ResponseStream != nil {
        // handle response
    }
}
```

### Parameters

| Parameter                                                                                | Type                                                                                     | Required                                                                                 | Description                                                                              | Example                                                                                  |
| ---------------------------------------------------------------------------------------- | ---------------------------------------------------------------------------------------- | ---------------------------------------------------------------------------------------- | ---------------------------------------------------------------------------------------- | ---------------------------------------------------------------------------------------- |
| `ctx`                                                                                    | [context.Context](https://pkg.go.dev/context#Context)                                    | :heavy_check_mark:                                                                       | The context to use for the request.                                                      |                                                                                          |
| `sessionID`                                                                              | `string`                                                                                 | :heavy_check_mark:                                                                       | N/A                                                                                      | demo-python-20260316                                                                     |
| `body`                                                                                   | [components.WorkspaceArchiveRequest](../../models/components/workspacearchiverequest.md) | :heavy_check_mark:                                                                       | N/A                                                                                      |                                                                                          |
| `sessionToken`                                                                           | optionalnullable.OptionalNullable[`string`]                                              | :heavy_minus_sign:                                                                       | N/A                                                                                      | sandbox_test_20260316_4f9c2b1a                                                           |
| `xOnBehalfOf`                                                                            | `*string`                                                                                | :heavy_minus_sign:                                                                       | Optional external end-user identifier forwarded by the API gateway.                      |                                                                                          |
| `opts`                                                                                   | [][operations.Option](../../models/operations/option.md)                                 | :heavy_minus_sign:                                                                       | The options for this request.                                                            |                                                                                          |

### Response

**[*operations.DownloadWorkspaceArchiveResponse](../../models/operations/downloadworkspacearchiveresponse.md), error**

### Errors

| Error Type                    | Status Code                   | Content Type                  |
| ----------------------------- | ----------------------------- | ----------------------------- |
| apierrors.HTTPValidationError | 422                           | application/json              |
| apierrors.APIError            | 4XX, 5XX                      | \*/\*                         |

## UploadArchive

Upload a zip archive and extract its files into the session workspace.

### Example Usage

<!-- UsageSnippet language="go" operationID="uploadWorkspaceArchive" method="put" path="/api/v1/sandbox/sessions/{session_id}/workspace/archive" -->
```go
package main

import(
	"context"
	mka1 "github.com/MeetKai/mka1-sdks/go"
	"github.com/MeetKai/mka1-sdks/go/optionalnullable"
	"log"
)

func main() {
    ctx := context.Background()

    s := mka1.New(
        mka1.WithSecurity("<YOUR_BEARER_TOKEN_HERE>"),
    )

    res, err := s.Sandbox.UploadArchive(ctx, "demo-python-20260316", optionalnullable.From(mka1.Pointer("sandbox_test_20260316_4f9c2b1a")), nil, nil)
    if err != nil {
        log.Fatal(err)
    }
    if res.ResponsePutWorkspaceArchiveApiv1SandboxSessionsSessionIDWorkspaceArchivePut != nil {
        // handle response
    }
}
```

### Parameters

| Parameter                                                           | Type                                                                | Required                                                            | Description                                                         | Example                                                             |
| ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- |
| `ctx`                                                               | [context.Context](https://pkg.go.dev/context#Context)               | :heavy_check_mark:                                                  | The context to use for the request.                                 |                                                                     |
| `sessionID`                                                         | `string`                                                            | :heavy_check_mark:                                                  | N/A                                                                 | demo-python-20260316                                                |
| `sessionToken`                                                      | optionalnullable.OptionalNullable[`string`]                         | :heavy_minus_sign:                                                  | N/A                                                                 | sandbox_test_20260316_4f9c2b1a                                      |
| `xOnBehalfOf`                                                       | `*string`                                                           | :heavy_minus_sign:                                                  | Optional external end-user identifier forwarded by the API gateway. |                                                                     |
| `body`                                                              | `*any`                                                              | :heavy_minus_sign:                                                  | N/A                                                                 |                                                                     |
| `opts`                                                              | [][operations.Option](../../models/operations/option.md)            | :heavy_minus_sign:                                                  | The options for this request.                                       |                                                                     |

### Response

**[*operations.UploadWorkspaceArchiveResponse](../../models/operations/uploadworkspacearchiveresponse.md), error**

### Errors

| Error Type                    | Status Code                   | Content Type                  |
| ----------------------------- | ----------------------------- | ----------------------------- |
| apierrors.HTTPValidationError | 422                           | application/json              |
| apierrors.APIError            | 4XX, 5XX                      | \*/\*                         |