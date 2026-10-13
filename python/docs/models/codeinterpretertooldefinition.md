# CodeInterpreterToolDefinition

Code interpreter tool definition: Enables code execution. Provide an explicit container ID or auto container configuration with optional file IDs. Non-null caller memory_limit is unsupported and rejected.


## Fields

| Field                                      | Type                                       | Required                                   | Description                                |
| ------------------------------------------ | ------------------------------------------ | ------------------------------------------ | ------------------------------------------ |
| `type`                                     | *Literal["code_interpreter"]*              | :heavy_check_mark:                         | N/A                                        |
| `container`                                | [models.Container](../models/container.md) | :heavy_check_mark:                         | N/A                                        |