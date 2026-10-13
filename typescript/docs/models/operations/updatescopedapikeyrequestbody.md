# UpdateScopedApiKeyRequestBody

## Example Usage

```typescript
import { UpdateScopedApiKeyRequestBody } from "@meetkai/mka1/models/operations";

let value: UpdateScopedApiKeyRequestBody = {
  keyId: "<id>",
  scopes: [
    "<value 1>",
  ],
};
```

## Fields

| Field                 | Type                  | Required              | Description           |
| --------------------- | --------------------- | --------------------- | --------------------- |
| `keyId`               | *string*              | :heavy_check_mark:    | N/A                   |
| `scopes`              | *string*[]            | :heavy_check_mark:    | N/A                   |
| `name`                | *string*              | :heavy_minus_sign:    | N/A                   |
| `rateLimitEnabled`    | *boolean*             | :heavy_minus_sign:    | N/A                   |
| `rateLimitTimeWindow` | *number*              | :heavy_minus_sign:    | N/A                   |
| `rateLimitMax`        | *number*              | :heavy_minus_sign:    | N/A                   |