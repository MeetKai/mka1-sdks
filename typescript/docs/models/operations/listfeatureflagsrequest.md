# ListFeatureFlagsRequest

## Example Usage

```typescript
import { ListFeatureFlagsRequest } from "@meetkai/mka1/models/operations";

let value: ListFeatureFlagsRequest = {};
```

## Fields

| Field                                                                         | Type                                                                          | Required                                                                      | Description                                                                   |
| ----------------------------------------------------------------------------- | ----------------------------------------------------------------------------- | ----------------------------------------------------------------------------- | ----------------------------------------------------------------------------- |
| `includeArchived`                                                             | *boolean*                                                                     | :heavy_minus_sign:                                                            | N/A                                                                           |
| `projectId`                                                                   | *string*                                                                      | :heavy_minus_sign:                                                            | Return only flags assigned to this project. Flag keys remain globally unique. |
| `xOnBehalfOf`                                                                 | *string*                                                                      | :heavy_minus_sign:                                                            | Optional external end-user identifier forwarded by the API gateway.           |