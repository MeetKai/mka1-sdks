# PutComputeTenantRequest

## Example Usage

```typescript
import { PutComputeTenantRequest } from "@meetkai/mka1/models/operations";

let value: PutComputeTenantRequest = {
  orgId: "<id>",
  computeTenantUpdate: {},
};
```

## Fields

| Field                                                                            | Type                                                                             | Required                                                                         | Description                                                                      |
| -------------------------------------------------------------------------------- | -------------------------------------------------------------------------------- | -------------------------------------------------------------------------------- | -------------------------------------------------------------------------------- |
| `orgId`                                                                          | *string*                                                                         | :heavy_check_mark:                                                               | N/A                                                                              |
| `xOnBehalfOf`                                                                    | *string*                                                                         | :heavy_minus_sign:                                                               | Optional external end-user identifier forwarded by the API gateway.              |
| `computeTenantUpdate`                                                            | [components.ComputeTenantUpdate](../../models/components/computetenantupdate.md) | :heavy_check_mark:                                                               | N/A                                                                              |