# UpdateGuardrailsResponse


## Fields

| Field                                                              | Type                                                               | Required                                                           | Description                                                        |
| ------------------------------------------------------------------ | ------------------------------------------------------------------ | ------------------------------------------------------------------ | ------------------------------------------------------------------ |
| `Object`                                                           | *string*                                                           | :heavy_check_mark:                                                 | N/A                                                                |
| `Guardrails`                                                       | List<[GuardrailConfig](../../Types/Components/GuardrailConfig.md)> | :heavy_check_mark:                                                 | N/A                                                                |
| `TeamId`                                                           | *string*                                                           | :heavy_check_mark:                                                 | Team this policy targets; null for the org-wide policy             |
| `UpdatedAt`                                                        | *double*                                                           | :heavy_check_mark:                                                 | Unix timestamp of when the policy was updated                      |