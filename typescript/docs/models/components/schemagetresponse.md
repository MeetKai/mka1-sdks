# SchemaGetResponse

Response from retrieving an extraction schema by ID.

## Example Usage

```typescript
import { SchemaGetResponse } from "@meetkai/mka1/models/components";

let value: SchemaGetResponse = {
  success: false,
  data: {
    id: "<id>",
    name: "<value>",
    schema: {
      "key": "<value>",
      "key1": "<value>",
      "key2": "<value>",
    },
    createdAt: new Date("2024-08-06T03:40:33.788Z"),
    updatedAt: new Date("2025-04-21T09:02:04.862Z"),
  },
};
```

## Fields

| Field                                                                                | Type                                                                                 | Required                                                                             | Description                                                                          |
| ------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------ |
| `success`                                                                            | *boolean*                                                                            | :heavy_check_mark:                                                                   | Indicates whether the schema retrieval was successful                                |
| `data`                                                                               | [components.SchemaGetResponseData](../../models/components/schemagetresponsedata.md) | :heavy_check_mark:                                                                   | The requested extraction schema                                                      |