# GetVectorStoresUsageResponseBody

OK

## Example Usage

```typescript
import { GetVectorStoresUsageResponseBody } from "@meetkai/mka1/models/operations";

let value: GetVectorStoresUsageResponseBody = {
  object: "page",
  data: [],
  hasMore: false,
  nextPage: "<value>",
};
```

## Fields

| Field                                                                                        | Type                                                                                         | Required                                                                                     | Description                                                                                  |
| -------------------------------------------------------------------------------------------- | -------------------------------------------------------------------------------------------- | -------------------------------------------------------------------------------------------- | -------------------------------------------------------------------------------------------- |
| `object`                                                                                     | *"page"*                                                                                     | :heavy_check_mark:                                                                           | N/A                                                                                          |
| `data`                                                                                       | [operations.GetVectorStoresUsageData](../../models/operations/getvectorstoresusagedata.md)[] | :heavy_check_mark:                                                                           | N/A                                                                                          |
| `hasMore`                                                                                    | *boolean*                                                                                    | :heavy_check_mark:                                                                           | Whether there are more pages                                                                 |
| `nextPage`                                                                                   | *string*                                                                                     | :heavy_check_mark:                                                                           | Cursor for next page, null if no more pages                                                  |