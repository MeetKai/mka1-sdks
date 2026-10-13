# PromptInjectionGuardrail

Prompt injection guardrail


## Fields

| Field                                                                        | Type                                                                         | Required                                                                     | Description                                                                  |
| ---------------------------------------------------------------------------- | ---------------------------------------------------------------------------- | ---------------------------------------------------------------------------- | ---------------------------------------------------------------------------- |
| `mode`                                                                       | *Literal["prompt_injection"]*                                                | :heavy_check_mark:                                                           | N/A                                                                          |
| `enabled`                                                                    | *Optional[bool]*                                                             | :heavy_minus_sign:                                                           | Whether this guardrail is enabled                                            |
| `check_output`                                                               | *Optional[bool]*                                                             | :heavy_minus_sign:                                                           | Also apply this guardrail to model output, not just the request              |
| `config`                                                                     | [Optional[models.PromptInjectionConfig]](../models/promptinjectionconfig.md) | :heavy_minus_sign:                                                           | Configuration for prompt injection detection guardrail                       |