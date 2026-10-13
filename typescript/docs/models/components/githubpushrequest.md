# GitHubPushRequest

Public operation request.

It deliberately has no credential or repository field: the credential is
the caller's stored connection, and the repository is the session's clone
binding. ``checkout_path`` names where the repository root sits inside
the workspace (empty = the workspace root), because the caller — the
agent working in the checkout — knows the layout and the server must not
guess it.

## Example Usage

```typescript
import { GitHubPushRequest } from "@meetkai/mka1/models/components";

let value: GitHubPushRequest = {
  assignmentGeneration: 422028,
  branch: "<value>",
};
```

## Fields

| Field                  | Type                   | Required               | Description            |
| ---------------------- | ---------------------- | ---------------------- | ---------------------- |
| `assignmentGeneration` | *number*               | :heavy_check_mark:     | N/A                    |
| `branch`               | *string*               | :heavy_check_mark:     | N/A                    |
| `checkoutPath`         | *string*               | :heavy_minus_sign:     | N/A                    |
| `force`                | *boolean*              | :heavy_minus_sign:     | N/A                    |