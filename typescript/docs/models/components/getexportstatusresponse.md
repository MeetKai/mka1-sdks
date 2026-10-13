# GetExportStatusResponse

Response containing the status and progress of the feedback export job.

## Example Usage

```typescript
import { GetExportStatusResponse } from "@meetkai/mka1/models/components";

let value: GetExportStatusResponse = {
  status: "TERMINATED",
};
```

## Fields

| Field                                                                                                    | Type                                                                                                     | Required                                                                                                 | Description                                                                                              |
| -------------------------------------------------------------------------------------------------------- | -------------------------------------------------------------------------------------------------------- | -------------------------------------------------------------------------------------------------------- | -------------------------------------------------------------------------------------------------------- |
| `status`                                                                                                 | [components.GetExportStatusResponseStatus](../../models/components/getexportstatusresponsestatus.md)     | :heavy_check_mark:                                                                                       | Current status of the export job                                                                         |
| `startTime`                                                                                              | [Date](https://developer.mozilla.org/en-US/docs/Web/JavaScript/Reference/Global_Objects/Date)            | :heavy_minus_sign:                                                                                       | ISO 8601 timestamp when the export job started                                                           |
| `closeTime`                                                                                              | [Date](https://developer.mozilla.org/en-US/docs/Web/JavaScript/Reference/Global_Objects/Date)            | :heavy_minus_sign:                                                                                       | ISO 8601 timestamp when the export job completed (if finished)                                           |
| `progress`                                                                                               | [components.GetExportStatusResponseProgress](../../models/components/getexportstatusresponseprogress.md) | :heavy_minus_sign:                                                                                       | Progress information (available when running)                                                            |
| `result`                                                                                                 | [components.Result](../../models/components/result.md)                                                   | :heavy_minus_sign:                                                                                       | Export result (only present when status is COMPLETED)                                                    |
| `error`                                                                                                  | *string*                                                                                                 | :heavy_minus_sign:                                                                                       | Error message (only present when status is FAILED)                                                       |