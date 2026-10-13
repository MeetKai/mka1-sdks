# WebSearchPreviewToolDefinition

Web search preview tool definition: Enables the preview web search tool variant with optional context size and user location.

## Example Usage

```typescript
import { WebSearchPreviewToolDefinition } from "@meetkai/mka1/models/components";

let value: WebSearchPreviewToolDefinition = {
  type: "web_search_preview_2025_03_11",
};
```

## Fields

| Field                                                                                                                                    | Type                                                                                                                                     | Required                                                                                                                                 | Description                                                                                                                              |
| ---------------------------------------------------------------------------------------------------------------------------------------- | ---------------------------------------------------------------------------------------------------------------------------------------- | ---------------------------------------------------------------------------------------------------------------------------------------- | ---------------------------------------------------------------------------------------------------------------------------------------- |
| `type`                                                                                                                                   | [components.WebSearchPreviewToolDefinitionType](../../models/components/websearchpreviewtooldefinitiontype.md)                           | :heavy_check_mark:                                                                                                                       | N/A                                                                                                                                      |
| `searchContextSize`                                                                                                                      | [components.WebSearchPreviewToolDefinitionSearchContextSize](../../models/components/websearchpreviewtooldefinitionsearchcontextsize.md) | :heavy_minus_sign:                                                                                                                       | N/A                                                                                                                                      |
| `userLocation`                                                                                                                           | [components.UserLocation](../../models/components/userlocation.md)                                                                       | :heavy_minus_sign:                                                                                                                       | N/A                                                                                                                                      |