# StartExportFeedbackResponse

Response when starting a feedback export job.


## Fields

| Field                                                                                                | Type                                                                                                 | Required                                                                                             | Description                                                                                          |
| ---------------------------------------------------------------------------------------------------- | ---------------------------------------------------------------------------------------------------- | ---------------------------------------------------------------------------------------------------- | ---------------------------------------------------------------------------------------------------- |
| `Started`                                                                                            | *bool*                                                                                               | :heavy_check_mark:                                                                                   | Whether a new export was started (false if already running)                                          |
| `Status`                                                                                             | [StartExportFeedbackResponseStatus](../../Types/Components/StartExportFeedbackResponseStatus.md)     | :heavy_check_mark:                                                                                   | Current status of the export job                                                                     |
| `Progress`                                                                                           | [StartExportFeedbackResponseProgress](../../Types/Components/StartExportFeedbackResponseProgress.md) | :heavy_minus_sign:                                                                                   | Progress information (available when running)                                                        |