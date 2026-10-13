# CreateOrUpdateSessionPullRequestRequest

## Example Usage

```typescript
import { CreateOrUpdateSessionPullRequestRequest } from "@meetkai/mka1/models/operations";

let value: CreateOrUpdateSessionPullRequestRequest = {
  sessionId: "<id>",
  gitHubPullRequestRequest: {
    branch: "<value>",
    title: "<value>",
  },
};
```

## Fields

| Field                                                                                      | Type                                                                                       | Required                                                                                   | Description                                                                                |
| ------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------ |
| `sessionId`                                                                                | *string*                                                                                   | :heavy_check_mark:                                                                         | N/A                                                                                        |
| `xOnBehalfOf`                                                                              | *string*                                                                                   | :heavy_minus_sign:                                                                         | Optional external end-user identifier forwarded by the API gateway.                        |
| `gitHubPullRequestRequest`                                                                 | [components.GitHubPullRequestRequest](../../models/components/githubpullrequestrequest.md) | :heavy_check_mark:                                                                         | N/A                                                                                        |