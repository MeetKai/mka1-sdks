# AnalyticsKeysCreateRequest

## Example Usage

```typescript
import { AnalyticsKeysCreateRequest } from "@meetkai/mka1/models/operations";

let value: AnalyticsKeysCreateRequest = {
  id: "<id>",
  analyticsKeyCreate: {
    name: "<value>",
  },
};
```

## Fields

| Field                                                                          | Type                                                                           | Required                                                                       | Description                                                                    |
| ------------------------------------------------------------------------------ | ------------------------------------------------------------------------------ | ------------------------------------------------------------------------------ | ------------------------------------------------------------------------------ |
| `id`                                                                           | *string*                                                                       | :heavy_check_mark:                                                             | ID of the analytics project.                                                   |
| `analyticsKeyCreate`                                                           | [components.AnalyticsKeyCreate](../../models/components/analyticskeycreate.md) | :heavy_check_mark:                                                             | N/A                                                                            |