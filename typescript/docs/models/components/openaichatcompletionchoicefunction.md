# OpenAIChatCompletionChoiceFunction

The function that the model called

## Example Usage

```typescript
import { OpenAIChatCompletionChoiceFunction } from "@meetkai/mka1/models/components";

let value: OpenAIChatCompletionChoiceFunction = {
  name: "<value>",
  arguments: "<value>",
};
```

## Fields

| Field                                                     | Type                                                      | Required                                                  | Description                                               |
| --------------------------------------------------------- | --------------------------------------------------------- | --------------------------------------------------------- | --------------------------------------------------------- |
| `name`                                                    | *string*                                                  | :heavy_check_mark:                                        | The name of the function to call                          |
| `arguments`                                               | *string*                                                  | :heavy_check_mark:                                        | The arguments to call the function with, as a JSON string |