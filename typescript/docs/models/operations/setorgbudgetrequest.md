# SetOrgBudgetRequest

## Example Usage

```typescript
import { SetOrgBudgetRequest } from "@meetkai/mka1/models/operations";

let value: SetOrgBudgetRequest = {
  requestBody: {
    period: "daily",
    limit: 1894.8,
    thresholds: [
      {
        pct: 616565,
        action: "alert",
      },
    ],
  },
};
```

## Fields

| Field                                                                                    | Type                                                                                     | Required                                                                                 | Description                                                                              |
| ---------------------------------------------------------------------------------------- | ---------------------------------------------------------------------------------------- | ---------------------------------------------------------------------------------------- | ---------------------------------------------------------------------------------------- |
| `orgId`                                                                                  | *string*                                                                                 | :heavy_minus_sign:                                                                       | N/A                                                                                      |
| `requestBody`                                                                            | [operations.SetOrgBudgetRequestBody](../../models/operations/setorgbudgetrequestbody.md) | :heavy_check_mark:                                                                       | N/A                                                                                      |