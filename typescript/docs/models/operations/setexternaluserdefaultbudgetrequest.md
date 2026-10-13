# SetExternalUserDefaultBudgetRequest

## Example Usage

```typescript
import { SetExternalUserDefaultBudgetRequest } from "@meetkai/mka1/models/operations";

let value: SetExternalUserDefaultBudgetRequest = {
  requestBody: {
    period: "monthly",
    limit: 7077.25,
    thresholds: [
      {
        pct: 691226,
        action: "block",
      },
    ],
  },
};
```

## Fields

| Field                                                                                                                    | Type                                                                                                                     | Required                                                                                                                 | Description                                                                                                              |
| ------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------ |
| `orgId`                                                                                                                  | *string*                                                                                                                 | :heavy_minus_sign:                                                                                                       | N/A                                                                                                                      |
| `requestBody`                                                                                                            | [operations.SetExternalUserDefaultBudgetRequestBody](../../models/operations/setexternaluserdefaultbudgetrequestbody.md) | :heavy_check_mark:                                                                                                       | N/A                                                                                                                      |