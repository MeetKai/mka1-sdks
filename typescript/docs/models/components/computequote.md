# ComputeQuote

## Example Usage

```typescript
import { ComputeQuote } from "@meetkai/mka1/models/components";

let value: ComputeQuote = {
  available: false,
  expiresAt: new Date("2024-10-11T19:12:49.759Z"),
  observedAt: new Date("2026-12-15T10:33:09.490Z"),
  priceUsdHr: {
    max: 1970.25,
    min: 7408.09,
  },
};
```

## Fields

| Field                                                                                         | Type                                                                                          | Required                                                                                      | Description                                                                                   |
| --------------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------------- |
| `available`                                                                                   | *boolean*                                                                                     | :heavy_check_mark:                                                                            | N/A                                                                                           |
| `expiresAt`                                                                                   | [Date](https://developer.mozilla.org/en-US/docs/Web/JavaScript/Reference/Global_Objects/Date) | :heavy_check_mark:                                                                            | N/A                                                                                           |
| `observedAt`                                                                                  | [Date](https://developer.mozilla.org/en-US/docs/Web/JavaScript/Reference/Global_Objects/Date) | :heavy_check_mark:                                                                            | N/A                                                                                           |
| `priceBreakdownUsdHr`                                                                         | [components.PriceBreakdownUsdHr](../../models/components/pricebreakdownusdhr.md)              | :heavy_minus_sign:                                                                            | N/A                                                                                           |
| `priceUsdHr`                                                                                  | [components.ComputePriceRange](../../models/components/computepricerange.md)                  | :heavy_check_mark:                                                                            | N/A                                                                                           |
| `providers`                                                                                   | [components.ComputeProviderQuote](../../models/components/computeproviderquote.md)[]          | :heavy_minus_sign:                                                                            | N/A                                                                                           |