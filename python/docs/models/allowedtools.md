# AllowedTools

Allowed tools tool choice: Restricts tool use to a provided list and sets whether tool use is optional (auto) or mandatory (required).


## Fields

| Field                                                          | Type                                                           | Required                                                       | Description                                                    |
| -------------------------------------------------------------- | -------------------------------------------------------------- | -------------------------------------------------------------- | -------------------------------------------------------------- |
| `type`                                                         | *Literal["allowed_tools"]*                                     | :heavy_check_mark:                                             | N/A                                                            |
| `mode`                                                         | [models.AllowedToolsMode](../models/allowedtoolsmode.md)       | :heavy_check_mark:                                             | N/A                                                            |
| `tools`                                                        | List[[models.AllowedToolsTool](../models/allowedtoolstool.md)] | :heavy_check_mark:                                             | N/A                                                            |