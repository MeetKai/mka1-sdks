# GuardrailsPolicy


## Fields

| Field                                                        | Type                                                         | Required                                                     | Description                                                  |
| ------------------------------------------------------------ | ------------------------------------------------------------ | ------------------------------------------------------------ | ------------------------------------------------------------ |
| `team_id`                                                    | *Nullable[str]*                                              | :heavy_check_mark:                                           | Team this policy targets; null for the org-wide policy       |
| `guardrails`                                                 | List[[models.GuardrailConfig](../models/guardrailconfig.md)] | :heavy_check_mark:                                           | N/A                                                          |
| `updated_at`                                                 | *float*                                                      | :heavy_check_mark:                                           | Unix timestamp of when the policy was last updated           |