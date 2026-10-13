# ResponseListObject

Paginated list object containing responses with cursor-based pagination metadata.

## Example Usage

```typescript
import { ResponseListObject } from "@meetkai/mka1/models/components";

let value: ResponseListObject = {
  object: "list",
  data: [
    {
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
    },
  ],
  hasMore: false,
};
```

## Fields

| Field                                                                                                                                     | Type                                                                                                                                      | Required                                                                                                                                  | Description                                                                                                                               |
| ----------------------------------------------------------------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------------------------------------------------------------- |
| `object`                                                                                                                                  | *"list"*                                                                                                                                  | :heavy_check_mark:                                                                                                                        | The object type, always 'list' for paginated list responses.                                                                              |
| `data`                                                                                                                                    | [components.ResponseObject](../../models/components/responseobject.md)[]                                                                  | :heavy_check_mark:                                                                                                                        | Array of response objects. Each response contains its status, model, input/output, tool usage logs, metadata, and completion information. |
| `firstId`                                                                                                                                 | *string*                                                                                                                                  | :heavy_minus_sign:                                                                                                                        | The ID of the first response in the current page. Used as a reference point for pagination.                                               |
| `lastId`                                                                                                                                  | *string*                                                                                                                                  | :heavy_minus_sign:                                                                                                                        | The ID of the last response in the current page. Used as a cursor for fetching the next page.                                             |
| `hasMore`                                                                                                                                 | *boolean*                                                                                                                                 | :heavy_check_mark:                                                                                                                        | Indicates whether there are more responses available beyond the current page. True if additional pages exist, false otherwise.            |