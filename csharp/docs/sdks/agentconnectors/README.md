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

<!-- UsageSnippet language="csharp" operationID="listAgentConnectors" method="get" path="/api/v1/agents/{id}/connectors" -->
```csharp
using MeetKai.MKA1;
using MeetKai.MKA1.Types.Components;
using MeetKai.MKA1.Types.Requests;

var sdk = new SDK(bearerAuth: "<YOUR_BEARER_TOKEN_HERE>");

var res = await sdk.AgentConnectors.ListAgentConnectorsAsync(
    id: "<id>",
    limit: 20,
    order: ListAgentConnectorsOrder.Desc
);

// handle response
```

### Parameters

| Parameter                                                                    | Type                                                                         | Required                                                                     | Description                                                                  |
| ---------------------------------------------------------------------------- | ---------------------------------------------------------------------------- | ---------------------------------------------------------------------------- | ---------------------------------------------------------------------------- |
| `Id`                                                                         | *string*                                                                     | :heavy_check_mark:                                                           | The agent ID.                                                                |
| `Limit`                                                                      | *long*                                                                       | :heavy_minus_sign:                                                           | N/A                                                                          |
| `Order`                                                                      | [ListAgentConnectorsOrder](../../Types/Requests/ListAgentConnectorsOrder.md) | :heavy_minus_sign:                                                           | N/A                                                                          |
| `XOnBehalfOf`                                                                | *string*                                                                     | :heavy_minus_sign:                                                           | Optional external end-user identifier forwarded by the API gateway.          |

### Response

**[ListAgentConnectorsResponse](../../Types/Requests/ListAgentConnectorsResponse.md)**

### Errors

| Error Type                              | Status Code                             | Content Type                            |
| --------------------------------------- | --------------------------------------- | --------------------------------------- |
| MeetKai.MKA1.Types.Errors.ErrorEnvelope | 401, 403, 404                           | application/json                        |
| MeetKai.MKA1.Types.Errors.APIException  | 4XX, 5XX                                | \*/\*                                   |

## CreateAgentConnector

Connects the agent to a Telegram bot or WhatsApp Business phone number, validates the provider credentials, and registers the agent's webhook. WhatsApp connector support is beta. Text, photos, and gateway-supported documents can invoke the agent; inbound media additionally requires write:files. Managed outbound files require read:files, and generated images require both file scopes so their transient provider URLs can be materialized before delivery. The optional write:feedback scope enables native thumbs reaction synchronization to gateway response feedback. These conditional scopes are deliberately not part of x-required-scopes because text-only connectors do not need them. An API key with every listed scope is required; its identity tuple and current scopes are stored as a non-widening ceiling, then revalidated with mk-authentication before every connector run; session and delegated end-user contexts are rejected. The required access policy controls which provider users or chats may invoke the agent.

### Example Usage

<!-- UsageSnippet language="csharp" operationID="createAgentConnector" method="post" path="/api/v1/agents/{id}/connectors" -->
```csharp
using MeetKai.MKA1;
using MeetKai.MKA1.Types.Components;
using System.Collections.Generic;

var sdk = new SDK(bearerAuth: "<YOUR_BEARER_TOKEN_HERE>");

var res = await sdk.AgentConnectors.CreateAgentConnectorAsync(
    id: "<id>",
    body: MeetKai.MKA1.Types.Components.CreateAgentConnectorRequest.CreateTelegram(
        new CreateTelegramAgentConnectorRequest() {
            Provider = CreateTelegramAgentConnectorRequestProvider.Telegram,
            Name = "support-bot",
            Credentials = new CreateTelegramAgentConnectorRequestCredentials() {
                BotToken = "123456789:replace-with-telegram-bot-token",
            },
            Access = new CreateTelegramAgentConnectorRequestAccess() {
                Mode = CreateTelegramAgentConnectorRequestMode.Allowlist,
                ChatIds = new List<long>() {
                    123456789,
                },
            },
        }
    )
);

// handle response
```

### Parameters

| Parameter                                                                                             | Type                                                                                                  | Required                                                                                              | Description                                                                                           |
| ----------------------------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------------------------- |
| `Id`                                                                                                  | *string*                                                                                              | :heavy_check_mark:                                                                                    | The agent ID.                                                                                         |
| `Body`                                                                                                | [Types.Components.CreateAgentConnectorRequest](../../Types/Components/CreateAgentConnectorRequest.md) | :heavy_check_mark:                                                                                    | N/A                                                                                                   |
| `XOnBehalfOf`                                                                                         | *string*                                                                                              | :heavy_minus_sign:                                                                                    | Optional external end-user identifier forwarded by the API gateway.                                   |

### Response

**[CreateAgentConnectorResponse](../../Types/Requests/CreateAgentConnectorResponse.md)**

### Errors

| Error Type                              | Status Code                             | Content Type                            |
| --------------------------------------- | --------------------------------------- | --------------------------------------- |
| MeetKai.MKA1.Types.Errors.ErrorEnvelope | 400, 401, 403, 404, 409                 | application/json                        |
| MeetKai.MKA1.Types.Errors.ErrorEnvelope | 502, 503                                | application/json                        |
| MeetKai.MKA1.Types.Errors.APIException  | 4XX, 5XX                                | \*/\*                                   |

## SetupWhatsAppAppWebhook

Beta. Returns the app-level callback URL and verification token that must be saved in Meta before the first WhatsApp phone connector is created. The caller must be allowed to manage the agent. The stable verification token is returned only in this no-store response and is not a Meta access token.

### Example Usage

<!-- UsageSnippet language="csharp" operationID="setupWhatsAppAppWebhook" method="post" path="/api/v1/agents/{id}/connectors/whatsapp/setup" -->
```csharp
using MeetKai.MKA1;
using MeetKai.MKA1.Types.Components;

var sdk = new SDK(bearerAuth: "<YOUR_BEARER_TOKEN_HERE>");

var res = await sdk.AgentConnectors.SetupWhatsAppAppWebhookAsync(
    id: "<id>",
    body: new WhatsAppWebhookSetupRequest() {
        AppId = "<id>",
    }
);

// handle response
```

### Parameters

| Parameter                                                                            | Type                                                                                 | Required                                                                             | Description                                                                          |
| ------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------ |
| `Id`                                                                                 | *string*                                                                             | :heavy_check_mark:                                                                   | The agent ID.                                                                        |
| `Body`                                                                               | [WhatsAppWebhookSetupRequest](../../Types/Components/WhatsAppWebhookSetupRequest.md) | :heavy_check_mark:                                                                   | N/A                                                                                  |
| `XOnBehalfOf`                                                                        | *string*                                                                             | :heavy_minus_sign:                                                                   | Optional external end-user identifier forwarded by the API gateway.                  |

### Response

**[SetupWhatsAppAppWebhookResponse](../../Types/Requests/SetupWhatsAppAppWebhookResponse.md)**

### Errors

| Error Type                              | Status Code                             | Content Type                            |
| --------------------------------------- | --------------------------------------- | --------------------------------------- |
| MeetKai.MKA1.Types.Errors.ErrorEnvelope | 400, 401, 403, 404                      | application/json                        |
| MeetKai.MKA1.Types.Errors.ErrorEnvelope | 503                                     | application/json                        |
| MeetKai.MKA1.Types.Errors.APIException  | 4XX, 5XX                                | \*/\*                                   |

## GetAgentConnector

Retrieves connector configuration and status without exposing credentials.

### Example Usage

<!-- UsageSnippet language="csharp" operationID="getAgentConnector" method="get" path="/api/v1/agents/{id}/connectors/{connectorId}" -->
```csharp
using MeetKai.MKA1;
using MeetKai.MKA1.Types.Components;

var sdk = new SDK(bearerAuth: "<YOUR_BEARER_TOKEN_HERE>");

var res = await sdk.AgentConnectors.GetAgentConnectorAsync(
    id: "<id>",
    connectorId: "<id>"
);

// handle response
```

### Parameters

| Parameter                                                           | Type                                                                | Required                                                            | Description                                                         |
| ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- |
| `Id`                                                                | *string*                                                            | :heavy_check_mark:                                                  | The agent ID.                                                       |
| `ConnectorId`                                                       | *string*                                                            | :heavy_check_mark:                                                  | The connector ID.                                                   |
| `XOnBehalfOf`                                                       | *string*                                                            | :heavy_minus_sign:                                                  | Optional external end-user identifier forwarded by the API gateway. |

### Response

**[GetAgentConnectorResponse](../../Types/Requests/GetAgentConnectorResponse.md)**

### Errors

| Error Type                              | Status Code                             | Content Type                            |
| --------------------------------------- | --------------------------------------- | --------------------------------------- |
| MeetKai.MKA1.Types.Errors.ErrorEnvelope | 401, 403, 404                           | application/json                        |
| MeetKai.MKA1.Types.Errors.APIException  | 4XX, 5XX                                | \*/\*                                   |

## DeleteAgentConnector

Unregisters the connector-specific provider webhook and deletes the stored connector credentials. Telegram pending updates are dropped; WhatsApp deletion clears only the phone-number callback and does not unsubscribe other numbers in the business account.

### Example Usage

<!-- UsageSnippet language="csharp" operationID="deleteAgentConnector" method="delete" path="/api/v1/agents/{id}/connectors/{connectorId}" -->
```csharp
using MeetKai.MKA1;
using MeetKai.MKA1.Types.Components;

var sdk = new SDK(bearerAuth: "<YOUR_BEARER_TOKEN_HERE>");

var res = await sdk.AgentConnectors.DeleteAgentConnectorAsync(
    id: "<id>",
    connectorId: "<id>"
);

// handle response
```

### Parameters

| Parameter                                                           | Type                                                                | Required                                                            | Description                                                         |
| ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- |
| `Id`                                                                | *string*                                                            | :heavy_check_mark:                                                  | The agent ID.                                                       |
| `ConnectorId`                                                       | *string*                                                            | :heavy_check_mark:                                                  | The connector ID.                                                   |
| `XOnBehalfOf`                                                       | *string*                                                            | :heavy_minus_sign:                                                  | Optional external end-user identifier forwarded by the API gateway. |

### Response

**[DeleteAgentConnectorResponse](../../Types/Requests/DeleteAgentConnectorResponse.md)**

### Errors

| Error Type                              | Status Code                             | Content Type                            |
| --------------------------------------- | --------------------------------------- | --------------------------------------- |
| MeetKai.MKA1.Types.Errors.ErrorEnvelope | 401, 403, 404                           | application/json                        |
| MeetKai.MKA1.Types.Errors.ErrorEnvelope | 502                                     | application/json                        |
| MeetKai.MKA1.Types.Errors.APIException  | 4XX, 5XX                                | \*/\*                                   |

## ActivateAgentConnector

Revalidates the stored provider credentials and registers the provider webhook. Use this to retry a connector left in an error state. API-key authentication with every listed scope is required; session authentication is rejected, and the key must belong to the connector's original user or service-account principal so existing conversations keep the same owner.

### Example Usage

<!-- UsageSnippet language="csharp" operationID="activateAgentConnector" method="post" path="/api/v1/agents/{id}/connectors/{connectorId}/activate" -->
```csharp
using MeetKai.MKA1;
using MeetKai.MKA1.Types.Components;

var sdk = new SDK(bearerAuth: "<YOUR_BEARER_TOKEN_HERE>");

var res = await sdk.AgentConnectors.ActivateAgentConnectorAsync(
    id: "<id>",
    connectorId: "<id>"
);

// handle response
```

### Parameters

| Parameter                                                           | Type                                                                | Required                                                            | Description                                                         |
| ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- |
| `Id`                                                                | *string*                                                            | :heavy_check_mark:                                                  | The agent ID.                                                       |
| `ConnectorId`                                                       | *string*                                                            | :heavy_check_mark:                                                  | The connector ID.                                                   |
| `XOnBehalfOf`                                                       | *string*                                                            | :heavy_minus_sign:                                                  | Optional external end-user identifier forwarded by the API gateway. |

### Response

**[ActivateAgentConnectorResponse](../../Types/Requests/ActivateAgentConnectorResponse.md)**

### Errors

| Error Type                              | Status Code                             | Content Type                            |
| --------------------------------------- | --------------------------------------- | --------------------------------------- |
| MeetKai.MKA1.Types.Errors.ErrorEnvelope | 401, 403, 404, 409                      | application/json                        |
| MeetKai.MKA1.Types.Errors.ErrorEnvelope | 502, 503                                | application/json                        |
| MeetKai.MKA1.Types.Errors.APIException  | 4XX, 5XX                                | \*/\*                                   |