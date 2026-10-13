# ComputeProviderQuote

## Example Usage

```typescript
import { ComputeProviderQuote } from "@meetkai/mka1/models/components";

let value: ComputeProviderQuote = {
  available: true,
  priceUsdHr: {
    max: 1970.25,
    min: 7408.09,
  },
  provider: "<value>",
};
```

## Fields

| Field                                                                         | Type                                                                          | Required                                                                      | Description                                                                   |
| ----------------------------------------------------------------------------- | ----------------------------------------------------------------------------- | ----------------------------------------------------------------------------- | ----------------------------------------------------------------------------- |
| `available`                                                                   | *boolean*                                                                     | :heavy_check_mark:                                                            | N/A                                                                           |
| `priceUsdHr`                                                                  | [components.ComputePriceRange](../../models/components/computepricerange.md)  | :heavy_check_mark:                                                            | N/A                                                                           |
| `provider`                                                                    | *string*                                                                      | :heavy_check_mark:                                                            | Opaque compute-provider identifier. Supported values are deployment-specific. |