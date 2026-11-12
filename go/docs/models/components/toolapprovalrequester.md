# ToolApprovalRequester

Who made the request whose tool call was held. Only this caller can continue the response.


## Fields

| Field                                                | Type                                                 | Required                                             | Description                                          |
| ---------------------------------------------------- | ---------------------------------------------------- | ---------------------------------------------------- | ---------------------------------------------------- |
| `UserID`                                             | `string`                                             | :heavy_check_mark:                                   | The user or service account whose request was held.  |
| `UserType`                                           | `string`                                             | :heavy_check_mark:                                   | user or service-account.                             |
| `ExternalUserID`                                     | `*string`                                            | :heavy_check_mark:                                   | The end user the request acted on behalf of, if any. |
| `TeamID`                                             | `*string`                                            | :heavy_check_mark:                                   | The team the request ran in, if any.                 |