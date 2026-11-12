# AgentRunApprovalDecision


## Fields

| Field                                                                       | Type                                                                        | Required                                                                    | Description                                                                 |
| --------------------------------------------------------------------------- | --------------------------------------------------------------------------- | --------------------------------------------------------------------------- | --------------------------------------------------------------------------- |
| `ApprovalRequestID`                                                         | `string`                                                                    | :heavy_check_mark:                                                          | ID of the approval request, from the run's pending_approvals.               |
| `Approve`                                                                   | `bool`                                                                      | :heavy_check_mark:                                                          | N/A                                                                         |
| `Reason`                                                                    | `*string`                                                                   | :heavy_minus_sign:                                                          | Why the call was approved or denied. A denial reason is shown to the model. |