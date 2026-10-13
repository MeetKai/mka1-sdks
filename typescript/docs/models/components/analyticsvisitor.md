# AnalyticsVisitor

## Example Usage

```typescript
import { AnalyticsVisitor } from "@meetkai/mka1/models/components";

let value: AnalyticsVisitor = {
  distinctId: "<id>",
  firstSeen: new Date("2026-09-17T07:00:00.123Z"),
  lastSeen: new Date("2026-09-17T07:00:00.123Z"),
  eventCount: 773014,
};
```

## Fields

| Field                                                                                           | Type                                                                                            | Required                                                                                        | Description                                                                                     | Example                                                                                         |
| ----------------------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------------------- |
| `distinctId`                                                                                    | *string*                                                                                        | :heavy_check_mark:                                                                              | The visitor's distinct_id as sent with their events.                                            |                                                                                                 |
| `firstSeen`                                                                                     | [Date](https://developer.mozilla.org/en-US/docs/Web/JavaScript/Reference/Global_Objects/Date)   | :heavy_check_mark:                                                                              | Timestamp of the visitor's earliest matching event in the time range, in UTC with milliseconds. | 2026-09-17T07:00:00.123Z                                                                        |
| `lastSeen`                                                                                      | [Date](https://developer.mozilla.org/en-US/docs/Web/JavaScript/Reference/Global_Objects/Date)   | :heavy_check_mark:                                                                              | Timestamp of the visitor's latest matching event in the time range, in UTC with milliseconds.   | 2026-09-17T07:00:00.123Z                                                                        |
| `eventCount`                                                                                    | *number*                                                                                        | :heavy_check_mark:                                                                              | Number of matching events from this visitor across the whole time range, not only this page.    |                                                                                                 |