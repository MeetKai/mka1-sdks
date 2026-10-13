# EvalOutputExtraction4

## Example Usage

```typescript
import { EvalOutputExtraction4 } from "@meetkai/mka1/models/components";

let value: EvalOutputExtraction4 = {
  type: "regex_last",
  pattern: "<value>",
};
```

## Fields

| Field                                  | Type                                   | Required                               | Description                            |
| -------------------------------------- | -------------------------------------- | -------------------------------------- | -------------------------------------- |
| `type`                                 | *"regex_last"*                         | :heavy_check_mark:                     | N/A                                    |
| `pattern`                              | *string*                               | :heavy_check_mark:                     | N/A                                    |
| `group`                                | *components.EvalOutputExtractionGroup* | :heavy_minus_sign:                     | N/A                                    |
| `flags`                                | *string*                               | :heavy_minus_sign:                     | N/A                                    |