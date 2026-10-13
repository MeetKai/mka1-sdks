# Sandbox

## Overview

### Available Operations

* [create](#create) - Create Session
* [list](#list) - List Sessions
* [get](#get) - Get Session
* [get_pricing](#get_pricing) - Get Sandbox Pricing
* [set_pricing](#set_pricing) - Set Sandbox Pricing
* [get_browser_url](#get_browser_url) - Get Browser Session URL
* [~~get_url~~](#get_url) - Get Browser Session URL (Deprecated) :warning: **Deprecated** Use [get_browser_url](docs/sdks/sandbox/README.md#get_browser_url) instead.
* [proxy_browser_port_request](#proxy_browser_port_request) - Proxy Browser Port Request
* [run_command](#run_command) - Run Command
* [run_code](#run_code) - Run Code
* [terminate](#terminate) - Terminate Session
* [get_workspace](#get_workspace) - Get Workspace Manifest
* [download_file](#download_file) - Download Workspace File
* [upload_file](#upload_file) - Upload Workspace File
* [download_archive](#download_archive) - Download Workspace Archive
* [upload_archive](#upload_archive) - Upload Workspace Archive

## create

Create a sandbox session and return its public session metadata, session token, and provider. Set `session_kind` to `browser` to start a browser-backed session instead of a standard command/code sandbox. Set `queue_if_full` to `true` to queue the request instead of failing when runner capacity is temporarily unavailable. It does not queue requests for session kinds the deployment does not support. Browser sessions require a Firecracker-backed deployment; standard-only deployments reject them immediately with `browser_sessions_not_enabled`.

### Example Usage

<!-- UsageSnippet language="python" operationID="createSession" method="post" path="/api/v1/sandbox/sessions" -->
```python
from meetkai_mka1 import SDK


with SDK(
    bearer_auth="<YOUR_BEARER_TOKEN_HERE>",
) as sdk:

    res = sdk.sandbox.create(session_id="demo-python-20260316", user_id="demo-user", session_kind="standard", ttl_seconds=600, sandbox_features=[], runtime_profile="standard", queue_if_full=False, skip_llm_credential_exchange=False)

    # Handle response
    print(res)

```

### Parameters

| Parameter                                                                             | Type                                                                                  | Required                                                                              | Description                                                                           |
| ------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------- |
| `session_id`                                                                          | *str*                                                                                 | :heavy_check_mark:                                                                    | N/A                                                                                   |
| `x_on_behalf_of`                                                                      | *Optional[str]*                                                                       | :heavy_minus_sign:                                                                    | Optional external end-user identifier forwarded by the API gateway.                   |
| `session_key`                                                                         | *OptionalNullable[str]*                                                               | :heavy_minus_sign:                                                                    | N/A                                                                                   |
| `user_id`                                                                             | *Optional[str]*                                                                       | :heavy_minus_sign:                                                                    | N/A                                                                                   |
| `session_kind`                                                                        | [Optional[models.SessionKind]](../../models/sessionkind.md)                           | :heavy_minus_sign:                                                                    | N/A                                                                                   |
| `resource_class`                                                                      | [OptionalNullable[models.SandboxResourceClass]](../../models/sandboxresourceclass.md) | :heavy_minus_sign:                                                                    | N/A                                                                                   |
| `ttl_seconds`                                                                         | *Optional[int]*                                                                       | :heavy_minus_sign:                                                                    | N/A                                                                                   |
| `sandbox_features`                                                                    | List[[models.SandboxFeature](../../models/sandboxfeature.md)]                         | :heavy_minus_sign:                                                                    | N/A                                                                                   |
| `runtime_profile`                                                                     | [Optional[models.SandboxRuntimeProfile]](../../models/sandboxruntimeprofile.md)       | :heavy_minus_sign:                                                                    | N/A                                                                                   |
| `memory_mounts`                                                                       | List[[models.MemoryMount](../../models/memorymount.md)]                               | :heavy_minus_sign:                                                                    | N/A                                                                                   |
| `queue_if_full`                                                                       | *Optional[bool]*                                                                      | :heavy_minus_sign:                                                                    | N/A                                                                                   |
| `skip_llm_credential_exchange`                                                        | *Optional[bool]*                                                                      | :heavy_minus_sign:                                                                    | N/A                                                                                   |
| `environment_id`                                                                      | *OptionalNullable[int]*                                                               | :heavy_minus_sign:                                                                    | N/A                                                                                   |
| `coding_harness_skills`                                                               | Dict[str, *Any*]                                                                      | :heavy_minus_sign:                                                                    | N/A                                                                                   |
| `retries`                                                                             | [Optional[utils.RetryConfig]](../../models/utils/retryconfig.md)                      | :heavy_minus_sign:                                                                    | Configuration to override the default retry behavior of the client.                   |

### Response

**[models.CreateSessionResponse](../../models/createsessionresponse.md)**

### Errors

| Error Type                 | Status Code                | Content Type               |
| -------------------------- | -------------------------- | -------------------------- |
| errors.HTTPValidationError | 422                        | application/json           |
| errors.SDKDefaultError     | 4XX, 5XX                   | \*/\*                      |

## list

List sandbox sessions visible to the authenticated caller.

### Example Usage

<!-- UsageSnippet language="python" operationID="listSessions" method="get" path="/api/v1/sandbox/sessions" -->
```python
from meetkai_mka1 import SDK


with SDK(
    bearer_auth="<YOUR_BEARER_TOKEN_HERE>",
) as sdk:

    res = sdk.sandbox.list()

    # Handle response
    print(res)

```

### Parameters

| Parameter                                                           | Type                                                                | Required                                                            | Description                                                         |
| ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- |
| `session_key`                                                       | *OptionalNullable[str]*                                             | :heavy_minus_sign:                                                  | Only sessions created with this session_key.                        |
| `x_on_behalf_of`                                                    | *Optional[str]*                                                     | :heavy_minus_sign:                                                  | Optional external end-user identifier forwarded by the API gateway. |
| `retries`                                                           | [Optional[utils.RetryConfig]](../../models/utils/retryconfig.md)    | :heavy_minus_sign:                                                  | Configuration to override the default retry behavior of the client. |

### Response

**[List[models.SessionRecord]](../../models/.md)**

### Errors

| Error Type                 | Status Code                | Content Type               |
| -------------------------- | -------------------------- | -------------------------- |
| errors.HTTPValidationError | 422                        | application/json           |
| errors.SDKDefaultError     | 4XX, 5XX                   | \*/\*                      |

## get

Return the current state, configuration, and resource allocation for a sandbox session.

### Example Usage

<!-- UsageSnippet language="python" operationID="getSession" method="get" path="/api/v1/sandbox/sessions/{session_id}" -->
```python
from meetkai_mka1 import SDK


with SDK(
    bearer_auth="<YOUR_BEARER_TOKEN_HERE>",
) as sdk:

    res = sdk.sandbox.get(session_id="demo-python-20260316")

    # Handle response
    print(res)

```

### Parameters

| Parameter                                                           | Type                                                                | Required                                                            | Description                                                         | Example                                                             |
| ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- |
| `session_id`                                                        | *str*                                                               | :heavy_check_mark:                                                  | N/A                                                                 | demo-python-20260316                                                |
| `x_on_behalf_of`                                                    | *Optional[str]*                                                     | :heavy_minus_sign:                                                  | Optional external end-user identifier forwarded by the API gateway. |                                                                     |
| `retries`                                                           | [Optional[utils.RetryConfig]](../../models/utils/retryconfig.md)    | :heavy_minus_sign:                                                  | Configuration to override the default retry behavior of the client. |                                                                     |

### Response

**[models.SessionRecord](../../models/sessionrecord.md)**

### Errors

| Error Type                 | Status Code                | Content Type               |
| -------------------------- | -------------------------- | -------------------------- |
| errors.HTTPValidationError | 422                        | application/json           |
| errors.SDKDefaultError     | 4XX, 5XX                   | \*/\*                      |

## get_pricing

Current sandbox pricing rate card, keyed by SKU (`standard`, `browser`, `eval-python`). Metered sandbox usage is billed `hours × (per_hour + reserved_memory_GiB × per_gib_hour)`; SKUs without a configured rate accrue no spend. Cluster admins only.

### Example Usage

<!-- UsageSnippet language="python" operationID="getSandboxPricing" method="get" path="/api/v1/sandbox/pricing" -->
```python
from meetkai_mka1 import SDK


with SDK(
    bearer_auth="<YOUR_BEARER_TOKEN_HERE>",
) as sdk:

    res = sdk.sandbox.get_pricing()

    # Handle response
    print(res)

```

### Parameters

| Parameter                                                           | Type                                                                | Required                                                            | Description                                                         |
| ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- |
| `retries`                                                           | [Optional[utils.RetryConfig]](../../models/utils/retryconfig.md)    | :heavy_minus_sign:                                                  | Configuration to override the default retry behavior of the client. |

### Response

**[models.SandboxPricingCard](../../models/sandboxpricingcard.md)**

### Errors

| Error Type             | Status Code            | Content Type           |
| ---------------------- | ---------------------- | ---------------------- |
| errors.SDKDefaultError | 4XX, 5XX               | \*/\*                  |

## set_pricing

Replace the sandbox pricing rate card. Full-replace semantics. Omitting a SKU that currently has a price is refused with 422 unless `allow_unpriced` is true: an unpriced SKU accrues no spend and its usage cannot be billed. A `currency` that differs from the stored one is saved only after the budgeting service accepts it as the cluster's billing currency (409 when it conflicts, 503 when it cannot be verified). Takes effect on the next meter window without a restart. Cluster admins only.

### Example Usage

<!-- UsageSnippet language="python" operationID="setSandboxPricing" method="put" path="/api/v1/sandbox/pricing" -->
```python
from meetkai_mka1 import SDK


with SDK(
    bearer_auth="<YOUR_BEARER_TOKEN_HERE>",
) as sdk:

    res = sdk.sandbox.set_pricing(rates={
        "standard": {
            "per_hour": 0.1,
            "per_gib_hour": 0.05,
        },
        "browser": {
            "per_hour": 0.4,
            "per_gib_hour": 0.05,
        },
        "eval-python": {
            "per_hour": 0.2,
            "per_gib_hour": 0.05,
        },
    }, allow_unpriced=False)

    # Handle response
    print(res)

```

### Parameters

| Parameter                                                              | Type                                                                   | Required                                                               | Description                                                            |
| ---------------------------------------------------------------------- | ---------------------------------------------------------------------- | ---------------------------------------------------------------------- | ---------------------------------------------------------------------- |
| `rates`                                                                | Dict[str, [models.SandboxPriceRate](../../models/sandboxpricerate.md)] | :heavy_check_mark:                                                     | N/A                                                                    |
| `currency`                                                             | *OptionalNullable[str]*                                                | :heavy_minus_sign:                                                     | N/A                                                                    |
| `allow_unpriced`                                                       | *Optional[bool]*                                                       | :heavy_minus_sign:                                                     | N/A                                                                    |
| `retries`                                                              | [Optional[utils.RetryConfig]](../../models/utils/retryconfig.md)       | :heavy_minus_sign:                                                     | Configuration to override the default retry behavior of the client.    |

### Response

**[models.SandboxPricingCard](../../models/sandboxpricingcard.md)**

### Errors

| Error Type                 | Status Code                | Content Type               |
| -------------------------- | -------------------------- | -------------------------- |
| errors.HTTPValidationError | 422                        | application/json           |
| errors.SDKDefaultError     | 4XX, 5XX                   | \*/\*                      |

## get_browser_url

Return the public gateway URL for a browser session's Chrome DevTools Protocol endpoint. Playwright can use this HTTP endpoint directly. For clients that require a WebSocket endpoint, request `json/version` and use its rewritten `webSocketDebuggerUrl`. Insert subpaths before the query string; for example, use `/ports/9222/json/version?session_token=...`. Send the same MKA1 API-key authorization header on the HTTP and WebSocket requests. Standard sessions do not expose a public URL; use the command, code, and workspace operations instead.

### Example Usage

<!-- UsageSnippet language="python" operationID="getBrowserSessionUrl" method="get" path="/api/v1/sandbox/sessions/{session_id}/browser-url" -->
```python
from meetkai_mka1 import SDK


with SDK(
    bearer_auth="<YOUR_BEARER_TOKEN_HERE>",
) as sdk:

    res = sdk.sandbox.get_browser_url(session_id="browser-demo-20260318", session_token="sandbox_test_browser_20260318")

    # Handle response
    print(res)

```

### Parameters

| Parameter                                                           | Type                                                                | Required                                                            | Description                                                         | Example                                                             |
| ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- |
| `session_id`                                                        | *str*                                                               | :heavy_check_mark:                                                  | N/A                                                                 | browser-demo-20260318                                               |
| `session_token`                                                     | *OptionalNullable[str]*                                             | :heavy_minus_sign:                                                  | N/A                                                                 | sandbox_test_browser_20260318                                       |
| `x_on_behalf_of`                                                    | *Optional[str]*                                                     | :heavy_minus_sign:                                                  | Optional external end-user identifier forwarded by the API gateway. |                                                                     |
| `retries`                                                           | [Optional[utils.RetryConfig]](../../models/utils/retryconfig.md)    | :heavy_minus_sign:                                                  | Configuration to override the default retry behavior of the client. |                                                                     |

### Response

**[models.SessionURLResponse](../../models/sessionurlresponse.md)**

### Errors

| Error Type                 | Status Code                | Content Type               |
| -------------------------- | -------------------------- | -------------------------- |
| errors.HTTPValidationError | 422                        | application/json           |
| errors.SDKDefaultError     | 4XX, 5XX                   | \*/\*                      |

## ~~get_url~~

Deprecated compatibility alias for `getBrowserUrl`. Return the public gateway URL for a browser session's Chrome DevTools Protocol endpoint. Standard sessions do not expose a public URL; use the command, code, and workspace operations instead.

> :warning: **DEPRECATED**: Use sandbox.getBrowserUrl instead.. Use `get_browser_url` instead.

### Example Usage

<!-- UsageSnippet language="python" operationID="getSessionUrl" method="get" path="/api/v1/sandbox/sessions/{session_id}/url" -->
```python
from meetkai_mka1 import SDK


with SDK(
    bearer_auth="<YOUR_BEARER_TOKEN_HERE>",
) as sdk:

    res = sdk.sandbox.get_url(session_id="browser-demo-20260318", session_token="sandbox_test_browser_20260318", port=9222)

    # Handle response
    print(res)

```

### Parameters

| Parameter                                                           | Type                                                                | Required                                                            | Description                                                         | Example                                                             |
| ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- |
| `session_id`                                                        | *str*                                                               | :heavy_check_mark:                                                  | N/A                                                                 | browser-demo-20260318                                               |
| `session_token`                                                     | *OptionalNullable[str]*                                             | :heavy_minus_sign:                                                  | N/A                                                                 | sandbox_test_browser_20260318                                       |
| `port`                                                              | *OptionalNullable[int]*                                             | :heavy_minus_sign:                                                  | N/A                                                                 | 9222                                                                |
| `x_on_behalf_of`                                                    | *Optional[str]*                                                     | :heavy_minus_sign:                                                  | Optional external end-user identifier forwarded by the API gateway. |                                                                     |
| `retries`                                                           | [Optional[utils.RetryConfig]](../../models/utils/retryconfig.md)    | :heavy_minus_sign:                                                  | Configuration to override the default retry behavior of the client. |                                                                     |

### Response

**[models.SessionURLResponse](../../models/sessionurlresponse.md)**

### Errors

| Error Type                 | Status Code                | Content Type               |
| -------------------------- | -------------------------- | -------------------------- |
| errors.HTTPValidationError | 422                        | application/json           |
| errors.SDKDefaultError     | 4XX, 5XX                   | \*/\*                      |

## proxy_browser_port_request

Proxy an HTTP request to an exposed browser-session port through the gateway. Use the URL returned by `GET /sessions/{session_id}/browser-url` as the base. Insert CDP subpaths such as `json/version` or `json/list` before its query string, preserving the `session_token` parameter. This low-level proxy is intended for browser sessions on port `9222` and still requires the normal MKA1 API-key authorization header.

### Example Usage

<!-- UsageSnippet language="python" operationID="proxyBrowserPortRequest" method="get" path="/api/v1/sandbox/sessions/{session_id}/ports/{port}/{subpath}" -->
```python
from meetkai_mka1 import SDK


with SDK(
    bearer_auth="<YOUR_BEARER_TOKEN_HERE>",
) as sdk:

    res = sdk.sandbox.proxy_browser_port_request(session_id="browser-demo-20260318", port=9222, subpath="json/version", session_token="sandbox_test_browser_20260318")

    # Handle response
    print(res)

```

### Parameters

| Parameter                                                           | Type                                                                | Required                                                            | Description                                                         | Example                                                             |
| ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- |
| `session_id`                                                        | *str*                                                               | :heavy_check_mark:                                                  | N/A                                                                 | browser-demo-20260318                                               |
| `port`                                                              | *int*                                                               | :heavy_check_mark:                                                  | N/A                                                                 | 9222                                                                |
| `subpath`                                                           | *str*                                                               | :heavy_check_mark:                                                  | N/A                                                                 | json/version                                                        |
| `session_token`                                                     | *OptionalNullable[str]*                                             | :heavy_minus_sign:                                                  | N/A                                                                 | sandbox_test_browser_20260318                                       |
| `x_on_behalf_of`                                                    | *Optional[str]*                                                     | :heavy_minus_sign:                                                  | Optional external end-user identifier forwarded by the API gateway. |                                                                     |
| `retries`                                                           | [Optional[utils.RetryConfig]](../../models/utils/retryconfig.md)    | :heavy_minus_sign:                                                  | Configuration to override the default retry behavior of the client. |                                                                     |

### Response

**[Any](../../models/.md)**

### Errors

| Error Type                 | Status Code                | Content Type               |
| -------------------------- | -------------------------- | -------------------------- |
| errors.HTTPValidationError | 422                        | application/json           |
| errors.SDKDefaultError     | 4XX, 5XX                   | \*/\*                      |

## run_command

Run a command in the session workspace and return stdout, stderr, exit code, and changed files.

### Example Usage

<!-- UsageSnippet language="python" operationID="runCommand" method="post" path="/api/v1/sandbox/sessions/{session_id}/commands" -->
```python
from meetkai_mka1 import SDK


with SDK(
    bearer_auth="<YOUR_BEARER_TOKEN_HERE>",
) as sdk:

    res = sdk.sandbox.run_command(session_id_param="demo-python-20260316", session_id="demo-python-20260316", command="python3", session_token="sandbox_test_20260316_4f9c2b1a", args=[
        "-c",
        "import math; print(math.sqrt(144))",
    ], cwd=None, env={

    }, timeout_seconds=60)

    # Handle response
    print(res)

```

### Parameters

| Parameter                                                           | Type                                                                | Required                                                            | Description                                                         | Example                                                             |
| ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- |
| `session_id_param`                                                  | *str*                                                               | :heavy_check_mark:                                                  | N/A                                                                 | demo-python-20260316                                                |
| `session_id`                                                        | *str*                                                               | :heavy_check_mark:                                                  | N/A                                                                 |                                                                     |
| `command`                                                           | *str*                                                               | :heavy_check_mark:                                                  | N/A                                                                 |                                                                     |
| `x_on_behalf_of`                                                    | *Optional[str]*                                                     | :heavy_minus_sign:                                                  | Optional external end-user identifier forwarded by the API gateway. |                                                                     |
| `session_token`                                                     | *OptionalNullable[str]*                                             | :heavy_minus_sign:                                                  | N/A                                                                 |                                                                     |
| `command_request_id`                                                | *OptionalNullable[str]*                                             | :heavy_minus_sign:                                                  | N/A                                                                 |                                                                     |
| `args`                                                              | List[*str*]                                                         | :heavy_minus_sign:                                                  | N/A                                                                 |                                                                     |
| `cwd`                                                               | *OptionalNullable[str]*                                             | :heavy_minus_sign:                                                  | N/A                                                                 |                                                                     |
| `env`                                                               | Dict[str, *str*]                                                    | :heavy_minus_sign:                                                  | N/A                                                                 |                                                                     |
| `timeout_seconds`                                                   | *Optional[int]*                                                     | :heavy_minus_sign:                                                  | N/A                                                                 |                                                                     |
| `retries`                                                           | [Optional[utils.RetryConfig]](../../models/utils/retryconfig.md)    | :heavy_minus_sign:                                                  | Configuration to override the default retry behavior of the client. |                                                                     |

### Response

**[models.CommandResult](../../models/commandresult.md)**

### Errors

| Error Type                 | Status Code                | Content Type               |
| -------------------------- | -------------------------- | -------------------------- |
| errors.HTTPValidationError | 422                        | application/json           |
| errors.SDKDefaultError     | 4XX, 5XX                   | \*/\*                      |

## run_code

Execute source code in the session workspace using a supported runtime and return the execution result.

### Example Usage

<!-- UsageSnippet language="python" operationID="runCode" method="post" path="/api/v1/sandbox/sessions/{session_id}/code" -->
```python
from meetkai_mka1 import SDK


with SDK(
    bearer_auth="<YOUR_BEARER_TOKEN_HERE>",
) as sdk:

    res = sdk.sandbox.run_code(session_id_param="demo-python-20260316", session_id="demo-python-20260316", code="from pathlib import Path; Path('live_check.txt').write_text('ok'); print('code-ran')", session_token="sandbox_test_20260316_4f9c2b1a", runtime="python", cwd=None, env={

    }, timeout_seconds=60)

    # Handle response
    print(res)

```

### Parameters

| Parameter                                                           | Type                                                                | Required                                                            | Description                                                         | Example                                                             |
| ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- |
| `session_id_param`                                                  | *str*                                                               | :heavy_check_mark:                                                  | N/A                                                                 | demo-python-20260316                                                |
| `session_id`                                                        | *str*                                                               | :heavy_check_mark:                                                  | N/A                                                                 |                                                                     |
| `code`                                                              | *str*                                                               | :heavy_check_mark:                                                  | N/A                                                                 |                                                                     |
| `x_on_behalf_of`                                                    | *Optional[str]*                                                     | :heavy_minus_sign:                                                  | Optional external end-user identifier forwarded by the API gateway. |                                                                     |
| `session_token`                                                     | *OptionalNullable[str]*                                             | :heavy_minus_sign:                                                  | N/A                                                                 |                                                                     |
| `runtime`                                                           | [Optional[models.CodeRuntime]](../../models/coderuntime.md)         | :heavy_minus_sign:                                                  | N/A                                                                 |                                                                     |
| `cwd`                                                               | *OptionalNullable[str]*                                             | :heavy_minus_sign:                                                  | N/A                                                                 |                                                                     |
| `env`                                                               | Dict[str, *str*]                                                    | :heavy_minus_sign:                                                  | N/A                                                                 |                                                                     |
| `timeout_seconds`                                                   | *Optional[int]*                                                     | :heavy_minus_sign:                                                  | N/A                                                                 |                                                                     |
| `retries`                                                           | [Optional[utils.RetryConfig]](../../models/utils/retryconfig.md)    | :heavy_minus_sign:                                                  | Configuration to override the default retry behavior of the client. |                                                                     |

### Response

**[models.CodeResult](../../models/coderesult.md)**

### Errors

| Error Type                 | Status Code                | Content Type               |
| -------------------------- | -------------------------- | -------------------------- |
| errors.HTTPValidationError | 422                        | application/json           |
| errors.SDKDefaultError     | 4XX, 5XX                   | \*/\*                      |

## terminate

Stop a sandbox session and release the backing sandbox resources.

### Example Usage

<!-- UsageSnippet language="python" operationID="terminateSession" method="post" path="/api/v1/sandbox/sessions/{session_id}/terminate" -->
```python
from meetkai_mka1 import SDK


with SDK(
    bearer_auth="<YOUR_BEARER_TOKEN_HERE>",
) as sdk:

    res = sdk.sandbox.terminate(session_id_param="demo-python-20260316", session_id="demo-python-20260316", session_token="sandbox_test_20260316_4f9c2b1a")

    # Handle response
    print(res)

```

### Parameters

| Parameter                                                           | Type                                                                | Required                                                            | Description                                                         | Example                                                             |
| ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- |
| `session_id_param`                                                  | *str*                                                               | :heavy_check_mark:                                                  | N/A                                                                 | demo-python-20260316                                                |
| `session_id`                                                        | *str*                                                               | :heavy_check_mark:                                                  | N/A                                                                 |                                                                     |
| `x_on_behalf_of`                                                    | *Optional[str]*                                                     | :heavy_minus_sign:                                                  | Optional external end-user identifier forwarded by the API gateway. |                                                                     |
| `session_token`                                                     | *OptionalNullable[str]*                                             | :heavy_minus_sign:                                                  | N/A                                                                 |                                                                     |
| `expected_session_kind`                                             | [OptionalNullable[models.SessionKind]](../../models/sessionkind.md) | :heavy_minus_sign:                                                  | N/A                                                                 |                                                                     |
| `retries`                                                           | [Optional[utils.RetryConfig]](../../models/utils/retryconfig.md)    | :heavy_minus_sign:                                                  | Configuration to override the default retry behavior of the client. |                                                                     |

### Response

**[models.TerminateSessionResponse](../../models/terminatesessionresponse.md)**

### Errors

| Error Type                 | Status Code                | Content Type               |
| -------------------------- | -------------------------- | -------------------------- |
| errors.HTTPValidationError | 422                        | application/json           |
| errors.SDKDefaultError     | 4XX, 5XX                   | \*/\*                      |

## get_workspace

List files currently stored in the session workspace, including paths, sizes, and etags.

### Example Usage

<!-- UsageSnippet language="python" operationID="getWorkspace" method="get" path="/api/v1/sandbox/sessions/{session_id}/workspace" -->
```python
from meetkai_mka1 import SDK


with SDK(
    bearer_auth="<YOUR_BEARER_TOKEN_HERE>",
) as sdk:

    res = sdk.sandbox.get_workspace(session_id="demo-python-20260316", session_token="sandbox_test_20260316_4f9c2b1a")

    # Handle response
    print(res)

```

### Parameters

| Parameter                                                           | Type                                                                | Required                                                            | Description                                                         | Example                                                             |
| ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- |
| `session_id`                                                        | *str*                                                               | :heavy_check_mark:                                                  | N/A                                                                 | demo-python-20260316                                                |
| `session_token`                                                     | *OptionalNullable[str]*                                             | :heavy_minus_sign:                                                  | N/A                                                                 | sandbox_test_20260316_4f9c2b1a                                      |
| `x_on_behalf_of`                                                    | *Optional[str]*                                                     | :heavy_minus_sign:                                                  | Optional external end-user identifier forwarded by the API gateway. |                                                                     |
| `retries`                                                           | [Optional[utils.RetryConfig]](../../models/utils/retryconfig.md)    | :heavy_minus_sign:                                                  | Configuration to override the default retry behavior of the client. |                                                                     |

### Response

**[models.WorkspaceManifest](../../models/workspacemanifest.md)**

### Errors

| Error Type                 | Status Code                | Content Type               |
| -------------------------- | -------------------------- | -------------------------- |
| errors.HTTPValidationError | 422                        | application/json           |
| errors.SDKDefaultError     | 4XX, 5XX                   | \*/\*                      |

## download_file

Download raw bytes from a file in the session workspace.

### Example Usage

<!-- UsageSnippet language="python" operationID="downloadWorkspaceFile" method="get" path="/api/v1/sandbox/sessions/{session_id}/workspace/files/{file_path}" -->
```python
from meetkai_mka1 import SDK


with SDK(
    bearer_auth="<YOUR_BEARER_TOKEN_HERE>",
) as sdk:

    res = sdk.sandbox.download_file(session_id="demo-python-20260316", file_path="outputs/report.txt", session_token="sandbox_test_20260316_4f9c2b1a")

    # Handle response
    print(res)

```

### Parameters

| Parameter                                                           | Type                                                                | Required                                                            | Description                                                         | Example                                                             |
| ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- |
| `session_id`                                                        | *str*                                                               | :heavy_check_mark:                                                  | N/A                                                                 | demo-python-20260316                                                |
| `file_path`                                                         | *str*                                                               | :heavy_check_mark:                                                  | N/A                                                                 | outputs/report.txt                                                  |
| `session_token`                                                     | *OptionalNullable[str]*                                             | :heavy_minus_sign:                                                  | N/A                                                                 | sandbox_test_20260316_4f9c2b1a                                      |
| `x_on_behalf_of`                                                    | *Optional[str]*                                                     | :heavy_minus_sign:                                                  | Optional external end-user identifier forwarded by the API gateway. |                                                                     |
| `retries`                                                           | [Optional[utils.RetryConfig]](../../models/utils/retryconfig.md)    | :heavy_minus_sign:                                                  | Configuration to override the default retry behavior of the client. |                                                                     |

### Response

**[httpx.Response](../../models/.md)**

### Errors

| Error Type                 | Status Code                | Content Type               |
| -------------------------- | -------------------------- | -------------------------- |
| errors.HTTPValidationError | 422                        | application/json           |
| errors.SDKDefaultError     | 4XX, 5XX                   | \*/\*                      |

## upload_file

Upload raw bytes into the session workspace at the given path.

### Example Usage

<!-- UsageSnippet language="python" operationID="uploadWorkspaceFile" method="put" path="/api/v1/sandbox/sessions/{session_id}/workspace/files/{file_path}" -->
```python
from meetkai_mka1 import SDK


with SDK(
    bearer_auth="<YOUR_BEARER_TOKEN_HERE>",
) as sdk:

    res = sdk.sandbox.upload_file(session_id="demo-python-20260316", file_path="inputs/config.json", session_token="sandbox_test_20260316_4f9c2b1a")

    # Handle response
    print(res)

```

### Parameters

| Parameter                                                           | Type                                                                | Required                                                            | Description                                                         | Example                                                             |
| ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- |
| `session_id`                                                        | *str*                                                               | :heavy_check_mark:                                                  | N/A                                                                 | demo-python-20260316                                                |
| `file_path`                                                         | *str*                                                               | :heavy_check_mark:                                                  | N/A                                                                 | inputs/config.json                                                  |
| `session_token`                                                     | *OptionalNullable[str]*                                             | :heavy_minus_sign:                                                  | N/A                                                                 | sandbox_test_20260316_4f9c2b1a                                      |
| `x_on_behalf_of`                                                    | *Optional[str]*                                                     | :heavy_minus_sign:                                                  | Optional external end-user identifier forwarded by the API gateway. |                                                                     |
| `body`                                                              | *Optional[Union[bytes, IO[bytes], io.IOBase]]*                      | :heavy_minus_sign:                                                  | N/A                                                                 |                                                                     |
| `retries`                                                           | [Optional[utils.RetryConfig]](../../models/utils/retryconfig.md)    | :heavy_minus_sign:                                                  | Configuration to override the default retry behavior of the client. |                                                                     |

### Response

**[Dict[str, str]](../../models/.md)**

### Errors

| Error Type                 | Status Code                | Content Type               |
| -------------------------- | -------------------------- | -------------------------- |
| errors.HTTPValidationError | 422                        | application/json           |
| errors.SDKDefaultError     | 4XX, 5XX                   | \*/\*                      |

## download_archive

Download a zip archive containing the selected workspace paths.

### Example Usage

<!-- UsageSnippet language="python" operationID="downloadWorkspaceArchive" method="post" path="/api/v1/sandbox/sessions/{session_id}/workspace/archive" -->
```python
from meetkai_mka1 import SDK


with SDK(
    bearer_auth="<YOUR_BEARER_TOKEN_HERE>",
) as sdk:

    res = sdk.sandbox.download_archive(session_id="demo-python-20260316", session_token="sandbox_test_20260316_4f9c2b1a", paths=[
        "outputs/report.txt",
    ])

    # Handle response
    print(res)

```

### Parameters

| Parameter                                                           | Type                                                                | Required                                                            | Description                                                         | Example                                                             |
| ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- |
| `session_id`                                                        | *str*                                                               | :heavy_check_mark:                                                  | N/A                                                                 | demo-python-20260316                                                |
| `session_token`                                                     | *OptionalNullable[str]*                                             | :heavy_minus_sign:                                                  | N/A                                                                 | sandbox_test_20260316_4f9c2b1a                                      |
| `x_on_behalf_of`                                                    | *Optional[str]*                                                     | :heavy_minus_sign:                                                  | Optional external end-user identifier forwarded by the API gateway. |                                                                     |
| `paths`                                                             | List[*str*]                                                         | :heavy_minus_sign:                                                  | N/A                                                                 |                                                                     |
| `retries`                                                           | [Optional[utils.RetryConfig]](../../models/utils/retryconfig.md)    | :heavy_minus_sign:                                                  | Configuration to override the default retry behavior of the client. |                                                                     |

### Response

**[httpx.Response](../../models/.md)**

### Errors

| Error Type                 | Status Code                | Content Type               |
| -------------------------- | -------------------------- | -------------------------- |
| errors.HTTPValidationError | 422                        | application/json           |
| errors.SDKDefaultError     | 4XX, 5XX                   | \*/\*                      |

## upload_archive

Upload a zip archive and extract its files into the session workspace.

### Example Usage

<!-- UsageSnippet language="python" operationID="uploadWorkspaceArchive" method="put" path="/api/v1/sandbox/sessions/{session_id}/workspace/archive" -->
```python
from meetkai_mka1 import SDK


with SDK(
    bearer_auth="<YOUR_BEARER_TOKEN_HERE>",
) as sdk:

    res = sdk.sandbox.upload_archive(session_id="demo-python-20260316", session_token="sandbox_test_20260316_4f9c2b1a")

    # Handle response
    print(res)

```

### Parameters

| Parameter                                                           | Type                                                                | Required                                                            | Description                                                         | Example                                                             |
| ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- |
| `session_id`                                                        | *str*                                                               | :heavy_check_mark:                                                  | N/A                                                                 | demo-python-20260316                                                |
| `session_token`                                                     | *OptionalNullable[str]*                                             | :heavy_minus_sign:                                                  | N/A                                                                 | sandbox_test_20260316_4f9c2b1a                                      |
| `x_on_behalf_of`                                                    | *Optional[str]*                                                     | :heavy_minus_sign:                                                  | Optional external end-user identifier forwarded by the API gateway. |                                                                     |
| `body`                                                              | *Optional[Union[bytes, IO[bytes], io.IOBase]]*                      | :heavy_minus_sign:                                                  | N/A                                                                 |                                                                     |
| `retries`                                                           | [Optional[utils.RetryConfig]](../../models/utils/retryconfig.md)    | :heavy_minus_sign:                                                  | Configuration to override the default retry behavior of the client. |                                                                     |

### Response

**[Dict[str, str]](../../models/.md)**

### Errors

| Error Type                 | Status Code                | Content Type               |
| -------------------------- | -------------------------- | -------------------------- |
| errors.HTTPValidationError | 422                        | application/json           |
| errors.SDKDefaultError     | 4XX, 5XX                   | \*/\*                      |