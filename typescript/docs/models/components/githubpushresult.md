# GitHubPushResult

## Example Usage

```typescript
import { GitHubPushResult } from "@meetkai/mka1/models/components";

let value: GitHubPushResult = {
  sessionId: "<id>",
  assignmentGeneration: 332517,
  repositoryId: 442650,
  owner: "<value>",
  repository: "<value>",
  branch: "<value>",
  remoteHeadSha: "<value>",
  noChanges: true,
};
```

## Fields

| Field                  | Type                   | Required               | Description            |
| ---------------------- | ---------------------- | ---------------------- | ---------------------- |
| `sessionId`            | *string*               | :heavy_check_mark:     | N/A                    |
| `assignmentGeneration` | *number*               | :heavy_check_mark:     | N/A                    |
| `repositoryId`         | *number*               | :heavy_check_mark:     | N/A                    |
| `owner`                | *string*               | :heavy_check_mark:     | N/A                    |
| `repository`           | *string*               | :heavy_check_mark:     | N/A                    |
| `branch`               | *string*               | :heavy_check_mark:     | N/A                    |
| `remoteHeadSha`        | *string*               | :heavy_check_mark:     | N/A                    |
| `noChanges`            | *boolean*              | :heavy_check_mark:     | N/A                    |