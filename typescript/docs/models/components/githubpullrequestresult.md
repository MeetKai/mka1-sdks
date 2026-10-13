# GitHubPullRequestResult

## Example Usage

```typescript
import { GitHubPullRequestResult } from "@meetkai/mka1/models/components";

let value: GitHubPullRequestResult = {
  sessionId: "<id>",
  repositoryId: 515681,
  owner: "<value>",
  repository: "<value>",
  number: 45186,
  url: "https://well-off-airline.name/",
  state: "Idaho",
  draft: false,
  headBranch: "<value>",
  baseBranch: null,
  created: true,
};
```

## Fields

| Field              | Type               | Required           | Description        |
| ------------------ | ------------------ | ------------------ | ------------------ |
| `sessionId`        | *string*           | :heavy_check_mark: | N/A                |
| `repositoryId`     | *number*           | :heavy_check_mark: | N/A                |
| `owner`            | *string*           | :heavy_check_mark: | N/A                |
| `repository`       | *string*           | :heavy_check_mark: | N/A                |
| `number`           | *number*           | :heavy_check_mark: | N/A                |
| `url`              | *string*           | :heavy_check_mark: | N/A                |
| `state`            | *string*           | :heavy_check_mark: | N/A                |
| `draft`            | *boolean*          | :heavy_check_mark: | N/A                |
| `headBranch`       | *string*           | :heavy_check_mark: | N/A                |
| `baseBranch`       | *string*           | :heavy_check_mark: | N/A                |
| `created`          | *boolean*          | :heavy_check_mark: | N/A                |