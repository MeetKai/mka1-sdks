# UpdateEvalScheduleResponseBody

OK

## Example Usage

```typescript
import { UpdateEvalScheduleResponseBody } from "@meetkai/mka1/models/operations";

let value: UpdateEvalScheduleResponseBody = {
  id: "<id>",
  object: "eval.schedule",
  name: "<value>",
  description:
    "tousle perfectly best-seller likewise mostly ew function besides woot",
  suiteId: "<id>",
  suiteVersion: 498266,
  cron: "<value>",
  intervalSeconds: 767786,
  timezone: "America/Guyana",
  overlapPolicy: "buffer_one",
  enabled: false,
  webhookUrl: "https://strict-elver.name",
  webhookConfigured: true,
  run: {
    models: [],
  },
  metadata: {
    "key": "<value>",
  },
  lastRunId: "<id>",
  lastRunAt: 538925,
  lastRunStatus: "<value>",
  nextRunAt: 180908,
  createdAt: 888245,
  updatedAt: 794962,
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
| `run`                                                                                                                      | [operations.UpdateEvalScheduleRun](../../models/operations/updateevalschedulerun.md)                                       | :heavy_check_mark:                                                                                                         | Persisted schedule run configuration. Unknown stored fields remain readable without becoming supported execution controls. |
| `metadata`                                                                                                                 | Record<string, *string*>                                                                                                   | :heavy_check_mark:                                                                                                         | N/A                                                                                                                        |
| `lastRunId`                                                                                                                | *string*                                                                                                                   | :heavy_check_mark:                                                                                                         | N/A                                                                                                                        |
| `lastRunAt`                                                                                                                | *number*                                                                                                                   | :heavy_check_mark:                                                                                                         | N/A                                                                                                                        |
| `lastRunStatus`                                                                                                            | *string*                                                                                                                   | :heavy_check_mark:                                                                                                         | N/A                                                                                                                        |
| `nextRunAt`                                                                                                                | *number*                                                                                                                   | :heavy_check_mark:                                                                                                         | Next scheduled fire time from Temporal, when resolvable.                                                                   |
| `createdAt`                                                                                                                | *number*                                                                                                                   | :heavy_check_mark:                                                                                                         | N/A                                                                                                                        |
| `updatedAt`                                                                                                                | *number*                                                                                                                   | :heavy_check_mark:                                                                                                         | N/A                                                                                                                        |