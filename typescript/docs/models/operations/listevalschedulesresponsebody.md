# ListEvalSchedulesResponseBody

OK

## Example Usage

```typescript
import { ListEvalSchedulesResponseBody } from "@meetkai/mka1/models/operations";

let value: ListEvalSchedulesResponseBody = {
  object: "list",
  data: [
    {
      id: "<id>",
      object: "eval.schedule",
      name: "<value>",
      description: "zowie yummy chunder sightseeing foolish thoroughly upsell",
      suiteId: "<id>",
      suiteVersion: 70350,
      cron: "<value>",
      intervalSeconds: 654389,
      timezone: "Asia/Ust-Nera",
      overlapPolicy: "allow_all",
      enabled: true,
      webhookUrl: "https://mean-conversation.org",
      webhookConfigured: false,
      run: {
        models: [
          "<value 1>",
          "<value 2>",
        ],
      },
      metadata: {},
      lastRunId: "<id>",
      lastRunAt: 930580,
      lastRunStatus: "<value>",
      nextRunAt: 281959,
      createdAt: 390498,
      updatedAt: 591350,
    },
  ],
  hasMore: false,
};
```

## Fields

| Field                                                                                  | Type                                                                                   | Required                                                                               | Description                                                                            |
| -------------------------------------------------------------------------------------- | -------------------------------------------------------------------------------------- | -------------------------------------------------------------------------------------- | -------------------------------------------------------------------------------------- |
| `object`                                                                               | *"list"*                                                                               | :heavy_check_mark:                                                                     | N/A                                                                                    |
| `data`                                                                                 | [operations.ListEvalSchedulesData](../../models/operations/listevalschedulesdata.md)[] | :heavy_check_mark:                                                                     | N/A                                                                                    |
| `firstId`                                                                              | *string*                                                                               | :heavy_minus_sign:                                                                     | N/A                                                                                    |
| `lastId`                                                                               | *string*                                                                               | :heavy_minus_sign:                                                                     | N/A                                                                                    |
| `hasMore`                                                                              | *boolean*                                                                              | :heavy_check_mark:                                                                     | N/A                                                                                    |