# EffectivePriceRow

## Example Usage

```typescript
import { EffectivePriceRow } from "@meetkai/mka1/models/components";

let value: EffectivePriceRow = {
  model: "Aventador",
  rates: {},
  source: "cluster_default",
};
```

## Fields

| Field                                                                                    | Type                                                                                     | Required                                                                                 | Description                                                                              |
| ---------------------------------------------------------------------------------------- | ---------------------------------------------------------------------------------------- | ---------------------------------------------------------------------------------------- | ---------------------------------------------------------------------------------------- |
| `model`                                                                                  | *string*                                                                                 | :heavy_check_mark:                                                                       | N/A                                                                                      |
| `rates`                                                                                  | [components.EffectivePriceRowRates](../../models/components/effectivepricerowrates.md)   | :heavy_check_mark:                                                                       | N/A                                                                                      |
| `source`                                                                                 | [components.EffectivePriceRowSource](../../models/components/effectivepricerowsource.md) | :heavy_check_mark:                                                                       | N/A                                                                                      |
| `resolvesTo`                                                                             | *string*[]                                                                               | :heavy_minus_sign:                                                                       | N/A                                                                                      |