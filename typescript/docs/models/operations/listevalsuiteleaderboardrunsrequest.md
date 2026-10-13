# ListEvalSuiteLeaderboardRunsRequest

## Example Usage

```typescript
import { ListEvalSuiteLeaderboardRunsRequest } from "@meetkai/mka1/models/operations";

let value: ListEvalSuiteLeaderboardRunsRequest = {
  suiteId: "eval_suite_aa87e2b1112a455b8deabed784372198",
  suiteVersion: 1,
  model: "meetkai:functionary-urdu-mini-pak",
};
```

## Fields

| Field                                                               | Type                                                                | Required                                                            | Description                                                         | Example                                                             |
| ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- |
| `suiteId`                                                           | *string*                                                            | :heavy_check_mark:                                                  | N/A                                                                 | eval_suite_aa87e2b1112a455b8deabed784372198                         |
| `suiteVersion`                                                      | *number*                                                            | :heavy_minus_sign:                                                  | N/A                                                                 | 1                                                                   |
| `perGroup`                                                          | *number*                                                            | :heavy_minus_sign:                                                  | N/A                                                                 | 5                                                                   |
| `model`                                                             | *string*                                                            | :heavy_minus_sign:                                                  | N/A                                                                 | meetkai:functionary-urdu-mini-pak                                   |
| `cursor`                                                            | *string*                                                            | :heavy_minus_sign:                                                  | N/A                                                                 |                                                                     |
| `xOnBehalfOf`                                                       | *string*                                                            | :heavy_minus_sign:                                                  | Optional external end-user identifier forwarded by the API gateway. |                                                                     |