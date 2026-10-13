# GetTeamDefaultBudgetsResponseBody

OK

## Example Usage

```typescript
import { GetTeamDefaultBudgetsResponseBody } from "@meetkai/mka1/models/operations";

let value: GetTeamDefaultBudgetsResponseBody = {
  object: "list",
  data: [
    {
      id: "<id>",
      scope: "external_user_default",
      scopeId: "<id>",
      scopeOrgId: "<id>",
      owner: "org",
      period: "daily",
      limit: 2124.11,
      thresholds: [],
      alertWebhookUrl: "https://urban-gym.com",
    },
  ],
};
```

## Fields

| Field                                                                                          | Type                                                                                           | Required                                                                                       | Description                                                                                    |
| ---------------------------------------------------------------------------------------------- | ---------------------------------------------------------------------------------------------- | ---------------------------------------------------------------------------------------------- | ---------------------------------------------------------------------------------------------- |
| `object`                                                                                       | *"list"*                                                                                       | :heavy_check_mark:                                                                             | N/A                                                                                            |
| `data`                                                                                         | [operations.GetTeamDefaultBudgetsData](../../models/operations/getteamdefaultbudgetsdata.md)[] | :heavy_check_mark:                                                                             | N/A                                                                                            |