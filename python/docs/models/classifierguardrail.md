# ClassifierGuardrail


## Fields

| Field                                                           | Type                                                            | Required                                                        | Description                                                     |
| --------------------------------------------------------------- | --------------------------------------------------------------- | --------------------------------------------------------------- | --------------------------------------------------------------- |
| `mode`                                                          | *Literal["classifier"]*                                         | :heavy_check_mark:                                              | N/A                                                             |
| `enabled`                                                       | *Optional[bool]*                                                | :heavy_minus_sign:                                              | Whether this guardrail is enabled                               |
| `check_output`                                                  | *Optional[bool]*                                                | :heavy_minus_sign:                                              | Also apply this guardrail to model output, not just the request |
| `config`                                                        | [models.ClassifierConfig](../models/classifierconfig.md)        | :heavy_check_mark:                                              | N/A                                                             |