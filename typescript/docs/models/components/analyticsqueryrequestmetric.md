# AnalyticsQueryRequestMetric

count counts events. unique_visitors counts distinct values of distinct_id. Both deduplicate event IDs first.

## Example Usage

```typescript
import { AnalyticsQueryRequestMetric } from "@meetkai/mka1/models/components";

let value: AnalyticsQueryRequestMetric = "count";
```

## Values

```typescript
"count" | "unique_visitors"
```