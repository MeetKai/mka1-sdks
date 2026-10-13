# TrackingExperimentsGetByNameRequest

## Example Usage

```typescript
import { TrackingExperimentsGetByNameRequest } from "@meetkai/mka1/models/operations";

let value: TrackingExperimentsGetByNameRequest = {
  experimentName: "<value>",
};
```

## Fields

| Field                                                               | Type                                                                | Required                                                            | Description                                                         |
| ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- |
| `experimentName`                                                    | *string*                                                            | :heavy_check_mark:                                                  | N/A                                                                 |
| `xOnBehalfOf`                                                       | *string*                                                            | :heavy_minus_sign:                                                  | Optional external end-user identifier forwarded by the API gateway. |