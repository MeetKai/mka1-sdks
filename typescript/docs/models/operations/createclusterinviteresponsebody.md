# CreateClusterInviteResponseBody

Invitation created

## Example Usage

```typescript
import { CreateClusterInviteResponseBody } from "@meetkai/mka1/models/operations";

let value: CreateClusterInviteResponseBody = {
  invitation: {
    id: "<id>",
    email: "Angelina_Ferry@hotmail.com",
    suggestedOrgName: "<value>",
    seedAvailableModels: [
      "<value 1>",
      "<value 2>",
      "<value 3>",
    ],
    expiresAt: "1745366807656",
    createdAt: "1719585321456",
  },
};
```

## Fields

| Field                                                          | Type                                                           | Required                                                       | Description                                                    |
| -------------------------------------------------------------- | -------------------------------------------------------------- | -------------------------------------------------------------- | -------------------------------------------------------------- |
| `invitation`                                                   | [operations.Invitation](../../models/operations/invitation.md) | :heavy_check_mark:                                             | N/A                                                            |