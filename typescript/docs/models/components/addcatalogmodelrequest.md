# AddCatalogModelRequest

## Example Usage

```typescript
import { AddCatalogModelRequest } from "@meetkai/mka1/models/components";

let value: AddCatalogModelRequest = {
  id: "<id>",
  provider: "<value>",
  modelId: "<id>",
  apiFormat: "responses",
  apiProviderType: "groq",
  created: 696207,
  auth: {
    type: "custom-headers",
    headers: {
      "key": "<value>",
      "key1": "<value>",
    },
  },
  capabilities: {
    modalities: {
      input: [
        "image",
      ],
      output: [
        "image",
      ],
    },
    reasoning: true,
  },
};
```

## Fields

| Field                                                                    | Type                                                                     | Required                                                                 | Description                                                              | Example                                                                  |
| ------------------------------------------------------------------------ | ------------------------------------------------------------------------ | ------------------------------------------------------------------------ | ------------------------------------------------------------------------ | ------------------------------------------------------------------------ |
| `id`                                                                     | *string*                                                                 | :heavy_check_mark:                                                       | N/A                                                                      |                                                                          |
| `provider`                                                               | *string*                                                                 | :heavy_check_mark:                                                       | N/A                                                                      |                                                                          |
| `modelId`                                                                | *string*                                                                 | :heavy_check_mark:                                                       | N/A                                                                      |                                                                          |
| `displayName`                                                            | *string*                                                                 | :heavy_minus_sign:                                                       | N/A                                                                      |                                                                          |
| `baseUrl`                                                                | *string*                                                                 | :heavy_minus_sign:                                                       | N/A                                                                      |                                                                          |
| `apiFormat`                                                              | [components.AutoEndpoint](../../models/components/autoendpoint.md)       | :heavy_check_mark:                                                       | N/A                                                                      | responses                                                                |
| `apiProviderType`                                                        | [components.ApiProviderType](../../models/components/apiprovidertype.md) | :heavy_check_mark:                                                       | N/A                                                                      |                                                                          |
| `created`                                                                | *number*                                                                 | :heavy_check_mark:                                                       | N/A                                                                      |                                                                          |
| `auth`                                                                   | *components.Auth*                                                        | :heavy_check_mark:                                                       | N/A                                                                      |                                                                          |
| `capabilities`                                                           | [components.Capabilities](../../models/components/capabilities.md)       | :heavy_check_mark:                                                       | N/A                                                                      |                                                                          |
| `contextWindow`                                                          | *number*                                                                 | :heavy_minus_sign:                                                       | N/A                                                                      |                                                                          |
| `rpm`                                                                    | *number*                                                                 | :heavy_minus_sign:                                                       | N/A                                                                      |                                                                          |
| `rateLimits`                                                             | [components.RateLimits](../../models/components/ratelimits.md)[]         | :heavy_minus_sign:                                                       | N/A                                                                      |                                                                          |
| `concurrency`                                                            | [components.Concurrency](../../models/components/concurrency.md)         | :heavy_minus_sign:                                                       | N/A                                                                      |                                                                          |
| `requestTimeoutMs`                                                       | *number*                                                                 | :heavy_minus_sign:                                                       | N/A                                                                      |                                                                          |
| `maxRetries`                                                             | *number*                                                                 | :heavy_minus_sign:                                                       | N/A                                                                      |                                                                          |
| `defaultParams`                                                          | [components.DefaultParams](../../models/components/defaultparams.md)     | :heavy_minus_sign:                                                       | N/A                                                                      |                                                                          |
| `rerouteRules`                                                           | [components.RerouteRules](../../models/components/rerouterules.md)[]     | :heavy_minus_sign:                                                       | N/A                                                                      |                                                                          |
| `hidden`                                                                 | *boolean*                                                                | :heavy_minus_sign:                                                       | N/A                                                                      |                                                                          |
| `embeddingLimits`                                                        | [components.EmbeddingLimits](../../models/components/embeddinglimits.md) | :heavy_minus_sign:                                                       | N/A                                                                      |                                                                          |
| `healthCheck`                                                            | *components.HealthCheck*                                                 | :heavy_minus_sign:                                                       | N/A                                                                      |                                                                          |
| `modelCard`                                                              | [components.ModelCard](../../models/components/modelcard.md)             | :heavy_minus_sign:                                                       | N/A                                                                      |                                                                          |