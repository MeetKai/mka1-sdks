# OpenAIToolDefinition

A tool the model may call while generating a response.

## Example Usage

```typescript
import { OpenAIToolDefinition } from "@meetkai/mka1/models/components";

let value: OpenAIToolDefinition = {
  type: "function",
  function: {
    name: "<value>",
  },
};
```

## Fields

| Field                                                         | Type                                                          | Required                                                      | Description                                                   |
| ------------------------------------------------------------- | ------------------------------------------------------------- | ------------------------------------------------------------- | ------------------------------------------------------------- |
| `type`                                                        | *"function"*                                                  | :heavy_check_mark:                                            | The type of the tool. Currently only 'function' is supported. |
| `function`                                                    | [components.FunctionT](../../models/components/functiont.md)  | :heavy_check_mark:                                            | The function definition                                       |