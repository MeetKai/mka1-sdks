# TestGuardrailsResponse


## Fields

| Field                                                                 | Type                                                                  | Required                                                              | Description                                                           |
| --------------------------------------------------------------------- | --------------------------------------------------------------------- | --------------------------------------------------------------------- | --------------------------------------------------------------------- |
| `Object`                                                              | `string`                                                              | :heavy_check_mark:                                                    | N/A                                                                   |
| `Passed`                                                              | `bool`                                                                | :heavy_check_mark:                                                    | N/A                                                                   |
| `TriggeredGuardrail`                                                  | [*components.GuardrailMode](../../models/components/guardrailmode.md) | :heavy_minus_sign:                                                    | N/A                                                                   |
| `RejectionMessage`                                                    | `*string`                                                             | :heavy_minus_sign:                                                    | N/A                                                                   |
| `UserInput`                                                           | `*string`                                                             | :heavy_minus_sign:                                                    | N/A                                                                   |
| `Details`                                                             | map[string]`any`                                                      | :heavy_minus_sign:                                                    | N/A                                                                   |