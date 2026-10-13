# AnalyticsEventsSearchRequest

## Example Usage

```typescript
import { AnalyticsEventsSearchRequest } from "@meetkai/mka1/models/operations";

let value: AnalyticsEventsSearchRequest = {
  id: "<id>",
  analyticsEventSearchRequest: {
    from: new Date("2026-09-01T00:00:00Z"),
    to: new Date("2026-09-02T00:00:00Z"),
    eventName: "page_view",
    filters: [
      {
        property: "plan",
        op: "gte",
      },
    ],
  },
};
```

## Fields

| Field                                                                                            | Type                                                                                             | Required                                                                                         | Description                                                                                      |
| ------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------ |
| `id`                                                                                             | *string*                                                                                         | :heavy_check_mark:                                                                               | ID of the analytics project.                                                                     |
| `analyticsEventSearchRequest`                                                                    | [components.AnalyticsEventSearchRequest](../../models/components/analyticseventsearchrequest.md) | :heavy_check_mark:                                                                               | N/A                                                                                              |