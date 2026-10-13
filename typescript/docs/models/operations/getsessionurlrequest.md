# GetSessionUrlRequest

## Example Usage

```typescript
import { GetSessionUrlRequest } from "@meetkai/mka1/models/operations";

let value: GetSessionUrlRequest = {
  sessionId: "browser-demo-20260318",
  sessionToken: "sandbox_test_browser_20260318",
  port: 9222,
};
```

## Fields

| Field                                                               | Type                                                                | Required                                                            | Description                                                         | Example                                                             |
| ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- |
| `sessionId`                                                         | *string*                                                            | :heavy_check_mark:                                                  | N/A                                                                 | browser-demo-20260318                                               |
| `sessionToken`                                                      | *string*                                                            | :heavy_minus_sign:                                                  | N/A                                                                 | sandbox_test_browser_20260318                                       |
| `port`                                                              | *number*                                                            | :heavy_minus_sign:                                                  | N/A                                                                 | 9222                                                                |
| `xOnBehalfOf`                                                       | *string*                                                            | :heavy_minus_sign:                                                  | Optional external end-user identifier forwarded by the API gateway. |                                                                     |