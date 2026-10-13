# PromptInjectionConfig

Configuration for prompt injection detection guardrail

## Example Usage

```typescript
import { PromptInjectionConfig } from "@meetkai/mka1/models/components";

let value: PromptInjectionConfig = {};
```

## Fields

| Field                                                  | Type                                                   | Required                                               | Description                                            |
| ------------------------------------------------------ | ------------------------------------------------------ | ------------------------------------------------------ | ------------------------------------------------------ |
| `threshold`                                            | *number*                                               | :heavy_minus_sign:                                     | Detection threshold (0-1)                              |
| `rejectionMessage`                                     | *string*                                               | :heavy_minus_sign:                                     | The message to return when this guardrail is triggered |