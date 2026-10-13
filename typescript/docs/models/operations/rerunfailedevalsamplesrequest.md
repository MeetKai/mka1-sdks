# RerunFailedEvalSamplesRequest

## Example Usage

```typescript
import { RerunFailedEvalSamplesRequest } from "@meetkai/mka1/models/operations";

let value: RerunFailedEvalSamplesRequest = {
  runId: "eval_run_aa87e2b1112a455b8deabed784372198",
};
```

## Fields

| Field                                                               | Type                                                                | Required                                                            | Description                                                         | Example                                                             |
| ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- |
| `runId`                                                             | *string*                                                            | :heavy_check_mark:                                                  | N/A                                                                 | eval_run_aa87e2b1112a455b8deabed784372198                           |
| `xOnBehalfOf`                                                       | *string*                                                            | :heavy_minus_sign:                                                  | Optional external end-user identifier forwarded by the API gateway. |                                                                     |