# CreateEvalScheduleRequest

## Example Usage

```typescript
import { CreateEvalScheduleRequest } from "@meetkai/mka1/models/components";

let value: CreateEvalScheduleRequest = {
  name: "<value>",
  suiteId: "<id>",
  run: {
    models: [],
  },
};
```

## Fields

| Field                                                                                              | Type                                                                                               | Required                                                                                           | Description                                                                                        |
| -------------------------------------------------------------------------------------------------- | -------------------------------------------------------------------------------------------------- | -------------------------------------------------------------------------------------------------- | -------------------------------------------------------------------------------------------------- |
| `name`                                                                                             | *string*                                                                                           | :heavy_check_mark:                                                                                 | N/A                                                                                                |
| `description`                                                                                      | *string*                                                                                           | :heavy_minus_sign:                                                                                 | N/A                                                                                                |
| `suiteId`                                                                                          | *string*                                                                                           | :heavy_check_mark:                                                                                 | N/A                                                                                                |
| `suiteVersion`                                                                                     | *number*                                                                                           | :heavy_minus_sign:                                                                                 | Pin a suite version. Omit to resolve the active version on each fire.                              |
| `cron`                                                                                             | *string*                                                                                           | :heavy_minus_sign:                                                                                 | 5-field cron expression. Provide exactly one of cron or interval_seconds.                          |
| `intervalSeconds`                                                                                  | *number*                                                                                           | :heavy_minus_sign:                                                                                 | Fixed interval between fires, in seconds. Provide exactly one of cron or interval_seconds.         |
| `timezone`                                                                                         | *string*                                                                                           | :heavy_minus_sign:                                                                                 | IANA timezone applied to cron expressions, for example US/Pacific.                                 |
| `overlapPolicy`                                                                                    | [components.EvalScheduleOverlapPolicy](../../models/components/evalscheduleoverlappolicy.md)       | :heavy_minus_sign:                                                                                 | N/A                                                                                                |
| `enabled`                                                                                          | *boolean*                                                                                          | :heavy_minus_sign:                                                                                 | When false, the schedule is created paused.                                                        |
| `webhookUrl`                                                                                       | *string*                                                                                           | :heavy_minus_sign:                                                                                 | HTTPS endpoint notified of run status transitions.                                                 |
| `webhookSecret`                                                                                    | *string*                                                                                           | :heavy_minus_sign:                                                                                 | Secret used to HMAC-SHA256 sign webhook payloads.                                                  |
| `run`                                                                                              | [components.EvalScheduleRunRequestConfig](../../models/components/evalschedulerunrequestconfig.md) | :heavy_check_mark:                                                                                 | N/A                                                                                                |
| `metadata`                                                                                         | Record<string, *string*>                                                                           | :heavy_minus_sign:                                                                                 | N/A                                                                                                |