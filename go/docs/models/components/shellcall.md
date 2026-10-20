# ShellCall

Shell call item: A hosted-container shell execution request with a command and status.


## Fields

| Field                                                                    | Type                                                                     | Required                                                                 | Description                                                              |
| ------------------------------------------------------------------------ | ------------------------------------------------------------------------ | ------------------------------------------------------------------------ | ------------------------------------------------------------------------ |
| `Type`                                                                   | `string`                                                                 | :heavy_check_mark:                                                       | N/A                                                                      |
| `ID`                                                                     | `string`                                                                 | :heavy_check_mark:                                                       | N/A                                                                      |
| `CallID`                                                                 | `string`                                                                 | :heavy_check_mark:                                                       | N/A                                                                      |
| `Action`                                                                 | [components.ShellCallAction](../../models/components/shellcallaction.md) | :heavy_check_mark:                                                       | N/A                                                                      |
| `Status`                                                                 | [components.ShellCallStatus](../../models/components/shellcallstatus.md) | :heavy_check_mark:                                                       | N/A                                                                      |