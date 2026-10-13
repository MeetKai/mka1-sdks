# AnalyticsEventSearchResponse

## Example Usage

```typescript
import { AnalyticsEventSearchResponse } from "@meetkai/mka1/models/components";

let value: AnalyticsEventSearchResponse = {
  events: [],
  nextCursor: "<value>",
};
```

## Fields

| Field                                                                                                                         | Type                                                                                                                          | Required                                                                                                                      | Description                                                                                                                   |
| ----------------------------------------------------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------------------------------------------------- |
| `events`                                                                                                                      | [components.AnalyticsEvent](../../models/components/analyticsevent.md)[]                                                      | :heavy_check_mark:                                                                                                            | Matching events, newest first. Events with the same timestamp are ordered by event_id, descending.                            |
| `nextCursor`                                                                                                                  | *string*                                                                                                                      | :heavy_check_mark:                                                                                                            | Cursor for the next page, or null when there are no more rows. It continues the sequence at the snapshot its first page took. |