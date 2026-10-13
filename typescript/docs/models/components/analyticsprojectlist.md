# AnalyticsProjectList

## Example Usage

```typescript
import { AnalyticsProjectList } from "@meetkai/mka1/models/components";

let value: AnalyticsProjectList = {
  projects: [
    {
      id: "<id>",
      orgId: "<id>",
      teamId: "<id>",
      name: "<value>",
      createdAt: new Date("2026-09-01T12:30:00Z"),
      updatedAt: new Date("2026-09-01T12:30:00Z"),
      archivedAt: new Date("2026-09-02T12:30:00Z"),
    },
  ],
  nextCursor: "<value>",
};
```

## Fields

| Field                                                                        | Type                                                                         | Required                                                                     | Description                                                                  |
| ---------------------------------------------------------------------------- | ---------------------------------------------------------------------------- | ---------------------------------------------------------------------------- | ---------------------------------------------------------------------------- |
| `projects`                                                                   | [components.AnalyticsProject](../../models/components/analyticsproject.md)[] | :heavy_check_mark:                                                           | N/A                                                                          |
| `nextCursor`                                                                 | *string*                                                                     | :heavy_check_mark:                                                           | N/A                                                                          |