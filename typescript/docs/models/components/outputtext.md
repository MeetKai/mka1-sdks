# OutputText

Text content output from the model with optional annotations for citations and file references.

## Example Usage

```typescript
import { OutputText } from "@meetkai/mka1/models/components";

let value: OutputText = {
  type: "output_text",
  text: "<value>",
};
```

## Fields

| Field                                                                                                                                        | Type                                                                                                                                         | Required                                                                                                                                     | Description                                                                                                                                  |
| -------------------------------------------------------------------------------------------------------------------------------------------- | -------------------------------------------------------------------------------------------------------------------------------------------- | -------------------------------------------------------------------------------------------------------------------------------------------- | -------------------------------------------------------------------------------------------------------------------------------------------- |
| `type`                                                                                                                                       | *"output_text"*                                                                                                                              | :heavy_check_mark:                                                                                                                           | The content type identifier for text output.                                                                                                 |
| `text`                                                                                                                                       | *string*                                                                                                                                     | :heavy_check_mark:                                                                                                                           | The generated text content from the model.                                                                                                   |
| `annotations`                                                                                                                                | *components.Annotations*[]                                                                                                                   | :heavy_minus_sign:                                                                                                                           | Array of annotations providing citations and references for the text. Used to attribute sources and reference files mentioned in the output. |
| `logprobs`                                                                                                                                   | [components.LogProb](../../models/components/logprob.md)[]                                                                                   | :heavy_minus_sign:                                                                                                                           | N/A                                                                                                                                          |