# Item


## Supported Types

### `components.InputMessage`

```typescript
const value: components.InputMessage = {
  role: "system",
  content: [],
  id: "msg_aa87e2b1112a455b8deabed784372198",
};
```

### `components.OutputMessage`

```typescript
const value: components.OutputMessage = {
  type: "message",
  id: "<id>",
  role: "assistant",
  content: [
    {
      type: "output_text",
      text: "<value>",
    },
  ],
  status: "in_progress",
};
```

### `components.OutputAudioItem`

```typescript
const value: components.OutputAudioItem = {
  type: "output_audio",
  data: "<value>",
  transcript: "<value>",
  id: "<id>",
  status: "incomplete",
};
```

### `components.FileSearchToolCall`

```typescript
const value: components.FileSearchToolCall = {
  type: "file_search_call",
  id: "<id>",
  queries: [
    "<value 1>",
    "<value 2>",
  ],
  status: "failed",
};
```

### `components.ComputerToolCall`

```typescript
const value: components.ComputerToolCall = {
  type: "computer_call",
  id: "<id>",
  callId: "<id>",
  action: {
    type: "move",
    x: 739634,
    y: 855140,
  },
  pendingSafetyChecks: [],
  status: "in_progress",
};
```

### `components.ComputerToolCallOutput`

```typescript
const value: components.ComputerToolCallOutput = {
  type: "computer_call_output",
  callId: "<id>",
  output: {
    type: "computer_screenshot",
  },
};
```

### `components.WebSearchToolCall`

```typescript
const value: components.WebSearchToolCall = {
  type: "web_search_call",
  id: "<id>",
  action: {
    type: "open_page",
    url: "https://excellent-godparent.org/",
  },
  status: "<value>",
};
```

### `components.FunctionToolCall`

```typescript
const value: components.FunctionToolCall = {
  type: "function_call",
  arguments: "<value>",
  callId: "<id>",
  name: "<value>",
};
```

### `components.FunctionToolCallOutput`

```typescript
const value: components.FunctionToolCallOutput = {
  type: "function_call_output",
  callId: "<id>",
  output: "<value>",
};
```

### `components.Reasoning`

```typescript
const value: components.Reasoning = {
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

### `components.ImageGenerationCall`

```typescript
const value: components.ImageGenerationCall = {
  type: "image_generation_call",
  id: "<id>",
  status: "<value>",
  result: "<value>",
};
```

### `components.CodeInterpreterToolCall`

```typescript
const value: components.CodeInterpreterToolCall = {
  type: "code_interpreter_call",
  id: "<id>",
  code: "<value>",
  containerId: "<id>",
  outputs: [],
  status: "in_progress",
};
```

### `components.LocalShellCall`

```typescript
const value: components.LocalShellCall = {
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

### `components.LocalShellCallOutput`

```typescript
const value: components.LocalShellCallOutput = {
  type: "local_shell_call_output",
  id: "<id>",
  output: "<value>",
};
```

### `components.ShellCall`

```typescript
const value: components.ShellCall = {
  type: "shell_call",
  id: "<id>",
  callId: "<id>",
  action: {
    type: "exec",
  },
  status: "completed",
};
```

### `components.ShellCallOutput`

```typescript
const value: components.ShellCallOutput = {
  type: "shell_call_output",
  id: "<id>",
  callId: "<id>",
  output: {
    stdout: "<value>",
    stderr: "<value>",
    outcome: {
      type: "timeout",
      exitCode: 589719,
    },
  },
};
```

### `components.MCPListTools`

```typescript
const value: components.MCPListTools = {
  type: "mcp_list_tools",
  id: "<id>",
  serverLabel: "<value>",
  tools: [
    {
      name: "<value>",
      inputSchema: {
        "key": "<value>",
        "key1": "<value>",
      },
    },
  ],
};
```

### `components.MCPApprovalRequest`

```typescript
const value: components.MCPApprovalRequest = {
  type: "mcp_approval_request",
  id: "<id>",
  arguments: "<value>",
  name: "<value>",
  serverLabel: "<value>",
};
```

### `components.MCPApprovalResponse`

```typescript
const value: components.MCPApprovalResponse = {
  type: "mcp_approval_response",
  approvalRequestId: "<id>",
  approve: true,
};
```

### `components.MCPToolCall`

```typescript
const value: components.MCPToolCall = {
  type: "mcp_call",
  id: "<id>",
  arguments: "<value>",
  name: "<value>",
  serverLabel: "<value>",
};
```

### `components.CustomToolCall`

```typescript
const value: components.CustomToolCall = {
  type: "custom_tool_call",
  callId: "<id>",
  input: "<value>",
  name: "<value>",
};
```

### `components.CustomToolCallOutput`

```typescript
const value: components.CustomToolCallOutput = {
  type: "custom_tool_call_output",
  callId: "<id>",
  output: "<value>",
};
```

### `components.ItemReference`

```typescript
const value: components.ItemReference = {
  id: "<id>",
};
```

### `components.ResponseCompactionItem`

```typescript
const value: components.ResponseCompactionItem = {
  type: "compaction",
  id: "<id>",
  content: "<value>",
};
```

