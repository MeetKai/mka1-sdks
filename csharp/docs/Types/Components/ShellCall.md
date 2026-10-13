# ShellCall

Shell call item: A hosted-container shell execution request with a command and status.


## Fields

| Field                                                        | Type                                                         | Required                                                     | Description                                                  |
| ------------------------------------------------------------ | ------------------------------------------------------------ | ------------------------------------------------------------ | ------------------------------------------------------------ |
| `Type`                                                       | *string*                                                     | :heavy_check_mark:                                           | N/A                                                          |
| `Id`                                                         | *string*                                                     | :heavy_check_mark:                                           | N/A                                                          |
| `CallId`                                                     | *string*                                                     | :heavy_check_mark:                                           | N/A                                                          |
| `Action`                                                     | [ShellCallAction](../../Types/Components/ShellCallAction.md) | :heavy_check_mark:                                           | N/A                                                          |
| `Status`                                                     | [ShellCallStatus](../../Types/Components/ShellCallStatus.md) | :heavy_check_mark:                                           | N/A                                                          |