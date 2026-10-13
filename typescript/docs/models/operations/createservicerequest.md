# CreateServiceRequest

## Example Usage

```typescript
import { CreateServiceRequest } from "@meetkai/mka1/models/operations";

let value: CreateServiceRequest = {
  idempotencyKey: "<value>",
  computeResourceCreate: {
    compute: {
      accelerator: "<value>",
      ephemeralDiskGb: 133945,
      gpuCount: 438176,
    },
    container: {
      image: "https://loremflickr.com/1288/320?lock=2331794271158214",
      scriptB64: "<value>",
    },
  },
};
```

## Fields

| Field                                                                                | Type                                                                                 | Required                                                                             | Description                                                                          |
| ------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------ |
| `idempotencyKey`                                                                     | *string*                                                                             | :heavy_check_mark:                                                                   | N/A                                                                                  |
| `xOnBehalfOf`                                                                        | *string*                                                                             | :heavy_minus_sign:                                                                   | Optional external end-user identifier forwarded by the API gateway.                  |
| `computeResourceCreate`                                                              | [components.ComputeResourceCreate](../../models/components/computeresourcecreate.md) | :heavy_check_mark:                                                                   | N/A                                                                                  |