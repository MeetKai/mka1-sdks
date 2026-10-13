# WebSearchToolDefinition

Web search tool definition: Enables web search with optional domain filters, search context size, and approximate user location.

## Example Usage

```typescript
import { WebSearchToolDefinition } from "@meetkai/mka1/models/components";

let value: WebSearchToolDefinition = {
  type: "web_search",
};
```

## Fields

| Field                                                                                            | Type                                                                                             | Required                                                                                         | Description                                                                                      |
| ------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------ |
| `type`                                                                                           | [components.WebSearchToolDefinitionType](../../models/components/websearchtooldefinitiontype.md) | :heavy_check_mark:                                                                               | N/A                                                                                              |
| `filters`                                                                                        | [components.WebSearchFilters](../../models/components/websearchfilters.md)                       | :heavy_minus_sign:                                                                               | N/A                                                                                              |
| `searchContextSize`                                                                              | [components.SearchContextSize](../../models/components/searchcontextsize.md)                     | :heavy_minus_sign:                                                                               | N/A                                                                                              |
| `userLocation`                                                                                   | [components.UserLocation](../../models/components/userlocation.md)                               | :heavy_minus_sign:                                                                               | N/A                                                                                              |