# GitHubPushRequest

Public operation request.

It deliberately has no credential or repository field: the credential is
the caller's stored connection, and the repository is the session's clone
binding. ``checkout_path`` names where the repository root sits inside
the workspace (empty = the workspace root), because the caller — the
agent working in the checkout — knows the layout and the server must not
guess it.


## Fields

| Field                   | Type                    | Required                | Description             |
| ----------------------- | ----------------------- | ----------------------- | ----------------------- |
| `assignment_generation` | *int*                   | :heavy_check_mark:      | N/A                     |
| `branch`                | *str*                   | :heavy_check_mark:      | N/A                     |
| `checkout_path`         | *Optional[str]*         | :heavy_minus_sign:      | N/A                     |
| `force`                 | *Optional[bool]*        | :heavy_minus_sign:      | N/A                     |