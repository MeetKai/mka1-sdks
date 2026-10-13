# RevokePermissionRequest


## Fields

| Field                                                                | Type                                                                 | Required                                                             | Description                                                          |
| -------------------------------------------------------------------- | -------------------------------------------------------------------- | -------------------------------------------------------------------- | -------------------------------------------------------------------- |
| `resource_type`                                                      | [models.LlmResourceType](../models/llmresourcetype.md)               | :heavy_check_mark:                                                   | Type of LLM resource                                                 |
| `resource_id`                                                        | *str*                                                                | :heavy_check_mark:                                                   | Unique identifier for the resource                                   |
| `user_id`                                                            | *str*                                                                | :heavy_check_mark:                                                   | Unique identifier for the user, or "*" to grant/revoke public access |
| `role`                                                               | [models.ResourceRole](../models/resourcerole.md)                     | :heavy_check_mark:                                                   | Permission role for the resource (owner > writer > reader)           |