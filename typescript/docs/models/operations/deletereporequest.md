# DeleteRepoRequest

## Example Usage

```typescript
import { DeleteRepoRequest } from "@meetkai/mka1/models/operations";

let value: DeleteRepoRequest = {
  org: "<value>",
  name: "<value>",
};
```

## Fields

| Field                                                               | Type                                                                | Required                                                            | Description                                                         |
| ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- |
| `org`                                                               | *string*                                                            | :heavy_check_mark:                                                  | The organization URL slug.                                          |
| `name`                                                              | *string*                                                            | :heavy_check_mark:                                                  | The repository name (URL label).                                    |
| `xOnBehalfOf`                                                       | *string*                                                            | :heavy_minus_sign:                                                  | Optional external end-user identifier forwarded by the API gateway. |