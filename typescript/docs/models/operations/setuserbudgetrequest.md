# SetUserBudgetRequest

## Example Usage

```typescript
import { SetUserBudgetRequest } from "@meetkai/mka1/models/operations";

let value: SetUserBudgetRequest = {
  id: "<id>",
  requestBody: {
    period: "daily",
    limit: 572.7,
    thresholds: [],
  },
};
```

## Fields

| Field                                                                                      | Type                                                                                       | Required                                                                                   | Description                                                                                |
| ------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------ |
| `id`                                                                                       | *string*                                                                                   | :heavy_check_mark:                                                                         | N/A                                                                                        |
| `orgId`                                                                                    | *string*                                                                                   | :heavy_minus_sign:                                                                         | N/A                                                                                        |
| `requestBody`                                                                              | [operations.SetUserBudgetRequestBody](../../models/operations/setuserbudgetrequestbody.md) | :heavy_check_mark:                                                                         | N/A                                                                                        |