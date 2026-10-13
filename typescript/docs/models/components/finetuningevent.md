# FineTuningEvent

## Example Usage

```typescript
import { FineTuningEvent } from "@meetkai/mka1/models/components";

let value: FineTuningEvent = {
  id: "<id>",
  object: "fine_tuning.job.event",
  createdAt: 895401,
  level: "warn",
  message: "<value>",
};
```

## Fields

| Field                                                                            | Type                                                                             | Required                                                                         | Description                                                                      |
| -------------------------------------------------------------------------------- | -------------------------------------------------------------------------------- | -------------------------------------------------------------------------------- | -------------------------------------------------------------------------------- |
| `id`                                                                             | *string*                                                                         | :heavy_check_mark:                                                               | N/A                                                                              |
| `object`                                                                         | *"fine_tuning.job.event"*                                                        | :heavy_check_mark:                                                               | N/A                                                                              |
| `createdAt`                                                                      | *number*                                                                         | :heavy_check_mark:                                                               | N/A                                                                              |
| `level`                                                                          | [components.Level](../../models/components/level.md)                             | :heavy_check_mark:                                                               | N/A                                                                              |
| `message`                                                                        | *string*                                                                         | :heavy_check_mark:                                                               | N/A                                                                              |
| `type`                                                                           | [components.FineTuningEventType](../../models/components/finetuningeventtype.md) | :heavy_minus_sign:                                                               | N/A                                                                              |
| `data`                                                                           | Record<string, *any*>                                                            | :heavy_minus_sign:                                                               | N/A                                                                              |