# UpdateTeamRequest

## Example Usage

```typescript
import { UpdateTeamRequest } from "@meetkai/mka1/models/operations";

let value: UpdateTeamRequest = {
  orgId: "<id>",
  teamId: "<id>",
};
```

## Fields

| Field                                                                                | Type                                                                                 | Required                                                                             | Description                                                                          |
| ------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------ |
| `orgId`                                                                              | *string*                                                                             | :heavy_check_mark:                                                                   | N/A                                                                                  |
| `teamId`                                                                             | *string*                                                                             | :heavy_check_mark:                                                                   | N/A                                                                                  |
| `xOnBehalfOf`                                                                        | *string*                                                                             | :heavy_minus_sign:                                                                   | Optional external end-user identifier forwarded by the API gateway.                  |
| `requestBody`                                                                        | [operations.UpdateTeamRequestBody](../../models/operations/updateteamrequestbody.md) | :heavy_minus_sign:                                                                   | N/A                                                                                  |