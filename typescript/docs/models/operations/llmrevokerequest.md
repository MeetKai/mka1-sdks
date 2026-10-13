# LlmRevokeRequest

## Example Usage

```typescript
import { LlmRevokeRequest } from "@meetkai/mka1/models/operations";

let value: LlmRevokeRequest = {
  revokePermissionRequest: {
    resourceType: "completion",
    resourceId: "my-completion-123",
    userId: "user-abc456",
    role: "reader",
  },
};
```

## Fields

| Field                                                                                                          | Type                                                                                                           | Required                                                                                                       | Description                                                                                                    | Example                                                                                                        |
| -------------------------------------------------------------------------------------------------------------- | -------------------------------------------------------------------------------------------------------------- | -------------------------------------------------------------------------------------------------------------- | -------------------------------------------------------------------------------------------------------------- | -------------------------------------------------------------------------------------------------------------- |
| `xOnBehalfOf`                                                                                                  | *string*                                                                                                       | :heavy_minus_sign:                                                                                             | Optional external end-user identifier forwarded by the API gateway.                                            |                                                                                                                |
| `revokePermissionRequest`                                                                                      | [components.RevokePermissionRequest](../../models/components/revokepermissionrequest.md)                       | :heavy_check_mark:                                                                                             | N/A                                                                                                            | {<br/>"resourceType": "completion",<br/>"resourceId": "my-completion-123",<br/>"userId": "user-abc456",<br/>"role": "reader"<br/>} |