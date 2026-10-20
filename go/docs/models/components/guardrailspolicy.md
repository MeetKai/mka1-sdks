# GuardrailsPolicy


## Fields

| Field                                                                      | Type                                                                       | Required                                                                   | Description                                                                |
| -------------------------------------------------------------------------- | -------------------------------------------------------------------------- | -------------------------------------------------------------------------- | -------------------------------------------------------------------------- |
| `TeamID`                                                                   | `*string`                                                                  | :heavy_check_mark:                                                         | Team this policy targets; null for the org-wide policy                     |
| `Guardrails`                                                               | [][components.GuardrailConfig](../../models/components/guardrailconfig.md) | :heavy_check_mark:                                                         | N/A                                                                        |
| `UpdatedAt`                                                                | `float64`                                                                  | :heavy_check_mark:                                                         | Unix timestamp of when the policy was last updated                         |