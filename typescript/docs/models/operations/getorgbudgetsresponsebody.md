# GetOrgBudgetsResponseBody

OK

## Example Usage

```typescript
import { GetOrgBudgetsResponseBody } from "@meetkai/mka1/models/operations";

let value: GetOrgBudgetsResponseBody = {
  object: "list",
  data: [
    {
      id: "<id>",
      scope: "user",
      scopeId: "<id>",
      scopeOrgId: "<id>",
      owner: "cluster",
      period: "daily",
      limit: 4914.23,
      thresholds: [],
      alertWebhookUrl: "https://afraid-invite.com/",
      spend: {
        window: "<value>",
        costSpent: 1036.17,
        limit: 2756.86,
        pct: 825341,
        status: "ok",
      },
    },
  ],
};
```

## Fields

| Field                                                                          | Type                                                                           | Required                                                                       | Description                                                                    |
| ------------------------------------------------------------------------------ | ------------------------------------------------------------------------------ | ------------------------------------------------------------------------------ | ------------------------------------------------------------------------------ |
| `object`                                                                       | *"list"*                                                                       | :heavy_check_mark:                                                             | N/A                                                                            |
| `data`                                                                         | [operations.GetOrgBudgetsData](../../models/operations/getorgbudgetsdata.md)[] | :heavy_check_mark:                                                             | N/A                                                                            |