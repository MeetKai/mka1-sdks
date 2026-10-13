# LlmGrantRequest

## Example Usage

```typescript
import { LlmGrantRequest } from "@meetkai/mka1/models/operations";

let value: LlmGrantRequest = {
  grantPermissionRequest: {
    resourceType: "completion",
    resourceId: "my-completion-123",
    userId: "user-abc456",
    role: "writer",
  },
};
```

## Fields

| Field                                                                                                          | Type                                                                                                           | Required                                                                                                       | Description                                                                                                    | Example                                                                                                        |
| -------------------------------------------------------------------------------------------------------------- | -------------------------------------------------------------------------------------------------------------- | -------------------------------------------------------------------------------------------------------------- | -------------------------------------------------------------------------------------------------------------- | -------------------------------------------------------------------------------------------------------------- |
| `xOnBehalfOf`                                                                                                  | *string*                                                                                                       | :heavy_minus_sign:                                                                                             | Optional external end-user identifier forwarded by the API gateway.                                            |                                                                                                                |
| `grantPermissionRequest`                                                                                       | [components.GrantPermissionRequest](../../models/components/grantpermissionrequest.md)                         | :heavy_check_mark:                                                                                             | N/A                                                                                                            | {<br/>"resourceType": "completion",<br/>"resourceId": "my-completion-123",<br/>"userId": "user-abc456",<br/>"role": "writer"<br/>} |