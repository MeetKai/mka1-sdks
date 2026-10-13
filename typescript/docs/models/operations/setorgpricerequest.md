# SetOrgPriceRequest

## Example Usage

```typescript
import { SetOrgPriceRequest } from "@meetkai/mka1/models/operations";

let value: SetOrgPriceRequest = {
  orgId: "<id>",
  putModelPriceBody: {
    model: "Golf",
    rates: {},
  },
};
```

## Fields

| Field                                                                        | Type                                                                         | Required                                                                     | Description                                                                  |
| ---------------------------------------------------------------------------- | ---------------------------------------------------------------------------- | ---------------------------------------------------------------------------- | ---------------------------------------------------------------------------- |
| `orgId`                                                                      | *string*                                                                     | :heavy_check_mark:                                                           | N/A                                                                          |
| `putModelPriceBody`                                                          | [components.PutModelPriceBody](../../models/components/putmodelpricebody.md) | :heavy_check_mark:                                                           | N/A                                                                          |