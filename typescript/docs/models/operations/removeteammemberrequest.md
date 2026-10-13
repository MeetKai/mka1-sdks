# RemoveTeamMemberRequest

## Example Usage

```typescript
import { RemoveTeamMemberRequest } from "@meetkai/mka1/models/operations";

let value: RemoveTeamMemberRequest = {
  orgId: "<id>",
  teamId: "<id>",
  memberId: "<id>",
};
```

## Fields

| Field                                                               | Type                                                                | Required                                                            | Description                                                         |
| ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- |
| `orgId`                                                             | *string*                                                            | :heavy_check_mark:                                                  | N/A                                                                 |
| `teamId`                                                            | *string*                                                            | :heavy_check_mark:                                                  | N/A                                                                 |
| `memberId`                                                          | *string*                                                            | :heavy_check_mark:                                                  | N/A                                                                 |
| `xOnBehalfOf`                                                       | *string*                                                            | :heavy_minus_sign:                                                  | Optional external end-user identifier forwarded by the API gateway. |