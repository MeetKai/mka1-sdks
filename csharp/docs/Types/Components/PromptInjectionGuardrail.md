# PromptInjectionGuardrail

Prompt injection guardrail


## Fields

| Field                                                                    | Type                                                                     | Required                                                                 | Description                                                              |
| ------------------------------------------------------------------------ | ------------------------------------------------------------------------ | ------------------------------------------------------------------------ | ------------------------------------------------------------------------ |
| `Mode`                                                                   | *string*                                                                 | :heavy_check_mark:                                                       | N/A                                                                      |
| `Enabled`                                                                | *bool*                                                                   | :heavy_minus_sign:                                                       | Whether this guardrail is enabled                                        |
| `CheckOutput`                                                            | *bool*                                                                   | :heavy_minus_sign:                                                       | Also apply this guardrail to model output, not just the request          |
| `Config`                                                                 | [PromptInjectionConfig](../../Types/Components/PromptInjectionConfig.md) | :heavy_minus_sign:                                                       | Configuration for prompt injection detection guardrail                   |