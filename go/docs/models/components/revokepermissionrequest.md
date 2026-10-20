# RevokePermissionRequest


## Fields

| Field                                                                    | Type                                                                     | Required                                                                 | Description                                                              |
| ------------------------------------------------------------------------ | ------------------------------------------------------------------------ | ------------------------------------------------------------------------ | ------------------------------------------------------------------------ |
| `ResourceType`                                                           | [components.LlmResourceType](../../models/components/llmresourcetype.md) | :heavy_check_mark:                                                       | Type of LLM resource                                                     |
| `ResourceID`                                                             | `string`                                                                 | :heavy_check_mark:                                                       | Unique identifier for the resource                                       |
| `UserID`                                                                 | `string`                                                                 | :heavy_check_mark:                                                       | Unique identifier for the user, or "*" to grant/revoke public access     |
| `Role`                                                                   | [components.ResourceRole](../../models/components/resourcerole.md)       | :heavy_check_mark:                                                       | Permission role for the resource (owner > writer > reader)               |