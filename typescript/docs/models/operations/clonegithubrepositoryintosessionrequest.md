# CloneGitHubRepositoryIntoSessionRequest

## Example Usage

```typescript
import { CloneGitHubRepositoryIntoSessionRequest } from "@meetkai/mka1/models/operations";

let value: CloneGitHubRepositoryIntoSessionRequest = {
  sessionId: "<id>",
  gitHubReadCloneRequest: {
    assignmentGeneration: 589545,
    repositoryId: 493923,
    owner: "<value>",
    repository: "<value>",
    baseSha: "<value>",
  },
};
```

## Fields

| Field                                                                                  | Type                                                                                   | Required                                                                               | Description                                                                            |
| -------------------------------------------------------------------------------------- | -------------------------------------------------------------------------------------- | -------------------------------------------------------------------------------------- | -------------------------------------------------------------------------------------- |
| `sessionId`                                                                            | *string*                                                                               | :heavy_check_mark:                                                                     | N/A                                                                                    |
| `xOnBehalfOf`                                                                          | *string*                                                                               | :heavy_minus_sign:                                                                     | Optional external end-user identifier forwarded by the API gateway.                    |
| `gitHubReadCloneRequest`                                                               | [components.GitHubReadCloneRequest](../../models/components/githubreadclonerequest.md) | :heavy_check_mark:                                                                     | N/A                                                                                    |