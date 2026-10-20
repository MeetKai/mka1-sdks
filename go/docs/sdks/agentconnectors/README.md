# AgentConnectors

## Overview

Connect saved agents to external messaging channels such as Telegram, including text, photo, and supported document exchange.

### Available Operations

* [ListAgentConnectors](#listagentconnectors) - List connectors for an agent
* [CreateAgentConnector](#createagentconnector) - Create a connector
* [SetupWhatsAppAppWebhook](#setupwhatsappappwebhook) - Set up a WhatsApp app webhook (Beta)
* [GetAgentConnector](#getagentconnector) - Retrieve a connector
* [DeleteAgentConnector](#deleteagentconnector) - Delete a connector
* [ActivateAgentConnector](#activateagentconnector) - Activate a connector

## ListAgentConnectors

Lists messaging-channel connectors configured for the agent. Connector credentials are never returned.

### Example Usage

<!-- UsageSnippet language="go" operationID="listAgentConnectors" method="get" path="/api/v1/agents/{id}/connectors" -->
```go
package main

import(
	"context"
	mka1 "github.com/MeetKai/mka1-sdks/go"
	"github.com/MeetKai/mka1-sdks/go/models/operations"
	"log"
)

func main() {
    ctx := context.Background()

    s := mka1.New(
        mka1.WithSecurity("<YOUR_BEARER_TOKEN_HERE>"),
    )

    res, err := s.AgentConnectors.ListAgentConnectors(ctx, "<id>", mka1.Pointer[int64](20), operations.ListAgentConnectorsOrderDesc.ToPointer(), nil)
    if err != nil {
        log.Fatal(err)
    }
    if res.AgentConnectorList != nil {
        // handle response
    }
}
```

### Parameters

| Parameter                                                                                   | Type                                                                                        | Required                                                                                    | Description                                                                                 |
| ------------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------------- |
| `ctx`                                                                                       | [context.Context](https://pkg.go.dev/context#Context)                                       | :heavy_check_mark:                                                                          | The context to use for the request.                                                         |
| `id`                                                                                        | `string`                                                                                    | :heavy_check_mark:                                                                          | The agent ID.                                                                               |
| `limit`                                                                                     | `*int64`                                                                                    | :heavy_minus_sign:                                                                          | N/A                                                                                         |
| `order`                                                                                     | [*operations.ListAgentConnectorsOrder](../../models/operations/listagentconnectorsorder.md) | :heavy_minus_sign:                                                                          | N/A                                                                                         |
| `xOnBehalfOf`                                                                               | `*string`                                                                                   | :heavy_minus_sign:                                                                          | Optional external end-user identifier forwarded by the API gateway.                         |
| `opts`                                                                                      | [][operations.Option](../../models/operations/option.md)                                    | :heavy_minus_sign:                                                                          | The options for this request.                                                               |

### Response

**[*operations.ListAgentConnectorsResponse](../../models/operations/listagentconnectorsresponse.md), error**

### Errors

| Error Type              | Status Code             | Content Type            |
| ----------------------- | ----------------------- | ----------------------- |
| apierrors.ErrorEnvelope | 401, 403, 404           | application/json        |
| apierrors.APIError      | 4XX, 5XX                | \*/\*                   |

## CreateAgentConnector

Connects the agent to a Telegram bot or WhatsApp Business phone number, validates the provider credentials, and registers the agent's webhook. WhatsApp connector support is beta. Text, photos, and gateway-supported documents can invoke the agent; inbound media additionally requires write:files. Managed outbound files require read:files, and generated images require both file scopes so their transient provider URLs can be materialized before delivery. The optional write:feedback scope enables native thumbs reaction synchronization to gateway response feedback. These conditional scopes are deliberately not part of x-required-scopes because text-only connectors do not need them. An API key with every listed scope is required; its identity tuple and current scopes are stored as a non-widening ceiling, then revalidated with mk-authentication before every connector run; session and delegated end-user contexts are rejected. The required access policy controls which provider users or chats may invoke the agent.

### Example Usage

<!-- UsageSnippet language="go" operationID="createAgentConnector" method="post" path="/api/v1/agents/{id}/connectors" -->
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

    res, err := s.AgentConnectors.CreateAgentConnector(ctx, "<id>", components.CreateCreateAgentConnectorRequestTelegram(
        components.CreateTelegramAgentConnectorRequest{
            Provider: components.CreateTelegramAgentConnectorRequestProviderTelegram,
            Name: mka1.Pointer("support-bot"),
            Credentials: components.CreateTelegramAgentConnectorRequestCredentials{
                BotToken: "123456789:replace-with-telegram-bot-token",
            },
            Access: components.CreateTelegramAgentConnectorRequestAccess{
                Mode: components.CreateTelegramAgentConnectorRequestModeAllowlist,
                ChatIds: []int64{
                    123456789,
                },
            },
        },
    ), nil)
    if err != nil {
        log.Fatal(err)
    }
    if res.AgentConnector != nil {
        // handle response
    }
}
```

### Parameters

| Parameter                                                                                        | Type                                                                                             | Required                                                                                         | Description                                                                                      |
| ------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------ |
| `ctx`                                                                                            | [context.Context](https://pkg.go.dev/context#Context)                                            | :heavy_check_mark:                                                                               | The context to use for the request.                                                              |
| `id`                                                                                             | `string`                                                                                         | :heavy_check_mark:                                                                               | The agent ID.                                                                                    |
| `body`                                                                                           | [components.CreateAgentConnectorRequest](../../models/components/createagentconnectorrequest.md) | :heavy_check_mark:                                                                               | N/A                                                                                              |
| `xOnBehalfOf`                                                                                    | `*string`                                                                                        | :heavy_minus_sign:                                                                               | Optional external end-user identifier forwarded by the API gateway.                              |
| `opts`                                                                                           | [][operations.Option](../../models/operations/option.md)                                         | :heavy_minus_sign:                                                                               | The options for this request.                                                                    |

### Response

**[*operations.CreateAgentConnectorResponse](../../models/operations/createagentconnectorresponse.md), error**

### Errors

| Error Type              | Status Code             | Content Type            |
| ----------------------- | ----------------------- | ----------------------- |
| apierrors.ErrorEnvelope | 400, 401, 403, 404, 409 | application/json        |
| apierrors.ErrorEnvelope | 502, 503                | application/json        |
| apierrors.APIError      | 4XX, 5XX                | \*/\*                   |

## SetupWhatsAppAppWebhook

Beta. Returns the app-level callback URL and verification token that must be saved in Meta before the first WhatsApp phone connector is created. The caller must be allowed to manage the agent. The stable verification token is returned only in this no-store response and is not a Meta access token.

### Example Usage

<!-- UsageSnippet language="go" operationID="setupWhatsAppAppWebhook" method="post" path="/api/v1/agents/{id}/connectors/whatsapp/setup" -->
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

    res, err := s.AgentConnectors.SetupWhatsAppAppWebhook(ctx, "<id>", components.WhatsAppWebhookSetupRequest{
        AppID: "<id>",
    }, nil)
    if err != nil {
        log.Fatal(err)
    }
    if res.WhatsAppWebhookSetup != nil {
        // handle response
    }
}
```

### Parameters

| Parameter                                                                                        | Type                                                                                             | Required                                                                                         | Description                                                                                      |
| ------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------ |
| `ctx`                                                                                            | [context.Context](https://pkg.go.dev/context#Context)                                            | :heavy_check_mark:                                                                               | The context to use for the request.                                                              |
| `id`                                                                                             | `string`                                                                                         | :heavy_check_mark:                                                                               | The agent ID.                                                                                    |
| `body`                                                                                           | [components.WhatsAppWebhookSetupRequest](../../models/components/whatsappwebhooksetuprequest.md) | :heavy_check_mark:                                                                               | N/A                                                                                              |
| `xOnBehalfOf`                                                                                    | `*string`                                                                                        | :heavy_minus_sign:                                                                               | Optional external end-user identifier forwarded by the API gateway.                              |
| `opts`                                                                                           | [][operations.Option](../../models/operations/option.md)                                         | :heavy_minus_sign:                                                                               | The options for this request.                                                                    |

### Response

**[*operations.SetupWhatsAppAppWebhookResponse](../../models/operations/setupwhatsappappwebhookresponse.md), error**

### Errors

| Error Type              | Status Code             | Content Type            |
| ----------------------- | ----------------------- | ----------------------- |
| apierrors.ErrorEnvelope | 400, 401, 403, 404      | application/json        |
| apierrors.ErrorEnvelope | 503                     | application/json        |
| apierrors.APIError      | 4XX, 5XX                | \*/\*                   |

## GetAgentConnector

Retrieves connector configuration and status without exposing credentials.

### Example Usage

<!-- UsageSnippet language="go" operationID="getAgentConnector" method="get" path="/api/v1/agents/{id}/connectors/{connectorId}" -->
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

    res, err := s.AgentConnectors.GetAgentConnector(ctx, "<id>", "<id>", nil)
    if err != nil {
        log.Fatal(err)
    }
    if res.AgentConnector != nil {
        // handle response
    }
}
```

### Parameters

| Parameter                                                           | Type                                                                | Required                                                            | Description                                                         |
| ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- |
| `ctx`                                                               | [context.Context](https://pkg.go.dev/context#Context)               | :heavy_check_mark:                                                  | The context to use for the request.                                 |
| `id`                                                                | `string`                                                            | :heavy_check_mark:                                                  | The agent ID.                                                       |
| `connectorID`                                                       | `string`                                                            | :heavy_check_mark:                                                  | The connector ID.                                                   |
| `xOnBehalfOf`                                                       | `*string`                                                           | :heavy_minus_sign:                                                  | Optional external end-user identifier forwarded by the API gateway. |
| `opts`                                                              | [][operations.Option](../../models/operations/option.md)            | :heavy_minus_sign:                                                  | The options for this request.                                       |

### Response

**[*operations.GetAgentConnectorResponse](../../models/operations/getagentconnectorresponse.md), error**

### Errors

| Error Type              | Status Code             | Content Type            |
| ----------------------- | ----------------------- | ----------------------- |
| apierrors.ErrorEnvelope | 401, 403, 404           | application/json        |
| apierrors.APIError      | 4XX, 5XX                | \*/\*                   |

## DeleteAgentConnector

Unregisters the connector-specific provider webhook and deletes the stored connector credentials. Telegram pending updates are dropped; WhatsApp deletion clears only the phone-number callback and does not unsubscribe other numbers in the business account.

### Example Usage

<!-- UsageSnippet language="go" operationID="deleteAgentConnector" method="delete" path="/api/v1/agents/{id}/connectors/{connectorId}" -->
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

    res, err := s.AgentConnectors.DeleteAgentConnector(ctx, "<id>", "<id>", nil)
    if err != nil {
        log.Fatal(err)
    }
    if res.AgentConnectorDeleted != nil {
        // handle response
    }
}
```

### Parameters

| Parameter                                                           | Type                                                                | Required                                                            | Description                                                         |
| ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- |
| `ctx`                                                               | [context.Context](https://pkg.go.dev/context#Context)               | :heavy_check_mark:                                                  | The context to use for the request.                                 |
| `id`                                                                | `string`                                                            | :heavy_check_mark:                                                  | The agent ID.                                                       |
| `connectorID`                                                       | `string`                                                            | :heavy_check_mark:                                                  | The connector ID.                                                   |
| `xOnBehalfOf`                                                       | `*string`                                                           | :heavy_minus_sign:                                                  | Optional external end-user identifier forwarded by the API gateway. |
| `opts`                                                              | [][operations.Option](../../models/operations/option.md)            | :heavy_minus_sign:                                                  | The options for this request.                                       |

### Response

**[*operations.DeleteAgentConnectorResponse](../../models/operations/deleteagentconnectorresponse.md), error**

### Errors

| Error Type              | Status Code             | Content Type            |
| ----------------------- | ----------------------- | ----------------------- |
| apierrors.ErrorEnvelope | 401, 403, 404           | application/json        |
| apierrors.ErrorEnvelope | 502                     | application/json        |
| apierrors.APIError      | 4XX, 5XX                | \*/\*                   |

## ActivateAgentConnector

Revalidates the stored provider credentials and registers the provider webhook. Use this to retry a connector left in an error state. API-key authentication with every listed scope is required; session authentication is rejected, and the key must belong to the connector's original user or service-account principal so existing conversations keep the same owner.

### Example Usage

<!-- UsageSnippet language="go" operationID="activateAgentConnector" method="post" path="/api/v1/agents/{id}/connectors/{connectorId}/activate" -->
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

    res, err := s.AgentConnectors.ActivateAgentConnector(ctx, "<id>", "<id>", nil)
    if err != nil {
        log.Fatal(err)
    }
    if res.AgentConnector != nil {
        // handle response
    }
}
```

### Parameters

| Parameter                                                           | Type                                                                | Required                                                            | Description                                                         |
| ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- |
| `ctx`                                                               | [context.Context](https://pkg.go.dev/context#Context)               | :heavy_check_mark:                                                  | The context to use for the request.                                 |
| `id`                                                                | `string`                                                            | :heavy_check_mark:                                                  | The agent ID.                                                       |
| `connectorID`                                                       | `string`                                                            | :heavy_check_mark:                                                  | The connector ID.                                                   |
| `xOnBehalfOf`                                                       | `*string`                                                           | :heavy_minus_sign:                                                  | Optional external end-user identifier forwarded by the API gateway. |
| `opts`                                                              | [][operations.Option](../../models/operations/option.md)            | :heavy_minus_sign:                                                  | The options for this request.                                       |

### Response

**[*operations.ActivateAgentConnectorResponse](../../models/operations/activateagentconnectorresponse.md), error**

### Errors

| Error Type              | Status Code             | Content Type            |
| ----------------------- | ----------------------- | ----------------------- |
| apierrors.ErrorEnvelope | 401, 403, 404, 409      | application/json        |
| apierrors.ErrorEnvelope | 502, 503                | application/json        |
| apierrors.APIError      | 4XX, 5XX                | \*/\*                   |