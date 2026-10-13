# GetMcpServerRequest

## Example Usage

```typescript
import { GetMcpServerRequest } from "@meetkai/mka1/models/operations";

let value: GetMcpServerRequest = {
  serverId: "mcp_srv_aa87e2b1112a455b8deabed784372198",
};
```

## Fields

| Field                                                               | Type                                                                | Required                                                            | Description                                                         | Example                                                             |
| ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- |
| `serverId`                                                          | *string*                                                            | :heavy_check_mark:                                                  | N/A                                                                 | mcp_srv_aa87e2b1112a455b8deabed784372198                            |
| `xOnBehalfOf`                                                       | *string*                                                            | :heavy_minus_sign:                                                  | Optional external end-user identifier forwarded by the API gateway. |                                                                     |