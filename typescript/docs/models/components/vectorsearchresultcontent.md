# VectorSearchResultContent

Content item in a search result.

## Example Usage

```typescript
import { VectorSearchResultContent } from "@meetkai/mka1/models/components";

let value: VectorSearchResultContent = {
  type: "text",
  text: "<value>",
};
```

## Fields

| Field                                         | Type                                          | Required                                      | Description                                   |
| --------------------------------------------- | --------------------------------------------- | --------------------------------------------- | --------------------------------------------- |
| `type`                                        | *"text"*                                      | :heavy_check_mark:                            | The content type identifier for text content. |
| `text`                                        | *string*                                      | :heavy_check_mark:                            | The text content of the search result.        |