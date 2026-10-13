# AnalyticsCaptureRequest

## Example Usage

```typescript
import { AnalyticsCaptureRequest } from "@meetkai/mka1/models/components";

let value: AnalyticsCaptureRequest = {
  idempotencyKey: "<value>",
  events: [],
};
```

## Fields

| Field                                                                                                                        | Type                                                                                                                         | Required                                                                                                                     | Description                                                                                                                  |
| ---------------------------------------------------------------------------------------------------------------------------- | ---------------------------------------------------------------------------------------------------------------------------- | ---------------------------------------------------------------------------------------------------------------------------- | ---------------------------------------------------------------------------------------------------------------------------- |
| `idempotencyKey`                                                                                                             | *string*                                                                                                                     | :heavy_check_mark:                                                                                                           | Unique identifier for this batch. Reuse it with the same events when retrying. Reusing it with different events returns 409. |
| `events`                                                                                                                     | [components.AnalyticsEvent](../../models/components/analyticsevent.md)[]                                                     | :heavy_check_mark:                                                                                                           | N/A                                                                                                                          |