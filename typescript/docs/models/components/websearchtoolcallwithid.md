# WebSearchToolCallWithId

Web search call item: A web-search tool-call record containing the executed action and status.

## Example Usage

```typescript
import { WebSearchToolCallWithId } from "@meetkai/mka1/models/components";

let value: WebSearchToolCallWithId = {
  type: "web_search_call",
  id: "<id>",
  action: {
    type: "find",
    pattern: "<value>",
    url: "https://mushy-larva.biz",
  },
  status: "<value>",
};
```

## Fields

| Field                                                      | Type                                                       | Required                                                   | Description                                                |
| ---------------------------------------------------------- | ---------------------------------------------------------- | ---------------------------------------------------------- | ---------------------------------------------------------- |
| `type`                                                     | *"web_search_call"*                                        | :heavy_check_mark:                                         | N/A                                                        |
| `id`                                                       | *string*                                                   | :heavy_check_mark:                                         | The unique ID of the message.                              |
| `action`                                                   | *components.WebSearchAction*                               | :heavy_check_mark:                                         | N/A                                                        |
| `status`                                                   | *string*                                                   | :heavy_check_mark:                                         | N/A                                                        |
| `responseId`                                               | *string*                                                   | :heavy_minus_sign:                                         | The ID of the response that created this item, if any.     |
| `metadata`                                                 | Record<string, *string*>                                   | :heavy_minus_sign:                                         | Metadata from the response that created this item, if any. |