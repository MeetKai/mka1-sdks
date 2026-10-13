# GetFilesUsageResponseBody

OK

## Example Usage

```typescript
import { GetFilesUsageResponseBody } from "@meetkai/mka1/models/operations";

let value: GetFilesUsageResponseBody = {
  object: "page",
  data: [
    {
      object: "bucket",
      startTime: 811432,
      endTime: 407006,
      results: [
        "<value 1>",
        "<value 2>",
      ],
    },
  ],
  hasMore: false,
  nextPage: "<value>",
};
```

## Fields

| Field                                                                          | Type                                                                           | Required                                                                       | Description                                                                    |
| ------------------------------------------------------------------------------ | ------------------------------------------------------------------------------ | ------------------------------------------------------------------------------ | ------------------------------------------------------------------------------ |
| `object`                                                                       | *"page"*                                                                       | :heavy_check_mark:                                                             | N/A                                                                            |
| `data`                                                                         | [operations.GetFilesUsageData](../../models/operations/getfilesusagedata.md)[] | :heavy_check_mark:                                                             | N/A                                                                            |
| `hasMore`                                                                      | *boolean*                                                                      | :heavy_check_mark:                                                             | Whether there are more pages                                                   |
| `nextPage`                                                                     | *string*                                                                       | :heavy_check_mark:                                                             | Cursor for next page, null if no more pages                                    |