# AnalyticsVisitorsSearchRequest

## Example Usage

```typescript
import { AnalyticsVisitorsSearchRequest } from "@meetkai/mka1/models/operations";

let value: AnalyticsVisitorsSearchRequest = {
  id: "<id>",
  analyticsVisitorSearchRequest: {
    from: new Date("2026-09-01T00:00:00Z"),
    to: new Date("2026-09-02T00:00:00Z"),
    eventName: "page_view",
    filters: [
      {
        property: "plan",
        op: "eq",
      },
    ],
  },
};
```

## Fields

| Field                                                                                                | Type                                                                                                 | Required                                                                                             | Description                                                                                          |
| ---------------------------------------------------------------------------------------------------- | ---------------------------------------------------------------------------------------------------- | ---------------------------------------------------------------------------------------------------- | ---------------------------------------------------------------------------------------------------- |
| `id`                                                                                                 | *string*                                                                                             | :heavy_check_mark:                                                                                   | ID of the analytics project.                                                                         |
| `analyticsVisitorSearchRequest`                                                                      | [components.AnalyticsVisitorSearchRequest](../../models/components/analyticsvisitorsearchrequest.md) | :heavy_check_mark:                                                                                   | N/A                                                                                                  |