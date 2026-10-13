# AddSessionGitHubRepositoryRequest

## Example Usage

```typescript
import { AddSessionGitHubRepositoryRequest } from "@meetkai/mka1/models/operations";

let value: AddSessionGitHubRepositoryRequest = {
  sessionId: "<id>",
  repositoryId: 392420,
  putSessionRepositoryRequest: {
    assignmentGeneration: 757081,
  },
};
```

## Fields

| Field                                                                                            | Type                                                                                             | Required                                                                                         | Description                                                                                      |
| ------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------ |
| `sessionId`                                                                                      | *string*                                                                                         | :heavy_check_mark:                                                                               | N/A                                                                                              |
| `repositoryId`                                                                                   | *number*                                                                                         | :heavy_check_mark:                                                                               | N/A                                                                                              |
| `xOnBehalfOf`                                                                                    | *string*                                                                                         | :heavy_minus_sign:                                                                               | Optional external end-user identifier forwarded by the API gateway.                              |
| `putSessionRepositoryRequest`                                                                    | [components.PutSessionRepositoryRequest](../../models/components/putsessionrepositoryrequest.md) | :heavy_check_mark:                                                                               | N/A                                                                                              |