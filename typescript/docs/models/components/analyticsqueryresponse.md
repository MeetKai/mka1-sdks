# AnalyticsQueryResponse

## Example Usage

```typescript
import { AnalyticsQueryResponse } from "@meetkai/mka1/models/components";

let value: AnalyticsQueryResponse = {
  metric: "unique_visitors",
  rows: [],
};
```

## Fields

| Field                                                                                              | Type                                                                                               | Required                                                                                           | Description                                                                                        |
| -------------------------------------------------------------------------------------------------- | -------------------------------------------------------------------------------------------------- | -------------------------------------------------------------------------------------------------- | -------------------------------------------------------------------------------------------------- |
| `metric`                                                                                           | [components.AnalyticsQueryResponseMetric](../../models/components/analyticsqueryresponsemetric.md) | :heavy_check_mark:                                                                                 | N/A                                                                                                |
| `rows`                                                                                             | [components.Rows](../../models/components/rows.md)[]                                               | :heavy_check_mark:                                                                                 | N/A                                                                                                |