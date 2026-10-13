# StartExportFeedbackResponse

Response when starting a feedback export job.

## Example Usage

```typescript
import { StartExportFeedbackResponse } from "@meetkai/mka1/models/components";

let value: StartExportFeedbackResponse = {
  started: true,
  status: "FAILED",
};
```

## Fields

| Field                                                                                                        | Type                                                                                                         | Required                                                                                                     | Description                                                                                                  |
| ------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------ |
| `started`                                                                                                    | *boolean*                                                                                                    | :heavy_check_mark:                                                                                           | Whether a new export was started (false if already running)                                                  |
| `status`                                                                                                     | [components.StartExportFeedbackResponseStatus](../../models/components/startexportfeedbackresponsestatus.md) | :heavy_check_mark:                                                                                           | Current status of the export job                                                                             |
| `progress`                                                                                                   | [components.Progress](../../models/components/progress.md)                                                   | :heavy_minus_sign:                                                                                           | Progress information (available when running)                                                                |