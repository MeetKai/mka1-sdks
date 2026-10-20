# GitHubPushRequest

Public operation request.

It deliberately has no credential or repository field: the credential is
the caller's stored connection, and the repository is the session's clone
binding. ``checkout_path`` names where the repository root sits inside
the workspace (empty = the workspace root), because the caller — the
agent working in the checkout — knows the layout and the server must not
guess it.


## Fields

| Field                  | Type                   | Required               | Description            |
| ---------------------- | ---------------------- | ---------------------- | ---------------------- |
| `AssignmentGeneration` | `int64`                | :heavy_check_mark:     | N/A                    |
| `Branch`               | `string`               | :heavy_check_mark:     | N/A                    |
| `CheckoutPath`         | `*string`              | :heavy_minus_sign:     | N/A                    |
| `Force`                | `*bool`                | :heavy_minus_sign:     | N/A                    |