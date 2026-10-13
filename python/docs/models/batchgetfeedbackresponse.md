# BatchGetFeedbackResponse

Response containing batch feedback results. Each result is either the feedback data or a not_found error.


## Fields

| Field                                                        | Type                                                         | Required                                                     | Description                                                  |
| ------------------------------------------------------------ | ------------------------------------------------------------ | ------------------------------------------------------------ | ------------------------------------------------------------ |
| `results`                                                    | List[[models.Result](../models/result.md)]                   | :heavy_check_mark:                                           | Array of feedback results in the same order as the input IDs |