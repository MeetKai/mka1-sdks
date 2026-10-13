# ResolveGitHubReferenceRequest

## Example Usage

```typescript
import { ResolveGitHubReferenceRequest } from "@meetkai/mka1/models/operations";

let value: ResolveGitHubReferenceRequest = {
  resolveReferenceRequest: {
    repositoryId: 573141,
  },
};
```

## Fields

| Field                                                                                    | Type                                                                                     | Required                                                                                 | Description                                                                              |
| ---------------------------------------------------------------------------------------- | ---------------------------------------------------------------------------------------- | ---------------------------------------------------------------------------------------- | ---------------------------------------------------------------------------------------- |
| `xOnBehalfOf`                                                                            | *string*                                                                                 | :heavy_minus_sign:                                                                       | Optional external end-user identifier forwarded by the API gateway.                      |
| `resolveReferenceRequest`                                                                | [components.ResolveReferenceRequest](../../models/components/resolvereferencerequest.md) | :heavy_check_mark:                                                                       | N/A                                                                                      |