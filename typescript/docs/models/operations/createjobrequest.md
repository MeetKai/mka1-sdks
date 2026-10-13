# CreateJobRequest

## Example Usage

```typescript
import { CreateJobRequest } from "@meetkai/mka1/models/operations";

let value: CreateJobRequest = {
  idempotencyKey: "<value>",
  computeJobCreate: {
    compute: {
      accelerator: "<value>",
      ephemeralDiskGb: 133945,
      gpuCount: 438176,
    },
    container: {
      command: [
        "<value 1>",
        "<value 2>",
        "<value 3>",
      ],
      image: "https://picsum.photos/seed/vmW8a7k/964/997",
    },
  },
};
```

## Fields

| Field                                                                      | Type                                                                       | Required                                                                   | Description                                                                |
| -------------------------------------------------------------------------- | -------------------------------------------------------------------------- | -------------------------------------------------------------------------- | -------------------------------------------------------------------------- |
| `idempotencyKey`                                                           | *string*                                                                   | :heavy_check_mark:                                                         | N/A                                                                        |
| `xOnBehalfOf`                                                              | *string*                                                                   | :heavy_minus_sign:                                                         | Optional external end-user identifier forwarded by the API gateway.        |
| `computeJobCreate`                                                         | [components.ComputeJobCreate](../../models/components/computejobcreate.md) | :heavy_check_mark:                                                         | N/A                                                                        |