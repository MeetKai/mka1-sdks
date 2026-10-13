# GetClassifyUsageResponseBody

OK

## Example Usage

```typescript
import { GetClassifyUsageResponseBody } from "@meetkai/mka1/models/operations";

let value: GetClassifyUsageResponseBody = {
  object: "page",
  data: [
    {
      object: "bucket",
      startTime: 13150,
      endTime: 662892,
      results: [
        "<value 1>",
        "<value 2>",
        "<value 3>",
      ],
    },
  ],
  hasMore: false,
  nextPage: "<value>",
};
```

## Fields

| Field                                                                                | Type                                                                                 | Required                                                                             | Description                                                                          |
| ------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------ |
| `object`                                                                             | *"page"*                                                                             | :heavy_check_mark:                                                                   | N/A                                                                                  |
| `data`                                                                               | [operations.GetClassifyUsageData](../../models/operations/getclassifyusagedata.md)[] | :heavy_check_mark:                                                                   | N/A                                                                                  |
| `hasMore`                                                                            | *boolean*                                                                            | :heavy_check_mark:                                                                   | Whether there are more pages                                                         |
| `nextPage`                                                                           | *string*                                                                             | :heavy_check_mark:                                                                   | Cursor for next page, null if no more pages                                          |