# LeakageGuardrail

Leakage guardrail


## Fields

| Field                                                           | Type                                                            | Required                                                        | Description                                                     |
| --------------------------------------------------------------- | --------------------------------------------------------------- | --------------------------------------------------------------- | --------------------------------------------------------------- |
| `Mode`                                                          | *string*                                                        | :heavy_check_mark:                                              | N/A                                                             |
| `Enabled`                                                       | *bool*                                                          | :heavy_minus_sign:                                              | Whether this guardrail is enabled                               |
| `CheckOutput`                                                   | *bool*                                                          | :heavy_minus_sign:                                              | Also apply this guardrail to model output, not just the request |
| `Config`                                                        | [LeakageConfig](../../Types/Components/LeakageConfig.md)        | :heavy_minus_sign:                                              | Configuration for system prompt leakage detection guardrail     |