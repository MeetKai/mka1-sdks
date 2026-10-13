# UpdateMcpServerRequest

## Example Usage

```typescript
import { UpdateMcpServerRequest } from "@meetkai/mka1/models/components";

let value: UpdateMcpServerRequest = {};
```

## Fields

| Field                                                                          | Type                                                                           | Required                                                                       | Description                                                                    |
| ------------------------------------------------------------------------------ | ------------------------------------------------------------------------------ | ------------------------------------------------------------------------------ | ------------------------------------------------------------------------------ |
| `name`                                                                         | *string*                                                                       | :heavy_minus_sign:                                                             | N/A                                                                            |
| `serverLabel`                                                                  | *string*                                                                       | :heavy_minus_sign:                                                             | N/A                                                                            |
| `serverUrl`                                                                    | *string*                                                                       | :heavy_minus_sign:                                                             | N/A                                                                            |
| `serverDescription`                                                            | *string*                                                                       | :heavy_minus_sign:                                                             | N/A                                                                            |
| `allowedTools`                                                                 | *components.MCPAllowedTools*                                                   | :heavy_minus_sign:                                                             | N/A                                                                            |
| `requireApproval`                                                              | [components.MCPRequireApproval](../../models/components/mcprequireapproval.md) | :heavy_minus_sign:                                                             | N/A                                                                            |
| `metadata`                                                                     | Record<string, *any*>                                                          | :heavy_minus_sign:                                                             | N/A                                                                            |