# CloneGitHubRepositoryIntoSessionRequest


## Fields

| Field                                                                      | Type                                                                       | Required                                                                   | Description                                                                |
| -------------------------------------------------------------------------- | -------------------------------------------------------------------------- | -------------------------------------------------------------------------- | -------------------------------------------------------------------------- |
| `SessionId`                                                                | *string*                                                                   | :heavy_check_mark:                                                         | N/A                                                                        |
| `XOnBehalfOf`                                                              | *string*                                                                   | :heavy_minus_sign:                                                         | Optional external end-user identifier forwarded by the API gateway.        |
| `Body`                                                                     | [GitHubReadCloneRequest](../../Types/Components/GitHubReadCloneRequest.md) | :heavy_check_mark:                                                         | N/A                                                                        |