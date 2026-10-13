# ListEvalSuiteVersionsRequest

## Example Usage

```typescript
import { ListEvalSuiteVersionsRequest } from "@meetkai/mka1/models/operations";

let value: ListEvalSuiteVersionsRequest = {
  suiteId: "eval_suite_aa87e2b1112a455b8deabed784372198",
};
```

## Fields

| Field                                                               | Type                                                                | Required                                                            | Description                                                         | Example                                                             |
| ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- |
| `suiteId`                                                           | *string*                                                            | :heavy_check_mark:                                                  | N/A                                                                 | eval_suite_aa87e2b1112a455b8deabed784372198                         |
| `after`                                                             | *string*                                                            | :heavy_minus_sign:                                                  | N/A                                                                 |                                                                     |
| `limit`                                                             | *number*                                                            | :heavy_minus_sign:                                                  | N/A                                                                 |                                                                     |
| `xOnBehalfOf`                                                       | *string*                                                            | :heavy_minus_sign:                                                  | Optional external end-user identifier forwarded by the API gateway. |                                                                     |