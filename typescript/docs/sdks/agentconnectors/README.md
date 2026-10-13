# AgentConnectors

## Overview

Connect saved agents to external messaging channels such as Telegram, including text, photo, and supported document exchange.

### Available Operations

* [listAgentConnectors](#listagentconnectors) - List connectors for an agent
* [createAgentConnector](#createagentconnector) - Create a connector
* [setupWhatsAppAppWebhook](#setupwhatsappappwebhook) - Set up a WhatsApp app webhook (Beta)
* [getAgentConnector](#getagentconnector) - Retrieve a connector
* [deleteAgentConnector](#deleteagentconnector) - Delete a connector
* [activateAgentConnector](#activateagentconnector) - Activate a connector

## listAgentConnectors

Lists messaging-channel connectors configured for the agent. Connector credentials are never returned.

### Example Usage

<!-- UsageSnippet language="typescript" operationID="listAgentConnectors" method="get" path="/api/v1/agents/{id}/connectors" -->
```typescript
import { SDK } from "@meetkai/mka1";

const sdk = new SDK({
  bearerAuth: "<YOUR_BEARER_TOKEN_HERE>",
});

async function run() {
  const result = await sdk.agentConnectors.listAgentConnectors({
    id: "<id>",
  });

  console.log(result);
}

run();
```

### Standalone function

The standalone function version of this method:

```typescript
import { SDKCore } from "@meetkai/mka1/core.js";
import { agentConnectorsListAgentConnectors } from "@meetkai/mka1/funcs/agentConnectorsListAgentConnectors.js";

// Use `SDKCore` for best tree-shaking performance.
// You can create one instance of it to use across an application.
const sdk = new SDKCore({
  bearerAuth: "<YOUR_BEARER_TOKEN_HERE>",
});

async function run() {
  const res = await agentConnectorsListAgentConnectors(sdk, {
    id: "<id>",
  });
  if (res.ok) {
    const { value: result } = res;
    console.log(result);
  } else {
    console.log("agentConnectorsListAgentConnectors failed:", res.error);
  }
}

run();
```

### React hooks and utilities

This method can be used in React components through the following hooks and
associated utilities.

> Check out [this guide][hook-guide] for information about each of the utilities
> below and how to get started using React hooks.

[hook-guide]: ../../../REACT_QUERY.md

```tsx
import {
  // Query hooks for fetching data.
  useAgentConnectorsListAgentConnectors,
  useAgentConnectorsListAgentConnectorsSuspense,

  // Utility for prefetching data during server-side rendering and in React
  // Server Components that will be immediately available to client components
  // using the hooks.
  prefetchAgentConnectorsListAgentConnectors,
  
  // Utilities to invalidate the query cache for this query in response to
  // mutations and other user actions.
  invalidateAgentConnectorsListAgentConnectors,
  invalidateAllAgentConnectorsListAgentConnectors,
} from "@meetkai/mka1/react-query/agentConnectorsListAgentConnectors.js";
```

### Parameters

| Parameter                                                                                                                                                                      | Type                                                                                                                                                                           | Required                                                                                                                                                                       | Description                                                                                                                                                                    |
| ------------------------------------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------------------------------------ |
| `request`                                                                                                                                                                      | [operations.ListAgentConnectorsRequest](../../models/operations/listagentconnectorsrequest.md)                                                                                 | :heavy_check_mark:                                                                                                                                                             | The request object to use for the request.                                                                                                                                     |
| `options`                                                                                                                                                                      | RequestOptions                                                                                                                                                                 | :heavy_minus_sign:                                                                                                                                                             | Used to set various options for making HTTP requests.                                                                                                                          |
| `options.fetchOptions`                                                                                                                                                         | [RequestInit](https://developer.mozilla.org/en-US/docs/Web/API/Request/Request#options)                                                                                        | :heavy_minus_sign:                                                                                                                                                             | Options that are passed to the underlying HTTP request. This can be used to inject extra headers for examples. All `Request` options, except `method` and `body`, are allowed. |
| `options.retries`                                                                                                                                                              | [RetryConfig](../../lib/utils/retryconfig.md)                                                                                                                                  | :heavy_minus_sign:                                                                                                                                                             | Enables retrying HTTP requests under certain failure conditions.                                                                                                               |

### Response

**Promise\<[components.AgentConnectorList](../../models/components/agentconnectorlist.md)\>**

### Errors

| Error Type           | Status Code          | Content Type         |
| -------------------- | -------------------- | -------------------- |
| errors.ErrorEnvelope | 401, 403, 404        | application/json     |
| errors.APIError      | 4XX, 5XX             | \*/\*                |

## createAgentConnector

Connects the agent to a Telegram bot or WhatsApp Business phone number, validates the provider credentials, and registers the agent's webhook. WhatsApp connector support is beta. Text, photos, and gateway-supported documents can invoke the agent; inbound media additionally requires write:files. Managed outbound files require read:files, and generated images require both file scopes so their transient provider URLs can be materialized before delivery. The optional write:feedback scope enables native thumbs reaction synchronization to gateway response feedback. These conditional scopes are deliberately not part of x-required-scopes because text-only connectors do not need them. An API key with every listed scope is required; its identity tuple and current scopes are stored as a non-widening ceiling, then revalidated with mk-authentication before every connector run; session and delegated end-user contexts are rejected. The required access policy controls which provider users or chats may invoke the agent.

### Example Usage

<!-- UsageSnippet language="typescript" operationID="createAgentConnector" method="post" path="/api/v1/agents/{id}/connectors" -->
```typescript
import { SDK } from "@meetkai/mka1";

const sdk = new SDK({
  bearerAuth: "<YOUR_BEARER_TOKEN_HERE>",
});

async function run() {
  const result = await sdk.agentConnectors.createAgentConnector({
    id: "<id>",
    createAgentConnectorRequest: {
      provider: "telegram",
      name: "support-bot",
      credentials: {
        botToken: "123456789:replace-with-telegram-bot-token",
      },
      access: {
        mode: "allowlist",
        chatIds: [
          123456789,
        ],
      },
      dropPendingUpdates: true,
    },
  });

  console.log(result);
}

run();
```

### Standalone function

The standalone function version of this method:

```typescript
import { SDKCore } from "@meetkai/mka1/core.js";
import { agentConnectorsCreateAgentConnector } from "@meetkai/mka1/funcs/agentConnectorsCreateAgentConnector.js";

// Use `SDKCore` for best tree-shaking performance.
// You can create one instance of it to use across an application.
const sdk = new SDKCore({
  bearerAuth: "<YOUR_BEARER_TOKEN_HERE>",
});

async function run() {
  const res = await agentConnectorsCreateAgentConnector(sdk, {
    id: "<id>",
    createAgentConnectorRequest: {
      provider: "telegram",
      name: "support-bot",
      credentials: {
        botToken: "123456789:replace-with-telegram-bot-token",
      },
      access: {
        mode: "allowlist",
        chatIds: [
          123456789,
        ],
      },
      dropPendingUpdates: true,
    },
  });
  if (res.ok) {
    const { value: result } = res;
    console.log(result);
  } else {
    console.log("agentConnectorsCreateAgentConnector failed:", res.error);
  }
}

run();
```

### React hooks and utilities

This method can be used in React components through the following hooks and
associated utilities.

> Check out [this guide][hook-guide] for information about each of the utilities
> below and how to get started using React hooks.

[hook-guide]: ../../../REACT_QUERY.md

```tsx
import {
  // Mutation hook for triggering the API call.
  useAgentConnectorsCreateAgentConnectorMutation
} from "@meetkai/mka1/react-query/agentConnectorsCreateAgentConnector.js";
```

### Parameters

| Parameter                                                                                                                                                                      | Type                                                                                                                                                                           | Required                                                                                                                                                                       | Description                                                                                                                                                                    |
| ------------------------------------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------------------------------------ |
| `request`                                                                                                                                                                      | [operations.CreateAgentConnectorRequest](../../models/operations/createagentconnectorrequest.md)                                                                               | :heavy_check_mark:                                                                                                                                                             | The request object to use for the request.                                                                                                                                     |
| `options`                                                                                                                                                                      | RequestOptions                                                                                                                                                                 | :heavy_minus_sign:                                                                                                                                                             | Used to set various options for making HTTP requests.                                                                                                                          |
| `options.fetchOptions`                                                                                                                                                         | [RequestInit](https://developer.mozilla.org/en-US/docs/Web/API/Request/Request#options)                                                                                        | :heavy_minus_sign:                                                                                                                                                             | Options that are passed to the underlying HTTP request. This can be used to inject extra headers for examples. All `Request` options, except `method` and `body`, are allowed. |
| `options.retries`                                                                                                                                                              | [RetryConfig](../../lib/utils/retryconfig.md)                                                                                                                                  | :heavy_minus_sign:                                                                                                                                                             | Enables retrying HTTP requests under certain failure conditions.                                                                                                               |

### Response

**Promise\<[components.AgentConnector](../../models/components/agentconnector.md)\>**

### Errors

| Error Type              | Status Code             | Content Type            |
| ----------------------- | ----------------------- | ----------------------- |
| errors.ErrorEnvelope    | 400, 401, 403, 404, 409 | application/json        |
| errors.ErrorEnvelope    | 502, 503                | application/json        |
| errors.APIError         | 4XX, 5XX                | \*/\*                   |

## setupWhatsAppAppWebhook

Beta. Returns the app-level callback URL and verification token that must be saved in Meta before the first WhatsApp phone connector is created. The caller must be allowed to manage the agent. The stable verification token is returned only in this no-store response and is not a Meta access token.

### Example Usage

<!-- UsageSnippet language="typescript" operationID="setupWhatsAppAppWebhook" method="post" path="/api/v1/agents/{id}/connectors/whatsapp/setup" -->
```typescript
import { SDK } from "@meetkai/mka1";

const sdk = new SDK({
  bearerAuth: "<YOUR_BEARER_TOKEN_HERE>",
});

async function run() {
  const result = await sdk.agentConnectors.setupWhatsAppAppWebhook({
    id: "<id>",
    whatsAppWebhookSetupRequest: {
      appId: "<id>",
    },
  });

  console.log(result);
}

run();
```

### Standalone function

The standalone function version of this method:

```typescript
import { SDKCore } from "@meetkai/mka1/core.js";
import { agentConnectorsSetupWhatsAppAppWebhook } from "@meetkai/mka1/funcs/agentConnectorsSetupWhatsAppAppWebhook.js";

// Use `SDKCore` for best tree-shaking performance.
// You can create one instance of it to use across an application.
const sdk = new SDKCore({
  bearerAuth: "<YOUR_BEARER_TOKEN_HERE>",
});

async function run() {
  const res = await agentConnectorsSetupWhatsAppAppWebhook(sdk, {
    id: "<id>",
    whatsAppWebhookSetupRequest: {
      appId: "<id>",
    },
  });
  if (res.ok) {
    const { value: result } = res;
    console.log(result);
  } else {
    console.log("agentConnectorsSetupWhatsAppAppWebhook failed:", res.error);
  }
}

run();
```

### React hooks and utilities

This method can be used in React components through the following hooks and
associated utilities.

> Check out [this guide][hook-guide] for information about each of the utilities
> below and how to get started using React hooks.

[hook-guide]: ../../../REACT_QUERY.md

```tsx
import {
  // Mutation hook for triggering the API call.
  useAgentConnectorsSetupWhatsAppAppWebhookMutation
} from "@meetkai/mka1/react-query/agentConnectorsSetupWhatsAppAppWebhook.js";
```

### Parameters

| Parameter                                                                                                                                                                      | Type                                                                                                                                                                           | Required                                                                                                                                                                       | Description                                                                                                                                                                    |
| ------------------------------------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------------------------------------ |
| `request`                                                                                                                                                                      | [operations.SetupWhatsAppAppWebhookRequest](../../models/operations/setupwhatsappappwebhookrequest.md)                                                                         | :heavy_check_mark:                                                                                                                                                             | The request object to use for the request.                                                                                                                                     |
| `options`                                                                                                                                                                      | RequestOptions                                                                                                                                                                 | :heavy_minus_sign:                                                                                                                                                             | Used to set various options for making HTTP requests.                                                                                                                          |
| `options.fetchOptions`                                                                                                                                                         | [RequestInit](https://developer.mozilla.org/en-US/docs/Web/API/Request/Request#options)                                                                                        | :heavy_minus_sign:                                                                                                                                                             | Options that are passed to the underlying HTTP request. This can be used to inject extra headers for examples. All `Request` options, except `method` and `body`, are allowed. |
| `options.retries`                                                                                                                                                              | [RetryConfig](../../lib/utils/retryconfig.md)                                                                                                                                  | :heavy_minus_sign:                                                                                                                                                             | Enables retrying HTTP requests under certain failure conditions.                                                                                                               |

### Response

**Promise\<[operations.SetupWhatsAppAppWebhookResponse](../../models/operations/setupwhatsappappwebhookresponse.md)\>**

### Errors

| Error Type           | Status Code          | Content Type         |
| -------------------- | -------------------- | -------------------- |
| errors.ErrorEnvelope | 400, 401, 403, 404   | application/json     |
| errors.ErrorEnvelope | 503                  | application/json     |
| errors.APIError      | 4XX, 5XX             | \*/\*                |

## getAgentConnector

Retrieves connector configuration and status without exposing credentials.

### Example Usage

<!-- UsageSnippet language="typescript" operationID="getAgentConnector" method="get" path="/api/v1/agents/{id}/connectors/{connectorId}" -->
```typescript
import { SDK } from "@meetkai/mka1";

const sdk = new SDK({
  bearerAuth: "<YOUR_BEARER_TOKEN_HERE>",
});

async function run() {
  const result = await sdk.agentConnectors.getAgentConnector({
    id: "<id>",
    connectorId: "<id>",
  });

  console.log(result);
}

run();
```

### Standalone function

The standalone function version of this method:

```typescript
import { SDKCore } from "@meetkai/mka1/core.js";
import { agentConnectorsGetAgentConnector } from "@meetkai/mka1/funcs/agentConnectorsGetAgentConnector.js";

// Use `SDKCore` for best tree-shaking performance.
// You can create one instance of it to use across an application.
const sdk = new SDKCore({
  bearerAuth: "<YOUR_BEARER_TOKEN_HERE>",
});

async function run() {
  const res = await agentConnectorsGetAgentConnector(sdk, {
    id: "<id>",
    connectorId: "<id>",
  });
  if (res.ok) {
    const { value: result } = res;
    console.log(result);
  } else {
    console.log("agentConnectorsGetAgentConnector failed:", res.error);
  }
}

run();
```

### React hooks and utilities

This method can be used in React components through the following hooks and
associated utilities.

> Check out [this guide][hook-guide] for information about each of the utilities
> below and how to get started using React hooks.

[hook-guide]: ../../../REACT_QUERY.md

```tsx
import {
  // Query hooks for fetching data.
  useAgentConnectorsGetAgentConnector,
  useAgentConnectorsGetAgentConnectorSuspense,

  // Utility for prefetching data during server-side rendering and in React
  // Server Components that will be immediately available to client components
  // using the hooks.
  prefetchAgentConnectorsGetAgentConnector,
  
  // Utilities to invalidate the query cache for this query in response to
  // mutations and other user actions.
  invalidateAgentConnectorsGetAgentConnector,
  invalidateAllAgentConnectorsGetAgentConnector,
} from "@meetkai/mka1/react-query/agentConnectorsGetAgentConnector.js";
```

### Parameters

| Parameter                                                                                                                                                                      | Type                                                                                                                                                                           | Required                                                                                                                                                                       | Description                                                                                                                                                                    |
| ------------------------------------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------------------------------------ |
| `request`                                                                                                                                                                      | [operations.GetAgentConnectorRequest](../../models/operations/getagentconnectorrequest.md)                                                                                     | :heavy_check_mark:                                                                                                                                                             | The request object to use for the request.                                                                                                                                     |
| `options`                                                                                                                                                                      | RequestOptions                                                                                                                                                                 | :heavy_minus_sign:                                                                                                                                                             | Used to set various options for making HTTP requests.                                                                                                                          |
| `options.fetchOptions`                                                                                                                                                         | [RequestInit](https://developer.mozilla.org/en-US/docs/Web/API/Request/Request#options)                                                                                        | :heavy_minus_sign:                                                                                                                                                             | Options that are passed to the underlying HTTP request. This can be used to inject extra headers for examples. All `Request` options, except `method` and `body`, are allowed. |
| `options.retries`                                                                                                                                                              | [RetryConfig](../../lib/utils/retryconfig.md)                                                                                                                                  | :heavy_minus_sign:                                                                                                                                                             | Enables retrying HTTP requests under certain failure conditions.                                                                                                               |

### Response

**Promise\<[components.AgentConnector](../../models/components/agentconnector.md)\>**

### Errors

| Error Type           | Status Code          | Content Type         |
| -------------------- | -------------------- | -------------------- |
| errors.ErrorEnvelope | 401, 403, 404        | application/json     |
| errors.APIError      | 4XX, 5XX             | \*/\*                |

## deleteAgentConnector

Unregisters the connector-specific provider webhook and deletes the stored connector credentials. Telegram pending updates are dropped; WhatsApp deletion clears only the phone-number callback and does not unsubscribe other numbers in the business account.

### Example Usage

<!-- UsageSnippet language="typescript" operationID="deleteAgentConnector" method="delete" path="/api/v1/agents/{id}/connectors/{connectorId}" -->
```typescript
import { SDK } from "@meetkai/mka1";

const sdk = new SDK({
  bearerAuth: "<YOUR_BEARER_TOKEN_HERE>",
});

async function run() {
  const result = await sdk.agentConnectors.deleteAgentConnector({
    id: "<id>",
    connectorId: "<id>",
  });

  console.log(result);
}

run();
```

### Standalone function

The standalone function version of this method:

```typescript
import { SDKCore } from "@meetkai/mka1/core.js";
import { agentConnectorsDeleteAgentConnector } from "@meetkai/mka1/funcs/agentConnectorsDeleteAgentConnector.js";

// Use `SDKCore` for best tree-shaking performance.
// You can create one instance of it to use across an application.
const sdk = new SDKCore({
  bearerAuth: "<YOUR_BEARER_TOKEN_HERE>",
});

async function run() {
  const res = await agentConnectorsDeleteAgentConnector(sdk, {
    id: "<id>",
    connectorId: "<id>",
  });
  if (res.ok) {
    const { value: result } = res;
    console.log(result);
  } else {
    console.log("agentConnectorsDeleteAgentConnector failed:", res.error);
  }
}

run();
```

### React hooks and utilities

This method can be used in React components through the following hooks and
associated utilities.

> Check out [this guide][hook-guide] for information about each of the utilities
> below and how to get started using React hooks.

[hook-guide]: ../../../REACT_QUERY.md

```tsx
import {
  // Mutation hook for triggering the API call.
  useAgentConnectorsDeleteAgentConnectorMutation
} from "@meetkai/mka1/react-query/agentConnectorsDeleteAgentConnector.js";
```

### Parameters

| Parameter                                                                                                                                                                      | Type                                                                                                                                                                           | Required                                                                                                                                                                       | Description                                                                                                                                                                    |
| ------------------------------------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------------------------------------ |
| `request`                                                                                                                                                                      | [operations.DeleteAgentConnectorRequest](../../models/operations/deleteagentconnectorrequest.md)                                                                               | :heavy_check_mark:                                                                                                                                                             | The request object to use for the request.                                                                                                                                     |
| `options`                                                                                                                                                                      | RequestOptions                                                                                                                                                                 | :heavy_minus_sign:                                                                                                                                                             | Used to set various options for making HTTP requests.                                                                                                                          |
| `options.fetchOptions`                                                                                                                                                         | [RequestInit](https://developer.mozilla.org/en-US/docs/Web/API/Request/Request#options)                                                                                        | :heavy_minus_sign:                                                                                                                                                             | Options that are passed to the underlying HTTP request. This can be used to inject extra headers for examples. All `Request` options, except `method` and `body`, are allowed. |
| `options.retries`                                                                                                                                                              | [RetryConfig](../../lib/utils/retryconfig.md)                                                                                                                                  | :heavy_minus_sign:                                                                                                                                                             | Enables retrying HTTP requests under certain failure conditions.                                                                                                               |

### Response

**Promise\<[components.AgentConnectorDeleted](../../models/components/agentconnectordeleted.md)\>**

### Errors

| Error Type           | Status Code          | Content Type         |
| -------------------- | -------------------- | -------------------- |
| errors.ErrorEnvelope | 401, 403, 404        | application/json     |
| errors.ErrorEnvelope | 502                  | application/json     |
| errors.APIError      | 4XX, 5XX             | \*/\*                |

## activateAgentConnector

Revalidates the stored provider credentials and registers the provider webhook. Use this to retry a connector left in an error state. API-key authentication with every listed scope is required; session authentication is rejected, and the key must belong to the connector's original user or service-account principal so existing conversations keep the same owner.

### Example Usage

<!-- UsageSnippet language="typescript" operationID="activateAgentConnector" method="post" path="/api/v1/agents/{id}/connectors/{connectorId}/activate" -->
```typescript
import { SDK } from "@meetkai/mka1";

const sdk = new SDK({
  bearerAuth: "<YOUR_BEARER_TOKEN_HERE>",
});

async function run() {
  const result = await sdk.agentConnectors.activateAgentConnector({
    id: "<id>",
    connectorId: "<id>",
  });

  console.log(result);
}

run();
```

### Standalone function

The standalone function version of this method:

```typescript
import { SDKCore } from "@meetkai/mka1/core.js";
import { agentConnectorsActivateAgentConnector } from "@meetkai/mka1/funcs/agentConnectorsActivateAgentConnector.js";

// Use `SDKCore` for best tree-shaking performance.
// You can create one instance of it to use across an application.
const sdk = new SDKCore({
  bearerAuth: "<YOUR_BEARER_TOKEN_HERE>",
});

async function run() {
  const res = await agentConnectorsActivateAgentConnector(sdk, {
    id: "<id>",
    connectorId: "<id>",
  });
  if (res.ok) {
    const { value: result } = res;
    console.log(result);
  } else {
    console.log("agentConnectorsActivateAgentConnector failed:", res.error);
  }
}

run();
```

### React hooks and utilities

This method can be used in React components through the following hooks and
associated utilities.

> Check out [this guide][hook-guide] for information about each of the utilities
> below and how to get started using React hooks.

[hook-guide]: ../../../REACT_QUERY.md

```tsx
import {
  // Mutation hook for triggering the API call.
  useAgentConnectorsActivateAgentConnectorMutation
} from "@meetkai/mka1/react-query/agentConnectorsActivateAgentConnector.js";
```

### Parameters

| Parameter                                                                                                                                                                      | Type                                                                                                                                                                           | Required                                                                                                                                                                       | Description                                                                                                                                                                    |
| ------------------------------------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------------------------------------ |
| `request`                                                                                                                                                                      | [operations.ActivateAgentConnectorRequest](../../models/operations/activateagentconnectorrequest.md)                                                                           | :heavy_check_mark:                                                                                                                                                             | The request object to use for the request.                                                                                                                                     |
| `options`                                                                                                                                                                      | RequestOptions                                                                                                                                                                 | :heavy_minus_sign:                                                                                                                                                             | Used to set various options for making HTTP requests.                                                                                                                          |
| `options.fetchOptions`                                                                                                                                                         | [RequestInit](https://developer.mozilla.org/en-US/docs/Web/API/Request/Request#options)                                                                                        | :heavy_minus_sign:                                                                                                                                                             | Options that are passed to the underlying HTTP request. This can be used to inject extra headers for examples. All `Request` options, except `method` and `body`, are allowed. |
| `options.retries`                                                                                                                                                              | [RetryConfig](../../lib/utils/retryconfig.md)                                                                                                                                  | :heavy_minus_sign:                                                                                                                                                             | Enables retrying HTTP requests under certain failure conditions.                                                                                                               |

### Response

**Promise\<[components.AgentConnector](../../models/components/agentconnector.md)\>**

### Errors

| Error Type           | Status Code          | Content Type         |
| -------------------- | -------------------- | -------------------- |
| errors.ErrorEnvelope | 401, 403, 404, 409   | application/json     |
| errors.ErrorEnvelope | 502, 503             | application/json     |
| errors.APIError      | 4XX, 5XX             | \*/\*                |