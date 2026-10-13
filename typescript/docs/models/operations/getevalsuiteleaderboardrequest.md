# GetEvalSuiteLeaderboardRequest

## Example Usage

```typescript
import { GetEvalSuiteLeaderboardRequest } from "@meetkai/mka1/models/operations";

let value: GetEvalSuiteLeaderboardRequest = {
  suiteId: "eval_suite_aa87e2b1112a455b8deabed784372198",
  suiteVersion: 1,
};
```

## Fields

| Field                                                               | Type                                                                | Required                                                            | Description                                                         | Example                                                             |
| ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- |
| `suiteId`                                                           | *string*                                                            | :heavy_check_mark:                                                  | N/A                                                                 | eval_suite_aa87e2b1112a455b8deabed784372198                         |
| `suiteVersion`                                                      | *number*                                                            | :heavy_minus_sign:                                                  | N/A                                                                 | 1                                                                   |
| `metric`                                                            | *string*                                                            | :heavy_minus_sign:                                                  | N/A                                                                 | reward                                                              |
| `agent`                                                             | *string*                                                            | :heavy_minus_sign:                                                  | N/A                                                                 |                                                                     |
| `model`                                                             | *string*                                                            | :heavy_minus_sign:                                                  | N/A                                                                 |                                                                     |
| `limit`                                                             | *number*                                                            | :heavy_minus_sign:                                                  | N/A                                                                 | 100                                                                 |
| `xOnBehalfOf`                                                       | *string*                                                            | :heavy_minus_sign:                                                  | Optional external end-user identifier forwarded by the API gateway. |                                                                     |