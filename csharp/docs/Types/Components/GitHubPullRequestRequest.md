# GitHubPullRequestRequest

Public operation request.

It deliberately has no repository field: the repository is the session's
clone binding. The head branch is the caller's — the branch the agent
pushed.


## Fields

| Field              | Type               | Required           | Description        |
| ------------------ | ------------------ | ------------------ | ------------------ |
| `Branch`           | *string*           | :heavy_check_mark: | N/A                |
| `Title`            | *string*           | :heavy_check_mark: | N/A                |
| `Body`             | *string*           | :heavy_minus_sign: | N/A                |
| `Base`             | *string*           | :heavy_minus_sign: | N/A                |
| `Draft`            | *bool*             | :heavy_minus_sign: | N/A                |
| `CheckoutPath`     | *string*           | :heavy_minus_sign: | N/A                |