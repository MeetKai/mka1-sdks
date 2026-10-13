# AgentSchedule

## Example Usage

```typescript
import { AgentSchedule } from "@meetkai/mka1/models/components";

let value: AgentSchedule = {
  object: "agent.schedule",
  id: "<id>",
  agentId: "<id>",
  name: "<value>",
  status: "paused",
  schedule: {
    type: "interval",
    intervalSeconds: 442240,
    timezone: "UTC",
  },
  input: "<value>",
  conversation: "<value>",
  previousResponseId: "<id>",
  contextManagement: [
    {
      type: "compaction",
      compactThreshold: 291374,
    },
  ],
  metadata: {
    "key": "<value>",
  },
  temporalScheduleId: "<id>",
  lastRunAt: new Date("2026-11-30T08:57:59.157Z"),
  lastRunId: "<id>",
  runCount: 295934,
  createdAt: new Date("2025-02-06T21:08:51.662Z"),
  updatedAt: new Date("2025-04-18T04:19:59.461Z"),
  deletedAt: new Date("2024-12-12T19:24:33.815Z"),
};
```

## Fields

| Field                                                                                                        | Type                                                                                                         | Required                                                                                                     | Description                                                                                                  |
| ------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------ |
| `object`                                                                                                     | [components.AgentScheduleObject](../../models/components/agentscheduleobject.md)                             | :heavy_check_mark:                                                                                           | N/A                                                                                                          |
| `id`                                                                                                         | *string*                                                                                                     | :heavy_check_mark:                                                                                           | N/A                                                                                                          |
| `agentId`                                                                                                    | *string*                                                                                                     | :heavy_check_mark:                                                                                           | N/A                                                                                                          |
| `name`                                                                                                       | *string*                                                                                                     | :heavy_check_mark:                                                                                           | N/A                                                                                                          |
| `status`                                                                                                     | [components.AgentScheduleStatus](../../models/components/agentschedulestatus.md)                             | :heavy_check_mark:                                                                                           | N/A                                                                                                          |
| `schedule`                                                                                                   | *components.AgentScheduleSpec*                                                                               | :heavy_check_mark:                                                                                           | N/A                                                                                                          |
| `input`                                                                                                      | *any*                                                                                                        | :heavy_check_mark:                                                                                           | Arbitrary JSON value.                                                                                        |
| `conversation`                                                                                               | *any*                                                                                                        | :heavy_check_mark:                                                                                           | N/A                                                                                                          |
| `previousResponseId`                                                                                         | *string*                                                                                                     | :heavy_check_mark:                                                                                           | N/A                                                                                                          |
| `contextManagement`                                                                                          | [components.AgentCompactionContextManagement](../../models/components/agentcompactioncontextmanagement.md)[] | :heavy_check_mark:                                                                                           | N/A                                                                                                          |
| `metadata`                                                                                                   | Record<string, *string*>                                                                                     | :heavy_check_mark:                                                                                           | N/A                                                                                                          |
| `temporalScheduleId`                                                                                         | *string*                                                                                                     | :heavy_check_mark:                                                                                           | N/A                                                                                                          |
| `lastRunAt`                                                                                                  | [Date](https://developer.mozilla.org/en-US/docs/Web/JavaScript/Reference/Global_Objects/Date)                | :heavy_check_mark:                                                                                           | N/A                                                                                                          |
| `lastRunId`                                                                                                  | *string*                                                                                                     | :heavy_check_mark:                                                                                           | N/A                                                                                                          |
| `runCount`                                                                                                   | *number*                                                                                                     | :heavy_check_mark:                                                                                           | N/A                                                                                                          |
| `createdAt`                                                                                                  | [Date](https://developer.mozilla.org/en-US/docs/Web/JavaScript/Reference/Global_Objects/Date)                | :heavy_check_mark:                                                                                           | N/A                                                                                                          |
| `updatedAt`                                                                                                  | [Date](https://developer.mozilla.org/en-US/docs/Web/JavaScript/Reference/Global_Objects/Date)                | :heavy_check_mark:                                                                                           | N/A                                                                                                          |
| `deletedAt`                                                                                                  | [Date](https://developer.mozilla.org/en-US/docs/Web/JavaScript/Reference/Global_Objects/Date)                | :heavy_check_mark:                                                                                           | N/A                                                                                                          |