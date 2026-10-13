# ResponseCompactionItemWithId

Compaction item: A condensed summary of prior conversation history to reduce context size.

## Example Usage

```typescript
import { ResponseCompactionItemWithId } from "@meetkai/mka1/models/components";

let value: ResponseCompactionItemWithId = {
  type: "compaction",
  id: "<id>",
  content: "<value>",
};
```

## Fields

| Field                                                      | Type                                                       | Required                                                   | Description                                                |
| ---------------------------------------------------------- | ---------------------------------------------------------- | ---------------------------------------------------------- | ---------------------------------------------------------- |
| `type`                                                     | *"compaction"*                                             | :heavy_check_mark:                                         | N/A                                                        |
| `id`                                                       | *string*                                                   | :heavy_check_mark:                                         | The unique ID of the message.                              |
| `content`                                                  | *string*                                                   | :heavy_check_mark:                                         | The compacted/summarized conversation content.             |
| `encryptedContent`                                         | *string*                                                   | :heavy_minus_sign:                                         | Optional encrypted content for OpenAI API compatibility.   |
| `createdBy`                                                | *string*                                                   | :heavy_minus_sign:                                         | The model that created this compaction.                    |
| `responseId`                                               | *string*                                                   | :heavy_minus_sign:                                         | The ID of the response that created this item, if any.     |
| `metadata`                                                 | Record<string, *string*>                                   | :heavy_minus_sign:                                         | Metadata from the response that created this item, if any. |