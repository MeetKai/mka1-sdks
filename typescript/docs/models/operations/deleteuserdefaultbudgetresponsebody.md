# DeleteUserDefaultBudgetResponseBody

OK

## Example Usage

```typescript
import { DeleteUserDefaultBudgetResponseBody } from "@meetkai/mka1/models/operations";

let value: DeleteUserDefaultBudgetResponseBody = {
  scope: "external_user",
  scopeId: "<id>",
  owner: "cluster",
  deleted: true,
};
```

## Fields

| Field                                                                                              | Type                                                                                               | Required                                                                                           | Description                                                                                        |
| -------------------------------------------------------------------------------------------------- | -------------------------------------------------------------------------------------------------- | -------------------------------------------------------------------------------------------------- | -------------------------------------------------------------------------------------------------- |
| `scope`                                                                                            | [operations.DeleteUserDefaultBudgetScope](../../models/operations/deleteuserdefaultbudgetscope.md) | :heavy_check_mark:                                                                                 | N/A                                                                                                |
| `scopeId`                                                                                          | *string*                                                                                           | :heavy_check_mark:                                                                                 | N/A                                                                                                |
| `owner`                                                                                            | [operations.DeleteUserDefaultBudgetOwner](../../models/operations/deleteuserdefaultbudgetowner.md) | :heavy_check_mark:                                                                                 | N/A                                                                                                |
| `deleted`                                                                                          | *true*                                                                                             | :heavy_check_mark:                                                                                 | N/A                                                                                                |