# EvalSuiteTokenMeasurement

## Example Usage

```typescript
import { EvalSuiteTokenMeasurement } from "@meetkai/mka1/models/components";

let value: EvalSuiteTokenMeasurement = {
  object: "eval.suite.token_measurement",
  suiteId: "<id>",
  measuredRuns: 107476,
  measuredSamples: 945286,
  remainingRuns: 85853,
};
```

## Fields

| Field                                                                                     | Type                                                                                      | Required                                                                                  | Description                                                                               |
| ----------------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------------- |
| `object`                                                                                  | *"eval.suite.token_measurement"*                                                          | :heavy_check_mark:                                                                        | N/A                                                                                       |
| `suiteId`                                                                                 | *string*                                                                                  | :heavy_check_mark:                                                                        | N/A                                                                                       |
| `measuredRuns`                                                                            | *number*                                                                                  | :heavy_check_mark:                                                                        | Runs whose samples were counted in this call.                                             |
| `measuredSamples`                                                                         | *number*                                                                                  | :heavy_check_mark:                                                                        | Samples that gained token figures in this call.                                           |
| `remainingRuns`                                                                           | *number*                                                                                  | :heavy_check_mark:                                                                        | Runs of the suite that still have samples with text but no token figure, after this call. |