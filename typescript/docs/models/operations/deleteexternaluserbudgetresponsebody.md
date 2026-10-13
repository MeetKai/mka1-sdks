# DeleteExternalUserBudgetResponseBody

OK

## Example Usage

```typescript
import { DeleteExternalUserBudgetResponseBody } from "@meetkai/mka1/models/operations";

let value: DeleteExternalUserBudgetResponseBody = {
  scope: "org",
  scopeId: "<id>",
  owner: "org",
  deleted: true,
};
```

## Fields

| Field                                                                                                | Type                                                                                                 | Required                                                                                             | Description                                                                                          |
| ---------------------------------------------------------------------------------------------------- | ---------------------------------------------------------------------------------------------------- | ---------------------------------------------------------------------------------------------------- | ---------------------------------------------------------------------------------------------------- |
| `scope`                                                                                              | [operations.DeleteExternalUserBudgetScope](../../models/operations/deleteexternaluserbudgetscope.md) | :heavy_check_mark:                                                                                   | N/A                                                                                                  |
| `scopeId`                                                                                            | *string*                                                                                             | :heavy_check_mark:                                                                                   | N/A                                                                                                  |
| `owner`                                                                                              | [operations.DeleteExternalUserBudgetOwner](../../models/operations/deleteexternaluserbudgetowner.md) | :heavy_check_mark:                                                                                   | N/A                                                                                                  |
| `deleted`                                                                                            | *true*                                                                                               | :heavy_check_mark:                                                                                   | N/A                                                                                                  |