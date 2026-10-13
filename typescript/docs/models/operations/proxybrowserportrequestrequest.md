# ProxyBrowserPortRequestRequest

## Example Usage

```typescript
import { ProxyBrowserPortRequestRequest } from "@meetkai/mka1/models/operations";

let value: ProxyBrowserPortRequestRequest = {
  sessionId: "browser-demo-20260318",
  port: 9222,
  subpath: "json/version",
  sessionToken: "sandbox_test_browser_20260318",
};
```

## Fields

| Field                                                               | Type                                                                | Required                                                            | Description                                                         | Example                                                             |
| ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- |
| `sessionId`                                                         | *string*                                                            | :heavy_check_mark:                                                  | N/A                                                                 | browser-demo-20260318                                               |
| `port`                                                              | *number*                                                            | :heavy_check_mark:                                                  | N/A                                                                 | 9222                                                                |
| `subpath`                                                           | *string*                                                            | :heavy_check_mark:                                                  | N/A                                                                 | json/version                                                        |
| `sessionToken`                                                      | *string*                                                            | :heavy_minus_sign:                                                  | N/A                                                                 | sandbox_test_browser_20260318                                       |
| `xOnBehalfOf`                                                       | *string*                                                            | :heavy_minus_sign:                                                  | Optional external end-user identifier forwarded by the API gateway. |                                                                     |