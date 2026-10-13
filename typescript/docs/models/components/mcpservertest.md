# McpServerTest

## Example Usage

```typescript
import { McpServerTest } from "@meetkai/mka1/models/components";

let value: McpServerTest = {
  serverId: "<id>",
  object: "mcp.server.test",
  connected: false,
  toolCount: 941501,
  toolNames: [
    "<value 1>",
    "<value 2>",
  ],
};
```

## Fields

| Field                                                                                                            | Type                                                                                                             | Required                                                                                                         | Description                                                                                                      |
| ---------------------------------------------------------------------------------------------------------------- | ---------------------------------------------------------------------------------------------------------------- | ---------------------------------------------------------------------------------------------------------------- | ---------------------------------------------------------------------------------------------------------------- |
| `serverId`                                                                                                       | *string*                                                                                                         | :heavy_check_mark:                                                                                               | N/A                                                                                                              |
| `object`                                                                                                         | *"mcp.server.test"*                                                                                              | :heavy_check_mark:                                                                                               | N/A                                                                                                              |
| `connected`                                                                                                      | *boolean*                                                                                                        | :heavy_check_mark:                                                                                               | Always true on a successful connection test; failed connections return HTTP 502. Retained for SDK compatibility. |
| `toolCount`                                                                                                      | *number*                                                                                                         | :heavy_check_mark:                                                                                               | N/A                                                                                                              |
| `toolNames`                                                                                                      | *string*[]                                                                                                       | :heavy_check_mark:                                                                                               | N/A                                                                                                              |