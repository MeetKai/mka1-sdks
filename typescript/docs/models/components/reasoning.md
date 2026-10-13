# Reasoning

Reasoning item: Model reasoning metadata, including summary text and optional detailed reasoning content.

## Example Usage

```typescript
import { Reasoning } from "@meetkai/mka1/models/components";

let value: Reasoning = {
  type: "reasoning",
  id: "<id>",
  summary: [
    {
      type: "summary_text",
      text: "<value>",
    },
  ],
};
```

## Fields

| Field                                                                  | Type                                                                   | Required                                                               | Description                                                            |
| ---------------------------------------------------------------------- | ---------------------------------------------------------------------- | ---------------------------------------------------------------------- | ---------------------------------------------------------------------- |
| `type`                                                                 | *"reasoning"*                                                          | :heavy_check_mark:                                                     | N/A                                                                    |
| `id`                                                                   | *string*                                                               | :heavy_check_mark:                                                     | N/A                                                                    |
| `summary`                                                              | [components.SummaryText](../../models/components/summarytext.md)[]     | :heavy_check_mark:                                                     | N/A                                                                    |
| `content`                                                              | [components.ReasoningText](../../models/components/reasoningtext.md)[] | :heavy_minus_sign:                                                     | N/A                                                                    |
| `encryptedContent`                                                     | *string*                                                               | :heavy_minus_sign:                                                     | N/A                                                                    |
| `status`                                                               | [components.Status](../../models/components/status.md)                 | :heavy_minus_sign:                                                     | N/A                                                                    |