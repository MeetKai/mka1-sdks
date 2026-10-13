# GetPendingInvitationResponseBody

Invitation to resume, or null when none exists

## Example Usage

```typescript
import { GetPendingInvitationResponseBody } from "@meetkai/mka1/models/operations";

let value: GetPendingInvitationResponseBody = {
  invitation: {
    type: "organization",
    id: "<id>",
  },
};
```

## Fields

| Field                                       | Type                                        | Required                                    | Description                                 |
| ------------------------------------------- | ------------------------------------------- | ------------------------------------------- | ------------------------------------------- |
| `invitation`                                | *operations.GetPendingInvitationInvitation* | :heavy_check_mark:                          | N/A                                         |