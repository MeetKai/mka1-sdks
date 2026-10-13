# FileSearchToolCall

File search call item: A tool-call record for semantic file search, including query terms, status, and optional results.

## Example Usage

```typescript
import { FileSearchToolCall } from "@meetkai/mka1/models/components";

let value: FileSearchToolCall = {
  type: "file_search_call",
  id: "<id>",
  queries: [
    "<value 1>",
    "<value 2>",
  ],
  status: "failed",
};
```

## Fields

| Field                                                                                      | Type                                                                                       | Required                                                                                   | Description                                                                                |
| ------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------ |
| `type`                                                                                     | *"file_search_call"*                                                                       | :heavy_check_mark:                                                                         | N/A                                                                                        |
| `id`                                                                                       | *string*                                                                                   | :heavy_check_mark:                                                                         | N/A                                                                                        |
| `queries`                                                                                  | *string*[]                                                                                 | :heavy_check_mark:                                                                         | N/A                                                                                        |
| `status`                                                                                   | [components.FileSearchToolCallStatus](../../models/components/filesearchtoolcallstatus.md) | :heavy_check_mark:                                                                         | N/A                                                                                        |
| `results`                                                                                  | [components.FileSearchResult](../../models/components/filesearchresult.md)[]               | :heavy_minus_sign:                                                                         | N/A                                                                                        |