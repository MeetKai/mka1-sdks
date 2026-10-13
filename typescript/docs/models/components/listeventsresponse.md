# ListEventsResponse

## Example Usage

```typescript
import { ListEventsResponse } from "@meetkai/mka1/models/components";

let value: ListEventsResponse = {
  object: "list",
  data: [
    {
      id: "<id>",
      object: "fine_tuning.job.event",
      createdAt: 402632,
      level: "info",
      message: "<value>",
    },
  ],
  hasMore: false,
};
```

## Fields

| Field                                                                      | Type                                                                       | Required                                                                   | Description                                                                |
| -------------------------------------------------------------------------- | -------------------------------------------------------------------------- | -------------------------------------------------------------------------- | -------------------------------------------------------------------------- |
| `object`                                                                   | *"list"*                                                                   | :heavy_check_mark:                                                         | N/A                                                                        |
| `data`                                                                     | [components.FineTuningEvent](../../models/components/finetuningevent.md)[] | :heavy_check_mark:                                                         | N/A                                                                        |
| `hasMore`                                                                  | *boolean*                                                                  | :heavy_check_mark:                                                         | N/A                                                                        |