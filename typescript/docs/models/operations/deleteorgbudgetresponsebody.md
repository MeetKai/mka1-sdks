# DeleteOrgBudgetResponseBody

OK

## Example Usage

```typescript
import { DeleteOrgBudgetResponseBody } from "@meetkai/mka1/models/operations";

let value: DeleteOrgBudgetResponseBody = {
  scope: "external_user_default",
  scopeId: "<id>",
  owner: "cluster",
  deleted: true,
};
```

## Fields

| Field                                                                              | Type                                                                               | Required                                                                           | Description                                                                        |
| ---------------------------------------------------------------------------------- | ---------------------------------------------------------------------------------- | ---------------------------------------------------------------------------------- | ---------------------------------------------------------------------------------- |
| `scope`                                                                            | [operations.DeleteOrgBudgetScope](../../models/operations/deleteorgbudgetscope.md) | :heavy_check_mark:                                                                 | N/A                                                                                |
| `scopeId`                                                                          | *string*                                                                           | :heavy_check_mark:                                                                 | N/A                                                                                |
| `owner`                                                                            | [operations.DeleteOrgBudgetOwner](../../models/operations/deleteorgbudgetowner.md) | :heavy_check_mark:                                                                 | N/A                                                                                |
| `deleted`                                                                          | *true*                                                                             | :heavy_check_mark:                                                                 | N/A                                                                                |