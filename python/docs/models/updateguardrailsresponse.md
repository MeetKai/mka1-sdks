# UpdateGuardrailsResponse


## Fields

| Field                                                        | Type                                                         | Required                                                     | Description                                                  |
| ------------------------------------------------------------ | ------------------------------------------------------------ | ------------------------------------------------------------ | ------------------------------------------------------------ |
| `object`                                                     | *Literal["guardrails_settings"]*                             | :heavy_check_mark:                                           | N/A                                                          |
| `guardrails`                                                 | List[[models.GuardrailConfig](../models/guardrailconfig.md)] | :heavy_check_mark:                                           | N/A                                                          |
| `team_id`                                                    | *Nullable[str]*                                              | :heavy_check_mark:                                           | Team this policy targets; null for the org-wide policy       |
| `updated_at`                                                 | *float*                                                      | :heavy_check_mark:                                           | Unix timestamp of when the policy was updated                |