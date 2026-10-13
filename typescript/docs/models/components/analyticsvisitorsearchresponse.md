# AnalyticsVisitorSearchResponse

## Example Usage

```typescript
import { AnalyticsVisitorSearchResponse } from "@meetkai/mka1/models/components";

let value: AnalyticsVisitorSearchResponse = {
  visitors: [],
  nextCursor: null,
};
```

## Fields

| Field                                                                                                                         | Type                                                                                                                          | Required                                                                                                                      | Description                                                                                                                   |
| ----------------------------------------------------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------------------------------------------------- |
| `visitors`                                                                                                                    | [components.AnalyticsVisitor](../../models/components/analyticsvisitor.md)[]                                                  | :heavy_check_mark:                                                                                                            | Matching visitors, most recently active first. Visitors with the same last_seen are ordered by distinct_id, descending.       |
| `nextCursor`                                                                                                                  | *string*                                                                                                                      | :heavy_check_mark:                                                                                                            | Cursor for the next page, or null when there are no more rows. It continues the sequence at the snapshot its first page took. |