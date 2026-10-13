# AnalyticsCaptureRequest

## Example Usage

```typescript
import { AnalyticsCaptureRequest } from "@meetkai/mka1/models/operations";

let value: AnalyticsCaptureRequest = {
  analyticsCaptureRequest: {
    idempotencyKey: "<value>",
    events: [],
  },
};
```

## Fields

| Field                                                                                    | Type                                                                                     | Required                                                                                 | Description                                                                              |
| ---------------------------------------------------------------------------------------- | ---------------------------------------------------------------------------------------- | ---------------------------------------------------------------------------------------- | ---------------------------------------------------------------------------------------- |
| `xOnBehalfOf`                                                                            | *string*                                                                                 | :heavy_minus_sign:                                                                       | Optional external end-user identifier forwarded by the API gateway.                      |
| `analyticsCaptureRequest`                                                                | [components.AnalyticsCaptureRequest](../../models/components/analyticscapturerequest.md) | :heavy_check_mark:                                                                       | N/A                                                                                      |