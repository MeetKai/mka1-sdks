# ClassifierGuardrail


## Fields

| Field                                                                      | Type                                                                       | Required                                                                   | Description                                                                |
| -------------------------------------------------------------------------- | -------------------------------------------------------------------------- | -------------------------------------------------------------------------- | -------------------------------------------------------------------------- |
| `Mode`                                                                     | `string`                                                                   | :heavy_check_mark:                                                         | N/A                                                                        |
| `Enabled`                                                                  | `*bool`                                                                    | :heavy_minus_sign:                                                         | Whether this guardrail is enabled                                          |
| `CheckOutput`                                                              | `*bool`                                                                    | :heavy_minus_sign:                                                         | Also apply this guardrail to model output, not just the request            |
| `Config`                                                                   | [components.ClassifierConfig](../../models/components/classifierconfig.md) | :heavy_check_mark:                                                         | N/A                                                                        |