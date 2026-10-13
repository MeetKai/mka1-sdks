# UploadWorkspaceFileRequest

## Example Usage

```typescript
import { UploadWorkspaceFileRequest } from "@meetkai/mka1/models/operations";

// No examples available for this model
```

## Fields

| Field                                                               | Type                                                                | Required                                                            | Description                                                         | Example                                                             |
| ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- |
| `sessionId`                                                         | *string*                                                            | :heavy_check_mark:                                                  | N/A                                                                 | demo-python-20260316                                                |
| `filePath`                                                          | *string*                                                            | :heavy_check_mark:                                                  | N/A                                                                 | inputs/config.json                                                  |
| `sessionToken`                                                      | *string*                                                            | :heavy_minus_sign:                                                  | N/A                                                                 | sandbox_test_20260316_4f9c2b1a                                      |
| `xOnBehalfOf`                                                       | *string*                                                            | :heavy_minus_sign:                                                  | Optional external end-user identifier forwarded by the API gateway. |                                                                     |
| `requestBody`                                                       | *ReadableStream<Uint8Array>*                                        | :heavy_minus_sign:                                                  | N/A                                                                 |                                                                     |