# GitHubPullRequestRequest

Public operation request.

It deliberately has no repository field: the repository is the session's
clone binding. The head branch is the caller's — the branch the agent
pushed.

## Example Usage

```typescript
import { GitHubPullRequestRequest } from "@meetkai/mka1/models/components";

let value: GitHubPullRequestRequest = {
  branch: "<value>",
  title: "<value>",
};
```

## Fields

| Field              | Type               | Required           | Description        |
| ------------------ | ------------------ | ------------------ | ------------------ |
| `branch`           | *string*           | :heavy_check_mark: | N/A                |
| `title`            | *string*           | :heavy_check_mark: | N/A                |
| `body`             | *string*           | :heavy_minus_sign: | N/A                |
| `base`             | *string*           | :heavy_minus_sign: | N/A                |
| `draft`            | *boolean*          | :heavy_minus_sign: | N/A                |
| `checkoutPath`     | *string*           | :heavy_minus_sign: | N/A                |