# DatasetInput

## Example Usage

```typescript
import { DatasetInput } from "@meetkai/mka1/models/components";

let value: DatasetInput = {
  dataset: {
    name: "<value>",
    digest: "<value>",
    sourceType: "<value>",
    source: "<value>",
  },
};
```

## Fields

| Field                                                    | Type                                                     | Required                                                 | Description                                              |
| -------------------------------------------------------- | -------------------------------------------------------- | -------------------------------------------------------- | -------------------------------------------------------- |
| `dataset`                                                | [components.Dataset](../../models/components/dataset.md) | :heavy_check_mark:                                       | N/A                                                      |
| `tags`                                                   | [components.Tag](../../models/components/tag.md)[]       | :heavy_minus_sign:                                       | N/A                                                      |