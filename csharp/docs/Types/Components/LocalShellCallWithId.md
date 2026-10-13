# LocalShellCallWithId

Local shell call item: A local-shell execution request with command details and execution status.


## Fields

| Field                                                          | Type                                                           | Required                                                       | Description                                                    |
| -------------------------------------------------------------- | -------------------------------------------------------------- | -------------------------------------------------------------- | -------------------------------------------------------------- |
| `Type`                                                         | *string*                                                       | :heavy_check_mark:                                             | N/A                                                            |
| `Id`                                                           | *string*                                                       | :heavy_check_mark:                                             | The unique ID of the message.                                  |
| `CallId`                                                       | *string*                                                       | :heavy_check_mark:                                             | N/A                                                            |
| `Action`                                                       | [LocalShellAction](../../Types/Components/LocalShellAction.md) | :heavy_check_mark:                                             | N/A                                                            |
| `Status`                                                       | *string*                                                       | :heavy_check_mark:                                             | N/A                                                            |
| `ResponseId`                                                   | *string*                                                       | :heavy_minus_sign:                                             | The ID of the response that created this item, if any.         |
| `Metadata`                                                     | Dictionary<String, *string*>                                   | :heavy_minus_sign:                                             | Metadata from the response that created this item, if any.     |