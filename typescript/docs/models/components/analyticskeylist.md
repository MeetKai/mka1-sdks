# AnalyticsKeyList

## Example Usage

```typescript
import { AnalyticsKeyList } from "@meetkai/mka1/models/components";

let value: AnalyticsKeyList = {
  keys: [
    {
      id: "<id>",
      projectId: "<id>",
      name: "<value>",
      prefix: "<value>",
      createdAt: new Date("2026-09-01T12:30:00Z"),
      revokedAt: new Date("2026-09-02T12:30:00Z"),
    },
  ],
  nextCursor: "<value>",
};
```

## Fields

| Field                                                                              | Type                                                                               | Required                                                                           | Description                                                                        |
| ---------------------------------------------------------------------------------- | ---------------------------------------------------------------------------------- | ---------------------------------------------------------------------------------- | ---------------------------------------------------------------------------------- |
| `keys`                                                                             | [components.AnalyticsCaptureKey](../../models/components/analyticscapturekey.md)[] | :heavy_check_mark:                                                                 | N/A                                                                                |
| `nextCursor`                                                                       | *string*                                                                           | :heavy_check_mark:                                                                 | N/A                                                                                |