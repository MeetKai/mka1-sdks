# GetUserDefaultBudgetsResponseBody

OK

## Example Usage

```typescript
import { GetUserDefaultBudgetsResponseBody } from "@meetkai/mka1/models/operations";

let value: GetUserDefaultBudgetsResponseBody = {
  object: "list",
  data: [
    {
      id: "<id>",
      scope: "org",
      scopeId: "<id>",
      scopeOrgId: "<id>",
      owner: "cluster",
      period: "monthly",
      limit: 7738.37,
      thresholds: [
        {
          pct: 108911,
          action: "block",
        },
      ],
      alertWebhookUrl: "https://unwritten-adviser.info/",
    },
  ],
};
```

## Fields

| Field                                                                                          | Type                                                                                           | Required                                                                                       | Description                                                                                    |
| ---------------------------------------------------------------------------------------------- | ---------------------------------------------------------------------------------------------- | ---------------------------------------------------------------------------------------------- | ---------------------------------------------------------------------------------------------- |
| `object`                                                                                       | *"list"*                                                                                       | :heavy_check_mark:                                                                             | N/A                                                                                            |
| `data`                                                                                         | [operations.GetUserDefaultBudgetsData](../../models/operations/getuserdefaultbudgetsdata.md)[] | :heavy_check_mark:                                                                             | N/A                                                                                            |