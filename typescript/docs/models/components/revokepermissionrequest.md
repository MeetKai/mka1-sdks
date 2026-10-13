# RevokePermissionRequest

## Example Usage

```typescript
import { RevokePermissionRequest } from "@meetkai/mka1/models/components";

let value: RevokePermissionRequest = {
  resourceType: "completion",
  resourceId: "my-completion-123",
  userId: "user-abc456",
  role: "reader",
};
```

## Fields

| Field                                                                    | Type                                                                     | Required                                                                 | Description                                                              |
| ------------------------------------------------------------------------ | ------------------------------------------------------------------------ | ------------------------------------------------------------------------ | ------------------------------------------------------------------------ |
| `resourceType`                                                           | [components.LlmResourceType](../../models/components/llmresourcetype.md) | :heavy_check_mark:                                                       | Type of LLM resource                                                     |
| `resourceId`                                                             | *string*                                                                 | :heavy_check_mark:                                                       | Unique identifier for the resource                                       |
| `userId`                                                                 | *string*                                                                 | :heavy_check_mark:                                                       | Unique identifier for the user, or "*" to grant/revoke public access     |
| `role`                                                                   | [components.ResourceRole](../../models/components/resourcerole.md)       | :heavy_check_mark:                                                       | Permission role for the resource (owner > writer > reader)               |