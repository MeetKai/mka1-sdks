# DeleteGuardrailsResponse


## Fields

| Field                                                          | Type                                                           | Required                                                       | Description                                                    |
| -------------------------------------------------------------- | -------------------------------------------------------------- | -------------------------------------------------------------- | -------------------------------------------------------------- |
| `object`                                                       | *Literal["guardrails_settings"]*                               | :heavy_check_mark:                                             | N/A                                                            |
| `deleted`                                                      | *bool*                                                         | :heavy_check_mark:                                             | Whether a policy row was deleted                               |
| `team_id`                                                      | *Nullable[str]*                                                | :heavy_check_mark:                                             | Team the deleted policy targeted; null for the org-wide policy |