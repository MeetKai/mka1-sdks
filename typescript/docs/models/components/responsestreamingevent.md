# ResponseStreamingEvent


## Supported Types

### `components.ResponseCreatedEvent`

```typescript
const value: components.ResponseCreatedEvent = {
  type: "response.created",
  sequenceNumber: 167482,
  response: {
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
};
```

### `components.ResponseInProgressEvent`

```typescript
const value: components.ResponseInProgressEvent = {
  type: "response.in_progress",
  sequenceNumber: 530526,
  response: {
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
};
```

### `components.ResponseCompletedEvent`

```typescript
const value: components.ResponseCompletedEvent = {
  type: "response.completed",
  sequenceNumber: 803980,
  response: {
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
};
```

### `components.ResponseFailedEvent`

```typescript
const value: components.ResponseFailedEvent = {
  type: "response.failed",
  sequenceNumber: 865741,
  response: {
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
};
```

### `components.ResponseIncompleteEvent`

```typescript
const value: components.ResponseIncompleteEvent = {
  type: "response.incomplete",
  sequenceNumber: 665974,
  response: {
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
};
```

### `components.ResponseQueuedEvent`

```typescript
const value: components.ResponseQueuedEvent = {
  type: "response.queued",
  sequenceNumber: 796875,
  response: {
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
};
```

### `components.ResponseCancelledEvent`

```typescript
const value: components.ResponseCancelledEvent = {
  type: "response.cancelled",
  sequenceNumber: 206860,
  response: {
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
};
```

### `components.ResponseOutputItemAddedEvent`

```typescript
const value: components.ResponseOutputItemAddedEvent = {
  type: "response.output_item.added",
  sequenceNumber: 502729,
  outputIndex: 453630,
  item: {
    type: "custom_tool_call",
    callId: "<id>",
    input: "<value>",
    name: "<value>",
  },
};
```

### `components.ResponseOutputItemDoneEvent`

```typescript
const value: components.ResponseOutputItemDoneEvent = {
  type: "response.output_item.done",
  sequenceNumber: 525098,
  outputIndex: 63506,
  item: {
    type: "computer_call",
    id: "<id>",
    callId: "<id>",
    action: {
      type: "double_click",
      x: 992146,
      y: 991972,
    },
    pendingSafetyChecks: [],
    status: "completed",
  },
};
```

### `components.ResponseContentPartAddedEvent`

```typescript
const value: components.ResponseContentPartAddedEvent = {
  type: "response.content_part.added",
  sequenceNumber: 45555,
  itemId: "<id>",
  outputIndex: 506959,
  contentIndex: 331465,
  part: {
    type: "reasoning_text",
    text: "<value>",
  },
};
```

### `components.ResponseContentPartDoneEvent`

```typescript
const value: components.ResponseContentPartDoneEvent = {
  type: "response.content_part.done",
  sequenceNumber: 133267,
  itemId: "<id>",
  outputIndex: 683752,
  contentIndex: 61029,
  part: {
    type: "refusal",
    refusal: "<value>",
  },
};
```

### `components.ResponseOutputTextDeltaEvent`

```typescript
const value: components.ResponseOutputTextDeltaEvent = {
  type: "response.output_text.delta",
  sequenceNumber: 673164,
  itemId: "<id>",
  outputIndex: 487856,
  contentIndex: 110262,
  delta: "<value>",
};
```

### `components.ResponseOutputTextDoneEvent`

```typescript
const value: components.ResponseOutputTextDoneEvent = {
  type: "response.output_text.done",
  sequenceNumber: 425179,
  itemId: "<id>",
  outputIndex: 633225,
  contentIndex: 237429,
  text: "<value>",
};
```

### `components.ResponseRefusalDeltaEvent`

```typescript
const value: components.ResponseRefusalDeltaEvent = {
  type: "response.refusal.delta",
  sequenceNumber: 395296,
  itemId: "<id>",
  outputIndex: 370708,
  contentIndex: 936011,
  delta: "<value>",
};
```

### `components.ResponseRefusalDoneEvent`

```typescript
const value: components.ResponseRefusalDoneEvent = {
  type: "response.refusal.done",
  sequenceNumber: 304504,
  itemId: "<id>",
  outputIndex: 425869,
  contentIndex: 108305,
  refusal: "<value>",
};
```

### `components.ResponseFunctionCallArgumentsDeltaEvent`

```typescript
const value: components.ResponseFunctionCallArgumentsDeltaEvent = {
  type: "response.function_call_arguments.delta",
  sequenceNumber: 112607,
  itemId: "<id>",
  outputIndex: 173885,
  delta: "<value>",
};
```

### `components.ResponseFunctionCallArgumentsDoneEvent`

```typescript
const value: components.ResponseFunctionCallArgumentsDoneEvent = {
  type: "response.function_call_arguments.done",
  sequenceNumber: 740062,
  itemId: "<id>",
  outputIndex: 582151,
  name: "<value>",
  arguments: "<value>",
};
```

### `components.ResponseFileSearchCallInProgressEvent`

```typescript
const value: components.ResponseFileSearchCallInProgressEvent = {
  type: "response.file_search_call.in_progress",
  sequenceNumber: 370273,
  itemId: "<id>",
  outputIndex: 554868,
};
```

### `components.ResponseFileSearchCallSearchingEvent`

```typescript
const value: components.ResponseFileSearchCallSearchingEvent = {
  type: "response.file_search_call.searching",
  sequenceNumber: 293441,
  itemId: "<id>",
  outputIndex: 237547,
};
```

### `components.ResponseFileSearchCallCompletedEvent`

```typescript
const value: components.ResponseFileSearchCallCompletedEvent = {
  type: "response.file_search_call.completed",
  sequenceNumber: 597473,
  itemId: "<id>",
  outputIndex: 776552,
};
```

### `components.ResponseWebSearchCallInProgressEvent`

```typescript
const value: components.ResponseWebSearchCallInProgressEvent = {
  type: "response.web_search_call.in_progress",
  sequenceNumber: 231856,
  itemId: "<id>",
  outputIndex: 449079,
};
```

### `components.ResponseWebSearchCallSearchingEvent`

```typescript
const value: components.ResponseWebSearchCallSearchingEvent = {
  type: "response.web_search_call.searching",
  sequenceNumber: 727317,
  itemId: "<id>",
  outputIndex: 846239,
};
```

### `components.ResponseWebSearchCallCompletedEvent`

```typescript
const value: components.ResponseWebSearchCallCompletedEvent = {
  type: "response.web_search_call.completed",
  sequenceNumber: 529005,
  itemId: "<id>",
  outputIndex: 122460,
};
```

### `components.ResponseHistoryCallInProgressEvent`

```typescript
const value: components.ResponseHistoryCallInProgressEvent = {
  type: "response.history_call.in_progress",
  sequenceNumber: 197848,
  itemId: "<id>",
  outputIndex: 309237,
};
```

### `components.ResponseHistoryCallSearchingEvent`

```typescript
const value: components.ResponseHistoryCallSearchingEvent = {
  type: "response.history_call.searching",
  sequenceNumber: 856690,
  itemId: "<id>",
  outputIndex: 309792,
};
```

### `components.ResponseHistoryCallCompletedEvent`

```typescript
const value: components.ResponseHistoryCallCompletedEvent = {
  type: "response.history_call.completed",
  sequenceNumber: 987348,
  itemId: "<id>",
  outputIndex: 710280,
};
```

### `components.ResponseSleepCallInProgressEvent`

```typescript
const value: components.ResponseSleepCallInProgressEvent = {
  type: "response.sleep_call.in_progress",
  sequenceNumber: 447892,
  itemId: "<id>",
  outputIndex: 116218,
};
```

### `components.ResponseSleepCallSleepingEvent`

```typescript
const value: components.ResponseSleepCallSleepingEvent = {
  type: "response.sleep_call.sleeping",
  sequenceNumber: 8071,
  itemId: "<id>",
  outputIndex: 627619,
};
```

### `components.ResponseSleepCallCompletedEvent`

```typescript
const value: components.ResponseSleepCallCompletedEvent = {
  type: "response.sleep_call.completed",
  sequenceNumber: 285309,
  itemId: "<id>",
  outputIndex: 255102,
};
```

### `components.ResponseToolSearchCallInProgressEvent`

```typescript
const value: components.ResponseToolSearchCallInProgressEvent = {
  type: "response.tool_search_call.in_progress",
  sequenceNumber: 871145,
  itemId: "<id>",
  outputIndex: 726102,
};
```

### `components.ResponseToolSearchCallSearchingEvent`

```typescript
const value: components.ResponseToolSearchCallSearchingEvent = {
  type: "response.tool_search_call.searching",
  sequenceNumber: 101487,
  itemId: "<id>",
  outputIndex: 119363,
};
```

### `components.ResponseToolSearchCallCompletedEvent`

```typescript
const value: components.ResponseToolSearchCallCompletedEvent = {
  type: "response.tool_search_call.completed",
  sequenceNumber: 255576,
  itemId: "<id>",
  outputIndex: 215592,
};
```

### `components.ResponseReasoningSummaryPartAddedEvent`

```typescript
const value: components.ResponseReasoningSummaryPartAddedEvent = {
  type: "response.reasoning_summary_part.added",
  sequenceNumber: 309396,
  itemId: "<id>",
  outputIndex: 963314,
  summaryIndex: 807635,
  part: {
    type: "summary_text",
    text: "<value>",
  },
};
```

### `components.ResponseReasoningSummaryPartDoneEvent`

```typescript
const value: components.ResponseReasoningSummaryPartDoneEvent = {
  type: "response.reasoning_summary_part.done",
  sequenceNumber: 623077,
  itemId: "<id>",
  outputIndex: 94231,
  summaryIndex: 500735,
  part: {
    type: "summary_text",
    text: "<value>",
  },
};
```

### `components.ResponseReasoningSummaryTextDeltaEvent`

```typescript
const value: components.ResponseReasoningSummaryTextDeltaEvent = {
  type: "response.reasoning_summary_text.delta",
  sequenceNumber: 143710,
  itemId: "<id>",
  outputIndex: 391272,
  summaryIndex: 56099,
  delta: "<value>",
};
```

### `components.ResponseReasoningSummaryTextDoneEvent`

```typescript
const value: components.ResponseReasoningSummaryTextDoneEvent = {
  type: "response.reasoning_summary_text.done",
  sequenceNumber: 206223,
  itemId: "<id>",
  outputIndex: 366329,
  summaryIndex: 314125,
  text: "<value>",
};
```

### `components.ResponseReasoningTextDeltaEvent`

```typescript
const value: components.ResponseReasoningTextDeltaEvent = {
  type: "response.reasoning_text.delta",
  sequenceNumber: 391800,
  itemId: "<id>",
  outputIndex: 467717,
  contentIndex: 357723,
  delta: "<value>",
};
```

### `components.ResponseReasoningTextDoneEvent`

```typescript
const value: components.ResponseReasoningTextDoneEvent = {
  type: "response.reasoning_text.done",
  sequenceNumber: 37603,
  itemId: "<id>",
  outputIndex: 929665,
  contentIndex: 863259,
  text: "<value>",
};
```

### `components.ResponseImageGenerationCallInProgressEvent`

```typescript
const value: components.ResponseImageGenerationCallInProgressEvent = {
  type: "response.image_generation_call.in_progress",
  sequenceNumber: 526513,
  itemId: "<id>",
  outputIndex: 835477,
};
```

### `components.ResponseImageGenerationCallGeneratingEvent`

```typescript
const value: components.ResponseImageGenerationCallGeneratingEvent = {
  type: "response.image_generation_call.generating",
  sequenceNumber: 10854,
  itemId: "<id>",
  outputIndex: 415747,
};
```

### `components.ResponseImageGenerationCallCompletedEvent`

```typescript
const value: components.ResponseImageGenerationCallCompletedEvent = {
  type: "response.image_generation_call.completed",
  sequenceNumber: 269803,
  itemId: "<id>",
  outputIndex: 259758,
};
```

### `components.ResponseImageGenerationCallPartialImageEvent`

```typescript
const value: components.ResponseImageGenerationCallPartialImageEvent = {
  type: "response.image_generation_call.partial_image",
  sequenceNumber: 382563,
  itemId: "<id>",
  outputIndex: 409770,
  partialImageIndex: 529018,
  partialImageB64: "<value>",
};
```

### `components.ResponseMCPCallArgumentsDeltaEvent`

```typescript
const value: components.ResponseMCPCallArgumentsDeltaEvent = {
  type: "response.mcp_call_arguments.delta",
  sequenceNumber: 75488,
  itemId: "<id>",
  outputIndex: 90432,
  delta: "<value>",
};
```

### `components.ResponseMCPCallArgumentsDoneEvent`

```typescript
const value: components.ResponseMCPCallArgumentsDoneEvent = {
  type: "response.mcp_call_arguments.done",
  sequenceNumber: 454225,
  itemId: "<id>",
  outputIndex: 172489,
  arguments: "<value>",
};
```

### `components.ResponseMCPCallInProgressEvent`

```typescript
const value: components.ResponseMCPCallInProgressEvent = {
  type: "response.mcp_call.in_progress",
  sequenceNumber: 652558,
  itemId: "<id>",
  outputIndex: 674352,
};
```

### `components.ResponseMCPCallCompletedEvent`

```typescript
const value: components.ResponseMCPCallCompletedEvent = {
  type: "response.mcp_call.completed",
  sequenceNumber: 72098,
  itemId: "<id>",
  outputIndex: 284374,
};
```

### `components.ResponseMCPCallFailedEvent`

```typescript
const value: components.ResponseMCPCallFailedEvent = {
  type: "response.mcp_call.failed",
  sequenceNumber: 817535,
  itemId: "<id>",
  outputIndex: 60918,
};
```

### `components.ResponseMCPListToolsInProgressEvent`

```typescript
const value: components.ResponseMCPListToolsInProgressEvent = {
  type: "response.mcp_list_tools.in_progress",
  sequenceNumber: 561377,
  itemId: "<id>",
  outputIndex: 519019,
};
```

### `components.ResponseMCPListToolsCompletedEvent`

```typescript
const value: components.ResponseMCPListToolsCompletedEvent = {
  type: "response.mcp_list_tools.completed",
  sequenceNumber: 447376,
  itemId: "<id>",
  outputIndex: 110227,
};
```

### `components.ResponseMCPListToolsFailedEvent`

```typescript
const value: components.ResponseMCPListToolsFailedEvent = {
  type: "response.mcp_list_tools.failed",
  sequenceNumber: 879219,
  itemId: "<id>",
  outputIndex: 657604,
};
```

### `components.ResponseReadFileCallInProgressEvent`

```typescript
const value: components.ResponseReadFileCallInProgressEvent = {
  type: "response.read_file_call.in_progress",
  sequenceNumber: 196559,
  itemId: "<id>",
  outputIndex: 230753,
};
```

### `components.ResponseReadFileCallReadingEvent`

```typescript
const value: components.ResponseReadFileCallReadingEvent = {
  type: "response.read_file_call.reading",
  sequenceNumber: 573241,
  itemId: "<id>",
  outputIndex: 938331,
};
```

### `components.ResponseReadFileCallCompletedEvent`

```typescript
const value: components.ResponseReadFileCallCompletedEvent = {
  type: "response.read_file_call.completed",
  sequenceNumber: 358438,
  itemId: "<id>",
  outputIndex: 42529,
};
```

### `components.ResponseCodeInterpreterCallInProgressEvent`

```typescript
const value: components.ResponseCodeInterpreterCallInProgressEvent = {
  type: "response.code_interpreter_call.in_progress",
  sequenceNumber: 693330,
  itemId: "<id>",
  outputIndex: 358674,
};
```

### `components.ResponseCodeInterpreterCallInterpretingEvent`

```typescript
const value: components.ResponseCodeInterpreterCallInterpretingEvent = {
  type: "response.code_interpreter_call.interpreting",
  sequenceNumber: 921594,
  itemId: "<id>",
  outputIndex: 311540,
};
```

### `components.ResponseCodeInterpreterCallCompletedEvent`

```typescript
const value: components.ResponseCodeInterpreterCallCompletedEvent = {
  type: "response.code_interpreter_call.completed",
  sequenceNumber: 231984,
  itemId: "<id>",
  outputIndex: 81492,
};
```

### `components.ResponseCodeInterpreterCallCodeDeltaEvent`

```typescript
const value: components.ResponseCodeInterpreterCallCodeDeltaEvent = {
  type: "response.code_interpreter_call_code.delta",
  sequenceNumber: 420654,
  itemId: "<id>",
  outputIndex: 975612,
  delta: "<value>",
};
```

### `components.ResponseCodeInterpreterCallCodeDoneEvent`

```typescript
const value: components.ResponseCodeInterpreterCallCodeDoneEvent = {
  type: "response.code_interpreter_call_code.done",
  sequenceNumber: 574292,
  itemId: "<id>",
  outputIndex: 366929,
  code: "<value>",
};
```

### `components.ResponseShellCallInProgressEvent`

```typescript
const value: components.ResponseShellCallInProgressEvent = {
  type: "response.shell_call.in_progress",
  sequenceNumber: 750715,
  itemId: "<id>",
  outputIndex: 691989,
};
```

### `components.ResponseShellCallExecutingEvent`

```typescript
const value: components.ResponseShellCallExecutingEvent = {
  type: "response.shell_call.executing",
  sequenceNumber: 393385,
  itemId: "<id>",
  outputIndex: 240402,
};
```

### `components.ResponseShellCallCompletedEvent`

```typescript
const value: components.ResponseShellCallCompletedEvent = {
  type: "response.shell_call.completed",
  sequenceNumber: 384317,
  itemId: "<id>",
  outputIndex: 879974,
};
```

### `components.ResponseCustomToolCallInputDeltaEvent`

```typescript
const value: components.ResponseCustomToolCallInputDeltaEvent = {
  type: "response.custom_tool_call_input.delta",
  sequenceNumber: 591313,
  itemId: "<id>",
  outputIndex: 597994,
  delta: "<value>",
};
```

### `components.ResponseCustomToolCallInputDoneEvent`

```typescript
const value: components.ResponseCustomToolCallInputDoneEvent = {
  type: "response.custom_tool_call_input.done",
  sequenceNumber: 202366,
  itemId: "<id>",
  outputIndex: 85806,
  input: "<value>",
};
```

### `components.ResponseOutputTextAnnotationAddedEvent`

```typescript
const value: components.ResponseOutputTextAnnotationAddedEvent = {
  type: "response.output_text.annotation.added",
  sequenceNumber: 1555,
  itemId: "<id>",
  outputIndex: 251392,
  contentIndex: 417194,
  annotationIndex: 1564,
  annotation: {
    type: "<value>",
    text: "<value>",
    start: 981955,
    end: 728911,
  },
};
```

### `components.ErrorEvent`

```typescript
const value: components.ErrorEvent = {
  type: "error",
  sequenceNumber: 857643,
  code: "<value>",
  message: "<value>",
};
```

