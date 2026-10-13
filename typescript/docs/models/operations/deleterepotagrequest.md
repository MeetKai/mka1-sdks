# DeleteRepoTagRequest

## Example Usage

```typescript
import { DeleteRepoTagRequest } from "@meetkai/mka1/models/operations";

let value: DeleteRepoTagRequest = {
  org: "<value>",
  name: "<value>",
  tag: "<value>",
};
```

## Fields

| Field                                                               | Type                                                                | Required                                                            | Description                                                         |
| ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- |
| `org`                                                               | *string*                                                            | :heavy_check_mark:                                                  | The organization URL slug.                                          |
| `name`                                                              | *string*                                                            | :heavy_check_mark:                                                  | The repository name (URL label).                                    |
| `tag`                                                               | *string*                                                            | :heavy_check_mark:                                                  | The image tag, exactly as pushed (tags are case-sensitive).         |
| `xOnBehalfOf`                                                       | *string*                                                            | :heavy_minus_sign:                                                  | Optional external end-user identifier forwarded by the API gateway. |