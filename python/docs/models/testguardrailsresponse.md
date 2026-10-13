# TestGuardrailsResponse


## Fields

| Field                                                        | Type                                                         | Required                                                     | Description                                                  |
| ------------------------------------------------------------ | ------------------------------------------------------------ | ------------------------------------------------------------ | ------------------------------------------------------------ |
| `object`                                                     | *Literal["guardrails_test_result"]*                          | :heavy_check_mark:                                           | N/A                                                          |
| `passed`                                                     | *bool*                                                       | :heavy_check_mark:                                           | N/A                                                          |
| `triggered_guardrail`                                        | [Optional[models.GuardrailMode]](../models/guardrailmode.md) | :heavy_minus_sign:                                           | N/A                                                          |
| `rejection_message`                                          | *Optional[str]*                                              | :heavy_minus_sign:                                           | N/A                                                          |
| `user_input`                                                 | *Optional[str]*                                              | :heavy_minus_sign:                                           | N/A                                                          |
| `details`                                                    | Dict[str, *Any*]                                             | :heavy_minus_sign:                                           | N/A                                                          |