# CreateMcpServerRequest

## Example Usage

```typescript
import { CreateMcpServerRequest } from "@meetkai/mka1/models/components";

let value: CreateMcpServerRequest = {
  name: "<value>",
  serverLabel: "<value>",
  serverUrl: "https://plain-bakeware.info/",
};
```

## Fields

| Field                                                                          | Type                                                                           | Required                                                                       | Description                                                                    |
| ------------------------------------------------------------------------------ | ------------------------------------------------------------------------------ | ------------------------------------------------------------------------------ | ------------------------------------------------------------------------------ |
| `name`                                                                         | *string*                                                                       | :heavy_check_mark:                                                             | N/A                                                                            |
| `serverLabel`                                                                  | *string*                                                                       | :heavy_check_mark:                                                             | N/A                                                                            |
| `serverUrl`                                                                    | *string*                                                                       | :heavy_check_mark:                                                             | N/A                                                                            |
| `serverDescription`                                                            | *string*                                                                       | :heavy_minus_sign:                                                             | N/A                                                                            |
| `allowedTools`                                                                 | *components.MCPAllowedTools*                                                   | :heavy_minus_sign:                                                             | N/A                                                                            |
| `requireApproval`                                                              | [components.MCPRequireApproval](../../models/components/mcprequireapproval.md) | :heavy_minus_sign:                                                             | N/A                                                                            |
| `metadata`                                                                     | Record<string, *any*>                                                          | :heavy_minus_sign:                                                             | N/A                                                                            |