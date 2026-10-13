# SpeechHistoryDeletionStatus

Confirmation that a speech history item was deleted.


## Fields

| Field                                | Type                                 | Required                             | Description                          |
| ------------------------------------ | ------------------------------------ | ------------------------------------ | ------------------------------------ |
| `id`                                 | *str*                                | :heavy_check_mark:                   | The ID of the deleted history item.  |
| `object`                             | *str*                                | :heavy_check_mark:                   | The object type of the deleted item. |
| `deleted`                            | *Literal[True]*                      | :heavy_check_mark:                   | Always true when deletion succeeds.  |