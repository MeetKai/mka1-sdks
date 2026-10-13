# One4

## Example Usage

```typescript
import { One4 } from "@meetkai/mka1/models/components";

let value: One4 = {
  type: "score_model",
  name: "<value>",
  model: "PT Cruiser",
  input: [],
};
```

## Fields

| Field                                                                  | Type                                                                   | Required                                                               | Description                                                            |
| ---------------------------------------------------------------------- | ---------------------------------------------------------------------- | ---------------------------------------------------------------------- | ---------------------------------------------------------------------- |
| `type`                                                                 | *"score_model"*                                                        | :heavy_check_mark:                                                     | N/A                                                                    |
| `name`                                                                 | *string*                                                               | :heavy_check_mark:                                                     | N/A                                                                    |
| `model`                                                                | *string*                                                               | :heavy_check_mark:                                                     | N/A                                                                    |
| `input`                                                                | [components.OneInput](../../models/components/oneinput.md)[]           | :heavy_check_mark:                                                     | N/A                                                                    |
| `range`                                                                | *number*[]                                                             | :heavy_minus_sign:                                                     | N/A                                                                    |
| `samplingParams`                                                       | [components.SamplingParams](../../models/components/samplingparams.md) | :heavy_minus_sign:                                                     | N/A                                                                    |