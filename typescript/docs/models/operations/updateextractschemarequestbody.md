# UpdateExtractSchemaRequestBody

Fields to update in the extraction schema. All fields are optional; only provided fields will be updated.

## Example Usage

```typescript
import { UpdateExtractSchemaRequestBody } from "@meetkai/mka1/models/operations";

let value: UpdateExtractSchemaRequestBody = {};
```

## Fields

| Field                                       | Type                                        | Required                                    | Description                                 |
| ------------------------------------------- | ------------------------------------------- | ------------------------------------------- | ------------------------------------------- |
| `name`                                      | *string*                                    | :heavy_minus_sign:                          | Optional new name for the extraction schema |
| `description`                               | *string*                                    | :heavy_minus_sign:                          | Optional new description for the schema     |
| `schema`                                    | Record<string, *any*>                       | :heavy_minus_sign:                          | Optional updated JSON Schema definition     |
| `metadata`                                  | Record<string, *any*>                       | :heavy_minus_sign:                          | Optional updated metadata                   |