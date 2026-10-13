# ClassifierGuardrail

## Example Usage

```typescript
import { ClassifierGuardrail } from "@meetkai/mka1/models/components";

let value: ClassifierGuardrail = {
  mode: "classifier",
  config: {
    model: "Colorado",
    prompt: "<value>",
  },
};
```

## Fields

| Field                                                                      | Type                                                                       | Required                                                                   | Description                                                                |
| -------------------------------------------------------------------------- | -------------------------------------------------------------------------- | -------------------------------------------------------------------------- | -------------------------------------------------------------------------- |
| `mode`                                                                     | *"classifier"*                                                             | :heavy_check_mark:                                                         | N/A                                                                        |
| `enabled`                                                                  | *boolean*                                                                  | :heavy_minus_sign:                                                         | Whether this guardrail is enabled                                          |
| `checkOutput`                                                              | *boolean*                                                                  | :heavy_minus_sign:                                                         | Also apply this guardrail to model output, not just the request            |
| `config`                                                                   | [components.ClassifierConfig](../../models/components/classifierconfig.md) | :heavy_check_mark:                                                         | N/A                                                                        |