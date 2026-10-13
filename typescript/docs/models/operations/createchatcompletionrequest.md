# CreateChatCompletionRequest

## Example Usage

```typescript
import { CreateChatCompletionRequest } from "@meetkai/mka1/models/operations";

let value: CreateChatCompletionRequest = {
  openAIChatCompletionRequestParams: {
    model: "meetkai:functionary-urdu-mini-pak",
    messages: [
      {
        role: "user",
        content: "What is the capital of France?",
      },
    ],
    maxTokens: 100,
    temperature: 0.7,
  },
};
```

## Fields

| Field                                                                                                                                                                    | Type                                                                                                                                                                     | Required                                                                                                                                                                 | Description                                                                                                                                                              | Example                                                                                                                                                                  |
| ------------------------------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------------------------------ |
| `xOnBehalfOf`                                                                                                                                                            | *string*                                                                                                                                                                 | :heavy_minus_sign:                                                                                                                                                       | Optional external end-user identifier forwarded by the API gateway.                                                                                                      |                                                                                                                                                                          |
| `openAIChatCompletionRequestParams`                                                                                                                                      | [components.OpenAIChatCompletionRequestParams](../../models/components/openaichatcompletionrequestparams.md)                                                             | :heavy_check_mark:                                                                                                                                                       | N/A                                                                                                                                                                      | {<br/>"model": "meetkai:functionary-urdu-mini-pak",<br/>"messages": [<br/>{<br/>"role": "user",<br/>"content": "What is the capital of France?"<br/>}<br/>],<br/>"temperature": 0.7,<br/>"max_tokens": 100<br/>} |