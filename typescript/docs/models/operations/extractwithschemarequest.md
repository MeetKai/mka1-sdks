# ExtractWithSchemaRequest

## Example Usage

```typescript
import { ExtractWithSchemaRequest } from "@meetkai/mka1/models/operations";

// No examples available for this model
```

## Fields

| Field                                                                                              | Type                                                                                               | Required                                                                                           | Description                                                                                        | Example                                                                                            |
| -------------------------------------------------------------------------------------------------- | -------------------------------------------------------------------------------------------------- | -------------------------------------------------------------------------------------------------- | -------------------------------------------------------------------------------------------------- | -------------------------------------------------------------------------------------------------- |
| `schemaId`                                                                                         | *string*                                                                                           | :heavy_check_mark:                                                                                 | N/A                                                                                                | schema_invoice_123                                                                                 |
| `xOnBehalfOf`                                                                                      | *string*                                                                                           | :heavy_minus_sign:                                                                                 | Optional external end-user identifier forwarded by the API gateway.                                |                                                                                                    |
| `requestBody`                                                                                      | [operations.ExtractWithSchemaRequestBody](../../models/operations/extractwithschemarequestbody.md) | :heavy_check_mark:                                                                                 | N/A                                                                                                |                                                                                                    |