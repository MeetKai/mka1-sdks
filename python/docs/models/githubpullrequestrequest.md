# GitHubPullRequestRequest

Public operation request.

It deliberately has no repository field: the repository is the session's
clone binding. The head branch is the caller's — the branch the agent
pushed.


## Fields

| Field                   | Type                    | Required                | Description             |
| ----------------------- | ----------------------- | ----------------------- | ----------------------- |
| `branch`                | *str*                   | :heavy_check_mark:      | N/A                     |
| `title`                 | *str*                   | :heavy_check_mark:      | N/A                     |
| `body`                  | *Optional[str]*         | :heavy_minus_sign:      | N/A                     |
| `base`                  | *OptionalNullable[str]* | :heavy_minus_sign:      | N/A                     |
| `draft`                 | *Optional[bool]*        | :heavy_minus_sign:      | N/A                     |
| `checkout_path`         | *Optional[str]*         | :heavy_minus_sign:      | N/A                     |