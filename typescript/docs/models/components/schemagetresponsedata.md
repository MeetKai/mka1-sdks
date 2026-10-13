# SchemaGetResponseData

The requested extraction schema

## Example Usage

```typescript
import { SchemaGetResponseData } from "@meetkai/mka1/models/components";

let value: SchemaGetResponseData = {
  id: "<id>",
  name: "<value>",
  schema: {
    "key": "<value>",
  },
  createdAt: new Date("2025-10-16T16:00:49.373Z"),
  updatedAt: new Date("2024-04-16T17:47:14.964Z"),
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