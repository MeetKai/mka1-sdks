# AgentScheduleSpec2

## Example Usage

```typescript
import { AgentScheduleSpec2 } from "@meetkai/mka1/models/components";

let value: AgentScheduleSpec2 = {
  type: "interval",
  intervalSeconds: 604000,
};
```

## Fields

| Field                                                                                         | Type                                                                                          | Required                                                                                      | Description                                                                                   |
| --------------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------------- |
| `type`                                                                                        | *"interval"*                                                                                  | :heavy_check_mark:                                                                            | N/A                                                                                           |
| `intervalSeconds`                                                                             | *number*                                                                                      | :heavy_check_mark:                                                                            | N/A                                                                                           |
| `startAt`                                                                                     | [Date](https://developer.mozilla.org/en-US/docs/Web/JavaScript/Reference/Global_Objects/Date) | :heavy_minus_sign:                                                                            | N/A                                                                                           |
| `timezone`                                                                                    | *string*                                                                                      | :heavy_minus_sign:                                                                            | N/A                                                                                           |