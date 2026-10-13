# CreateComputeQuoteRequest

## Example Usage

```typescript
import { CreateComputeQuoteRequest } from "@meetkai/mka1/models/operations";

let value: CreateComputeQuoteRequest = {
  computeQuoteRequest: {
    compute: {
      accelerator: "<value>",
      ephemeralDiskGb: 133945,
      gpuCount: 438176,
    },
    container: {
      image: "https://loremflickr.com/2920/449?lock=7599160431540206",
    },
    resourceType: "service",
  },
};
```

## Fields

| Field                                                                            | Type                                                                             | Required                                                                         | Description                                                                      |
| -------------------------------------------------------------------------------- | -------------------------------------------------------------------------------- | -------------------------------------------------------------------------------- | -------------------------------------------------------------------------------- |
| `xOnBehalfOf`                                                                    | *string*                                                                         | :heavy_minus_sign:                                                               | Optional external end-user identifier forwarded by the API gateway.              |
| `computeQuoteRequest`                                                            | [components.ComputeQuoteRequest](../../models/components/computequoterequest.md) | :heavy_check_mark:                                                               | N/A                                                                              |