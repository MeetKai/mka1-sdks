# ListStandaloneVolumesRequest

## Example Usage

```typescript
import { ListStandaloneVolumesRequest } from "@meetkai/mka1/models/operations";

let value: ListStandaloneVolumesRequest = {};
```

## Fields

| Field                                                                                              | Type                                                                                               | Required                                                                                           | Description                                                                                        |
| -------------------------------------------------------------------------------------------------- | -------------------------------------------------------------------------------------------------- | -------------------------------------------------------------------------------------------------- | -------------------------------------------------------------------------------------------------- |
| `status`                                                                                           | [components.ComputeStandaloneVolumeState](../../models/components/computestandalonevolumestate.md) | :heavy_minus_sign:                                                                                 | N/A                                                                                                |
| `cursor`                                                                                           | *string*                                                                                           | :heavy_minus_sign:                                                                                 | N/A                                                                                                |
| `limit`                                                                                            | *number*                                                                                           | :heavy_minus_sign:                                                                                 | N/A                                                                                                |
| `xOnBehalfOf`                                                                                      | *string*                                                                                           | :heavy_minus_sign:                                                                                 | Optional external end-user identifier forwarded by the API gateway.                                |