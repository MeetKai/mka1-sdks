# ToolApprovalResponseWithID

Tool approval response item: the decision on a prior tool approval request. A gateway extension.


## Fields

| Field                                                                       | Type                                                                        | Required                                                                    | Description                                                                 |
| --------------------------------------------------------------------------- | --------------------------------------------------------------------------- | --------------------------------------------------------------------------- | --------------------------------------------------------------------------- |
| `Type`                                                                      | `string`                                                                    | :heavy_check_mark:                                                          | N/A                                                                         |
| `ApprovalRequestID`                                                         | `string`                                                                    | :heavy_check_mark:                                                          | The id of the tool_approval_request being decided.                          |
| `Approve`                                                                   | `bool`                                                                      | :heavy_check_mark:                                                          | N/A                                                                         |
| `ID`                                                                        | `string`                                                                    | :heavy_check_mark:                                                          | The unique ID of the message.                                               |
| `Reason`                                                                    | `*string`                                                                   | :heavy_minus_sign:                                                          | Why the call was approved or denied. A denial reason is shown to the model. |
| `ResponseID`                                                                | optionalnullable.OptionalNullable[`string`]                                 | :heavy_minus_sign:                                                          | The ID of the response that created this item, if any.                      |
| `Metadata`                                                                  | optionalnullable.OptionalNullable[map[string]`string`]                      | :heavy_minus_sign:                                                          | Metadata from the response that created this item, if any.                  |