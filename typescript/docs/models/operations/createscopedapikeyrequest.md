# CreateScopedApiKeyRequest

## Example Usage

```typescript
import { CreateScopedApiKeyRequest } from "@meetkai/mka1/models/operations";

let value: CreateScopedApiKeyRequest = {};
```

## Fields

| Field                                                                                                | Type                                                                                                 | Required                                                                                             | Description                                                                                          |
| ---------------------------------------------------------------------------------------------------- | ---------------------------------------------------------------------------------------------------- | ---------------------------------------------------------------------------------------------------- | ---------------------------------------------------------------------------------------------------- |
| `xOnBehalfOf`                                                                                        | *string*                                                                                             | :heavy_minus_sign:                                                                                   | Optional external end-user identifier forwarded by the API gateway.                                  |
| `requestBody`                                                                                        | [operations.CreateScopedApiKeyRequestBody](../../models/operations/createscopedapikeyrequestbody.md) | :heavy_minus_sign:                                                                                   | N/A                                                                                                  |