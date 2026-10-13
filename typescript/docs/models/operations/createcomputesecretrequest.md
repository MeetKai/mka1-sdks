# CreateComputeSecretRequest

## Example Usage

```typescript
import { CreateComputeSecretRequest } from "@meetkai/mka1/models/operations";

let value: CreateComputeSecretRequest = {
  computeSecretCreate: {
    data: {
      "key": "<value>",
    },
    name: "<value>",
  },
};
```

## Fields

| Field                                                                            | Type                                                                             | Required                                                                         | Description                                                                      |
| -------------------------------------------------------------------------------- | -------------------------------------------------------------------------------- | -------------------------------------------------------------------------------- | -------------------------------------------------------------------------------- |
| `xOnBehalfOf`                                                                    | *string*                                                                         | :heavy_minus_sign:                                                               | Optional external end-user identifier forwarded by the API gateway.              |
| `computeSecretCreate`                                                            | [components.ComputeSecretCreate](../../models/components/computesecretcreate.md) | :heavy_check_mark:                                                               | N/A                                                                              |