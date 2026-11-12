# ResumeAgentRunToolApprovalRequest


## Fields

| Field                                                               | Type                                                                | Required                                                            | Description                                                         |
| ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- |
| `ApprovalRequestID`                                                 | `string`                                                            | :heavy_check_mark:                                                  | ID of a held tool call, as the approval queue lists it.             |
| `XOnBehalfOf`                                                       | `*string`                                                           | :heavy_minus_sign:                                                  | Optional external end-user identifier forwarded by the API gateway. |