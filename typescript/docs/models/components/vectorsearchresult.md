# VectorSearchResult

A single search result from a vector store search.

## Example Usage

```typescript
import { VectorSearchResult } from "@meetkai/mka1/models/components";

let value: VectorSearchResult = {
  fileId: "<id>",
  filename: "example.file",
  score: 7713.87,
  content: [],
};
```

## Fields

| Field                                                                                          | Type                                                                                           | Required                                                                                       | Description                                                                                    |
| ---------------------------------------------------------------------------------------------- | ---------------------------------------------------------------------------------------------- | ---------------------------------------------------------------------------------------------- | ---------------------------------------------------------------------------------------------- |
| `fileId`                                                                                       | *string*                                                                                       | :heavy_check_mark:                                                                             | The ID of the file containing this result.                                                     |
| `filename`                                                                                     | *string*                                                                                       | :heavy_check_mark:                                                                             | The name of the file.                                                                          |
| `score`                                                                                        | *number*                                                                                       | :heavy_check_mark:                                                                             | The relevance score of this result.                                                            |
| `attributes`                                                                                   | Record<string, *components.VectorSearchResultAttributes*>                                      | :heavy_minus_sign:                                                                             | File attributes.                                                                               |
| `content`                                                                                      | [components.VectorSearchResultContent](../../models/components/vectorsearchresultcontent.md)[] | :heavy_check_mark:                                                                             | Array of content items.                                                                        |