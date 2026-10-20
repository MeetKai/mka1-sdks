# BanWordsGuardrail

Banned words guardrail


## Fields

| Field                                                                   | Type                                                                    | Required                                                                | Description                                                             |
| ----------------------------------------------------------------------- | ----------------------------------------------------------------------- | ----------------------------------------------------------------------- | ----------------------------------------------------------------------- |
| `Mode`                                                                  | `string`                                                                | :heavy_check_mark:                                                      | N/A                                                                     |
| `Enabled`                                                               | `*bool`                                                                 | :heavy_minus_sign:                                                      | Whether this guardrail is enabled                                       |
| `CheckOutput`                                                           | `*bool`                                                                 | :heavy_minus_sign:                                                      | Also apply this guardrail to model output, not just the request         |
| `Config`                                                                | [*components.BanWordsConfig](../../models/components/banwordsconfig.md) | :heavy_minus_sign:                                                      | Configuration for banned words guardrail                                |