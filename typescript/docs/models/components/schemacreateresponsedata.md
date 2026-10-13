# SchemaCreateResponseData

The created extraction schema with generated ID and timestamps

## Example Usage

```typescript
import { SchemaCreateResponseData } from "@meetkai/mka1/models/components";

let value: SchemaCreateResponseData = {
  id: "<id>",
  name: "<value>",
  schema: {
    "key": "<value>",
    "key1": "<value>",
    "key2": "<value>",
  },
  createdAt: new Date("2026-02-03T14:35:57.150Z"),
  updatedAt: new Date("2025-08-20T08:39:06.389Z"),
};
```

## Fields

| Field                                                                                         | Type                                                                                          | Required                                                                                      | Description                                                                                   |
| --------------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------------- |
| `id`                                                                                          | *string*                                                                                      | :heavy_check_mark:                                                                            | Unique identifier for the extraction schema                                                   |
| `name`                                                                                        | *string*                                                                                      | :heavy_check_mark:                                                                            | Name of the extraction schema                                                                 |
| `description`                                                                                 | *string*                                                                                      | :heavy_minus_sign:                                                                            | Optional description of the schema                                                            |
| `schema`                                                                                      | Record<string, *any*>                                                                         | :heavy_check_mark:                                                                            | The JSON Schema object defining the extraction structure                                      |
| `metadata`                                                                                    | Record<string, *any*>                                                                         | :heavy_minus_sign:                                                                            | Optional metadata associated with the schema                                                  |
| `createdAt`                                                                                   | [Date](https://developer.mozilla.org/en-US/docs/Web/JavaScript/Reference/Global_Objects/Date) | :heavy_check_mark:                                                                            | ISO 8601 timestamp when the schema was created                                                |
| `updatedAt`                                                                                   | [Date](https://developer.mozilla.org/en-US/docs/Web/JavaScript/Reference/Global_Objects/Date) | :heavy_check_mark:                                                                            | ISO 8601 timestamp when the schema was last updated                                           |