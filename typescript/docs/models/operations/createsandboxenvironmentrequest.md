# CreateSandboxEnvironmentRequest

## Example Usage

```typescript
import { CreateSandboxEnvironmentRequest } from "@meetkai/mka1/models/operations";

let value: CreateSandboxEnvironmentRequest = {
  saveEnvironmentRequest: {
    name: "<value>",
  },
};
```

## Fields

| Field                                                                                  | Type                                                                                   | Required                                                                               | Description                                                                            |
| -------------------------------------------------------------------------------------- | -------------------------------------------------------------------------------------- | -------------------------------------------------------------------------------------- | -------------------------------------------------------------------------------------- |
| `xOnBehalfOf`                                                                          | *string*                                                                               | :heavy_minus_sign:                                                                     | Optional external end-user identifier forwarded by the API gateway.                    |
| `saveEnvironmentRequest`                                                               | [components.SaveEnvironmentRequest](../../models/components/saveenvironmentrequest.md) | :heavy_check_mark:                                                                     | N/A                                                                                    |