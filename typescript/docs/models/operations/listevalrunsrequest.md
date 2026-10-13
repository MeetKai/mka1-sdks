# ListEvalRunsRequest

## Example Usage

```typescript
import { ListEvalRunsRequest } from "@meetkai/mka1/models/operations";

let value: ListEvalRunsRequest = {
  suiteId: "eval_suite_aa87e2b1112a455b8deabed784372198",
  suiteVersion: 1,
};
```

## Fields

| Field                                                                                              | Type                                                                                               | Required                                                                                           | Description                                                                                        | Example                                                                                            |
| -------------------------------------------------------------------------------------------------- | -------------------------------------------------------------------------------------------------- | -------------------------------------------------------------------------------------------------- | -------------------------------------------------------------------------------------------------- | -------------------------------------------------------------------------------------------------- |
| `after`                                                                                            | *string*                                                                                           | :heavy_minus_sign:                                                                                 | N/A                                                                                                |                                                                                                    |
| `limit`                                                                                            | *number*                                                                                           | :heavy_minus_sign:                                                                                 | N/A                                                                                                |                                                                                                    |
| `suiteId`                                                                                          | *string*                                                                                           | :heavy_minus_sign:                                                                                 | N/A                                                                                                | eval_suite_aa87e2b1112a455b8deabed784372198                                                        |
| `suiteVersion`                                                                                     | *number*                                                                                           | :heavy_minus_sign:                                                                                 | N/A                                                                                                | 1                                                                                                  |
| `status`                                                                                           | [operations.ListEvalRunsQueryParamStatus](../../models/operations/listevalrunsqueryparamstatus.md) | :heavy_minus_sign:                                                                                 | N/A                                                                                                |                                                                                                    |
| `xOnBehalfOf`                                                                                      | *string*                                                                                           | :heavy_minus_sign:                                                                                 | Optional external end-user identifier forwarded by the API gateway.                                |                                                                                                    |