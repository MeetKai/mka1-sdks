# ResponseObjectTools


## Supported Types

### `components.FunctionToolDefinition`

```typescript
const value: components.FunctionToolDefinition = {
  type: "function",
  name: "<value>",
  parameters: {
    "key": "<value>",
  },
  strict: true,
};
```

### `components.ToolsFileSearchToolDefinition`

```typescript
const value: components.ToolsFileSearchToolDefinition = {
  type: "file_search",
  vectorStoreIds: [
    "<value 1>",
    "<value 2>",
    "<value 3>",
  ],
};
```

### `components.ComputerUseToolDefinition`

```typescript
const value: components.ComputerUseToolDefinition = {
  type: "computer_use_preview",
  displayHeight: 388527,
  displayWidth: 950446,
  environment: "<value>",
};
```

### `components.WebSearchToolDefinition`

```typescript
const value: components.WebSearchToolDefinition = {
  type: "web_search",
};
```

### `any`

```typescript
const value: any = "<value>";
```

### `components.CodeInterpreterToolDefinition`

```typescript
const value: components.CodeInterpreterToolDefinition = {
  type: "code_interpreter",
  container: "<value>",
};
```

### `components.ImageGenerationToolDefinition`

```typescript
const value: components.ImageGenerationToolDefinition = {
  type: "image_generation",
};
```

### `components.LocalShellToolDefinition`

```typescript
const value: components.LocalShellToolDefinition = {
  type: "local_shell",
};
```

### `components.ShellToolDefinition`

```typescript
const value: components.ShellToolDefinition = {
  type: "shell",
};
```

### `components.CustomToolDefinition`

```typescript
const value: components.CustomToolDefinition = {
  type: "custom",
  name: "<value>",
};
```

### `components.WebSearchPreviewToolDefinition`

```typescript
const value: components.WebSearchPreviewToolDefinition = {
  type: "web_search_preview_2025_03_11",
};
```

### `components.HostedToolDefinition`

```typescript
const value: components.HostedToolDefinition = {
  type: "file_search",
};
```

### `components.SleepToolDefinition`

```typescript
const value: components.SleepToolDefinition = {
  type: "sleep",
};
```

### `components.HistoryToolDefinition`

```typescript
const value: components.HistoryToolDefinition = {
  type: "history",
};
```

