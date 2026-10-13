# ToolChoice


## Supported Types

### `components.ToolChoiceMode`

```typescript
const value: components.ToolChoiceMode = "required";
```

### `components.AllowedTools`

```typescript
const value: components.AllowedTools = {
  type: "allowed_tools",
  mode: "auto",
  tools: [
    {
      type: "<value>",
    },
  ],
};
```

### `components.HostedToolChoice`

```typescript
const value: components.HostedToolChoice = {
  type: "web_search_preview",
};
```

### `components.FunctionToolChoice`

```typescript
const value: components.FunctionToolChoice = {
  type: "function",
  name: "<value>",
};
```

### `components.MCPToolChoice`

```typescript
const value: components.MCPToolChoice = {
  type: "mcp",
  serverLabel: "<value>",
};
```

### `components.CustomToolChoice`

```typescript
const value: components.CustomToolChoice = {
  type: "custom",
  name: "<value>",
};
```

