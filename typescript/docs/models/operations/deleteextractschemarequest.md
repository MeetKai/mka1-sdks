# DeleteExtractSchemaRequest

## Example Usage

```typescript
import { DeleteExtractSchemaRequest } from "@meetkai/mka1/models/operations";

let value: DeleteExtractSchemaRequest = {
  schemaId: "schema_invoice_123",
};
```

## Fields

| Field                                                               | Type                                                                | Required                                                            | Description                                                         | Example                                                             |
| ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- |
| `schemaId`                                                          | *string*                                                            | :heavy_check_mark:                                                  | N/A                                                                 | schema_invoice_123                                                  |
| `xOnBehalfOf`                                                       | *string*                                                            | :heavy_minus_sign:                                                  | Optional external end-user identifier forwarded by the API gateway. |                                                                     |