# JsonSchema

JSON Schema definition for structured output. Required when type is 'json_schema'.

## Example Usage

```typescript
import { JsonSchema } from "@meetkai/mka1/models/components";

let value: JsonSchema = {
  name: "<value>",
  schema: {
    "key": "<value>",
    "key1": "<value>",
  },
};
```

## Fields

| Field                 | Type                  | Required              | Description           |
| --------------------- | --------------------- | --------------------- | --------------------- |
| `name`                | *string*              | :heavy_check_mark:    | N/A                   |
| `schema`              | Record<string, *any*> | :heavy_check_mark:    | N/A                   |
| `strict`              | *boolean*             | :heavy_minus_sign:    | N/A                   |