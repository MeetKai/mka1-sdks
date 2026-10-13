# DismissSessionGitHubRepositoryRequest

## Example Usage

```typescript
import { DismissSessionGitHubRepositoryRequest } from "@meetkai/mka1/models/operations";

let value: DismissSessionGitHubRepositoryRequest = {
  sessionId: "<id>",
  repositoryId: 317206,
  dismissSessionRepositoryRequest: {
    assignmentGeneration: 678954,
  },
};
```

## Fields

| Field                                                                                                    | Type                                                                                                     | Required                                                                                                 | Description                                                                                              |
| -------------------------------------------------------------------------------------------------------- | -------------------------------------------------------------------------------------------------------- | -------------------------------------------------------------------------------------------------------- | -------------------------------------------------------------------------------------------------------- |
| `sessionId`                                                                                              | *string*                                                                                                 | :heavy_check_mark:                                                                                       | N/A                                                                                                      |
| `repositoryId`                                                                                           | *number*                                                                                                 | :heavy_check_mark:                                                                                       | N/A                                                                                                      |
| `xOnBehalfOf`                                                                                            | *string*                                                                                                 | :heavy_minus_sign:                                                                                       | Optional external end-user identifier forwarded by the API gateway.                                      |
| `dismissSessionRepositoryRequest`                                                                        | [components.DismissSessionRepositoryRequest](../../models/components/dismisssessionrepositoryrequest.md) | :heavy_check_mark:                                                                                       | N/A                                                                                                      |