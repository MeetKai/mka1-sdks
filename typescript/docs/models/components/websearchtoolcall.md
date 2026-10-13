# WebSearchToolCall

Web search call item: A web-search tool-call record containing the executed action and status.

## Example Usage

```typescript
import { WebSearchToolCall } from "@meetkai/mka1/models/components";

let value: WebSearchToolCall = {
  type: "web_search_call",
  id: "<id>",
  action: {
    type: "open_page",
    url: "https://excellent-godparent.org/",
  },
  status: "<value>",
};
```

## Fields

| Field                        | Type                         | Required                     | Description                  |
| ---------------------------- | ---------------------------- | ---------------------------- | ---------------------------- |
| `type`                       | *"web_search_call"*          | :heavy_check_mark:           | N/A                          |
| `id`                         | *string*                     | :heavy_check_mark:           | N/A                          |
| `action`                     | *components.WebSearchAction* | :heavy_check_mark:           | N/A                          |
| `status`                     | *string*                     | :heavy_check_mark:           | N/A                          |