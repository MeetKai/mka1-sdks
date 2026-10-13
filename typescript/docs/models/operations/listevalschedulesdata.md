# ListEvalSchedulesData

## Example Usage

```typescript
import { ListEvalSchedulesData } from "@meetkai/mka1/models/operations";

let value: ListEvalSchedulesData = {
  id: "<id>",
  object: "eval.schedule",
  name: "<value>",
  description: "stake tasty likewise doubtfully",
  suiteId: "<id>",
  suiteVersion: 262050,
  cron: "<value>",
  intervalSeconds: 517319,
  timezone: "Pacific/Nauru",
  overlapPolicy: "allow_all",
  enabled: true,
  webhookUrl: "https://alienated-validity.org",
  webhookConfigured: false,
  run: {
    models: [
      "<value 1>",
      "<value 2>",
    ],
  },
  metadata: {
    "key": "<value>",
    "key1": "<value>",
    "key2": "<value>",
  },
  lastRunId: "<id>",
  lastRunAt: 480952,
  lastRunStatus: "<value>",
  nextRunAt: 755280,
  createdAt: 287112,
  updatedAt: 843013,
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
| `run`                                                                                                                      | [operations.ListEvalSchedulesRun](../../models/operations/listevalschedulesrun.md)                                         | :heavy_check_mark:                                                                                                         | Persisted schedule run configuration. Unknown stored fields remain readable without becoming supported execution controls. |
| `metadata`                                                                                                                 | Record<string, *string*>                                                                                                   | :heavy_check_mark:                                                                                                         | N/A                                                                                                                        |
| `lastRunId`                                                                                                                | *string*                                                                                                                   | :heavy_check_mark:                                                                                                         | N/A                                                                                                                        |
| `lastRunAt`                                                                                                                | *number*                                                                                                                   | :heavy_check_mark:                                                                                                         | N/A                                                                                                                        |
| `lastRunStatus`                                                                                                            | *string*                                                                                                                   | :heavy_check_mark:                                                                                                         | N/A                                                                                                                        |
| `nextRunAt`                                                                                                                | *number*                                                                                                                   | :heavy_check_mark:                                                                                                         | Next scheduled fire time from Temporal, when resolvable.                                                                   |
| `createdAt`                                                                                                                | *number*                                                                                                                   | :heavy_check_mark:                                                                                                         | N/A                                                                                                                        |
| `updatedAt`                                                                                                                | *number*                                                                                                                   | :heavy_check_mark:                                                                                                         | N/A                                                                                                                        |