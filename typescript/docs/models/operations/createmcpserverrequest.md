# CreateMcpServerRequest

## Example Usage

```typescript
import { CreateMcpServerRequest } from "@meetkai/mka1/models/operations";

let value: CreateMcpServerRequest = {
  createMcpServerRequest: {
    name: "<value>",
    serverLabel: "<value>",
    serverUrl: "https://plain-bakeware.info/",
  },
};
```

## Fields

| Field                                                                                  | Type                                                                                   | Required                                                                               | Description                                                                            |
| -------------------------------------------------------------------------------------- | -------------------------------------------------------------------------------------- | -------------------------------------------------------------------------------------- | -------------------------------------------------------------------------------------- |
| `xOnBehalfOf`                                                                          | *string*                                                                               | :heavy_minus_sign:                                                                     | Optional external end-user identifier forwarded by the API gateway.                    |
| `createMcpServerRequest`                                                               | [components.CreateMcpServerRequest](../../models/components/createmcpserverrequest.md) | :heavy_check_mark:                                                                     | N/A                                                                                    |