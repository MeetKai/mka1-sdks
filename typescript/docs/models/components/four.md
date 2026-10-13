# Four

Forces the model to call a specific function

## Example Usage

```typescript
import { Four } from "@meetkai/mka1/models/components";

let value: Four = {
  type: "function",
  function: {
    name: "<value>",
  },
};
```

## Fields

| Field                                                                          | Type                                                                           | Required                                                                       | Description                                                                    |
| ------------------------------------------------------------------------------ | ------------------------------------------------------------------------------ | ------------------------------------------------------------------------------ | ------------------------------------------------------------------------------ |
| `type`                                                                         | *"function"*                                                                   | :heavy_check_mark:                                                             | The type of the tool. Currently only 'function' is supported.                  |
| `function`                                                                     | [components.ToolChoiceFunction](../../models/components/toolchoicefunction.md) | :heavy_check_mark:                                                             | The function to call                                                           |