# McpServerList

## Example Usage

```typescript
import { McpServerList } from "@meetkai/mka1/models/components";

let value: McpServerList = {
  object: "list",
  data: [
    {
      id: "<id>",
      object: "mcp.server",
      name: "<value>",
      serverLabel: "<value>",
      serverUrl: "https://normal-pile.name/",
      serverDescription: "<value>",
      allowedTools: [
        "<value 1>",
      ],
      requireApproval: "always",
      metadata: {
        "key": "<value>",
        "key1": "<value>",
      },
      createdAt: new Date("2025-05-01T18:27:17.555Z"),
      updatedAt: new Date("2026-12-08T12:43:30.219Z"),
    },
  ],
  firstId: "<id>",
  hasMore: false,
  lastId: "<id>",
};
```

## Fields

| Field                                                          | Type                                                           | Required                                                       | Description                                                    |
| -------------------------------------------------------------- | -------------------------------------------------------------- | -------------------------------------------------------------- | -------------------------------------------------------------- |
| `object`                                                       | *"list"*                                                       | :heavy_check_mark:                                             | N/A                                                            |
| `data`                                                         | [components.McpServer](../../models/components/mcpserver.md)[] | :heavy_check_mark:                                             | N/A                                                            |
| `firstId`                                                      | *string*                                                       | :heavy_check_mark:                                             | N/A                                                            |
| `hasMore`                                                      | *boolean*                                                      | :heavy_check_mark:                                             | N/A                                                            |
| `lastId`                                                       | *string*                                                       | :heavy_check_mark:                                             | N/A                                                            |