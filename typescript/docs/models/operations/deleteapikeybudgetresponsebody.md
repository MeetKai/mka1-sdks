# DeleteApiKeyBudgetResponseBody

OK

## Example Usage

```typescript
import { DeleteApiKeyBudgetResponseBody } from "@meetkai/mka1/models/operations";

let value: DeleteApiKeyBudgetResponseBody = {
  scope: "apikey",
  scopeId: "<id>",
  owner: "cluster",
  deleted: true,
};
```

## Fields

| Field                                                                                    | Type                                                                                     | Required                                                                                 | Description                                                                              |
| ---------------------------------------------------------------------------------------- | ---------------------------------------------------------------------------------------- | ---------------------------------------------------------------------------------------- | ---------------------------------------------------------------------------------------- |
| `scope`                                                                                  | [operations.DeleteApiKeyBudgetScope](../../models/operations/deleteapikeybudgetscope.md) | :heavy_check_mark:                                                                       | N/A                                                                                      |
| `scopeId`                                                                                | *string*                                                                                 | :heavy_check_mark:                                                                       | N/A                                                                                      |
| `owner`                                                                                  | [operations.DeleteApiKeyBudgetOwner](../../models/operations/deleteapikeybudgetowner.md) | :heavy_check_mark:                                                                       | N/A                                                                                      |
| `deleted`                                                                                | *true*                                                                                   | :heavy_check_mark:                                                                       | N/A                                                                                      |