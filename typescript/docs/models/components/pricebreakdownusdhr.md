# PriceBreakdownUsdHr

## Example Usage

```typescript
import { PriceBreakdownUsdHr } from "@meetkai/mka1/models/components";

let value: PriceBreakdownUsdHr = {
  compute: {
    max: 731.63,
    min: 1906.51,
  },
  volume: {
    max: 1225.88,
    min: 9068.24,
  },
};
```

## Fields

| Field                                                                        | Type                                                                         | Required                                                                     | Description                                                                  |
| ---------------------------------------------------------------------------- | ---------------------------------------------------------------------------- | ---------------------------------------------------------------------------- | ---------------------------------------------------------------------------- |
| `compute`                                                                    | [components.ComputePriceRange](../../models/components/computepricerange.md) | :heavy_check_mark:                                                           | N/A                                                                          |
| `volume`                                                                     | [components.ComputePriceRange](../../models/components/computepricerange.md) | :heavy_check_mark:                                                           | N/A                                                                          |