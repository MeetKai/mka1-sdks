# GetApiKeyBudgetsResponseBody

OK

## Example Usage

```typescript
import { GetApiKeyBudgetsResponseBody } from "@meetkai/mka1/models/operations";

let value: GetApiKeyBudgetsResponseBody = {
  object: "list",
  data: [
    {
      id: "<id>",
      scope: "team",
      scopeId: "<id>",
      scopeOrgId: "<id>",
      owner: "org",
      period: "monthly",
      limit: 9758.11,
      thresholds: [],
      alertWebhookUrl: "https://bright-strategy.biz/",
      spend: {
        window: "<value>",
        costSpent: 7311.25,
        limit: 3727.24,
        pct: 342301,
        status: "ok",
      },
    },
  ],
};
```

## Fields

| Field                                                                                | Type                                                                                 | Required                                                                             | Description                                                                          |
| ------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------ |
| `object`                                                                             | *"list"*                                                                             | :heavy_check_mark:                                                                   | N/A                                                                                  |
| `data`                                                                               | [operations.GetApiKeyBudgetsData](../../models/operations/getapikeybudgetsdata.md)[] | :heavy_check_mark:                                                                   | N/A                                                                                  |