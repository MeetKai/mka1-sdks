# OpenAIChatCompletionChoiceToolCalls

## Example Usage

```typescript
import { OpenAIChatCompletionChoiceToolCalls } from "@meetkai/mka1/models/components";

let value: OpenAIChatCompletionChoiceToolCalls = {
  id: "<id>",
  type: "function",
  function: {
    name: "<value>",
    arguments: "<value>",
  },
};
```

## Fields

| Field                                                                                                          | Type                                                                                                           | Required                                                                                                       | Description                                                                                                    |
| -------------------------------------------------------------------------------------------------------------- | -------------------------------------------------------------------------------------------------------------- | -------------------------------------------------------------------------------------------------------------- | -------------------------------------------------------------------------------------------------------------- |
| `id`                                                                                                           | *string*                                                                                                       | :heavy_check_mark:                                                                                             | The ID of the tool call                                                                                        |
| `type`                                                                                                         | *"function"*                                                                                                   | :heavy_check_mark:                                                                                             | The type of the tool. Currently only 'function' is supported.                                                  |
| `function`                                                                                                     | [components.OpenAIChatCompletionChoiceFunction](../../models/components/openaichatcompletionchoicefunction.md) | :heavy_check_mark:                                                                                             | The function that the model called                                                                             |