# GetResponseResponse


## Supported Types

### `components.ResponseObject`

```typescript
const value: components.ResponseObject = {
  id: "resp_abc123",
  object: "response",
  createdAt: 1735689600,
  completedAt: 1735689601,
  status: "completed",
  error: null,
  incompleteDetails: null,
  background: false,
  instructions: null,
  maxOutputTokens: null,
  maxToolCalls: 30,
  metadata: {},
  model: "meetkai:functionary-urdu-mini-pak",
  output: [
    {
      role: "assistant",
      content: [
        {
          type: "output_text",
          text: "The capital of France is Paris.",
          annotations: [],
        },
      ],
      status: "completed",
      id: "msg_abc123",
    },
  ],
  outputText: "The capital of France is Paris.",
  parallelToolCalls: true,
  previousResponseId: null,
  reasoning: {
    effort: null,
    summary: null,
  },
  serviceTier: "auto",
  store: true,
  text: {
    format: {
      type: "text",
    },
  },
  toolChoice: "auto",
  tools: [],
  truncation: "auto",
  usage: {
    inputTokens: 8,
    inputTokensDetails: {
      cachedTokens: 0,
    },
    outputTokens: 7,
    outputTokensDetails: {
      reasoningTokens: 0,
    },
    totalTokens: 15,
  },
  user: null,
};
```

### `EventStream<operations.GetResponseResponseBody>`

