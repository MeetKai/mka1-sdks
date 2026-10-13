# UpdateMcpServerRequest

## Example Usage

```typescript
import { UpdateMcpServerRequest } from "@meetkai/mka1/models/operations";

let value: UpdateMcpServerRequest = {
  serverId: "mcp_srv_aa87e2b1112a455b8deabed784372198",
  updateMcpServerRequest: {},
};
```

## Fields

| Field                                                                                  | Type                                                                                   | Required                                                                               | Description                                                                            | Example                                                                                |
| -------------------------------------------------------------------------------------- | -------------------------------------------------------------------------------------- | -------------------------------------------------------------------------------------- | -------------------------------------------------------------------------------------- | -------------------------------------------------------------------------------------- |
| `serverId`                                                                             | *string*                                                                               | :heavy_check_mark:                                                                     | N/A                                                                                    | mcp_srv_aa87e2b1112a455b8deabed784372198                                               |
| `xOnBehalfOf`                                                                          | *string*                                                                               | :heavy_minus_sign:                                                                     | Optional external end-user identifier forwarded by the API gateway.                    |                                                                                        |
| `updateMcpServerRequest`                                                               | [components.UpdateMcpServerRequest](../../models/components/updatemcpserverrequest.md) | :heavy_check_mark:                                                                     | N/A                                                                                    |                                                                                        |