# TriggerEvalScheduleResponseBody

OK

## Example Usage

```typescript
import { TriggerEvalScheduleResponseBody } from "@meetkai/mka1/models/operations";

let value: TriggerEvalScheduleResponseBody = {
  id: "<id>",
  object: "eval.schedule",
  name: "<value>",
  description: "obligation while aw equally inwardly gee sit critical inborn",
  suiteId: "<id>",
  suiteVersion: 617233,
  cron: null,
  intervalSeconds: 162002,
  timezone: "America/Tijuana",
  overlapPolicy: "buffer_one",
  enabled: true,
  webhookUrl: "https://round-remark.com",
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
  },
  lastRunId: "<id>",
  lastRunAt: 177953,
  lastRunStatus: null,
  nextRunAt: 604817,
  createdAt: 749697,
  updatedAt: 546197,
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
| `run`                                                                                                                      | [operations.TriggerEvalScheduleRun](../../models/operations/triggerevalschedulerun.md)                                     | :heavy_check_mark:                                                                                                         | Persisted schedule run configuration. Unknown stored fields remain readable without becoming supported execution controls. |
| `metadata`                                                                                                                 | Record<string, *string*>                                                                                                   | :heavy_check_mark:                                                                                                         | N/A                                                                                                                        |
| `lastRunId`                                                                                                                | *string*                                                                                                                   | :heavy_check_mark:                                                                                                         | N/A                                                                                                                        |
| `lastRunAt`                                                                                                                | *number*                                                                                                                   | :heavy_check_mark:                                                                                                         | N/A                                                                                                                        |
| `lastRunStatus`                                                                                                            | *string*                                                                                                                   | :heavy_check_mark:                                                                                                         | N/A                                                                                                                        |
| `nextRunAt`                                                                                                                | *number*                                                                                                                   | :heavy_check_mark:                                                                                                         | Next scheduled fire time from Temporal, when resolvable.                                                                   |
| `createdAt`                                                                                                                | *number*                                                                                                                   | :heavy_check_mark:                                                                                                         | N/A                                                                                                                        |
| `updatedAt`                                                                                                                | *number*                                                                                                                   | :heavy_check_mark:                                                                                                         | N/A                                                                                                                        |