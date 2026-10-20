# ToolChoice


## Supported Types

### ToolChoiceMode

```go
toolChoice := components.CreateToolChoiceToolChoiceMode(components.ToolChoiceMode{/* values here */})
```

### AllowedTools

```go
toolChoice := components.CreateToolChoiceAllowedTools(components.AllowedTools{/* values here */})
```

### HostedToolChoice

```go
toolChoice := components.CreateToolChoiceHostedToolChoice(components.HostedToolChoice{/* values here */})
```

### FunctionToolChoice

```go
toolChoice := components.CreateToolChoiceFunctionToolChoice(components.FunctionToolChoice{/* values here */})
```

### MCPToolChoice

```go
toolChoice := components.CreateToolChoiceMCPToolChoice(components.MCPToolChoice{/* values here */})
```

### CustomToolChoice

```go
toolChoice := components.CreateToolChoiceCustomToolChoice(components.CustomToolChoice{/* values here */})
```

## Union Discrimination

Use the `Type` field to determine which variant is active, then access the corresponding field:

```go
switch toolChoice.Type {
	case components.ToolChoiceTypeToolChoiceMode:
		// toolChoice.ToolChoiceMode is populated
	case components.ToolChoiceTypeAllowedTools:
		// toolChoice.AllowedTools is populated
	case components.ToolChoiceTypeHostedToolChoice:
		// toolChoice.HostedToolChoice is populated
	case components.ToolChoiceTypeFunctionToolChoice:
		// toolChoice.FunctionToolChoice is populated
	case components.ToolChoiceTypeMCPToolChoice:
		// toolChoice.MCPToolChoice is populated
	case components.ToolChoiceTypeCustomToolChoice:
		// toolChoice.CustomToolChoice is populated
	default:
		// Unknown type - use toolChoice.GetUnknownRaw() for raw JSON
}
```
