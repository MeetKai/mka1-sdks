# ListJobsRequest

## Example Usage

```typescript
import { ListJobsRequest } from "@meetkai/mka1/models/operations";

let value: ListJobsRequest = {};
```

## Fields

| Field                                                                              | Type                                                                               | Required                                                                           | Description                                                                        |
| ---------------------------------------------------------------------------------- | ---------------------------------------------------------------------------------- | ---------------------------------------------------------------------------------- | ---------------------------------------------------------------------------------- |
| `state`                                                                            | [components.ComputeResourceState](../../models/components/computeresourcestate.md) | :heavy_minus_sign:                                                                 | N/A                                                                                |
| `cursor`                                                                           | *string*                                                                           | :heavy_minus_sign:                                                                 | N/A                                                                                |
| `limit`                                                                            | *number*                                                                           | :heavy_minus_sign:                                                                 | N/A                                                                                |
| `xOnBehalfOf`                                                                      | *string*                                                                           | :heavy_minus_sign:                                                                 | Optional external end-user identifier forwarded by the API gateway.                |