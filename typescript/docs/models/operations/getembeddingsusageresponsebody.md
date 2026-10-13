# GetEmbeddingsUsageResponseBody

OK

## Example Usage

```typescript
import { GetEmbeddingsUsageResponseBody } from "@meetkai/mka1/models/operations";

let value: GetEmbeddingsUsageResponseBody = {
  object: "page",
  data: [
    {
      object: "bucket",
      startTime: 876152,
      endTime: 326741,
      results: [
        "<value 1>",
        "<value 2>",
      ],
    },
  ],
  hasMore: true,
  nextPage: "<value>",
};
```

## Fields

| Field                                                                                    | Type                                                                                     | Required                                                                                 | Description                                                                              |
| ---------------------------------------------------------------------------------------- | ---------------------------------------------------------------------------------------- | ---------------------------------------------------------------------------------------- | ---------------------------------------------------------------------------------------- |
| `object`                                                                                 | *"page"*                                                                                 | :heavy_check_mark:                                                                       | N/A                                                                                      |
| `data`                                                                                   | [operations.GetEmbeddingsUsageData](../../models/operations/getembeddingsusagedata.md)[] | :heavy_check_mark:                                                                       | N/A                                                                                      |
| `hasMore`                                                                                | *boolean*                                                                                | :heavy_check_mark:                                                                       | Whether there are more pages                                                             |
| `nextPage`                                                                               | *string*                                                                                 | :heavy_check_mark:                                                                       | Cursor for next page, null if no more pages                                              |