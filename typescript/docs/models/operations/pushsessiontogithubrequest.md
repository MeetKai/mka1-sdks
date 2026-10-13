# PushSessionToGitHubRequest

## Example Usage

```typescript
import { PushSessionToGitHubRequest } from "@meetkai/mka1/models/operations";

let value: PushSessionToGitHubRequest = {
  sessionId: "<id>",
  gitHubPushRequest: {
    assignmentGeneration: 251514,
    branch: "<value>",
  },
};
```

## Fields

| Field                                                                        | Type                                                                         | Required                                                                     | Description                                                                  |
| ---------------------------------------------------------------------------- | ---------------------------------------------------------------------------- | ---------------------------------------------------------------------------- | ---------------------------------------------------------------------------- |
| `sessionId`                                                                  | *string*                                                                     | :heavy_check_mark:                                                           | N/A                                                                          |
| `xOnBehalfOf`                                                                | *string*                                                                     | :heavy_minus_sign:                                                           | Optional external end-user identifier forwarded by the API gateway.          |
| `gitHubPushRequest`                                                          | [components.GitHubPushRequest](../../models/components/githubpushrequest.md) | :heavy_check_mark:                                                           | N/A                                                                          |