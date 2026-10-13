# DeleteExternalUserDefaultBudgetResponseBody

OK

## Example Usage

```typescript
import { DeleteExternalUserDefaultBudgetResponseBody } from "@meetkai/mka1/models/operations";

let value: DeleteExternalUserDefaultBudgetResponseBody = {
  scope: "user",
  scopeId: "<id>",
  owner: "cluster",
  deleted: true,
};
```

## Fields

| Field                                                                                                              | Type                                                                                                               | Required                                                                                                           | Description                                                                                                        |
| ------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------ |
| `scope`                                                                                                            | [operations.DeleteExternalUserDefaultBudgetScope](../../models/operations/deleteexternaluserdefaultbudgetscope.md) | :heavy_check_mark:                                                                                                 | N/A                                                                                                                |
| `scopeId`                                                                                                          | *string*                                                                                                           | :heavy_check_mark:                                                                                                 | N/A                                                                                                                |
| `owner`                                                                                                            | [operations.DeleteExternalUserDefaultBudgetOwner](../../models/operations/deleteexternaluserdefaultbudgetowner.md) | :heavy_check_mark:                                                                                                 | N/A                                                                                                                |
| `deleted`                                                                                                          | *true*                                                                                                             | :heavy_check_mark:                                                                                                 | N/A                                                                                                                |