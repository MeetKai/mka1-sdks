# GetGuardrailsResponse

## Example Usage

```typescript
import { GetGuardrailsResponse } from "@meetkai/mka1/models/components";

let value: GetGuardrailsResponse = {
  object: "guardrails_settings",
  guardrails: [
    {
      mode: "ban_words",
      enabled: true,
      config: {
        words: [
          "spam",
        ],
        rejectionMessage:
          "I'm sorry, but I can't process this request as it contains content that isn't allowed. Please rephrase your message.",
      },
    },
    {
      mode: "prompt_injection",
      enabled: true,
      config: {
        threshold: 0.8,
        rejectionMessage:
          "I'm sorry, but I can't process this request. Please rephrase your message in a different way.",
      },
    },
  ],
};
```

## Fields

| Field                          | Type                           | Required                       | Description                    |
| ------------------------------ | ------------------------------ | ------------------------------ | ------------------------------ |
| `object`                       | *"guardrails_settings"*        | :heavy_check_mark:             | N/A                            |
| `guardrails`                   | *components.GuardrailConfig*[] | :heavy_check_mark:             | N/A                            |