# UpdateClusterInviteRequest

## Example Usage

```typescript
import { UpdateClusterInviteRequest } from "@meetkai/mka1/models/operations";

let value: UpdateClusterInviteRequest = {
  id: "<id>",
  requestBody: {},
};
```

## Fields

| Field                                                                                                  | Type                                                                                                   | Required                                                                                               | Description                                                                                            |
| ------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------ |
| `id`                                                                                                   | *string*                                                                                               | :heavy_check_mark:                                                                                     | N/A                                                                                                    |
| `xOnBehalfOf`                                                                                          | *string*                                                                                               | :heavy_minus_sign:                                                                                     | Optional external end-user identifier forwarded by the API gateway.                                    |
| `requestBody`                                                                                          | [operations.UpdateClusterInviteRequestBody](../../models/operations/updateclusterinviterequestbody.md) | :heavy_check_mark:                                                                                     | N/A                                                                                                    |