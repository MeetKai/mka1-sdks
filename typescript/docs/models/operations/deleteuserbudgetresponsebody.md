# DeleteUserBudgetResponseBody

OK

## Example Usage

```typescript
import { DeleteUserBudgetResponseBody } from "@meetkai/mka1/models/operations";

let value: DeleteUserBudgetResponseBody = {
  scope: "user",
  scopeId: "<id>",
  owner: "cluster",
  deleted: true,
};
```

## Fields

| Field                                                                                | Type                                                                                 | Required                                                                             | Description                                                                          |
| ------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------ |
| `scope`                                                                              | [operations.DeleteUserBudgetScope](../../models/operations/deleteuserbudgetscope.md) | :heavy_check_mark:                                                                   | N/A                                                                                  |
| `scopeId`                                                                            | *string*                                                                             | :heavy_check_mark:                                                                   | N/A                                                                                  |
| `owner`                                                                              | [operations.DeleteUserBudgetOwner](../../models/operations/deleteuserbudgetowner.md) | :heavy_check_mark:                                                                   | N/A                                                                                  |
| `deleted`                                                                            | *true*                                                                               | :heavy_check_mark:                                                                   | N/A                                                                                  |