# AnalyticsCreatedCaptureKey

## Example Usage

```typescript
import { AnalyticsCreatedCaptureKey } from "@meetkai/mka1/models/components";

let value: AnalyticsCreatedCaptureKey = {
  id: "<id>",
  projectId: "<id>",
  name: "<value>",
  prefix: "<value>",
  createdAt: new Date("2026-09-01T12:30:00Z"),
  revokedAt: new Date("2026-09-02T12:30:00Z"),
  key: "<key>",
};
```

## Fields

| Field                                                                                         | Type                                                                                          | Required                                                                                      | Description                                                                                   | Example                                                                                       |
| --------------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------------- |
| `id`                                                                                          | *string*                                                                                      | :heavy_check_mark:                                                                            | N/A                                                                                           |                                                                                               |
| `projectId`                                                                                   | *string*                                                                                      | :heavy_check_mark:                                                                            | N/A                                                                                           |                                                                                               |
| `name`                                                                                        | *string*                                                                                      | :heavy_check_mark:                                                                            | N/A                                                                                           |                                                                                               |
| `prefix`                                                                                      | *string*                                                                                      | :heavy_check_mark:                                                                            | N/A                                                                                           |                                                                                               |
| `createdAt`                                                                                   | [Date](https://developer.mozilla.org/en-US/docs/Web/JavaScript/Reference/Global_Objects/Date) | :heavy_check_mark:                                                                            | When the capture key was created, in UTC.                                                     | 2026-09-01T12:30:00Z                                                                          |
| `revokedAt`                                                                                   | [Date](https://developer.mozilla.org/en-US/docs/Web/JavaScript/Reference/Global_Objects/Date) | :heavy_check_mark:                                                                            | N/A                                                                                           | 2026-09-02T12:30:00Z                                                                          |
| `key`                                                                                         | *string*                                                                                      | :heavy_check_mark:                                                                            | Capture-only secret. Returned once; store it now.                                             |                                                                                               |