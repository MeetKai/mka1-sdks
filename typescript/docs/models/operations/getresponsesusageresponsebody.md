# GetResponsesUsageResponseBody

OK

## Example Usage

```typescript
import { GetResponsesUsageResponseBody } from "@meetkai/mka1/models/operations";

let value: GetResponsesUsageResponseBody = {
  object: "page",
  data: [],
  hasMore: false,
  nextPage: "<value>",
};
```

## Fields

| Field                                                                                  | Type                                                                                   | Required                                                                               | Description                                                                            |
| -------------------------------------------------------------------------------------- | -------------------------------------------------------------------------------------- | -------------------------------------------------------------------------------------- | -------------------------------------------------------------------------------------- |
| `object`                                                                               | *"page"*                                                                               | :heavy_check_mark:                                                                     | N/A                                                                                    |
| `data`                                                                                 | [operations.GetResponsesUsageData](../../models/operations/getresponsesusagedata.md)[] | :heavy_check_mark:                                                                     | N/A                                                                                    |
| `hasMore`                                                                              | *boolean*                                                                              | :heavy_check_mark:                                                                     | Whether there are more pages                                                           |
| `nextPage`                                                                             | *string*                                                                               | :heavy_check_mark:                                                                     | Cursor for next page, null if no more pages                                            |