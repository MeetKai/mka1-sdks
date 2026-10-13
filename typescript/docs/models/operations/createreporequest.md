# CreateRepoRequest

## Example Usage

```typescript
import { CreateRepoRequest } from "@meetkai/mka1/models/operations";

let value: CreateRepoRequest = {
  createRepoRequest: {
    name: "my-model",
  },
};
```

## Fields

| Field                                                                        | Type                                                                         | Required                                                                     | Description                                                                  |
| ---------------------------------------------------------------------------- | ---------------------------------------------------------------------------- | ---------------------------------------------------------------------------- | ---------------------------------------------------------------------------- |
| `xOnBehalfOf`                                                                | *string*                                                                     | :heavy_minus_sign:                                                           | Optional external end-user identifier forwarded by the API gateway.          |
| `createRepoRequest`                                                          | [components.CreateRepoRequest](../../models/components/createreporequest.md) | :heavy_check_mark:                                                           | N/A                                                                          |