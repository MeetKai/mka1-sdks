# CreateEvalScheduleResponseBody

OK

## Example Usage

```typescript
import { CreateEvalScheduleResponseBody } from "@meetkai/mka1/models/operations";

let value: CreateEvalScheduleResponseBody = {
  id: "<id>",
  object: "eval.schedule",
  name: "<value>",
  description: "mmm abaft compete",
  suiteId: "<id>",
  suiteVersion: 440222,
  cron: "<value>",
  intervalSeconds: 903572,
  timezone: "Asia/Yerevan",
  overlapPolicy: "buffer_one",
  enabled: true,
  webhookUrl: "https://general-step.name/",
  webhookConfigured: false,
  run: {
    models: [
      "<value 1>",
      "<value 2>",
      "<value 3>",
    ],
  },
  metadata: {
    "key": "<value>",
    "key1": "<value>",
  },
  lastRunId: "<id>",
  lastRunAt: 303041,
  lastRunStatus: "<value>",
  nextRunAt: 582494,
  createdAt: 492894,
  updatedAt: 247741,
};
```

## Fields

| Field                                                                                                                      | Type                                                                                                                       | Required                                                                                                                   | Description                                                                                                                |
| -------------------------------------------------------------------------------------------------------------------------- | -------------------------------------------------------------------------------------------------------------------------- | -------------------------------------------------------------------------------------------------------------------------- | -------------------------------------------------------------------------------------------------------------------------- |
| `id`                                                                                                                       | *string*                                                                                                                   | :heavy_check_mark:                                                                                                         | N/A                                                                                                                        |
| `object`                                                                                                                   | *"eval.schedule"*                                                                                                          | :heavy_check_mark:                                                                                                         | N/A                                                                                                                        |
| `name`                                                                                                                     | *string*                                                                                                                   | :heavy_check_mark:                                                                                                         | N/A                                                                                                                        |
| `description`                                                                                                              | *string*                                                                                                                   | :heavy_check_mark:                                                                                                         | N/A                                                                                                                        |
| `suiteId`                                                                                                                  | *string*                                                                                                                   | :heavy_check_mark:                                                                                                         | N/A                                                                                                                        |
| `suiteVersion`                                                                                                             | *number*                                                                                                                   | :heavy_check_mark:                                                                                                         | N/A                                                                                                                        |
| `cron`                                                                                                                     | *string*                                                                                                                   | :heavy_check_mark:                                                                                                         | N/A                                                                                                                        |
| `intervalSeconds`                                                                                                          | *number*                                                                                                                   | :heavy_check_mark:                                                                                                         | N/A                                                                                                                        |
| `timezone`                                                                                                                 | *string*                                                                                                                   | :heavy_check_mark:                                                                                                         | N/A                                                                                                                        |
| `overlapPolicy`                                                                                                            | [components.EvalScheduleOverlapPolicy](../../models/components/evalscheduleoverlappolicy.md)                               | :heavy_check_mark:                                                                                                         | N/A                                                                                                                        |
| `enabled`                                                                                                                  | *boolean*                                                                                                                  | :heavy_check_mark:                                                                                                         | N/A                                                                                                                        |
| `webhookUrl`                                                                                                               | *string*                                                                                                                   | :heavy_check_mark:                                                                                                         | N/A                                                                                                                        |
| `webhookConfigured`                                                                                                        | *boolean*                                                                                                                  | :heavy_check_mark:                                                                                                         | True when a signing secret is stored. The secret itself is never returned.                                                 |
| `run`                                                                                                                      | [operations.Run](../../models/operations/run.md)                                                                           | :heavy_check_mark:                                                                                                         | Persisted schedule run configuration. Unknown stored fields remain readable without becoming supported execution controls. |
| `metadata`                                                                                                                 | Record<string, *string*>                                                                                                   | :heavy_check_mark:                                                                                                         | N/A                                                                                                                        |
| `lastRunId`                                                                                                                | *string*                                                                                                                   | :heavy_check_mark:                                                                                                         | N/A                                                                                                                        |
| `lastRunAt`                                                                                                                | *number*                                                                                                                   | :heavy_check_mark:                                                                                                         | N/A                                                                                                                        |
| `lastRunStatus`                                                                                                            | *string*                                                                                                                   | :heavy_check_mark:                                                                                                         | N/A                                                                                                                        |
| `nextRunAt`                                                                                                                | *number*                                                                                                                   | :heavy_check_mark:                                                                                                         | Next scheduled fire time from Temporal, when resolvable.                                                                   |
| `createdAt`                                                                                                                | *number*                                                                                                                   | :heavy_check_mark:                                                                                                         | N/A                                                                                                                        |
| `updatedAt`                                                                                                                | *number*                                                                                                                   | :heavy_check_mark:                                                                                                         | N/A                                                                                                                        |