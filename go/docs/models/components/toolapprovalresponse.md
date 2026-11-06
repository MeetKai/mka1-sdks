# ToolApprovalResponse

Tool approval response item: the decision on a prior tool approval request. A gateway extension.


## Fields

| Field                                                                       | Type                                                                        | Required                                                                    | Description                                                                 |
| --------------------------------------------------------------------------- | --------------------------------------------------------------------------- | --------------------------------------------------------------------------- | --------------------------------------------------------------------------- |
| `Type`                                                                      | `string`                                                                    | :heavy_check_mark:                                                          | N/A                                                                         |
| `ApprovalRequestID`                                                         | `string`                                                                    | :heavy_check_mark:                                                          | The id of the tool_approval_request being decided.                          |
| `Approve`                                                                   | `bool`                                                                      | :heavy_check_mark:                                                          | N/A                                                                         |
| `ID`                                                                        | `*string`                                                                   | :heavy_minus_sign:                                                          | N/A                                                                         |
| `Reason`                                                                    | `*string`                                                                   | :heavy_minus_sign:                                                          | Why the call was approved or denied. A denial reason is shown to the model. |