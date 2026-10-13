# SetTeamDefaultBudgetRequest

## Example Usage

```typescript
import { SetTeamDefaultBudgetRequest } from "@meetkai/mka1/models/operations";

let value: SetTeamDefaultBudgetRequest = {
  requestBody: {
    period: "daily",
    limit: 9846.67,
    thresholds: [
      {
        pct: 984337,
        action: "alert",
      },
    ],
  },
};
```

## Fields

| Field                                                                                                    | Type                                                                                                     | Required                                                                                                 | Description                                                                                              |
| -------------------------------------------------------------------------------------------------------- | -------------------------------------------------------------------------------------------------------- | -------------------------------------------------------------------------------------------------------- | -------------------------------------------------------------------------------------------------------- |
| `orgId`                                                                                                  | *string*                                                                                                 | :heavy_minus_sign:                                                                                       | N/A                                                                                                      |
| `requestBody`                                                                                            | [operations.SetTeamDefaultBudgetRequestBody](../../models/operations/setteamdefaultbudgetrequestbody.md) | :heavy_check_mark:                                                                                       | N/A                                                                                                      |