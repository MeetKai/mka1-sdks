# GetBrowserSessionUrlRequest

## Example Usage

```typescript
import { GetBrowserSessionUrlRequest } from "@meetkai/mka1/models/operations";

let value: GetBrowserSessionUrlRequest = {
  sessionId: "browser-demo-20260318",
  sessionToken: "sandbox_test_browser_20260318",
};
```

## Fields

| Field                                                               | Type                                                                | Required                                                            | Description                                                         | Example                                                             |
| ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- |
| `sessionId`                                                         | *string*                                                            | :heavy_check_mark:                                                  | N/A                                                                 | browser-demo-20260318                                               |
| `sessionToken`                                                      | *string*                                                            | :heavy_minus_sign:                                                  | N/A                                                                 | sandbox_test_browser_20260318                                       |
| `xOnBehalfOf`                                                       | *string*                                                            | :heavy_minus_sign:                                                  | Optional external end-user identifier forwarded by the API gateway. |                                                                     |