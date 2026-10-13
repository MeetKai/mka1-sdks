# SpeechHistoryDeletionStatus

Confirmation that a speech history item was deleted.


## Fields

| Field                                | Type                                 | Required                             | Description                          |
| ------------------------------------ | ------------------------------------ | ------------------------------------ | ------------------------------------ |
| `Id`                                 | *string*                             | :heavy_check_mark:                   | The ID of the deleted history item.  |
| `Object`                             | *string*                             | :heavy_check_mark:                   | The object type of the deleted item. |
| `Deleted`                            | *bool*                               | :heavy_check_mark:                   | Always true when deletion succeeds.  |