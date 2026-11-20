# ToolDefinitionSchedule

Lets the model create, list and cancel its own follow-ups, such as "remind me Friday at 9" or "check this every morning". Each follow-up is a schedule with deliver_to chat: it replies in the Telegram chat the model is talking in, can repeat at most once an hour, and a chat holds at most 20. The tool works through this schedule API as the caller; each run sends it with the running agent's id.


## Fields

| Field                                                              | Type                                                               | Required                                                           | Description                                                        |
| ------------------------------------------------------------------ | ------------------------------------------------------------------ | ------------------------------------------------------------------ | ------------------------------------------------------------------ |
| `Type`                                                             | [components.TypeSchedule](../../models/components/typeschedule.md) | :heavy_check_mark:                                                 | N/A                                                                |