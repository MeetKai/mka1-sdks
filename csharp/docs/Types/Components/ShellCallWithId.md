# ShellCallWithId

Shell call item: A hosted-container shell execution request with a command and status.


## Fields

| Field                                                                    | Type                                                                     | Required                                                                 | Description                                                              |
| ------------------------------------------------------------------------ | ------------------------------------------------------------------------ | ------------------------------------------------------------------------ | ------------------------------------------------------------------------ |
| `Type`                                                                   | *string*                                                                 | :heavy_check_mark:                                                       | N/A                                                                      |
| `Id`                                                                     | *string*                                                                 | :heavy_check_mark:                                                       | The unique ID of the message.                                            |
| `CallId`                                                                 | *string*                                                                 | :heavy_check_mark:                                                       | N/A                                                                      |
| `Action`                                                                 | [ShellCallAction](../../Types/Components/ShellCallAction.md)             | :heavy_check_mark:                                                       | N/A                                                                      |
| `Status`                                                                 | [ShellCallWithIdStatus](../../Types/Components/ShellCallWithIdStatus.md) | :heavy_check_mark:                                                       | N/A                                                                      |
| `ResponseId`                                                             | *string*                                                                 | :heavy_minus_sign:                                                       | The ID of the response that created this item, if any.                   |
| `Metadata`                                                               | Dictionary<String, *string*>                                             | :heavy_minus_sign:                                                       | Metadata from the response that created this item, if any.               |