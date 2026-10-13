# LeakageGuardrail

Leakage guardrail


## Fields

| Field                                                           | Type                                                            | Required                                                        | Description                                                     |
| --------------------------------------------------------------- | --------------------------------------------------------------- | --------------------------------------------------------------- | --------------------------------------------------------------- |
| `mode`                                                          | *Literal["leakage"]*                                            | :heavy_check_mark:                                              | N/A                                                             |
| `enabled`                                                       | *Optional[bool]*                                                | :heavy_minus_sign:                                              | Whether this guardrail is enabled                               |
| `check_output`                                                  | *Optional[bool]*                                                | :heavy_minus_sign:                                              | Also apply this guardrail to model output, not just the request |
| `config`                                                        | [Optional[models.LeakageConfig]](../models/leakageconfig.md)    | :heavy_minus_sign:                                              | Configuration for system prompt leakage detection guardrail     |