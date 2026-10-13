# UpdateExtractSchemaRequest

## Example Usage

```typescript
import { UpdateExtractSchemaRequest } from "@meetkai/mka1/models/operations";

let value: UpdateExtractSchemaRequest = {
  schemaId: "schema_invoice_123",
  requestBody: {},
};
```

## Fields

| Field                                                                                                  | Type                                                                                                   | Required                                                                                               | Description                                                                                            | Example                                                                                                |
| ------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------ |
| `schemaId`                                                                                             | *string*                                                                                               | :heavy_check_mark:                                                                                     | N/A                                                                                                    | schema_invoice_123                                                                                     |
| `xOnBehalfOf`                                                                                          | *string*                                                                                               | :heavy_minus_sign:                                                                                     | Optional external end-user identifier forwarded by the API gateway.                                    |                                                                                                        |
| `requestBody`                                                                                          | [operations.UpdateExtractSchemaRequestBody](../../models/operations/updateextractschemarequestbody.md) | :heavy_check_mark:                                                                                     | N/A                                                                                                    |                                                                                                        |