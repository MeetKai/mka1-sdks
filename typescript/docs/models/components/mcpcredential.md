# McpCredential

## Example Usage

```typescript
import { McpCredential } from "@meetkai/mka1/models/components";

let value: McpCredential = {
  id: "<id>",
  object: "mcp.credential",
  serverId: "<id>",
  name: "<value>",
  authType: "headers",
  authorizationPreview: "<value>",
  headerNames: [
    "<value 1>",
    "<value 2>",
    "<value 3>",
  ],
  expiresAt: new Date("2024-10-05T13:18:04.768Z"),
  lastUsedAt: new Date("2024-03-06T19:46:08.216Z"),
  createdAt: new Date("2024-12-12T20:24:16.909Z"),
  updatedAt: new Date("2024-10-16T15:06:59.906Z"),
  revokedAt: new Date("2026-12-09T16:49:11.107Z"),
};
```

## Fields

| Field                                                                                         | Type                                                                                          | Required                                                                                      | Description                                                                                   |
| --------------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------------- |
| `id`                                                                                          | *string*                                                                                      | :heavy_check_mark:                                                                            | N/A                                                                                           |
| `object`                                                                                      | *"mcp.credential"*                                                                            | :heavy_check_mark:                                                                            | N/A                                                                                           |
| `serverId`                                                                                    | *string*                                                                                      | :heavy_check_mark:                                                                            | N/A                                                                                           |
| `name`                                                                                        | *string*                                                                                      | :heavy_check_mark:                                                                            | N/A                                                                                           |
| `authType`                                                                                    | [components.MCPAuthType](../../models/components/mcpauthtype.md)                              | :heavy_check_mark:                                                                            | N/A                                                                                           |
| `authorizationPreview`                                                                        | *string*                                                                                      | :heavy_check_mark:                                                                            | N/A                                                                                           |
| `headerNames`                                                                                 | *string*[]                                                                                    | :heavy_check_mark:                                                                            | N/A                                                                                           |
| `expiresAt`                                                                                   | [Date](https://developer.mozilla.org/en-US/docs/Web/JavaScript/Reference/Global_Objects/Date) | :heavy_check_mark:                                                                            | N/A                                                                                           |
| `lastUsedAt`                                                                                  | [Date](https://developer.mozilla.org/en-US/docs/Web/JavaScript/Reference/Global_Objects/Date) | :heavy_check_mark:                                                                            | N/A                                                                                           |
| `createdAt`                                                                                   | [Date](https://developer.mozilla.org/en-US/docs/Web/JavaScript/Reference/Global_Objects/Date) | :heavy_check_mark:                                                                            | N/A                                                                                           |
| `updatedAt`                                                                                   | [Date](https://developer.mozilla.org/en-US/docs/Web/JavaScript/Reference/Global_Objects/Date) | :heavy_check_mark:                                                                            | N/A                                                                                           |
| `revokedAt`                                                                                   | [Date](https://developer.mozilla.org/en-US/docs/Web/JavaScript/Reference/Global_Objects/Date) | :heavy_check_mark:                                                                            | N/A                                                                                           |