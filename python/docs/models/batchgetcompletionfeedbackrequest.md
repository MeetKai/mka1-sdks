# BatchGetCompletionFeedbackRequest


## Fields

| Field                                                                  | Type                                                                   | Required                                                               | Description                                                            | Example                                                                |
| ---------------------------------------------------------------------- | ---------------------------------------------------------------------- | ---------------------------------------------------------------------- | ---------------------------------------------------------------------- | ---------------------------------------------------------------------- |
| `x_on_behalf_of`                                                       | *Optional[str]*                                                        | :heavy_minus_sign:                                                     | Optional external end-user identifier forwarded by the API gateway.    |                                                                        |
| `body`                                                                 | [models.BatchGetFeedbackRequest](../models/batchgetfeedbackrequest.md) | :heavy_check_mark:                                                     | N/A                                                                    | {<br/>"ids": [<br/>"chatcmpl-abc123",<br/>"chatcmpl-def456",<br/>"resp-xyz789"<br/>]<br/>} |