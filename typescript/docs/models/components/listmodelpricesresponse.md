# ListModelPricesResponse

## Example Usage

```typescript
import { ListModelPricesResponse } from "@meetkai/mka1/models/components";

let value: ListModelPricesResponse = {
  object: "list",
  data: [
    {
      model: "V90",
      orgId: "<id>",
      rates: {},
      effectiveFrom: "<value>",
      effectiveTo: "<value>",
      setBy: "<value>",
    },
  ],
};
```

## Fields

| Field                                                                  | Type                                                                   | Required                                                               | Description                                                            |
| ---------------------------------------------------------------------- | ---------------------------------------------------------------------- | ---------------------------------------------------------------------- | ---------------------------------------------------------------------- |
| `object`                                                               | *"list"*                                                               | :heavy_check_mark:                                                     | N/A                                                                    |
| `data`                                                                 | [components.ModelPriceRow](../../models/components/modelpricerow.md)[] | :heavy_check_mark:                                                     | N/A                                                                    |