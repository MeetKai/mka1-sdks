# GetResponseResponseBody

Successful response - returns either streaming events (SSE) when stream=true or a complete response object (JSON) when stream=false or omitted

## Example Usage

```typescript
import { GetResponseResponseBody } from "@meetkai/mka1/models/operations";

let value: GetResponseResponseBody = {
  event: "response.completed",
  data: {
    type: "response.completed",
    sequenceNumber: 1,
    response: {
      id: "resp_get123",
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
        verbosity: "medium",
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
    },
  },
};
```

## Fields

| Field                                      | Type                                       | Required                                   | Description                                |
| ------------------------------------------ | ------------------------------------------ | ------------------------------------------ | ------------------------------------------ |
| `event`                                    | *string*                                   | :heavy_minus_sign:                         | The event type (optional in SSE)           |
| `data`                                     | *components.ResponseStreamingEvent*        | :heavy_check_mark:                         | N/A                                        |
| `id`                                       | *string*                                   | :heavy_minus_sign:                         | Optional event ID for reconnection         |
| `retry`                                    | *number*                                   | :heavy_minus_sign:                         | Optional reconnection time in milliseconds |