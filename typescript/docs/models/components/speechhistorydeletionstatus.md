# SpeechHistoryDeletionStatus

Confirmation that a speech history item was deleted.

## Example Usage

```typescript
import { SpeechHistoryDeletionStatus } from "@meetkai/mka1/models/components";

let value: SpeechHistoryDeletionStatus = {
  id: "<id>",
  object: "<value>",
  deleted: true,
};
```

## Fields

| Field                                | Type                                 | Required                             | Description                          |
| ------------------------------------ | ------------------------------------ | ------------------------------------ | ------------------------------------ |
| `id`                                 | *string*                             | :heavy_check_mark:                   | The ID of the deleted history item.  |
| `object`                             | *string*                             | :heavy_check_mark:                   | The object type of the deleted item. |
| `deleted`                            | *true*                               | :heavy_check_mark:                   | Always true when deletion succeeds.  |