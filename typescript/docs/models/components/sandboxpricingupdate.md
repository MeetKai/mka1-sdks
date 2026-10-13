# SandboxPricingUpdate

Full-replace rate card update.

A SKU that has a price and is omitted here would become unpriced, and its
usage would then be recorded with no cost, which can never be billed. That
is refused unless ``allow_unpriced`` says it is intended.

## Example Usage

```typescript
import { SandboxPricingUpdate } from "@meetkai/mka1/models/components";

let value: SandboxPricingUpdate = {
  rates: {},
};
```

## Fields

| Field                                                                                      | Type                                                                                       | Required                                                                                   | Description                                                                                |
| ------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------ |
| `rates`                                                                                    | Record<string, [components.SandboxPriceRate](../../models/components/sandboxpricerate.md)> | :heavy_check_mark:                                                                         | N/A                                                                                        |
| `currency`                                                                                 | *string*                                                                                   | :heavy_minus_sign:                                                                         | N/A                                                                                        |
| `allowUnpriced`                                                                            | *boolean*                                                                                  | :heavy_minus_sign:                                                                         | N/A                                                                                        |