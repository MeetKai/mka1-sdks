# AgentScheduleSpec1

## Example Usage

```typescript
import { AgentScheduleSpec1 } from "@meetkai/mka1/models/components";

let value: AgentScheduleSpec1 = {
  type: "once",
  runAt: new Date("2025-10-03T08:36:07.015Z"),
};
```

## Fields

| Field                                                                                         | Type                                                                                          | Required                                                                                      | Description                                                                                   |
| --------------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------------- |
| `type`                                                                                        | *"once"*                                                                                      | :heavy_check_mark:                                                                            | N/A                                                                                           |
| `runAt`                                                                                       | [Date](https://developer.mozilla.org/en-US/docs/Web/JavaScript/Reference/Global_Objects/Date) | :heavy_check_mark:                                                                            | N/A                                                                                           |
| `timezone`                                                                                    | *string*                                                                                      | :heavy_minus_sign:                                                                            | N/A                                                                                           |