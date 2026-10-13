# TrackingRunsSearchRequestBody

## Example Usage

```typescript
import { TrackingRunsSearchRequestBody } from "@meetkai/mka1/models/operations";

let value: TrackingRunsSearchRequestBody = {
  experimentIds: [],
};
```

## Fields

| Field                                                            | Type                                                             | Required                                                         | Description                                                      |
| ---------------------------------------------------------------- | ---------------------------------------------------------------- | ---------------------------------------------------------------- | ---------------------------------------------------------------- |
| `experimentIds`                                                  | *string*[]                                                       | :heavy_check_mark:                                               | N/A                                                              |
| `filter`                                                         | *string*                                                         | :heavy_minus_sign:                                               | N/A                                                              |
| `maxResults`                                                     | *number*                                                         | :heavy_minus_sign:                                               | N/A                                                              |
| `orderBy`                                                        | *string*[]                                                       | :heavy_minus_sign:                                               | N/A                                                              |
| `pageToken`                                                      | *string*                                                         | :heavy_minus_sign:                                               | N/A                                                              |
| `runViewType`                                                    | [operations.RunViewType](../../models/operations/runviewtype.md) | :heavy_minus_sign:                                               | N/A                                                              |