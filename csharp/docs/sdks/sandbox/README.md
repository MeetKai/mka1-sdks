# Sandbox

## Overview

### Available Operations

* [Create](#create) - Create Session
* [List](#list) - List Sessions
* [Get](#get) - Get Session
* [GetPricing](#getpricing) - Get Sandbox Pricing
* [SetPricing](#setpricing) - Set Sandbox Pricing
* [GetBrowserUrl](#getbrowserurl) - Get Browser Session URL
* [~~GetUrl~~](#geturl) - Get Browser Session URL (Deprecated) :warning: **Deprecated** Use [GetBrowserUrl](docs/sdks/sandbox/README.md#getbrowserurl) instead.
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

Create a sandbox session and return its public session metadata, session token, and provider. Set `session_kind` to `browser` to start a browser-backed session instead of a standard command/code sandbox. Set `queue_if_full` to `true` to queue the request instead of failing when runner capacity is temporarily unavailable. It does not queue requests for session kinds the deployment does not support. Browser sessions require a Firecracker-backed deployment; standard-only deployments reject them immediately with `browser_sessions_not_enabled`.

### Example Usage

<!-- UsageSnippet language="csharp" operationID="createSession" method="post" path="/api/v1/sandbox/sessions" -->
```csharp
using MeetKai.MKA1;
using MeetKai.MKA1.Types.Components;
using System.Collections.Generic;

var sdk = new SDK(bearerAuth: "<YOUR_BEARER_TOKEN_HERE>");

var res = await sdk.Sandbox.CreateAsync(body: new MeetKai.MKA1.Types.Components.CreateSessionRequest() {
    SessionId = "demo-python-20260316",
    SessionKind = SessionKind.Standard,
    SandboxFeatures = new List<SandboxFeature>() {},
    RuntimeProfile = SandboxRuntimeProfile.Standard,
});

// handle response
```

### Parameters

| Parameter                                                                               | Type                                                                                    | Required                                                                                | Description                                                                             |
| --------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------- |
| `Body`                                                                                  | [Types.Components.CreateSessionRequest](../../Types/Components/CreateSessionRequest.md) | :heavy_check_mark:                                                                      | N/A                                                                                     |
| `XOnBehalfOf`                                                                           | *string*                                                                                | :heavy_minus_sign:                                                                      | Optional external end-user identifier forwarded by the API gateway.                     |

### Response

**[Types.Requests.CreateSessionResponse](../../Types/Requests/CreateSessionResponse.md)**

### Errors

| Error Type                                    | Status Code                                   | Content Type                                  |
| --------------------------------------------- | --------------------------------------------- | --------------------------------------------- |
| MeetKai.MKA1.Types.Errors.HTTPValidationError | 422                                           | application/json                              |
| MeetKai.MKA1.Types.Errors.APIException        | 4XX, 5XX                                      | \*/\*                                         |

## List

List sandbox sessions visible to the authenticated caller.

### Example Usage

<!-- UsageSnippet language="csharp" operationID="listSessions" method="get" path="/api/v1/sandbox/sessions" -->
```csharp
using MeetKai.MKA1;
using MeetKai.MKA1.Types.Components;

var sdk = new SDK(bearerAuth: "<YOUR_BEARER_TOKEN_HERE>");

var res = await sdk.Sandbox.ListAsync();

// handle response
```

### Parameters

| Parameter                                                           | Type                                                                | Required                                                            | Description                                                         |
| ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- |
| `SessionKey`                                                        | *string*                                                            | :heavy_minus_sign:                                                  | Only sessions created with this session_key.                        |
| `XOnBehalfOf`                                                       | *string*                                                            | :heavy_minus_sign:                                                  | Optional external end-user identifier forwarded by the API gateway. |

### Response

**[ListSessionsResponse](../../Types/Requests/ListSessionsResponse.md)**

### Errors

| Error Type                                    | Status Code                                   | Content Type                                  |
| --------------------------------------------- | --------------------------------------------- | --------------------------------------------- |
| MeetKai.MKA1.Types.Errors.HTTPValidationError | 422                                           | application/json                              |
| MeetKai.MKA1.Types.Errors.APIException        | 4XX, 5XX                                      | \*/\*                                         |

## Get

Return the current state, configuration, and resource allocation for a sandbox session.

### Example Usage

<!-- UsageSnippet language="csharp" operationID="getSession" method="get" path="/api/v1/sandbox/sessions/{session_id}" -->
```csharp
using MeetKai.MKA1;
using MeetKai.MKA1.Types.Components;

var sdk = new SDK(bearerAuth: "<YOUR_BEARER_TOKEN_HERE>");

var res = await sdk.Sandbox.GetAsync(sessionId: "demo-python-20260316");

// handle response
```

### Parameters

| Parameter                                                           | Type                                                                | Required                                                            | Description                                                         | Example                                                             |
| ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- |
| `SessionId`                                                         | *string*                                                            | :heavy_check_mark:                                                  | N/A                                                                 | demo-python-20260316                                                |
| `XOnBehalfOf`                                                       | *string*                                                            | :heavy_minus_sign:                                                  | Optional external end-user identifier forwarded by the API gateway. |                                                                     |

### Response

**[GetSessionResponse](../../Types/Requests/GetSessionResponse.md)**

### Errors

| Error Type                                    | Status Code                                   | Content Type                                  |
| --------------------------------------------- | --------------------------------------------- | --------------------------------------------- |
| MeetKai.MKA1.Types.Errors.HTTPValidationError | 422                                           | application/json                              |
| MeetKai.MKA1.Types.Errors.APIException        | 4XX, 5XX                                      | \*/\*                                         |

## GetPricing

Current sandbox pricing rate card, keyed by SKU (`standard`, `browser`, `eval-python`). Metered sandbox usage is billed `hours × (per_hour + reserved_memory_GiB × per_gib_hour)`; SKUs without a configured rate accrue no spend. Cluster admins only.

### Example Usage

<!-- UsageSnippet language="csharp" operationID="getSandboxPricing" method="get" path="/api/v1/sandbox/pricing" -->
```csharp
using MeetKai.MKA1;
using MeetKai.MKA1.Types.Components;

var sdk = new SDK(bearerAuth: "<YOUR_BEARER_TOKEN_HERE>");

var res = await sdk.Sandbox.GetPricingAsync();

// handle response
```

### Response

**[GetSandboxPricingResponse](../../Types/Requests/GetSandboxPricingResponse.md)**

### Errors

| Error Type                             | Status Code                            | Content Type                           |
| -------------------------------------- | -------------------------------------- | -------------------------------------- |
| MeetKai.MKA1.Types.Errors.APIException | 4XX, 5XX                               | \*/\*                                  |

## SetPricing

Replace the sandbox pricing rate card. Full-replace semantics. Omitting a SKU that currently has a price is refused with 422 unless `allow_unpriced` is true: an unpriced SKU accrues no spend and its usage cannot be billed. A `currency` that differs from the stored one is saved only after the budgeting service accepts it as the cluster's billing currency (409 when it conflicts, 503 when it cannot be verified). Takes effect on the next meter window without a restart. Cluster admins only.

### Example Usage

<!-- UsageSnippet language="csharp" operationID="setSandboxPricing" method="put" path="/api/v1/sandbox/pricing" -->
```csharp
using MeetKai.MKA1;
using MeetKai.MKA1.Types.Components;
using System.Collections.Generic;

var sdk = new SDK(bearerAuth: "<YOUR_BEARER_TOKEN_HERE>");

SandboxPricingUpdate req = new SandboxPricingUpdate() {
    Rates = new Dictionary<string, SandboxPriceRate>() {
        { "standard", new SandboxPriceRate() {
            PerHour = 0.1D,
            PerGibHour = 0.05D,
        } },
        { "browser", new SandboxPriceRate() {
            PerHour = 0.4D,
            PerGibHour = 0.05D,
        } },
        { "eval-python", new SandboxPriceRate() {
            PerHour = 0.2D,
            PerGibHour = 0.05D,
        } },
    },
};

var res = await sdk.Sandbox.SetPricingAsync(req);

// handle response
```

### Parameters

| Parameter                                                              | Type                                                                   | Required                                                               | Description                                                            |
| ---------------------------------------------------------------------- | ---------------------------------------------------------------------- | ---------------------------------------------------------------------- | ---------------------------------------------------------------------- |
| `request`                                                              | [SandboxPricingUpdate](../../Types/Components/SandboxPricingUpdate.md) | :heavy_check_mark:                                                     | The request object to use for the request.                             |

### Response

**[SetSandboxPricingResponse](../../Types/Requests/SetSandboxPricingResponse.md)**

### Errors

| Error Type                                    | Status Code                                   | Content Type                                  |
| --------------------------------------------- | --------------------------------------------- | --------------------------------------------- |
| MeetKai.MKA1.Types.Errors.HTTPValidationError | 422                                           | application/json                              |
| MeetKai.MKA1.Types.Errors.APIException        | 4XX, 5XX                                      | \*/\*                                         |

## GetBrowserUrl

Return the public gateway URL for a browser session's Chrome DevTools Protocol endpoint. Playwright can use this HTTP endpoint directly. For clients that require a WebSocket endpoint, request `json/version` and use its rewritten `webSocketDebuggerUrl`. Insert subpaths before the query string; for example, use `/ports/9222/json/version?session_token=...`. Send the same MKA1 API-key authorization header on the HTTP and WebSocket requests. Standard sessions do not expose a public URL; use the command, code, and workspace operations instead.

### Example Usage

<!-- UsageSnippet language="csharp" operationID="getBrowserSessionUrl" method="get" path="/api/v1/sandbox/sessions/{session_id}/browser-url" -->
```csharp
using MeetKai.MKA1;
using MeetKai.MKA1.Types.Components;

var sdk = new SDK(bearerAuth: "<YOUR_BEARER_TOKEN_HERE>");

var res = await sdk.Sandbox.GetBrowserUrlAsync(
    sessionId: "browser-demo-20260318",
    sessionToken: "sandbox_test_browser_20260318"
);

// handle response
```

### Parameters

| Parameter                                                           | Type                                                                | Required                                                            | Description                                                         | Example                                                             |
| ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- |
| `SessionId`                                                         | *string*                                                            | :heavy_check_mark:                                                  | N/A                                                                 | browser-demo-20260318                                               |
| `SessionToken`                                                      | *string*                                                            | :heavy_minus_sign:                                                  | N/A                                                                 | sandbox_test_browser_20260318                                       |
| `XOnBehalfOf`                                                       | *string*                                                            | :heavy_minus_sign:                                                  | Optional external end-user identifier forwarded by the API gateway. |                                                                     |

### Response

**[GetBrowserSessionUrlResponse](../../Types/Requests/GetBrowserSessionUrlResponse.md)**

### Errors

| Error Type                                    | Status Code                                   | Content Type                                  |
| --------------------------------------------- | --------------------------------------------- | --------------------------------------------- |
| MeetKai.MKA1.Types.Errors.HTTPValidationError | 422                                           | application/json                              |
| MeetKai.MKA1.Types.Errors.APIException        | 4XX, 5XX                                      | \*/\*                                         |

## ~~GetUrl~~

Deprecated compatibility alias for `getBrowserUrl`. Return the public gateway URL for a browser session's Chrome DevTools Protocol endpoint. Standard sessions do not expose a public URL; use the command, code, and workspace operations instead.

> :warning: **DEPRECATED**: Use sandbox.getBrowserUrl instead.. Use `GetBrowserUrl` instead.

### Example Usage

<!-- UsageSnippet language="csharp" operationID="getSessionUrl" method="get" path="/api/v1/sandbox/sessions/{session_id}/url" -->
```csharp
using MeetKai.MKA1;
using MeetKai.MKA1.Types.Components;

var sdk = new SDK(bearerAuth: "<YOUR_BEARER_TOKEN_HERE>");

var res = await sdk.Sandbox.GetUrlAsync(
    sessionId: "browser-demo-20260318",
    sessionToken: "sandbox_test_browser_20260318",
    port: 9222
);

// handle response
```

### Parameters

| Parameter                                                           | Type                                                                | Required                                                            | Description                                                         | Example                                                             |
| ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- |
| `SessionId`                                                         | *string*                                                            | :heavy_check_mark:                                                  | N/A                                                                 | browser-demo-20260318                                               |
| `SessionToken`                                                      | *string*                                                            | :heavy_minus_sign:                                                  | N/A                                                                 | sandbox_test_browser_20260318                                       |
| `Port`                                                              | *long*                                                              | :heavy_minus_sign:                                                  | N/A                                                                 | 9222                                                                |
| `XOnBehalfOf`                                                       | *string*                                                            | :heavy_minus_sign:                                                  | Optional external end-user identifier forwarded by the API gateway. |                                                                     |

### Response

**[GetSessionUrlResponse](../../Types/Requests/GetSessionUrlResponse.md)**

### Errors

| Error Type                                    | Status Code                                   | Content Type                                  |
| --------------------------------------------- | --------------------------------------------- | --------------------------------------------- |
| MeetKai.MKA1.Types.Errors.HTTPValidationError | 422                                           | application/json                              |
| MeetKai.MKA1.Types.Errors.APIException        | 4XX, 5XX                                      | \*/\*                                         |

## ProxyBrowserPortRequest

Proxy an HTTP request to an exposed browser-session port through the gateway. Use the URL returned by `GET /sessions/{session_id}/browser-url` as the base. Insert CDP subpaths such as `json/version` or `json/list` before its query string, preserving the `session_token` parameter. This low-level proxy is intended for browser sessions on port `9222` and still requires the normal MKA1 API-key authorization header.

### Example Usage

<!-- UsageSnippet language="csharp" operationID="proxyBrowserPortRequest" method="get" path="/api/v1/sandbox/sessions/{session_id}/ports/{port}/{subpath}" -->
```csharp
using MeetKai.MKA1;
using MeetKai.MKA1.Types.Components;
using MeetKai.MKA1.Types.Requests;

var sdk = new SDK(bearerAuth: "<YOUR_BEARER_TOKEN_HERE>");

ProxyBrowserPortRequestRequest req = new ProxyBrowserPortRequestRequest() {
    SessionId = "browser-demo-20260318",
    Port = 9222,
    Subpath = "json/version",
    SessionToken = "sandbox_test_browser_20260318",
};

var res = await sdk.Sandbox.ProxyBrowserPortRequestAsync(req);

// handle response
```

### Parameters

| Parameter                                                                                | Type                                                                                     | Required                                                                                 | Description                                                                              |
| ---------------------------------------------------------------------------------------- | ---------------------------------------------------------------------------------------- | ---------------------------------------------------------------------------------------- | ---------------------------------------------------------------------------------------- |
| `request`                                                                                | [ProxyBrowserPortRequestRequest](../../Types/Requests/ProxyBrowserPortRequestRequest.md) | :heavy_check_mark:                                                                       | The request object to use for the request.                                               |

### Response

**[ProxyBrowserPortRequestResponse](../../Types/Requests/ProxyBrowserPortRequestResponse.md)**

### Errors

| Error Type                                    | Status Code                                   | Content Type                                  |
| --------------------------------------------- | --------------------------------------------- | --------------------------------------------- |
| MeetKai.MKA1.Types.Errors.HTTPValidationError | 422                                           | application/json                              |
| MeetKai.MKA1.Types.Errors.APIException        | 4XX, 5XX                                      | \*/\*                                         |

## RunCommand

Run a command in the session workspace and return stdout, stderr, exit code, and changed files.

### Example Usage

<!-- UsageSnippet language="csharp" operationID="runCommand" method="post" path="/api/v1/sandbox/sessions/{session_id}/commands" -->
```csharp
using MeetKai.MKA1;
using MeetKai.MKA1.Types.Components;
using System.Collections.Generic;

var sdk = new SDK(bearerAuth: "<YOUR_BEARER_TOKEN_HERE>");

var res = await sdk.Sandbox.RunCommandAsync(
    sessionId: "demo-python-20260316",
    body: new CommandRequest() {
        SessionId = "demo-python-20260316",
        SessionToken = "sandbox_test_20260316_4f9c2b1a",
        Command = "python3",
        Args = new List<string>() {
            "-c",
            "import math; print(math.sqrt(144))",
        },
        Cwd = null,
        Env = new Dictionary<string, string>() {

        },
    }
);

// handle response
```

### Parameters

| Parameter                                                           | Type                                                                | Required                                                            | Description                                                         | Example                                                             |
| ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- |
| `SessionId`                                                         | *string*                                                            | :heavy_check_mark:                                                  | N/A                                                                 | demo-python-20260316                                                |
| `Body`                                                              | [CommandRequest](../../Types/Components/CommandRequest.md)          | :heavy_check_mark:                                                  | N/A                                                                 |                                                                     |
| `XOnBehalfOf`                                                       | *string*                                                            | :heavy_minus_sign:                                                  | Optional external end-user identifier forwarded by the API gateway. |                                                                     |

### Response

**[RunCommandResponse](../../Types/Requests/RunCommandResponse.md)**

### Errors

| Error Type                                    | Status Code                                   | Content Type                                  |
| --------------------------------------------- | --------------------------------------------- | --------------------------------------------- |
| MeetKai.MKA1.Types.Errors.HTTPValidationError | 422                                           | application/json                              |
| MeetKai.MKA1.Types.Errors.APIException        | 4XX, 5XX                                      | \*/\*                                         |

## RunCode

Execute source code in the session workspace using a supported runtime and return the execution result.

### Example Usage

<!-- UsageSnippet language="csharp" operationID="runCode" method="post" path="/api/v1/sandbox/sessions/{session_id}/code" -->
```csharp
using MeetKai.MKA1;
using MeetKai.MKA1.Types.Components;
using System.Collections.Generic;

var sdk = new SDK(bearerAuth: "<YOUR_BEARER_TOKEN_HERE>");

var res = await sdk.Sandbox.RunCodeAsync(
    sessionId: "demo-python-20260316",
    body: new CodeRequest() {
        SessionId = "demo-python-20260316",
        SessionToken = "sandbox_test_20260316_4f9c2b1a",
        Runtime = CodeRuntime.Python,
        Code = "from pathlib import Path; Path('live_check.txt').write_text('ok'); print('code-ran')",
        Cwd = null,
        Env = new Dictionary<string, string>() {

        },
    }
);

// handle response
```

### Parameters

| Parameter                                                           | Type                                                                | Required                                                            | Description                                                         | Example                                                             |
| ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- |
| `SessionId`                                                         | *string*                                                            | :heavy_check_mark:                                                  | N/A                                                                 | demo-python-20260316                                                |
| `Body`                                                              | [CodeRequest](../../Types/Components/CodeRequest.md)                | :heavy_check_mark:                                                  | N/A                                                                 |                                                                     |
| `XOnBehalfOf`                                                       | *string*                                                            | :heavy_minus_sign:                                                  | Optional external end-user identifier forwarded by the API gateway. |                                                                     |

### Response

**[RunCodeResponse](../../Types/Requests/RunCodeResponse.md)**

### Errors

| Error Type                                    | Status Code                                   | Content Type                                  |
| --------------------------------------------- | --------------------------------------------- | --------------------------------------------- |
| MeetKai.MKA1.Types.Errors.HTTPValidationError | 422                                           | application/json                              |
| MeetKai.MKA1.Types.Errors.APIException        | 4XX, 5XX                                      | \*/\*                                         |

## Terminate

Stop a sandbox session and release the backing sandbox resources.

### Example Usage

<!-- UsageSnippet language="csharp" operationID="terminateSession" method="post" path="/api/v1/sandbox/sessions/{session_id}/terminate" -->
```csharp
using MeetKai.MKA1;
using MeetKai.MKA1.Types.Components;

var sdk = new SDK(bearerAuth: "<YOUR_BEARER_TOKEN_HERE>");

var res = await sdk.Sandbox.TerminateAsync(
    sessionId: "demo-python-20260316",
    body: new MeetKai.MKA1.Types.Components.TerminateSessionRequest() {
        SessionId = "demo-python-20260316",
        SessionToken = "sandbox_test_20260316_4f9c2b1a",
    }
);

// handle response
```

### Parameters

| Parameter                                                                                     | Type                                                                                          | Required                                                                                      | Description                                                                                   | Example                                                                                       |
| --------------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------------- |
| `SessionId`                                                                                   | *string*                                                                                      | :heavy_check_mark:                                                                            | N/A                                                                                           | demo-python-20260316                                                                          |
| `Body`                                                                                        | [Types.Components.TerminateSessionRequest](../../Types/Components/TerminateSessionRequest.md) | :heavy_check_mark:                                                                            | N/A                                                                                           |                                                                                               |
| `XOnBehalfOf`                                                                                 | *string*                                                                                      | :heavy_minus_sign:                                                                            | Optional external end-user identifier forwarded by the API gateway.                           |                                                                                               |

### Response

**[Types.Requests.TerminateSessionResponse](../../Types/Requests/TerminateSessionResponse.md)**

### Errors

| Error Type                                    | Status Code                                   | Content Type                                  |
| --------------------------------------------- | --------------------------------------------- | --------------------------------------------- |
| MeetKai.MKA1.Types.Errors.HTTPValidationError | 422                                           | application/json                              |
| MeetKai.MKA1.Types.Errors.APIException        | 4XX, 5XX                                      | \*/\*                                         |

## GetWorkspace

List files currently stored in the session workspace, including paths, sizes, and etags.

### Example Usage

<!-- UsageSnippet language="csharp" operationID="getWorkspace" method="get" path="/api/v1/sandbox/sessions/{session_id}/workspace" -->
```csharp
using MeetKai.MKA1;
using MeetKai.MKA1.Types.Components;

var sdk = new SDK(bearerAuth: "<YOUR_BEARER_TOKEN_HERE>");

var res = await sdk.Sandbox.GetWorkspaceAsync(
    sessionId: "demo-python-20260316",
    sessionToken: "sandbox_test_20260316_4f9c2b1a"
);

// handle response
```

### Parameters

| Parameter                                                           | Type                                                                | Required                                                            | Description                                                         | Example                                                             |
| ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- |
| `SessionId`                                                         | *string*                                                            | :heavy_check_mark:                                                  | N/A                                                                 | demo-python-20260316                                                |
| `SessionToken`                                                      | *string*                                                            | :heavy_minus_sign:                                                  | N/A                                                                 | sandbox_test_20260316_4f9c2b1a                                      |
| `XOnBehalfOf`                                                       | *string*                                                            | :heavy_minus_sign:                                                  | Optional external end-user identifier forwarded by the API gateway. |                                                                     |

### Response

**[GetWorkspaceResponse](../../Types/Requests/GetWorkspaceResponse.md)**

### Errors

| Error Type                                    | Status Code                                   | Content Type                                  |
| --------------------------------------------- | --------------------------------------------- | --------------------------------------------- |
| MeetKai.MKA1.Types.Errors.HTTPValidationError | 422                                           | application/json                              |
| MeetKai.MKA1.Types.Errors.APIException        | 4XX, 5XX                                      | \*/\*                                         |

## DownloadFile

Download raw bytes from a file in the session workspace.

### Example Usage

<!-- UsageSnippet language="csharp" operationID="downloadWorkspaceFile" method="get" path="/api/v1/sandbox/sessions/{session_id}/workspace/files/{file_path}" -->
```csharp
using MeetKai.MKA1;
using MeetKai.MKA1.Types.Components;

var sdk = new SDK(bearerAuth: "<YOUR_BEARER_TOKEN_HERE>");

var res = await sdk.Sandbox.DownloadFileAsync(
    sessionId: "demo-python-20260316",
    filePath: "outputs/report.txt",
    sessionToken: "sandbox_test_20260316_4f9c2b1a"
);

// handle response
```

### Parameters

| Parameter                                                           | Type                                                                | Required                                                            | Description                                                         | Example                                                             |
| ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- |
| `SessionId`                                                         | *string*                                                            | :heavy_check_mark:                                                  | N/A                                                                 | demo-python-20260316                                                |
| `FilePath`                                                          | *string*                                                            | :heavy_check_mark:                                                  | N/A                                                                 | outputs/report.txt                                                  |
| `SessionToken`                                                      | *string*                                                            | :heavy_minus_sign:                                                  | N/A                                                                 | sandbox_test_20260316_4f9c2b1a                                      |
| `XOnBehalfOf`                                                       | *string*                                                            | :heavy_minus_sign:                                                  | Optional external end-user identifier forwarded by the API gateway. |                                                                     |

### Response

**[DownloadWorkspaceFileResponse](../../Types/Requests/DownloadWorkspaceFileResponse.md)**

### Errors

| Error Type                                    | Status Code                                   | Content Type                                  |
| --------------------------------------------- | --------------------------------------------- | --------------------------------------------- |
| MeetKai.MKA1.Types.Errors.HTTPValidationError | 422                                           | application/json                              |
| MeetKai.MKA1.Types.Errors.APIException        | 4XX, 5XX                                      | \*/\*                                         |

## UploadFile

Upload raw bytes into the session workspace at the given path.

### Example Usage

<!-- UsageSnippet language="csharp" operationID="uploadWorkspaceFile" method="put" path="/api/v1/sandbox/sessions/{session_id}/workspace/files/{file_path}" -->
```csharp
using MeetKai.MKA1;
using MeetKai.MKA1.Types.Components;
using MeetKai.MKA1.Types.Requests;

var sdk = new SDK(bearerAuth: "<YOUR_BEARER_TOKEN_HERE>");

UploadWorkspaceFileRequest req = new UploadWorkspaceFileRequest() {
    SessionId = "demo-python-20260316",
    FilePath = "inputs/config.json",
    SessionToken = "sandbox_test_20260316_4f9c2b1a",
};

var res = await sdk.Sandbox.UploadFileAsync(req);

// handle response
```

### Parameters

| Parameter                                                                        | Type                                                                             | Required                                                                         | Description                                                                      |
| -------------------------------------------------------------------------------- | -------------------------------------------------------------------------------- | -------------------------------------------------------------------------------- | -------------------------------------------------------------------------------- |
| `request`                                                                        | [UploadWorkspaceFileRequest](../../Types/Requests/UploadWorkspaceFileRequest.md) | :heavy_check_mark:                                                               | The request object to use for the request.                                       |

### Response

**[UploadWorkspaceFileResponse](../../Types/Requests/UploadWorkspaceFileResponse.md)**

### Errors

| Error Type                                    | Status Code                                   | Content Type                                  |
| --------------------------------------------- | --------------------------------------------- | --------------------------------------------- |
| MeetKai.MKA1.Types.Errors.HTTPValidationError | 422                                           | application/json                              |
| MeetKai.MKA1.Types.Errors.APIException        | 4XX, 5XX                                      | \*/\*                                         |

## DownloadArchive

Download a zip archive containing the selected workspace paths.

### Example Usage

<!-- UsageSnippet language="csharp" operationID="downloadWorkspaceArchive" method="post" path="/api/v1/sandbox/sessions/{session_id}/workspace/archive" -->
```csharp
using MeetKai.MKA1;
using MeetKai.MKA1.Types.Components;
using System.Collections.Generic;

var sdk = new SDK(bearerAuth: "<YOUR_BEARER_TOKEN_HERE>");

var res = await sdk.Sandbox.DownloadArchiveAsync(
    sessionId: "demo-python-20260316",
    body: new WorkspaceArchiveRequest() {
        Paths = new List<string>() {
            "outputs/report.txt",
        },
    },
    sessionToken: "sandbox_test_20260316_4f9c2b1a"
);

// handle response
```

### Parameters

| Parameter                                                                    | Type                                                                         | Required                                                                     | Description                                                                  | Example                                                                      |
| ---------------------------------------------------------------------------- | ---------------------------------------------------------------------------- | ---------------------------------------------------------------------------- | ---------------------------------------------------------------------------- | ---------------------------------------------------------------------------- |
| `SessionId`                                                                  | *string*                                                                     | :heavy_check_mark:                                                           | N/A                                                                          | demo-python-20260316                                                         |
| `Body`                                                                       | [WorkspaceArchiveRequest](../../Types/Components/WorkspaceArchiveRequest.md) | :heavy_check_mark:                                                           | N/A                                                                          |                                                                              |
| `SessionToken`                                                               | *string*                                                                     | :heavy_minus_sign:                                                           | N/A                                                                          | sandbox_test_20260316_4f9c2b1a                                               |
| `XOnBehalfOf`                                                                | *string*                                                                     | :heavy_minus_sign:                                                           | Optional external end-user identifier forwarded by the API gateway.          |                                                                              |

### Response

**[DownloadWorkspaceArchiveResponse](../../Types/Requests/DownloadWorkspaceArchiveResponse.md)**

### Errors

| Error Type                                    | Status Code                                   | Content Type                                  |
| --------------------------------------------- | --------------------------------------------- | --------------------------------------------- |
| MeetKai.MKA1.Types.Errors.HTTPValidationError | 422                                           | application/json                              |
| MeetKai.MKA1.Types.Errors.APIException        | 4XX, 5XX                                      | \*/\*                                         |

## UploadArchive

Upload a zip archive and extract its files into the session workspace.

### Example Usage

<!-- UsageSnippet language="csharp" operationID="uploadWorkspaceArchive" method="put" path="/api/v1/sandbox/sessions/{session_id}/workspace/archive" -->
```csharp
using MeetKai.MKA1;
using MeetKai.MKA1.Types.Components;

var sdk = new SDK(bearerAuth: "<YOUR_BEARER_TOKEN_HERE>");

var res = await sdk.Sandbox.UploadArchiveAsync(
    sessionId: "demo-python-20260316",
    sessionToken: "sandbox_test_20260316_4f9c2b1a"
);

// handle response
```

### Parameters

| Parameter                                                           | Type                                                                | Required                                                            | Description                                                         | Example                                                             |
| ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- |
| `SessionId`                                                         | *string*                                                            | :heavy_check_mark:                                                  | N/A                                                                 | demo-python-20260316                                                |
| `SessionToken`                                                      | *string*                                                            | :heavy_minus_sign:                                                  | N/A                                                                 | sandbox_test_20260316_4f9c2b1a                                      |
| `XOnBehalfOf`                                                       | *string*                                                            | :heavy_minus_sign:                                                  | Optional external end-user identifier forwarded by the API gateway. |                                                                     |
| `Body`                                                              | *byte[]*                                                            | :heavy_minus_sign:                                                  | N/A                                                                 |                                                                     |

### Response

**[UploadWorkspaceArchiveResponse](../../Types/Requests/UploadWorkspaceArchiveResponse.md)**

### Errors

| Error Type                                    | Status Code                                   | Content Type                                  |
| --------------------------------------------- | --------------------------------------------- | --------------------------------------------- |
| MeetKai.MKA1.Types.Errors.HTTPValidationError | 422                                           | application/json                              |
| MeetKai.MKA1.Types.Errors.APIException        | 4XX, 5XX                                      | \*/\*                                         |