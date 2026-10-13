# GuardrailsPolicy


## Fields

| Field                                                              | Type                                                               | Required                                                           | Description                                                        |
| ------------------------------------------------------------------ | ------------------------------------------------------------------ | ------------------------------------------------------------------ | ------------------------------------------------------------------ |
| `TeamId`                                                           | *string*                                                           | :heavy_check_mark:                                                 | Team this policy targets; null for the org-wide policy             |
| `Guardrails`                                                       | List<[GuardrailConfig](../../Types/Components/GuardrailConfig.md)> | :heavy_check_mark:                                                 | N/A                                                                |
| `UpdatedAt`                                                        | *double*                                                           | :heavy_check_mark:                                                 | Unix timestamp of when the policy was last updated                 |