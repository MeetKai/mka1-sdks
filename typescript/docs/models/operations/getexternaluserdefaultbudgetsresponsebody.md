# GetExternalUserDefaultBudgetsResponseBody

OK

## Example Usage

```typescript
import { GetExternalUserDefaultBudgetsResponseBody } from "@meetkai/mka1/models/operations";

let value: GetExternalUserDefaultBudgetsResponseBody = {
  object: "list",
  data: [
    {
      id: "<id>",
      scope: "team",
      scopeId: "<id>",
      scopeOrgId: "<id>",
      owner: "org",
      period: "daily",
      limit: 9456.68,
      thresholds: [],
      alertWebhookUrl: "https://bulky-pupil.org/",
    },
  ],
};
```

## Fields

| Field                                                                                                          | Type                                                                                                           | Required                                                                                                       | Description                                                                                                    |
| -------------------------------------------------------------------------------------------------------------- | -------------------------------------------------------------------------------------------------------------- | -------------------------------------------------------------------------------------------------------------- | -------------------------------------------------------------------------------------------------------------- |
| `object`                                                                                                       | *"list"*                                                                                                       | :heavy_check_mark:                                                                                             | N/A                                                                                                            |
| `data`                                                                                                         | [operations.GetExternalUserDefaultBudgetsData](../../models/operations/getexternaluserdefaultbudgetsdata.md)[] | :heavy_check_mark:                                                                                             | N/A                                                                                                            |