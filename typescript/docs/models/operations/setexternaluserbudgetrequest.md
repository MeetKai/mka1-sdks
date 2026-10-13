# SetExternalUserBudgetRequest

## Example Usage

```typescript
import { SetExternalUserBudgetRequest } from "@meetkai/mka1/models/operations";

let value: SetExternalUserBudgetRequest = {
  id: "<id>",
  requestBody: {
    period: "daily",
    limit: 2931.32,
    thresholds: [
      {
        pct: 720106,
        action: "alert",
      },
    ],
  },
};
```

## Fields

| Field                                                                                                      | Type                                                                                                       | Required                                                                                                   | Description                                                                                                |
| ---------------------------------------------------------------------------------------------------------- | ---------------------------------------------------------------------------------------------------------- | ---------------------------------------------------------------------------------------------------------- | ---------------------------------------------------------------------------------------------------------- |
| `id`                                                                                                       | *string*                                                                                                   | :heavy_check_mark:                                                                                         | N/A                                                                                                        |
| `orgId`                                                                                                    | *string*                                                                                                   | :heavy_minus_sign:                                                                                         | N/A                                                                                                        |
| `requestBody`                                                                                              | [operations.SetExternalUserBudgetRequestBody](../../models/operations/setexternaluserbudgetrequestbody.md) | :heavy_check_mark:                                                                                         | N/A                                                                                                        |