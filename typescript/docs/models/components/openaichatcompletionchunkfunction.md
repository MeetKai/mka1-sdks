# OpenAIChatCompletionChunkFunction

The function that the model called

## Example Usage

```typescript
import { OpenAIChatCompletionChunkFunction } from "@meetkai/mka1/models/components";

let value: OpenAIChatCompletionChunkFunction = {};
```

## Fields

| Field                                                  | Type                                                   | Required                                               | Description                                            |
| ------------------------------------------------------ | ------------------------------------------------------ | ------------------------------------------------------ | ------------------------------------------------------ |
| `name`                                                 | *string*                                               | :heavy_minus_sign:                                     | The name of the function called                        |
| `arguments`                                            | *string*                                               | :heavy_minus_sign:                                     | The arguments passed to the function, as a JSON string |