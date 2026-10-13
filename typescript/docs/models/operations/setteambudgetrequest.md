# SetTeamBudgetRequest

## Example Usage

```typescript
import { SetTeamBudgetRequest } from "@meetkai/mka1/models/operations";

let value: SetTeamBudgetRequest = {
  id: "<id>",
  requestBody: {
    period: "weekly",
    limit: 3645.95,
    thresholds: [
      {
        pct: 443379,
        action: "alert",
      },
    ],
  },
};
```

## Fields

| Field                                                                                      | Type                                                                                       | Required                                                                                   | Description                                                                                |
| ------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------ |
| `id`                                                                                       | *string*                                                                                   | :heavy_check_mark:                                                                         | N/A                                                                                        |
| `orgId`                                                                                    | *string*                                                                                   | :heavy_minus_sign:                                                                         | N/A                                                                                        |
| `requestBody`                                                                              | [operations.SetTeamBudgetRequestBody](../../models/operations/setteambudgetrequestbody.md) | :heavy_check_mark:                                                                         | N/A                                                                                        |