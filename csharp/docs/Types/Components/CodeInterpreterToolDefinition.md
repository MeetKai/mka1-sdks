# CodeInterpreterToolDefinition

Code interpreter tool definition: Enables code execution. Provide an explicit container ID or auto container configuration with optional file IDs. Non-null caller memory_limit is unsupported and rejected.


## Fields

| Field                                            | Type                                             | Required                                         | Description                                      |
| ------------------------------------------------ | ------------------------------------------------ | ------------------------------------------------ | ------------------------------------------------ |
| `Type`                                           | *string*                                         | :heavy_check_mark:                               | N/A                                              |
| `Container`                                      | [Container](../../Types/Components/Container.md) | :heavy_check_mark:                               | N/A                                              |