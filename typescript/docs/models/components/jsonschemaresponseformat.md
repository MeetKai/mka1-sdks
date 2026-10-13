# JSONSchemaResponseFormat

## Example Usage

```typescript
import { JSONSchemaResponseFormat } from "@meetkai/mka1/models/components";

let value: JSONSchemaResponseFormat = {
  type: "json_schema",
  name: "<value>",
  schema: {},
};
```

## Fields

| Field                 | Type                  | Required              | Description           |
| --------------------- | --------------------- | --------------------- | --------------------- |
| `type`                | *"json_schema"*       | :heavy_check_mark:    | N/A                   |
| `name`                | *string*              | :heavy_check_mark:    | N/A                   |
| `schema`              | Record<string, *any*> | :heavy_check_mark:    | N/A                   |
| `description`         | *string*              | :heavy_minus_sign:    | N/A                   |
| `strict`              | *boolean*             | :heavy_minus_sign:    | N/A                   |