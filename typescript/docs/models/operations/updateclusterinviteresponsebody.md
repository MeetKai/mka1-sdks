# UpdateClusterInviteResponseBody

Invitation updated

## Example Usage

```typescript
import { UpdateClusterInviteResponseBody } from "@meetkai/mka1/models/operations";

let value: UpdateClusterInviteResponseBody = {
  invitation: {
    id: "<id>",
    email: "Brooke89@hotmail.com",
    suggestedOrgName: "<value>",
    seedAvailableModels: [],
    expiresAt: "1746975367505",
    createdAt: "1722511681732",
  },
};
```

## Fields

| Field                                                                                                | Type                                                                                                 | Required                                                                                             | Description                                                                                          |
| ---------------------------------------------------------------------------------------------------- | ---------------------------------------------------------------------------------------------------- | ---------------------------------------------------------------------------------------------------- | ---------------------------------------------------------------------------------------------------- |
| `invitation`                                                                                         | [operations.UpdateClusterInviteInvitation](../../models/operations/updateclusterinviteinvitation.md) | :heavy_check_mark:                                                                                   | N/A                                                                                                  |