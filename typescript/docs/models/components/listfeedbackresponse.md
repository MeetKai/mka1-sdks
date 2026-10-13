# ListFeedbackResponse

Paginated list object containing feedback entries with cursor-based pagination metadata.

## Example Usage

```typescript
import { ListFeedbackResponse } from "@meetkai/mka1/models/components";

let value: ListFeedbackResponse = {
  object: "list",
  data: [],
  hasMore: true,
};
```

## Fields

| Field                                                                                                                | Type                                                                                                                 | Required                                                                                                             | Description                                                                                                          |
| -------------------------------------------------------------------------------------------------------------------- | -------------------------------------------------------------------------------------------------------------------- | -------------------------------------------------------------------------------------------------------------------- | -------------------------------------------------------------------------------------------------------------------- |
| `object`                                                                                                             | *"list"*                                                                                                             | :heavy_check_mark:                                                                                                   | The object type, always 'list' for paginated list responses.                                                         |
| `data`                                                                                                               | [components.ListFeedbackResponseData](../../models/components/listfeedbackresponsedata.md)[]                         | :heavy_check_mark:                                                                                                   | Array of feedback entries ordered by creation date of the underlying request.                                        |
| `firstId`                                                                                                            | *string*                                                                                                             | :heavy_minus_sign:                                                                                                   | The ID of the first feedback entry in the current page. Used as a reference point for pagination.                    |
| `lastId`                                                                                                             | *string*                                                                                                             | :heavy_minus_sign:                                                                                                   | The ID of the last feedback entry in the current page. Used as a cursor for fetching the next page.                  |
| `hasMore`                                                                                                            | *boolean*                                                                                                            | :heavy_check_mark:                                                                                                   | Indicates whether there are more feedback entries available beyond the current page. True if additional pages exist. |