# SchemaCreateResponse

Response from creating a new extraction schema.

## Example Usage

```typescript
import { SchemaCreateResponse } from "@meetkai/mka1/models/components";

let value: SchemaCreateResponse = {
  success: true,
  data: {
    id: "<id>",
    name: "<value>",
    schema: {},
    createdAt: new Date("2024-06-18T05:04:26.797Z"),
    updatedAt: new Date("2024-01-07T20:40:42.413Z"),
  },
};
```

## Fields

| Field                                                                                      | Type                                                                                       | Required                                                                                   | Description                                                                                |
| ------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------ |
| `success`                                                                                  | *boolean*                                                                                  | :heavy_check_mark:                                                                         | Indicates whether the schema creation was successful                                       |
| `data`                                                                                     | [components.SchemaCreateResponseData](../../models/components/schemacreateresponsedata.md) | :heavy_check_mark:                                                                         | The created extraction schema with generated ID and timestamps                             |