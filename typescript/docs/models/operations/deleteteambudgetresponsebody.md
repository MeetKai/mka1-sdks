# DeleteTeamBudgetResponseBody

OK

## Example Usage

```typescript
import { DeleteTeamBudgetResponseBody } from "@meetkai/mka1/models/operations";

let value: DeleteTeamBudgetResponseBody = {
  scope: "team",
  scopeId: "<id>",
  owner: "org",
  deleted: true,
};
```

## Fields

| Field                                                                                | Type                                                                                 | Required                                                                             | Description                                                                          |
| ------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------ |
| `scope`                                                                              | [operations.DeleteTeamBudgetScope](../../models/operations/deleteteambudgetscope.md) | :heavy_check_mark:                                                                   | N/A                                                                                  |
| `scopeId`                                                                            | *string*                                                                             | :heavy_check_mark:                                                                   | N/A                                                                                  |
| `owner`                                                                              | [operations.DeleteTeamBudgetOwner](../../models/operations/deleteteambudgetowner.md) | :heavy_check_mark:                                                                   | N/A                                                                                  |
| `deleted`                                                                            | *true*                                                                               | :heavy_check_mark:                                                                   | N/A                                                                                  |