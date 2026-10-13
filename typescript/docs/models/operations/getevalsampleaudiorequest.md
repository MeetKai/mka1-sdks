# GetEvalSampleAudioRequest

## Example Usage

```typescript
import { GetEvalSampleAudioRequest } from "@meetkai/mka1/models/operations";

let value: GetEvalSampleAudioRequest = {
  runId: "eval_run_aa87e2b1112a455b8deabed784372198",
  sampleIndex: 0,
};
```

## Fields

| Field                                                               | Type                                                                | Required                                                            | Description                                                         | Example                                                             |
| ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- |
| `runId`                                                             | *string*                                                            | :heavy_check_mark:                                                  | N/A                                                                 | eval_run_aa87e2b1112a455b8deabed784372198                           |
| `sampleIndex`                                                       | *number*                                                            | :heavy_check_mark:                                                  | N/A                                                                 | 0                                                                   |
| `model`                                                             | *string*                                                            | :heavy_minus_sign:                                                  | N/A                                                                 |                                                                     |
| `taskId`                                                            | *string*                                                            | :heavy_minus_sign:                                                  | N/A                                                                 |                                                                     |
| `xOnBehalfOf`                                                       | *string*                                                            | :heavy_minus_sign:                                                  | Optional external end-user identifier forwarded by the API gateway. |                                                                     |