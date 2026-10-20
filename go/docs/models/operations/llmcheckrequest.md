# LlmCheckRequest


## Fields

| Field                                                                    | Type                                                                     | Required                                                                 | Description                                                              |
| ------------------------------------------------------------------------ | ------------------------------------------------------------------------ | ------------------------------------------------------------------------ | ------------------------------------------------------------------------ |
| `ResourceType`                                                           | [components.LlmResourceType](../../models/components/llmresourcetype.md) | :heavy_check_mark:                                                       | Type of LLM resource                                                     |
| `ResourceID`                                                             | `string`                                                                 | :heavy_check_mark:                                                       | N/A                                                                      |
| `Role`                                                                   | [components.ResourceRole](../../models/components/resourcerole.md)       | :heavy_check_mark:                                                       | Permission role for the resource (owner > writer > reader)               |
| `XOnBehalfOf`                                                            | `*string`                                                                | :heavy_minus_sign:                                                       | Optional external end-user identifier forwarded by the API gateway.      |