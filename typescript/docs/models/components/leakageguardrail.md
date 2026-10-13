# LeakageGuardrail

Leakage guardrail

## Example Usage

```typescript
import { LeakageGuardrail } from "@meetkai/mka1/models/components";

let value: LeakageGuardrail = {
  mode: "leakage",
};
```

## Fields

| Field                                                                | Type                                                                 | Required                                                             | Description                                                          |
| -------------------------------------------------------------------- | -------------------------------------------------------------------- | -------------------------------------------------------------------- | -------------------------------------------------------------------- |
| `mode`                                                               | *"leakage"*                                                          | :heavy_check_mark:                                                   | N/A                                                                  |
| `enabled`                                                            | *boolean*                                                            | :heavy_minus_sign:                                                   | Whether this guardrail is enabled                                    |
| `checkOutput`                                                        | *boolean*                                                            | :heavy_minus_sign:                                                   | Also apply this guardrail to model output, not just the request      |
| `config`                                                             | [components.LeakageConfig](../../models/components/leakageconfig.md) | :heavy_minus_sign:                                                   | Configuration for system prompt leakage detection guardrail          |