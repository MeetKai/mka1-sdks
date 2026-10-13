# BanWordsGuardrail

Banned words guardrail

## Example Usage

```typescript
import { BanWordsGuardrail } from "@meetkai/mka1/models/components";

let value: BanWordsGuardrail = {
  mode: "ban_words",
};
```

## Fields

| Field                                                                  | Type                                                                   | Required                                                               | Description                                                            |
| ---------------------------------------------------------------------- | ---------------------------------------------------------------------- | ---------------------------------------------------------------------- | ---------------------------------------------------------------------- |
| `mode`                                                                 | *"ban_words"*                                                          | :heavy_check_mark:                                                     | N/A                                                                    |
| `enabled`                                                              | *boolean*                                                              | :heavy_minus_sign:                                                     | Whether this guardrail is enabled                                      |
| `checkOutput`                                                          | *boolean*                                                              | :heavy_minus_sign:                                                     | Also apply this guardrail to model output, not just the request        |
| `config`                                                               | [components.BanWordsConfig](../../models/components/banwordsconfig.md) | :heavy_minus_sign:                                                     | Configuration for banned words guardrail                               |