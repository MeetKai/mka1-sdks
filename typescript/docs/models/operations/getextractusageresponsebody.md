# GetExtractUsageResponseBody

OK

## Example Usage

```typescript
import { GetExtractUsageResponseBody } from "@meetkai/mka1/models/operations";

let value: GetExtractUsageResponseBody = {
  object: "page",
  data: [],
  hasMore: false,
  nextPage: "<value>",
};
```

## Fields

| Field                                                                              | Type                                                                               | Required                                                                           | Description                                                                        |
| ---------------------------------------------------------------------------------- | ---------------------------------------------------------------------------------- | ---------------------------------------------------------------------------------- | ---------------------------------------------------------------------------------- |
| `object`                                                                           | *"page"*                                                                           | :heavy_check_mark:                                                                 | N/A                                                                                |
| `data`                                                                             | [operations.GetExtractUsageData](../../models/operations/getextractusagedata.md)[] | :heavy_check_mark:                                                                 | N/A                                                                                |
| `hasMore`                                                                          | *boolean*                                                                          | :heavy_check_mark:                                                                 | Whether there are more pages                                                       |
| `nextPage`                                                                         | *string*                                                                           | :heavy_check_mark:                                                                 | Cursor for next page, null if no more pages                                        |