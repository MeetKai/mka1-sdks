# AnalyticsProjectsUpdateRequest

## Example Usage

```typescript
import { AnalyticsProjectsUpdateRequest } from "@meetkai/mka1/models/operations";

let value: AnalyticsProjectsUpdateRequest = {
  id: "<id>",
  analyticsProjectUpdate: {
    name: "<value>",
  },
};
```

## Fields

| Field                                                                                  | Type                                                                                   | Required                                                                               | Description                                                                            |
| -------------------------------------------------------------------------------------- | -------------------------------------------------------------------------------------- | -------------------------------------------------------------------------------------- | -------------------------------------------------------------------------------------- |
| `id`                                                                                   | *string*                                                                               | :heavy_check_mark:                                                                     | ID of the analytics project.                                                           |
| `analyticsProjectUpdate`                                                               | [components.AnalyticsProjectUpdate](../../models/components/analyticsprojectupdate.md) | :heavy_check_mark:                                                                     | N/A                                                                                    |