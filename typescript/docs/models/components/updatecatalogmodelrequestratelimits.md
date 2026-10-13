# UpdateCatalogModelRequestRateLimits

## Example Usage

```typescript
import { UpdateCatalogModelRequestRateLimits } from "@meetkai/mka1/models/components";

let value: UpdateCatalogModelRequestRateLimits = {
  scope: "externalUser",
  rpm: 430921,
};
```

## Fields

| Field                                                                    | Type                                                                     | Required                                                                 | Description                                                              |
| ------------------------------------------------------------------------ | ------------------------------------------------------------------------ | ------------------------------------------------------------------------ | ------------------------------------------------------------------------ |
| `scope`                                                                  | [components.RateLimitsScope](../../models/components/ratelimitsscope.md) | :heavy_check_mark:                                                       | N/A                                                                      |
| `rpm`                                                                    | *number*                                                                 | :heavy_check_mark:                                                       | N/A                                                                      |
| `duration`                                                               | *number*                                                                 | :heavy_minus_sign:                                                       | N/A                                                                      |
| `queue`                                                                  | [components.RateLimitsQueue](../../models/components/ratelimitsqueue.md) | :heavy_minus_sign:                                                       | N/A                                                                      |