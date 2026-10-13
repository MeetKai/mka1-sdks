# AgentConnectors

## Overview

Connect saved agents to external messaging channels such as Telegram, including text, photo, and supported document exchange.

### Available Operations

* [list_agent_connectors](#list_agent_connectors) - List connectors for an agent
* [create_agent_connector](#create_agent_connector) - Create a connector
* [setup_whats_app_app_webhook](#setup_whats_app_app_webhook) - Set up a WhatsApp app webhook (Beta)
* [get_agent_connector](#get_agent_connector) - Retrieve a connector
* [delete_agent_connector](#delete_agent_connector) - Delete a connector
* [activate_agent_connector](#activate_agent_connector) - Activate a connector

## list_agent_connectors

Lists messaging-channel connectors configured for the agent. Connector credentials are never returned.

### Example Usage

<!-- UsageSnippet language="python" operationID="listAgentConnectors" method="get" path="/api/v1/agents/{id}/connectors" -->
```python
from meetkai_mka1 import SDK


with SDK(
    bearer_auth="<YOUR_BEARER_TOKEN_HERE>",
) as sdk:

    res = sdk.agent_connectors.list_agent_connectors(id="<id>", limit=20, order="desc")

    # Handle response
    print(res)

```

### Parameters

| Parameter                                                                             | Type                                                                                  | Required                                                                              | Description                                                                           |
| ------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------- |
| `id`                                                                                  | *str*                                                                                 | :heavy_check_mark:                                                                    | The agent ID.                                                                         |
| `limit`                                                                               | *Optional[int]*                                                                       | :heavy_minus_sign:                                                                    | N/A                                                                                   |
| `order`                                                                               | [Optional[models.ListAgentConnectorsOrder]](../../models/listagentconnectorsorder.md) | :heavy_minus_sign:                                                                    | N/A                                                                                   |
| `x_on_behalf_of`                                                                      | *Optional[str]*                                                                       | :heavy_minus_sign:                                                                    | Optional external end-user identifier forwarded by the API gateway.                   |
| `retries`                                                                             | [Optional[utils.RetryConfig]](../../models/utils/retryconfig.md)                      | :heavy_minus_sign:                                                                    | Configuration to override the default retry behavior of the client.                   |

### Response

**[models.AgentConnectorList](../../models/agentconnectorlist.md)**

### Errors

| Error Type             | Status Code            | Content Type           |
| ---------------------- | ---------------------- | ---------------------- |
| errors.ErrorEnvelope   | 401, 403, 404          | application/json       |
| errors.SDKDefaultError | 4XX, 5XX               | \*/\*                  |

## create_agent_connector

Connects the agent to a Telegram bot or WhatsApp Business phone number, validates the provider credentials, and registers the agent's webhook. WhatsApp connector support is beta. Text, photos, and gateway-supported documents can invoke the agent; inbound media additionally requires write:files. Managed outbound files require read:files, and generated images require both file scopes so their transient provider URLs can be materialized before delivery. The optional write:feedback scope enables native thumbs reaction synchronization to gateway response feedback. These conditional scopes are deliberately not part of x-required-scopes because text-only connectors do not need them. An API key with every listed scope is required; its identity tuple and current scopes are stored as a non-widening ceiling, then revalidated with mk-authentication before every connector run; session and delegated end-user contexts are rejected. The required access policy controls which provider users or chats may invoke the agent.

### Example Usage

<!-- UsageSnippet language="python" operationID="createAgentConnector" method="post" path="/api/v1/agents/{id}/connectors" -->
```python
from meetkai_mka1 import SDK


with SDK(
    bearer_auth="<YOUR_BEARER_TOKEN_HERE>",
) as sdk:

    res = sdk.agent_connectors.create_agent_connector(id="<id>", body={
        "provider": "telegram",
        "name": "support-bot",
        "credentials": {
            "bot_token": "123456789:replace-with-telegram-bot-token",
        },
        "access": {
            "mode": "allowlist",
            "chat_ids": [
                123456789,
            ],
        },
        "drop_pending_updates": True,
    })

    # Handle response
    print(res)

```

### Parameters

| Parameter                                                                         | Type                                                                              | Required                                                                          | Description                                                                       |
| --------------------------------------------------------------------------------- | --------------------------------------------------------------------------------- | --------------------------------------------------------------------------------- | --------------------------------------------------------------------------------- |
| `id`                                                                              | *str*                                                                             | :heavy_check_mark:                                                                | The agent ID.                                                                     |
| `body`                                                                            | [models.CreateAgentConnectorRequest](../../models/createagentconnectorrequest.md) | :heavy_check_mark:                                                                | N/A                                                                               |
| `x_on_behalf_of`                                                                  | *Optional[str]*                                                                   | :heavy_minus_sign:                                                                | Optional external end-user identifier forwarded by the API gateway.               |
| `retries`                                                                         | [Optional[utils.RetryConfig]](../../models/utils/retryconfig.md)                  | :heavy_minus_sign:                                                                | Configuration to override the default retry behavior of the client.               |

### Response

**[models.AgentConnector](../../models/agentconnector.md)**

### Errors

| Error Type              | Status Code             | Content Type            |
| ----------------------- | ----------------------- | ----------------------- |
| errors.ErrorEnvelope    | 400, 401, 403, 404, 409 | application/json        |
| errors.ErrorEnvelope    | 502, 503                | application/json        |
| errors.SDKDefaultError  | 4XX, 5XX                | \*/\*                   |

## setup_whats_app_app_webhook

Beta. Returns the app-level callback URL and verification token that must be saved in Meta before the first WhatsApp phone connector is created. The caller must be allowed to manage the agent. The stable verification token is returned only in this no-store response and is not a Meta access token.

### Example Usage

<!-- UsageSnippet language="python" operationID="setupWhatsAppAppWebhook" method="post" path="/api/v1/agents/{id}/connectors/whatsapp/setup" -->
```python
from meetkai_mka1 import SDK


with SDK(
    bearer_auth="<YOUR_BEARER_TOKEN_HERE>",
) as sdk:

    res = sdk.agent_connectors.setup_whats_app_app_webhook(id="<id>", app_id="<id>")

    # Handle response
    print(res)

```

### Parameters

| Parameter                                                           | Type                                                                | Required                                                            | Description                                                         |
| ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- |
| `id`                                                                | *str*                                                               | :heavy_check_mark:                                                  | The agent ID.                                                       |
| `app_id`                                                            | *str*                                                               | :heavy_check_mark:                                                  | N/A                                                                 |
| `x_on_behalf_of`                                                    | *Optional[str]*                                                     | :heavy_minus_sign:                                                  | Optional external end-user identifier forwarded by the API gateway. |
| `retries`                                                           | [Optional[utils.RetryConfig]](../../models/utils/retryconfig.md)    | :heavy_minus_sign:                                                  | Configuration to override the default retry behavior of the client. |

### Response

**[models.SetupWhatsAppAppWebhookResponse](../../models/setupwhatsappappwebhookresponse.md)**

### Errors

| Error Type             | Status Code            | Content Type           |
| ---------------------- | ---------------------- | ---------------------- |
| errors.ErrorEnvelope   | 400, 401, 403, 404     | application/json       |
| errors.ErrorEnvelope   | 503                    | application/json       |
| errors.SDKDefaultError | 4XX, 5XX               | \*/\*                  |

## get_agent_connector

Retrieves connector configuration and status without exposing credentials.

### Example Usage

<!-- UsageSnippet language="python" operationID="getAgentConnector" method="get" path="/api/v1/agents/{id}/connectors/{connectorId}" -->
```python
from meetkai_mka1 import SDK


with SDK(
    bearer_auth="<YOUR_BEARER_TOKEN_HERE>",
) as sdk:

    res = sdk.agent_connectors.get_agent_connector(id="<id>", connector_id="<id>")

    # Handle response
    print(res)

```

### Parameters

| Parameter                                                           | Type                                                                | Required                                                            | Description                                                         |
| ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- |
| `id`                                                                | *str*                                                               | :heavy_check_mark:                                                  | The agent ID.                                                       |
| `connector_id`                                                      | *str*                                                               | :heavy_check_mark:                                                  | The connector ID.                                                   |
| `x_on_behalf_of`                                                    | *Optional[str]*                                                     | :heavy_minus_sign:                                                  | Optional external end-user identifier forwarded by the API gateway. |
| `retries`                                                           | [Optional[utils.RetryConfig]](../../models/utils/retryconfig.md)    | :heavy_minus_sign:                                                  | Configuration to override the default retry behavior of the client. |

### Response

**[models.AgentConnector](../../models/agentconnector.md)**

### Errors

| Error Type             | Status Code            | Content Type           |
| ---------------------- | ---------------------- | ---------------------- |
| errors.ErrorEnvelope   | 401, 403, 404          | application/json       |
| errors.SDKDefaultError | 4XX, 5XX               | \*/\*                  |

## delete_agent_connector

Unregisters the connector-specific provider webhook and deletes the stored connector credentials. Telegram pending updates are dropped; WhatsApp deletion clears only the phone-number callback and does not unsubscribe other numbers in the business account.

### Example Usage

<!-- UsageSnippet language="python" operationID="deleteAgentConnector" method="delete" path="/api/v1/agents/{id}/connectors/{connectorId}" -->
```python
from meetkai_mka1 import SDK


with SDK(
    bearer_auth="<YOUR_BEARER_TOKEN_HERE>",
) as sdk:

    res = sdk.agent_connectors.delete_agent_connector(id="<id>", connector_id="<id>")

    # Handle response
    print(res)

```

### Parameters

| Parameter                                                           | Type                                                                | Required                                                            | Description                                                         |
| ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- |
| `id`                                                                | *str*                                                               | :heavy_check_mark:                                                  | The agent ID.                                                       |
| `connector_id`                                                      | *str*                                                               | :heavy_check_mark:                                                  | The connector ID.                                                   |
| `x_on_behalf_of`                                                    | *Optional[str]*                                                     | :heavy_minus_sign:                                                  | Optional external end-user identifier forwarded by the API gateway. |
| `retries`                                                           | [Optional[utils.RetryConfig]](../../models/utils/retryconfig.md)    | :heavy_minus_sign:                                                  | Configuration to override the default retry behavior of the client. |

### Response

**[models.AgentConnectorDeleted](../../models/agentconnectordeleted.md)**

### Errors

| Error Type             | Status Code            | Content Type           |
| ---------------------- | ---------------------- | ---------------------- |
| errors.ErrorEnvelope   | 401, 403, 404          | application/json       |
| errors.ErrorEnvelope   | 502                    | application/json       |
| errors.SDKDefaultError | 4XX, 5XX               | \*/\*                  |

## activate_agent_connector

Revalidates the stored provider credentials and registers the provider webhook. Use this to retry a connector left in an error state. API-key authentication with every listed scope is required; session authentication is rejected, and the key must belong to the connector's original user or service-account principal so existing conversations keep the same owner.

### Example Usage

<!-- UsageSnippet language="python" operationID="activateAgentConnector" method="post" path="/api/v1/agents/{id}/connectors/{connectorId}/activate" -->
```python
from meetkai_mka1 import SDK


with SDK(
    bearer_auth="<YOUR_BEARER_TOKEN_HERE>",
) as sdk:

    res = sdk.agent_connectors.activate_agent_connector(id="<id>", connector_id="<id>")

    # Handle response
    print(res)

```

### Parameters

| Parameter                                                           | Type                                                                | Required                                                            | Description                                                         |
| ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- |
| `id`                                                                | *str*                                                               | :heavy_check_mark:                                                  | The agent ID.                                                       |
| `connector_id`                                                      | *str*                                                               | :heavy_check_mark:                                                  | The connector ID.                                                   |
| `x_on_behalf_of`                                                    | *Optional[str]*                                                     | :heavy_minus_sign:                                                  | Optional external end-user identifier forwarded by the API gateway. |
| `retries`                                                           | [Optional[utils.RetryConfig]](../../models/utils/retryconfig.md)    | :heavy_minus_sign:                                                  | Configuration to override the default retry behavior of the client. |

### Response

**[models.AgentConnector](../../models/agentconnector.md)**

### Errors

| Error Type             | Status Code            | Content Type           |
| ---------------------- | ---------------------- | ---------------------- |
| errors.ErrorEnvelope   | 401, 403, 404, 409     | application/json       |
| errors.ErrorEnvelope   | 502, 503               | application/json       |
| errors.SDKDefaultError | 4XX, 5XX               | \*/\*                  |