# PromptInjectionConfig

Configuration for prompt injection detection guardrail


## Fields

| Field                                                  | Type                                                   | Required                                               | Description                                            |
| ------------------------------------------------------ | ------------------------------------------------------ | ------------------------------------------------------ | ------------------------------------------------------ |
| `Threshold`                                            | `*float64`                                             | :heavy_minus_sign:                                     | Detection threshold (0-1)                              |
| `RejectionMessage`                                     | `*string`                                              | :heavy_minus_sign:                                     | The message to return when this guardrail is triggered |