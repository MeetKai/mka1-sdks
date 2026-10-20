# PushSessionToGitHubRequest


## Fields

| Field                                                                        | Type                                                                         | Required                                                                     | Description                                                                  |
| ---------------------------------------------------------------------------- | ---------------------------------------------------------------------------- | ---------------------------------------------------------------------------- | ---------------------------------------------------------------------------- |
| `SessionID`                                                                  | `string`                                                                     | :heavy_check_mark:                                                           | N/A                                                                          |
| `XOnBehalfOf`                                                                | `*string`                                                                    | :heavy_minus_sign:                                                           | Optional external end-user identifier forwarded by the API gateway.          |
| `Body`                                                                       | [components.GitHubPushRequest](../../models/components/githubpushrequest.md) | :heavy_check_mark:                                                           | N/A                                                                          |