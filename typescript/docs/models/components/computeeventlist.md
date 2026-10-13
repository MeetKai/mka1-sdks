# ComputeEventList

## Example Usage

```typescript
import { ComputeEventList } from "@meetkai/mka1/models/components";

let value: ComputeEventList = {
  nextCursor: "<value>",
  total: 87029,
  data: [
    {
      data: {},
      id: "<id>",
      timestamp: new Date("2024-03-11T06:20:30.630Z"),
      type: "<value>",
    },
  ],
};
```

## Fields

| Field                                                                | Type                                                                 | Required                                                             | Description                                                          |
| -------------------------------------------------------------------- | -------------------------------------------------------------------- | -------------------------------------------------------------------- | -------------------------------------------------------------------- |
| `nextCursor`                                                         | *string*                                                             | :heavy_check_mark:                                                   | N/A                                                                  |
| `total`                                                              | *number*                                                             | :heavy_check_mark:                                                   | N/A                                                                  |
| `data`                                                               | [components.ComputeEvent](../../models/components/computeevent.md)[] | :heavy_check_mark:                                                   | N/A                                                                  |