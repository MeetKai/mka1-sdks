# GitHubReadCloneRequest

Public operation request. It deliberately has no credential or path field.

## Example Usage

```typescript
import { GitHubReadCloneRequest } from "@meetkai/mka1/models/components";

let value: GitHubReadCloneRequest = {
  assignmentGeneration: 254628,
  repositoryId: 810571,
  owner: "<value>",
  repository: "<value>",
  baseSha: "<value>",
};
```

## Fields

| Field                  | Type                   | Required               | Description            |
| ---------------------- | ---------------------- | ---------------------- | ---------------------- |
| `assignmentGeneration` | *number*               | :heavy_check_mark:     | N/A                    |
| `repositoryId`         | *number*               | :heavy_check_mark:     | N/A                    |
| `owner`                | *string*               | :heavy_check_mark:     | N/A                    |
| `repository`           | *string*               | :heavy_check_mark:     | N/A                    |
| `baseSha`              | *string*               | :heavy_check_mark:     | N/A                    |