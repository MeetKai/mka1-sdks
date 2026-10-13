# SetUserDefaultBudgetRequest

## Example Usage

```typescript
import { SetUserDefaultBudgetRequest } from "@meetkai/mka1/models/operations";

let value: SetUserDefaultBudgetRequest = {
  requestBody: {
    period: "monthly",
    limit: 8752.59,
    thresholds: [
      {
        pct: 778062,
        action: "block",
      },
    ],
  },
};
```

## Fields

| Field                                                                                                    | Type                                                                                                     | Required                                                                                                 | Description                                                                                              |
| -------------------------------------------------------------------------------------------------------- | -------------------------------------------------------------------------------------------------------- | -------------------------------------------------------------------------------------------------------- | -------------------------------------------------------------------------------------------------------- |
| `orgId`                                                                                                  | *string*                                                                                                 | :heavy_minus_sign:                                                                                       | N/A                                                                                                      |
| `requestBody`                                                                                            | [operations.SetUserDefaultBudgetRequestBody](../../models/operations/setuserdefaultbudgetrequestbody.md) | :heavy_check_mark:                                                                                       | N/A                                                                                                      |