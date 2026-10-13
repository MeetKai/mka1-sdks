# SchemaUpdateResponse

Response from updating an existing extraction schema.

## Example Usage

```typescript
import { SchemaUpdateResponse } from "@meetkai/mka1/models/components";

let value: SchemaUpdateResponse = {
  success: true,
  data: {
    id: "<id>",
    name: "<value>",
    schema: {
      "key": "<value>",
      "key1": "<value>",
    },
    createdAt: new Date("2025-08-29T22:51:28.700Z"),
    updatedAt: new Date("2026-04-20T05:13:37.777Z"),
  },
};
```

## Fields

| Field                                                                                      | Type                                                                                       | Required                                                                                   | Description                                                                                |
| ------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------ |
| `success`                                                                                  | *boolean*                                                                                  | :heavy_check_mark:                                                                         | Indicates whether the schema update was successful                                         |
| `data`                                                                                     | [components.SchemaUpdateResponseData](../../models/components/schemaupdateresponsedata.md) | :heavy_check_mark:                                                                         | The updated extraction schema with new updated_at timestamp                                |