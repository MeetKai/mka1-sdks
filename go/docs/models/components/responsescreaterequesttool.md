# ResponsesCreateRequestTool


## Supported Types

### FunctionToolDefinition

```go
responsesCreateRequestTool := components.CreateResponsesCreateRequestToolFunctionToolDefinition(components.FunctionToolDefinition{/* values here */})
```

### FileSearchToolDefinition

```go
responsesCreateRequestTool := components.CreateResponsesCreateRequestToolFileSearchToolDefinition(components.FileSearchToolDefinition{/* values here */})
```

### ComputerUseToolDefinition

```go
responsesCreateRequestTool := components.CreateResponsesCreateRequestToolComputerUseToolDefinition(components.ComputerUseToolDefinition{/* values here */})
```

### WebSearchToolDefinition

```go
responsesCreateRequestTool := components.CreateResponsesCreateRequestToolWebSearchToolDefinition(components.WebSearchToolDefinition{/* values here */})
```

### MCPToolDefinition

```go
responsesCreateRequestTool := components.CreateResponsesCreateRequestToolMCPToolDefinition(components.MCPToolDefinition{/* values here */})
```

### CodeInterpreterToolRequest

```go
responsesCreateRequestTool := components.CreateResponsesCreateRequestToolCodeInterpreterToolRequest(components.CodeInterpreterToolRequest{/* values here */})
```

### ImageGenerationToolDefinition

```go
responsesCreateRequestTool := components.CreateResponsesCreateRequestToolImageGenerationToolDefinition(components.ImageGenerationToolDefinition{/* values here */})
```

### LocalShellToolDefinition

```go
responsesCreateRequestTool := components.CreateResponsesCreateRequestToolLocalShellToolDefinition(components.LocalShellToolDefinition{/* values here */})
```

### ShellToolRequest

```go
responsesCreateRequestTool := components.CreateResponsesCreateRequestToolShellToolRequest(components.ShellToolRequest{/* values here */})
```

### CustomToolDefinition

```go
responsesCreateRequestTool := components.CreateResponsesCreateRequestToolCustomToolDefinition(components.CustomToolDefinition{/* values here */})
```

### WebSearchPreviewToolDefinition

```go
responsesCreateRequestTool := components.CreateResponsesCreateRequestToolWebSearchPreviewToolDefinition(components.WebSearchPreviewToolDefinition{/* values here */})
```

### HostedToolShorthandDefinition

```go
responsesCreateRequestTool := components.CreateResponsesCreateRequestToolHostedToolShorthandDefinition(components.HostedToolShorthandDefinition{/* values here */})
```

### SleepToolDefinition

```go
responsesCreateRequestTool := components.CreateResponsesCreateRequestToolSleepToolDefinition(components.SleepToolDefinition{/* values here */})
```

### HistoryToolDefinition

```go
responsesCreateRequestTool := components.CreateResponsesCreateRequestToolHistoryToolDefinition(components.HistoryToolDefinition{/* values here */})
```

### AgentToolDefinition

```go
responsesCreateRequestTool := components.CreateResponsesCreateRequestToolAgentToolDefinition(components.AgentToolDefinition{/* values here */})
```

## Union Discrimination

Use the `Type` field to determine which variant is active, then access the corresponding field:

```go
switch responsesCreateRequestTool.Type {
	case components.ResponsesCreateRequestToolTypeFunctionToolDefinition:
		// responsesCreateRequestTool.FunctionToolDefinition is populated
	case components.ResponsesCreateRequestToolTypeFileSearchToolDefinition:
		// responsesCreateRequestTool.FileSearchToolDefinition is populated
	case components.ResponsesCreateRequestToolTypeComputerUseToolDefinition:
		// responsesCreateRequestTool.ComputerUseToolDefinition is populated
	case components.ResponsesCreateRequestToolTypeWebSearchToolDefinition:
		// responsesCreateRequestTool.WebSearchToolDefinition is populated
	case components.ResponsesCreateRequestToolTypeMCPToolDefinition:
		// responsesCreateRequestTool.MCPToolDefinition is populated
	case components.ResponsesCreateRequestToolTypeCodeInterpreterToolRequest:
		// responsesCreateRequestTool.CodeInterpreterToolRequest is populated
	case components.ResponsesCreateRequestToolTypeImageGenerationToolDefinition:
		// responsesCreateRequestTool.ImageGenerationToolDefinition is populated
	case components.ResponsesCreateRequestToolTypeLocalShellToolDefinition:
		// responsesCreateRequestTool.LocalShellToolDefinition is populated
	case components.ResponsesCreateRequestToolTypeShellToolRequest:
		// responsesCreateRequestTool.ShellToolRequest is populated
	case components.ResponsesCreateRequestToolTypeCustomToolDefinition:
		// responsesCreateRequestTool.CustomToolDefinition is populated
	case components.ResponsesCreateRequestToolTypeWebSearchPreviewToolDefinition:
		// responsesCreateRequestTool.WebSearchPreviewToolDefinition is populated
	case components.ResponsesCreateRequestToolTypeHostedToolShorthandDefinition:
		// responsesCreateRequestTool.HostedToolShorthandDefinition is populated
	case components.ResponsesCreateRequestToolTypeSleepToolDefinition:
		// responsesCreateRequestTool.SleepToolDefinition is populated
	case components.ResponsesCreateRequestToolTypeHistoryToolDefinition:
		// responsesCreateRequestTool.HistoryToolDefinition is populated
	case components.ResponsesCreateRequestToolTypeAgentToolDefinition:
		// responsesCreateRequestTool.AgentToolDefinition is populated
}
```
