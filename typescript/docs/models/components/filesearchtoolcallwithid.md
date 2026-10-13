# FileSearchToolCallWithId

File search call item: A tool-call record for semantic file search, including query terms, status, and optional results.

## Example Usage

```typescript
import { FileSearchToolCallWithId } from "@meetkai/mka1/models/components";

let value: FileSearchToolCallWithId = {
  type: "file_search_call",
  id: "<id>",
  queries: [],
  status: "incomplete",
};
```

## Fields

| Field                                                                                                  | Type                                                                                                   | Required                                                                                               | Description                                                                                            |
| ------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------ |
| `type`                                                                                                 | *"file_search_call"*                                                                                   | :heavy_check_mark:                                                                                     | N/A                                                                                                    |
| `id`                                                                                                   | *string*                                                                                               | :heavy_check_mark:                                                                                     | The unique ID of the message.                                                                          |
| `queries`                                                                                              | *string*[]                                                                                             | :heavy_check_mark:                                                                                     | N/A                                                                                                    |
| `status`                                                                                               | [components.FileSearchToolCallWithIdStatus](../../models/components/filesearchtoolcallwithidstatus.md) | :heavy_check_mark:                                                                                     | N/A                                                                                                    |
| `results`                                                                                              | [components.FileSearchResult](../../models/components/filesearchresult.md)[]                           | :heavy_minus_sign:                                                                                     | N/A                                                                                                    |
| `responseId`                                                                                           | *string*                                                                                               | :heavy_minus_sign:                                                                                     | The ID of the response that created this item, if any.                                                 |
| `metadata`                                                                                             | Record<string, *string*>                                                                               | :heavy_minus_sign:                                                                                     | Metadata from the response that created this item, if any.                                             |