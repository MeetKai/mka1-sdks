# Sandbox.Connectors

## Overview

### Available Operations

* [List](#list) - List Connectors
* [CreateAuthorizationIntent](#createauthorizationintent) - Start Connector Sign-In
* [Connect](#connect) - Finish Connector Sign-In
* [SetAPIKey](#setapikey) - Set Connector API Key
* [Disconnect](#disconnect) - Disconnect Connector
* [ListTools](#listtools) - List Connector Tools
* [SetTools](#settools) - Set Connector Tool Allowlist

## List

List the connectors you can connect and your connection to each, or `null` when you have none. `status` is `needs_login` when the connector must be reconnected. `tool_allowlist` set to `null` means sessions may call every tool the connector lists, read or write. Only an environment with `network_access` set to `full` can list connectors, at most `max_per_environment` of them.

### Example Usage

<!-- UsageSnippet language="go" operationID="listSandboxConnectors" method="get" path="/api/v1/sandbox/connectors" -->
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

    res, err := s.Sandbox.Connectors.List(ctx, nil)
    if err != nil {
        log.Fatal(err)
    }
    if res.ConnectorCatalogModel != nil {
        // handle response
    }
}
```

### Parameters

| Parameter                                                           | Type                                                                | Required                                                            | Description                                                         |
| ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- |
| `ctx`                                                               | [context.Context](https://pkg.go.dev/context#Context)               | :heavy_check_mark:                                                  | The context to use for the request.                                 |
| `xOnBehalfOf`                                                       | `*string`                                                           | :heavy_minus_sign:                                                  | Optional external end-user identifier forwarded by the API gateway. |
| `opts`                                                              | [][operations.Option](../../models/operations/option.md)            | :heavy_minus_sign:                                                  | The options for this request.                                       |

### Response

**[*operations.ListSandboxConnectorsResponse](../../models/operations/listsandboxconnectorsresponse.md), error**

### Errors

| Error Type         | Status Code        | Content Type       |
| ------------------ | ------------------ | ------------------ |
| apierrors.APIError | 4XX, 5XX           | \*/\*              |

## CreateAuthorizationIntent

Start connecting an OAuth connector to your account. Send the user to the returned `authorize_url`. The connector redirects back to the platform callback page with a `code` and the same `state`, which it passes to `POST /connectors/oauth/connections` before `expires_in_seconds` elapses. Each `state` works once, and only for the account that started the sign-in.

### Example Usage

<!-- UsageSnippet language="go" operationID="createSandboxConnectorAuthorizationIntent" method="post" path="/api/v1/sandbox/connectors/oauth/intents" -->
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

    res, err := s.Sandbox.Connectors.CreateAuthorizationIntent(ctx, components.CreateConnectorIntentRequest{
        ConnectorKey: "<value>",
    }, nil)
    if err != nil {
        log.Fatal(err)
    }
    if res.ConnectorAuthorizeIntentModel != nil {
        // handle response
    }
}
```

### Parameters

| Parameter                                                                                          | Type                                                                                               | Required                                                                                           | Description                                                                                        |
| -------------------------------------------------------------------------------------------------- | -------------------------------------------------------------------------------------------------- | -------------------------------------------------------------------------------------------------- | -------------------------------------------------------------------------------------------------- |
| `ctx`                                                                                              | [context.Context](https://pkg.go.dev/context#Context)                                              | :heavy_check_mark:                                                                                 | The context to use for the request.                                                                |
| `body`                                                                                             | [components.CreateConnectorIntentRequest](../../models/components/createconnectorintentrequest.md) | :heavy_check_mark:                                                                                 | N/A                                                                                                |
| `xOnBehalfOf`                                                                                      | `*string`                                                                                          | :heavy_minus_sign:                                                                                 | Optional external end-user identifier forwarded by the API gateway.                                |
| `opts`                                                                                             | [][operations.Option](../../models/operations/option.md)                                           | :heavy_minus_sign:                                                                                 | The options for this request.                                                                      |

### Response

**[*operations.CreateSandboxConnectorAuthorizationIntentResponse](../../models/operations/createsandboxconnectorauthorizationintentresponse.md), error**

### Errors

| Error Type                    | Status Code                   | Content Type                  |
| ----------------------------- | ----------------------------- | ----------------------------- |
| apierrors.HTTPValidationError | 422                           | application/json              |
| apierrors.APIError            | 4XX, 5XX                      | \*/\*                         |

## Connect

Exchange the `code` and `state` from the connector's redirect for a stored connection. Call it as the same signed-in user who started the sign-in. The sandbox service keeps the token encrypted and never returns it.

### Example Usage

<!-- UsageSnippet language="go" operationID="connectSandboxConnector" method="post" path="/api/v1/sandbox/connectors/oauth/connections" -->
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

    res, err := s.Sandbox.Connectors.Connect(ctx, components.ConnectConnectorRequest{
        Code: "<value>",
        State: "Kansas",
    }, nil)
    if err != nil {
        log.Fatal(err)
    }
    if res.ConnectorModel != nil {
        // handle response
    }
}
```

### Parameters

| Parameter                                                                                | Type                                                                                     | Required                                                                                 | Description                                                                              |
| ---------------------------------------------------------------------------------------- | ---------------------------------------------------------------------------------------- | ---------------------------------------------------------------------------------------- | ---------------------------------------------------------------------------------------- |
| `ctx`                                                                                    | [context.Context](https://pkg.go.dev/context#Context)                                    | :heavy_check_mark:                                                                       | The context to use for the request.                                                      |
| `body`                                                                                   | [components.ConnectConnectorRequest](../../models/components/connectconnectorrequest.md) | :heavy_check_mark:                                                                       | N/A                                                                                      |
| `xOnBehalfOf`                                                                            | `*string`                                                                                | :heavy_minus_sign:                                                                       | Optional external end-user identifier forwarded by the API gateway.                      |
| `opts`                                                                                   | [][operations.Option](../../models/operations/option.md)                                 | :heavy_minus_sign:                                                                       | The options for this request.                                                            |

### Response

**[*operations.ConnectSandboxConnectorResponse](../../models/operations/connectsandboxconnectorresponse.md), error**

### Errors

| Error Type                    | Status Code                   | Content Type                  |
| ----------------------------- | ----------------------------- | ----------------------------- |
| apierrors.HTTPValidationError | 422                           | application/json              |
| apierrors.APIError            | 4XX, 5XX                      | \*/\*                         |

## SetAPIKey

Connect an API-key connector. The key is checked against the connector before it is stored (422 when the connector refuses it) and is never returned.

### Example Usage

<!-- UsageSnippet language="go" operationID="setSandboxConnectorApiKey" method="put" path="/api/v1/sandbox/connectors/connections/{connector_key}/api-key" -->
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

    res, err := s.Sandbox.Connectors.SetAPIKey(ctx, "<value>", components.SetConnectorAPIKeyRequest{
        APIKey: "<value>",
    }, nil)
    if err != nil {
        log.Fatal(err)
    }
    if res.ConnectorModel != nil {
        // handle response
    }
}
```

### Parameters

| Parameter                                                                                    | Type                                                                                         | Required                                                                                     | Description                                                                                  |
| -------------------------------------------------------------------------------------------- | -------------------------------------------------------------------------------------------- | -------------------------------------------------------------------------------------------- | -------------------------------------------------------------------------------------------- |
| `ctx`                                                                                        | [context.Context](https://pkg.go.dev/context#Context)                                        | :heavy_check_mark:                                                                           | The context to use for the request.                                                          |
| `connectorKey`                                                                               | `string`                                                                                     | :heavy_check_mark:                                                                           | N/A                                                                                          |
| `body`                                                                                       | [components.SetConnectorAPIKeyRequest](../../models/components/setconnectorapikeyrequest.md) | :heavy_check_mark:                                                                           | N/A                                                                                          |
| `xOnBehalfOf`                                                                                | `*string`                                                                                    | :heavy_minus_sign:                                                                           | Optional external end-user identifier forwarded by the API gateway.                          |
| `opts`                                                                                       | [][operations.Option](../../models/operations/option.md)                                     | :heavy_minus_sign:                                                                           | The options for this request.                                                                |

### Response

**[*operations.SetSandboxConnectorAPIKeyResponse](../../models/operations/setsandboxconnectorapikeyresponse.md), error**

### Errors

| Error Type                    | Status Code                   | Content Type                  |
| ----------------------------- | ----------------------------- | ----------------------------- |
| apierrors.HTTPValidationError | 422                           | application/json              |
| apierrors.APIError            | 4XX, 5XX                      | \*/\*                         |

## Disconnect

Delete your connection to a connector and revoke its token at the connector when it supports revocation. The connection is deleted even if the connector does not confirm the revocation.

### Example Usage

<!-- UsageSnippet language="go" operationID="disconnectSandboxConnector" method="delete" path="/api/v1/sandbox/connectors/connections/{connector_key}" -->
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

    res, err := s.Sandbox.Connectors.Disconnect(ctx, "<value>", nil)
    if err != nil {
        log.Fatal(err)
    }
    if res != nil {
        // handle response
    }
}
```

### Parameters

| Parameter                                                           | Type                                                                | Required                                                            | Description                                                         |
| ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- |
| `ctx`                                                               | [context.Context](https://pkg.go.dev/context#Context)               | :heavy_check_mark:                                                  | The context to use for the request.                                 |
| `connectorKey`                                                      | `string`                                                            | :heavy_check_mark:                                                  | N/A                                                                 |
| `xOnBehalfOf`                                                       | `*string`                                                           | :heavy_minus_sign:                                                  | Optional external end-user identifier forwarded by the API gateway. |
| `opts`                                                              | [][operations.Option](../../models/operations/option.md)            | :heavy_minus_sign:                                                  | The options for this request.                                       |

### Response

**[*operations.DisconnectSandboxConnectorResponse](../../models/operations/disconnectsandboxconnectorresponse.md), error**

### Errors

| Error Type                    | Status Code                   | Content Type                  |
| ----------------------------- | ----------------------------- | ----------------------------- |
| apierrors.HTTPValidationError | 422                           | application/json              |
| apierrors.APIError            | 4XX, 5XX                      | \*/\*                         |

## ListTools

List the connector's tools now, with whether each is read-only, your tool allowlist, and `allowed`: the tools a session could call. 409 when the connector must be reconnected.

### Example Usage

<!-- UsageSnippet language="go" operationID="listSandboxConnectorTools" method="get" path="/api/v1/sandbox/connectors/connections/{connector_key}/tools" -->
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

    res, err := s.Sandbox.Connectors.ListTools(ctx, "<value>", nil)
    if err != nil {
        log.Fatal(err)
    }
    if res.ConnectorToolsModel != nil {
        // handle response
    }
}
```

### Parameters

| Parameter                                                           | Type                                                                | Required                                                            | Description                                                         |
| ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- |
| `ctx`                                                               | [context.Context](https://pkg.go.dev/context#Context)               | :heavy_check_mark:                                                  | The context to use for the request.                                 |
| `connectorKey`                                                      | `string`                                                            | :heavy_check_mark:                                                  | N/A                                                                 |
| `xOnBehalfOf`                                                       | `*string`                                                           | :heavy_minus_sign:                                                  | Optional external end-user identifier forwarded by the API gateway. |
| `opts`                                                              | [][operations.Option](../../models/operations/option.md)            | :heavy_minus_sign:                                                  | The options for this request.                                       |

### Response

**[*operations.ListSandboxConnectorToolsResponse](../../models/operations/listsandboxconnectortoolsresponse.md), error**

### Errors

| Error Type                    | Status Code                   | Content Type                  |
| ----------------------------- | ----------------------------- | ----------------------------- |
| apierrors.HTTPValidationError | 422                           | application/json              |
| apierrors.APIError            | 4XX, 5XX                      | \*/\*                         |

## SetTools

Choose which of the connector's tools sessions may call. Send a list of tool names, or `null` to allow every tool the connector lists, read or write.

### Example Usage

<!-- UsageSnippet language="go" operationID="setSandboxConnectorTools" method="put" path="/api/v1/sandbox/connectors/connections/{connector_key}/tools" -->
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

    res, err := s.Sandbox.Connectors.SetTools(ctx, "<value>", components.SetConnectorToolsRequest{
        ToolAllowlist: []string{},
    }, nil)
    if err != nil {
        log.Fatal(err)
    }
    if res.ConnectorModel != nil {
        // handle response
    }
}
```

### Parameters

| Parameter                                                                                  | Type                                                                                       | Required                                                                                   | Description                                                                                |
| ------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------ |
| `ctx`                                                                                      | [context.Context](https://pkg.go.dev/context#Context)                                      | :heavy_check_mark:                                                                         | The context to use for the request.                                                        |
| `connectorKey`                                                                             | `string`                                                                                   | :heavy_check_mark:                                                                         | N/A                                                                                        |
| `body`                                                                                     | [components.SetConnectorToolsRequest](../../models/components/setconnectortoolsrequest.md) | :heavy_check_mark:                                                                         | N/A                                                                                        |
| `xOnBehalfOf`                                                                              | `*string`                                                                                  | :heavy_minus_sign:                                                                         | Optional external end-user identifier forwarded by the API gateway.                        |
| `opts`                                                                                     | [][operations.Option](../../models/operations/option.md)                                   | :heavy_minus_sign:                                                                         | The options for this request.                                                              |

### Response

**[*operations.SetSandboxConnectorToolsResponse](../../models/operations/setsandboxconnectortoolsresponse.md), error**

### Errors

| Error Type                    | Status Code                   | Content Type                  |
| ----------------------------- | ----------------------------- | ----------------------------- |
| apierrors.HTTPValidationError | 422                           | application/json              |
| apierrors.APIError            | 4XX, 5XX                      | \*/\*                         |