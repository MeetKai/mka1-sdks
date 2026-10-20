# UpdateGuardrailsResponse


## Fields

| Field                                                                      | Type                                                                       | Required                                                                   | Description                                                                |
| -------------------------------------------------------------------------- | -------------------------------------------------------------------------- | -------------------------------------------------------------------------- | -------------------------------------------------------------------------- |
| `Object`                                                                   | `string`                                                                   | :heavy_check_mark:                                                         | N/A                                                                        |
| `Guardrails`                                                               | [][components.GuardrailConfig](../../models/components/guardrailconfig.md) | :heavy_check_mark:                                                         | N/A                                                                        |
| `TeamID`                                                                   | `*string`                                                                  | :heavy_check_mark:                                                         | Team this policy targets; null for the org-wide policy                     |
| `UpdatedAt`                                                                | `float64`                                                                  | :heavy_check_mark:                                                         | Unix timestamp of when the policy was updated                              |