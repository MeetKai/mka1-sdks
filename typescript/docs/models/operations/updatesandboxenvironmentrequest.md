# UpdateSandboxEnvironmentRequest

## Example Usage

```typescript
import { UpdateSandboxEnvironmentRequest } from "@meetkai/mka1/models/operations";

let value: UpdateSandboxEnvironmentRequest = {
  environmentId: 374107,
  saveEnvironmentRequest: {
    name: "<value>",
  },
};
```

## Fields

| Field                                                                                  | Type                                                                                   | Required                                                                               | Description                                                                            |
| -------------------------------------------------------------------------------------- | -------------------------------------------------------------------------------------- | -------------------------------------------------------------------------------------- | -------------------------------------------------------------------------------------- |
| `environmentId`                                                                        | *number*                                                                               | :heavy_check_mark:                                                                     | N/A                                                                                    |
| `xOnBehalfOf`                                                                          | *string*                                                                               | :heavy_minus_sign:                                                                     | Optional external end-user identifier forwarded by the API gateway.                    |
| `saveEnvironmentRequest`                                                               | [components.SaveEnvironmentRequest](../../models/components/saveenvironmentrequest.md) | :heavy_check_mark:                                                                     | N/A                                                                                    |