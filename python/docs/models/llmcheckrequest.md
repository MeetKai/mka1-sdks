# LlmCheckRequest


## Fields

| Field                                                               | Type                                                                | Required                                                            | Description                                                         |
| ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- |
| `resource_type`                                                     | [models.LlmResourceType](../models/llmresourcetype.md)              | :heavy_check_mark:                                                  | Type of LLM resource                                                |
| `resource_id`                                                       | *str*                                                               | :heavy_check_mark:                                                  | N/A                                                                 |
| `role`                                                              | [models.ResourceRole](../models/resourcerole.md)                    | :heavy_check_mark:                                                  | Permission role for the resource (owner > writer > reader)          |
| `x_on_behalf_of`                                                    | *Optional[str]*                                                     | :heavy_minus_sign:                                                  | Optional external end-user identifier forwarded by the API gateway. |