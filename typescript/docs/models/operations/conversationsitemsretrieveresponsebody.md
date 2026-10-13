# ConversationsItemsRetrieveResponseBody

OK


## Supported Types

### `operations.InputMessageItem`

```typescript
const value: operations.InputMessageItem = {
  role: "system",
  content: [
    "<value>",
  ],
  id: "<id>",
};
```

### `components.OutputMessageWithId`

```typescript
const value: components.OutputMessageWithId = {
  type: "message",
  id: "<id>",
  role: "assistant",
  content: [
    {
      type: "output_text",
      text: "<value>",
    },
  ],
  status: "completed",
};
```

### `components.OutputAudioItemWithId`

```typescript
const value: components.OutputAudioItemWithId = {
  type: "output_audio",
  data: "<value>",
  transcript: "<value>",
  id: "<id>",
  status: "in_progress",
};
```

### `components.FileSearchToolCallWithId`

```typescript
const value: components.FileSearchToolCallWithId = {
  type: "file_search_call",
  id: "<id>",
  queries: [],
  status: "incomplete",
};
```

### `components.ComputerToolCallWithId`

```typescript
const value: components.ComputerToolCallWithId = {
  type: "computer_call",
  id: "<id>",
  callId: "<id>",
  action: {
    type: "keypress",
    keys: [
      "<value 1>",
      "<value 2>",
      "<value 3>",
    ],
  },
  pendingSafetyChecks: [],
  status: "completed",
};
```

### `components.ComputerToolCallOutputWithId`

```typescript
const value: components.ComputerToolCallOutputWithId = {
  type: "computer_call_output",
  callId: "<id>",
  output: {
    type: "computer_screenshot",
  },
  id: "<id>",
};
```

### `components.WebSearchToolCallWithId`

```typescript
const value: components.WebSearchToolCallWithId = {
  type: "web_search_call",
  id: "<id>",
  action: {
    type: "find",
    pattern: "<value>",
    url: "https://mushy-larva.biz",
  },
  status: "<value>",
};
```

### `components.FunctionToolCallWithId`

```typescript
const value: components.FunctionToolCallWithId = {
  type: "function_call",
  arguments: "<value>",
  callId: "<id>",
  name: "<value>",
  id: "<id>",
};
```

### `components.FunctionToolCallOutputWithId`

```typescript
const value: components.FunctionToolCallOutputWithId = {
  type: "function_call_output",
  callId: "<id>",
  output: "<value>",
  id: "<id>",
};
```

### `components.ReasoningWithId`

```typescript
const value: components.ReasoningWithId = {
  type: "reasoning",
  id: "<id>",
  summary: [
    {
      type: "summary_text",
      text: "<value>",
    },
  ],
};
```

### `components.ImageGenerationCallWithId`

```typescript
const value: components.ImageGenerationCallWithId = {
  type: "image_generation_call",
  id: "<id>",
  status: "<value>",
  result: "<value>",
};
```

### `components.CodeInterpreterToolCallWithId`

```typescript
const value: components.CodeInterpreterToolCallWithId = {
  type: "code_interpreter_call",
  id: "<id>",
  code: "<value>",
  containerId: "<id>",
  outputs: [],
  status: "incomplete",
};
```

### `components.LocalShellCallWithId`

```typescript
const value: components.LocalShellCallWithId = {
  type: "local_shell_call",
  id: "<id>",
  callId: "<id>",
  action: {
    type: "exec",
    command: [
      "<value 1>",
      "<value 2>",
    ],
    env: {
      "key": "<value>",
      "key1": "<value>",
      "key2": "<value>",
    },
  },
  status: "<value>",
};
```

### `components.LocalShellCallOutputWithId`

```typescript
const value: components.LocalShellCallOutputWithId = {
  type: "local_shell_call_output",
  id: "<id>",
  output: "<value>",
};
```

### `components.ShellCallWithId`

```typescript
const value: components.ShellCallWithId = {
  type: "shell_call",
  id: "<id>",
  callId: "<id>",
  action: {
    type: "exec",
  },
  status: "incomplete",
};
```

### `components.ShellCallOutputWithId`

```typescript
const value: components.ShellCallOutputWithId = {
  type: "shell_call_output",
  id: "<id>",
  callId: "<id>",
  output: {
    stdout: "<value>",
    stderr: "<value>",
    outcome: {
      type: "timeout",
      exitCode: 631345,
    },
  },
};
```

### `components.MCPListToolsWithId`

```typescript
const value: components.MCPListToolsWithId = {
  type: "mcp_list_tools",
  id: "<id>",
  serverLabel: "<value>",
  tools: [],
};
```

### `components.MCPApprovalRequestWithId`

```typescript
const value: components.MCPApprovalRequestWithId = {
  type: "mcp_approval_request",
  id: "<id>",
  arguments: "<value>",
  name: "<value>",
  serverLabel: "<value>",
};
```

### `components.MCPApprovalResponseWithId`

```typescript
const value: components.MCPApprovalResponseWithId = {
  type: "mcp_approval_response",
  approvalRequestId: "<id>",
  approve: false,
  id: "<id>",
};
```

### `components.MCPToolCallWithId`

```typescript
const value: components.MCPToolCallWithId = {
  type: "mcp_call",
  id: "<id>",
  arguments: "<value>",
  name: "<value>",
  serverLabel: "<value>",
};
```

### `components.CustomToolCallWithId`

```typescript
const value: components.CustomToolCallWithId = {
  type: "custom_tool_call",
  callId: "<id>",
  input: "<value>",
  name: "<value>",
  id: "<id>",
};
```

### `components.CustomToolCallOutputWithId`

```typescript
const value: components.CustomToolCallOutputWithId = {
  type: "custom_tool_call_output",
  callId: "<id>",
  output: "<value>",
  id: "<id>",
};
```

### `components.ItemReferenceWithId`

```typescript
const value: components.ItemReferenceWithId = {
  id: "<id>",
};
```

### `components.ResponseCompactionItemWithId`

```typescript
const value: components.ResponseCompactionItemWithId = {
  type: "compaction",
  id: "<id>",
  content: "<value>",
};
```

