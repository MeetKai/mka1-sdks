# DeleteTeamDefaultBudgetResponseBody

OK

## Example Usage

```typescript
import { DeleteTeamDefaultBudgetResponseBody } from "@meetkai/mka1/models/operations";

let value: DeleteTeamDefaultBudgetResponseBody = {
  scope: "apikey",
  scopeId: "<id>",
  owner: "cluster",
  deleted: true,
};
```

## Fields

| Field                                                                                              | Type                                                                                               | Required                                                                                           | Description                                                                                        |
| -------------------------------------------------------------------------------------------------- | -------------------------------------------------------------------------------------------------- | -------------------------------------------------------------------------------------------------- | -------------------------------------------------------------------------------------------------- |
| `scope`                                                                                            | [operations.DeleteTeamDefaultBudgetScope](../../models/operations/deleteteamdefaultbudgetscope.md) | :heavy_check_mark:                                                                                 | N/A                                                                                                |
| `scopeId`                                                                                          | *string*                                                                                           | :heavy_check_mark:                                                                                 | N/A                                                                                                |
| `owner`                                                                                            | [operations.DeleteTeamDefaultBudgetOwner](../../models/operations/deleteteamdefaultbudgetowner.md) | :heavy_check_mark:                                                                                 | N/A                                                                                                |
| `deleted`                                                                                          | *true*                                                                                             | :heavy_check_mark:                                                                                 | N/A                                                                                                |