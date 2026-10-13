# LlmCheckRequest


## Fields

| Field                                                               | Type                                                                | Required                                                            | Description                                                         |
| ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- |
| `ResourceType`                                                      | [LlmResourceType](../../Types/Components/LlmResourceType.md)        | :heavy_check_mark:                                                  | Type of LLM resource                                                |
| `ResourceId`                                                        | *string*                                                            | :heavy_check_mark:                                                  | N/A                                                                 |
| `Role`                                                              | [ResourceRole](../../Types/Components/ResourceRole.md)              | :heavy_check_mark:                                                  | Permission role for the resource (owner > writer > reader)          |
| `XOnBehalfOf`                                                       | *string*                                                            | :heavy_minus_sign:                                                  | Optional external end-user identifier forwarded by the API gateway. |