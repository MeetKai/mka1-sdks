# ClusterDefaultRuleSummary

A cluster default guardrail, without the operator's configuration


## Fields

| Field                                                                | Type                                                                 | Required                                                             | Description                                                          |
| -------------------------------------------------------------------- | -------------------------------------------------------------------- | -------------------------------------------------------------------- | -------------------------------------------------------------------- |
| `Mode`                                                               | [components.GuardrailMode](../../models/components/guardrailmode.md) | :heavy_check_mark:                                                   | N/A                                                                  |
| `Enabled`                                                            | `bool`                                                               | :heavy_check_mark:                                                   | N/A                                                                  |
| `CheckOutput`                                                        | `*bool`                                                              | :heavy_minus_sign:                                                   | Whether this guardrail also checks model output                      |
| `RejectionMessage`                                                   | `*string`                                                            | :heavy_minus_sign:                                                   | The message returned when this guardrail blocks a request            |