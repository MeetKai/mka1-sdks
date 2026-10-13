# PatchRepoRequest

## Example Usage

```typescript
import { PatchRepoRequest } from "@meetkai/mka1/models/operations";

let value: PatchRepoRequest = {
  org: "<value>",
  name: "<value>",
  patchRepoRequest: {},
};
```

## Fields

| Field                                                                      | Type                                                                       | Required                                                                   | Description                                                                |
| -------------------------------------------------------------------------- | -------------------------------------------------------------------------- | -------------------------------------------------------------------------- | -------------------------------------------------------------------------- |
| `org`                                                                      | *string*                                                                   | :heavy_check_mark:                                                         | The organization URL slug.                                                 |
| `name`                                                                     | *string*                                                                   | :heavy_check_mark:                                                         | The repository name (URL label).                                           |
| `xOnBehalfOf`                                                              | *string*                                                                   | :heavy_minus_sign:                                                         | Optional external end-user identifier forwarded by the API gateway.        |
| `patchRepoRequest`                                                         | [components.PatchRepoRequest](../../models/components/patchreporequest.md) | :heavy_check_mark:                                                         | N/A                                                                        |