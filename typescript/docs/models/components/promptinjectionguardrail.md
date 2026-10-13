# PromptInjectionGuardrail

Prompt injection guardrail

## Example Usage

```typescript
import { PromptInjectionGuardrail } from "@meetkai/mka1/models/components";

let value: PromptInjectionGuardrail = {
  mode: "prompt_injection",
};
```

## Fields

| Field                                                                                | Type                                                                                 | Required                                                                             | Description                                                                          |
| ------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------ |
| `mode`                                                                               | *"prompt_injection"*                                                                 | :heavy_check_mark:                                                                   | N/A                                                                                  |
| `enabled`                                                                            | *boolean*                                                                            | :heavy_minus_sign:                                                                   | Whether this guardrail is enabled                                                    |
| `checkOutput`                                                                        | *boolean*                                                                            | :heavy_minus_sign:                                                                   | Also apply this guardrail to model output, not just the request                      |
| `config`                                                                             | [components.PromptInjectionConfig](../../models/components/promptinjectionconfig.md) | :heavy_minus_sign:                                                                   | Configuration for prompt injection detection guardrail                               |