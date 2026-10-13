# DownloadWorkspaceFileRequest

## Example Usage

```typescript
import { DownloadWorkspaceFileRequest } from "@meetkai/mka1/models/operations";

let value: DownloadWorkspaceFileRequest = {
  sessionId: "demo-python-20260316",
  filePath: "outputs/report.txt",
  sessionToken: "sandbox_test_20260316_4f9c2b1a",
};
```

## Fields

| Field                                                               | Type                                                                | Required                                                            | Description                                                         | Example                                                             |
| ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- |
| `sessionId`                                                         | *string*                                                            | :heavy_check_mark:                                                  | N/A                                                                 | demo-python-20260316                                                |
| `filePath`                                                          | *string*                                                            | :heavy_check_mark:                                                  | N/A                                                                 | outputs/report.txt                                                  |
| `sessionToken`                                                      | *string*                                                            | :heavy_minus_sign:                                                  | N/A                                                                 | sandbox_test_20260316_4f9c2b1a                                      |
| `xOnBehalfOf`                                                       | *string*                                                            | :heavy_minus_sign:                                                  | Optional external end-user identifier forwarded by the API gateway. |                                                                     |