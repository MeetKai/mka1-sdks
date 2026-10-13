# CompactResponseRequest

## Example Usage

```typescript
import { CompactResponseRequest } from "@meetkai/mka1/models/operations";

let value: CompactResponseRequest = {
  compactResponseRequest: {
    model: "Volt",
    input: [
      {
        type: "mcp_list_tools",
        id: "<id>",
        serverLabel: "<value>",
        tools: [],
      },
    ],
  },
};
```

## Fields

| Field                                                                                  | Type                                                                                   | Required                                                                               | Description                                                                            |
| -------------------------------------------------------------------------------------- | -------------------------------------------------------------------------------------- | -------------------------------------------------------------------------------------- | -------------------------------------------------------------------------------------- |
| `xOnBehalfOf`                                                                          | *string*                                                                               | :heavy_minus_sign:                                                                     | Optional external end-user identifier forwarded by the API gateway.                    |
| `compactResponseRequest`                                                               | [components.CompactResponseRequest](../../models/components/compactresponserequest.md) | :heavy_check_mark:                                                                     | N/A                                                                                    |