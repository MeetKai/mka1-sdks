# GetConversationsUsageResponseBody

OK

## Example Usage

```typescript
import { GetConversationsUsageResponseBody } from "@meetkai/mka1/models/operations";

let value: GetConversationsUsageResponseBody = {
  object: "page",
  data: [],
  hasMore: false,
  nextPage: "<value>",
};
```

## Fields

| Field                                                                                          | Type                                                                                           | Required                                                                                       | Description                                                                                    |
| ---------------------------------------------------------------------------------------------- | ---------------------------------------------------------------------------------------------- | ---------------------------------------------------------------------------------------------- | ---------------------------------------------------------------------------------------------- |
| `object`                                                                                       | *"page"*                                                                                       | :heavy_check_mark:                                                                             | N/A                                                                                            |
| `data`                                                                                         | [operations.GetConversationsUsageData](../../models/operations/getconversationsusagedata.md)[] | :heavy_check_mark:                                                                             | N/A                                                                                            |
| `hasMore`                                                                                      | *boolean*                                                                                      | :heavy_check_mark:                                                                             | Whether there are more pages                                                                   |
| `nextPage`                                                                                     | *string*                                                                                       | :heavy_check_mark:                                                                             | Cursor for next page, null if no more pages                                                    |