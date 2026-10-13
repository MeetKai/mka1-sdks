# FormatDetail

## Example Usage

```typescript
import { FormatDetail } from "@meetkai/mka1/models/components";

let value: FormatDetail = {
  id: "<id>",
  title: "<value>",
  trains: [
    "<value 1>",
    "<value 2>",
    "<value 3>",
  ],
  rowSchema: {
    "key": "<value>",
    "key1": "<value>",
  },
  layout: {
    "key": "<value>",
    "key1": "<value>",
  },
  semantics: [],
  converters: [
    "<value 1>",
  ],
};
```

## Fields

| Field                                                                | Type                                                                 | Required                                                             | Description                                                          |
| -------------------------------------------------------------------- | -------------------------------------------------------------------- | -------------------------------------------------------------------- | -------------------------------------------------------------------- |
| `id`                                                                 | *string*                                                             | :heavy_check_mark:                                                   | N/A                                                                  |
| `title`                                                              | *string*                                                             | :heavy_check_mark:                                                   | N/A                                                                  |
| `trains`                                                             | *string*[]                                                           | :heavy_check_mark:                                                   | N/A                                                                  |
| `rowSchema`                                                          | Record<string, *any*>                                                | :heavy_check_mark:                                                   | N/A                                                                  |
| `layout`                                                             | Record<string, *any*>                                                | :heavy_check_mark:                                                   | N/A                                                                  |
| `semantics`                                                          | [components.SemanticRule](../../models/components/semanticrule.md)[] | :heavy_check_mark:                                                   | N/A                                                                  |
| `converters`                                                         | *string*[]                                                           | :heavy_check_mark:                                                   | N/A                                                                  |