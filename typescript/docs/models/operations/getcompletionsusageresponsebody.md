# GetCompletionsUsageResponseBody

OK

## Example Usage

```typescript
import { GetCompletionsUsageResponseBody } from "@meetkai/mka1/models/operations";

let value: GetCompletionsUsageResponseBody = {
  object: "page",
  data: [],
  hasMore: true,
  nextPage: "<value>",
};
```

## Fields

| Field                                                                                      | Type                                                                                       | Required                                                                                   | Description                                                                                |
| ------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------ |
| `object`                                                                                   | *"page"*                                                                                   | :heavy_check_mark:                                                                         | N/A                                                                                        |
| `data`                                                                                     | [operations.GetCompletionsUsageData](../../models/operations/getcompletionsusagedata.md)[] | :heavy_check_mark:                                                                         | N/A                                                                                        |
| `hasMore`                                                                                  | *boolean*                                                                                  | :heavy_check_mark:                                                                         | Whether there are more pages                                                               |
| `nextPage`                                                                                 | *string*                                                                                   | :heavy_check_mark:                                                                         | Cursor for next page, null if no more pages                                                |