# DownloadWorkspaceArchiveRequest

## Example Usage

```typescript
import { DownloadWorkspaceArchiveRequest } from "@meetkai/mka1/models/operations";

let value: DownloadWorkspaceArchiveRequest = {
  sessionId: "demo-python-20260316",
  sessionToken: "sandbox_test_20260316_4f9c2b1a",
  workspaceArchiveRequest: {},
};
```

## Fields

| Field                                                                                    | Type                                                                                     | Required                                                                                 | Description                                                                              | Example                                                                                  |
| ---------------------------------------------------------------------------------------- | ---------------------------------------------------------------------------------------- | ---------------------------------------------------------------------------------------- | ---------------------------------------------------------------------------------------- | ---------------------------------------------------------------------------------------- |
| `sessionId`                                                                              | *string*                                                                                 | :heavy_check_mark:                                                                       | N/A                                                                                      | demo-python-20260316                                                                     |
| `sessionToken`                                                                           | *string*                                                                                 | :heavy_minus_sign:                                                                       | N/A                                                                                      | sandbox_test_20260316_4f9c2b1a                                                           |
| `xOnBehalfOf`                                                                            | *string*                                                                                 | :heavy_minus_sign:                                                                       | Optional external end-user identifier forwarded by the API gateway.                      |                                                                                          |
| `workspaceArchiveRequest`                                                                | [components.WorkspaceArchiveRequest](../../models/components/workspacearchiverequest.md) | :heavy_check_mark:                                                                       | N/A                                                                                      |                                                                                          |