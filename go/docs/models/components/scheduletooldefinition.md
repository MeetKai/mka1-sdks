# ScheduleToolDefinition

Schedule tool definition: Lets the model create, list and cancel its own follow-ups, such as "remind me Friday at 9". Each is a schedule of the saved agent in MKA1 Agents with deliver_to chat, created as the caller, so it replies in the Telegram chat the caller is talking in. MKA1 Agents enforces at most once an hour and 20 per chat.


## Fields

| Field                                                                                     | Type                                                                                      | Required                                                                                  | Description                                                                               |
| ----------------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------------- |
| `Type`                                                                                    | `string`                                                                                  | :heavy_check_mark:                                                                        | N/A                                                                                       |
| `AgentID`                                                                                 | `string`                                                                                  | :heavy_check_mark:                                                                        | ID of the saved agent the follow-ups belong to. MKA1 Agents sets it to the running agent. |