# EffectivePricesResponse

## Example Usage

```typescript
import { EffectivePricesResponse } from "@meetkai/mka1/models/components";

let value: EffectivePricesResponse = {
  object: "list",
  currency: "Turkish Lira",
  data: [],
};
```

## Fields

| Field                                                                          | Type                                                                           | Required                                                                       | Description                                                                    |
| ------------------------------------------------------------------------------ | ------------------------------------------------------------------------------ | ------------------------------------------------------------------------------ | ------------------------------------------------------------------------------ |
| `object`                                                                       | *"list"*                                                                       | :heavy_check_mark:                                                             | N/A                                                                            |
| `currency`                                                                     | *string*                                                                       | :heavy_check_mark:                                                             | N/A                                                                            |
| `data`                                                                         | [components.EffectivePriceRow](../../models/components/effectivepricerow.md)[] | :heavy_check_mark:                                                             | N/A                                                                            |