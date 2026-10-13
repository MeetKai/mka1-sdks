# TrackingExperimentsGetRequest

## Example Usage

```typescript
import { TrackingExperimentsGetRequest } from "@meetkai/mka1/models/operations";

let value: TrackingExperimentsGetRequest = {
  experimentId: "<id>",
};
```

## Fields

| Field                                                               | Type                                                                | Required                                                            | Description                                                         |
| ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- |
| `experimentId`                                                      | *string*                                                            | :heavy_check_mark:                                                  | N/A                                                                 |
| `xOnBehalfOf`                                                       | *string*                                                            | :heavy_minus_sign:                                                  | Optional external end-user identifier forwarded by the API gateway. |