# GrantPermissionRequest


## Fields

| Field                                                                | Type                                                                 | Required                                                             | Description                                                          |
| -------------------------------------------------------------------- | -------------------------------------------------------------------- | -------------------------------------------------------------------- | -------------------------------------------------------------------- |
| `ResourceType`                                                       | [LlmResourceType](../../Types/Components/LlmResourceType.md)         | :heavy_check_mark:                                                   | Type of LLM resource                                                 |
| `ResourceId`                                                         | *string*                                                             | :heavy_check_mark:                                                   | Unique identifier for the resource                                   |
| `UserId`                                                             | *string*                                                             | :heavy_check_mark:                                                   | Unique identifier for the user, or "*" to grant/revoke public access |
| `Role`                                                               | [ResourceRole](../../Types/Components/ResourceRole.md)               | :heavy_check_mark:                                                   | Permission role for the resource (owner > writer > reader)           |