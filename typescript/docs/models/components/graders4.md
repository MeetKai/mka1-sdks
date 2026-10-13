# Graders4

## Example Usage

```typescript
import { Graders4 } from "@meetkai/mka1/models/components";

let value: Graders4 = {
  type: "score_model",
  name: "<value>",
  model: "El Camino",
  input: [],
};
```

## Fields

| Field                                                                                | Type                                                                                 | Required                                                                             | Description                                                                          |
| ------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------ |
| `type`                                                                               | *"score_model"*                                                                      | :heavy_check_mark:                                                                   | N/A                                                                                  |
| `name`                                                                               | *string*                                                                             | :heavy_check_mark:                                                                   | N/A                                                                                  |
| `model`                                                                              | *string*                                                                             | :heavy_check_mark:                                                                   | N/A                                                                                  |
| `input`                                                                              | [components.GradersInput](../../models/components/gradersinput.md)[]                 | :heavy_check_mark:                                                                   | N/A                                                                                  |
| `range`                                                                              | *number*[]                                                                           | :heavy_minus_sign:                                                                   | N/A                                                                                  |
| `samplingParams`                                                                     | [components.GradersSamplingParams](../../models/components/graderssamplingparams.md) | :heavy_minus_sign:                                                                   | N/A                                                                                  |