# CreateScopedApiKeyRequestBody

## Example Usage

```typescript
import { CreateScopedApiKeyRequestBody } from "@meetkai/mka1/models/operations";

let value: CreateScopedApiKeyRequestBody = {
  name: "<value>",
  teamId: "<id>",
  scopes: [
    "<value 1>",
    "<value 2>",
  ],
};
```

## Fields

| Field                                                          | Type                                                           | Required                                                       | Description                                                    |
| -------------------------------------------------------------- | -------------------------------------------------------------- | -------------------------------------------------------------- | -------------------------------------------------------------- |
| `name`                                                         | *string*                                                       | :heavy_check_mark:                                             | N/A                                                            |
| `teamId`                                                       | *string*                                                       | :heavy_check_mark:                                             | N/A                                                            |
| `scopes`                                                       | *string*[]                                                     | :heavy_check_mark:                                             | N/A                                                            |
| `expiresIn`                                                    | *number*                                                       | :heavy_minus_sign:                                             | N/A                                                            |
| `rateLimitEnabled`                                             | *boolean*                                                      | :heavy_minus_sign:                                             | N/A                                                            |
| `rateLimitTimeWindow`                                          | *number*                                                       | :heavy_minus_sign:                                             | N/A                                                            |
| `rateLimitMax`                                                 | *number*                                                       | :heavy_minus_sign:                                             | N/A                                                            |
| `onBehalfOf`                                                   | [operations.OnBehalfOf](../../models/operations/onbehalfof.md) | :heavy_minus_sign:                                             | N/A                                                            |