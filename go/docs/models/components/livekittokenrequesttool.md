# LivekitTokenRequestTool


## Supported Types

### FunctionToolDefinition

```go
livekitTokenRequestTool := components.CreateLivekitTokenRequestToolFunctionToolDefinition(components.FunctionToolDefinition{/* values here */})
```

### FileSearchToolDefinition

```go
livekitTokenRequestTool := components.CreateLivekitTokenRequestToolFileSearchToolDefinition(components.FileSearchToolDefinition{/* values here */})
```

### ComputerUseToolDefinition

```go
livekitTokenRequestTool := components.CreateLivekitTokenRequestToolComputerUseToolDefinition(components.ComputerUseToolDefinition{/* values here */})
```

### WebSearchToolDefinition

```go
livekitTokenRequestTool := components.CreateLivekitTokenRequestToolWebSearchToolDefinition(components.WebSearchToolDefinition{/* values here */})
```

### MCPToolDefinition

```go
livekitTokenRequestTool := components.CreateLivekitTokenRequestToolMCPToolDefinition(components.MCPToolDefinition{/* values here */})
```

### CodeInterpreterToolRequest

```go
livekitTokenRequestTool := components.CreateLivekitTokenRequestToolCodeInterpreterToolRequest(components.CodeInterpreterToolRequest{/* values here */})
```

### ImageGenerationToolDefinition

```go
livekitTokenRequestTool := components.CreateLivekitTokenRequestToolImageGenerationToolDefinition(components.ImageGenerationToolDefinition{/* values here */})
```

### LocalShellToolDefinition

```go
livekitTokenRequestTool := components.CreateLivekitTokenRequestToolLocalShellToolDefinition(components.LocalShellToolDefinition{/* values here */})
```

### ShellToolRequest

```go
livekitTokenRequestTool := components.CreateLivekitTokenRequestToolShellToolRequest(components.ShellToolRequest{/* values here */})
```

### CustomToolDefinition

```go
livekitTokenRequestTool := components.CreateLivekitTokenRequestToolCustomToolDefinition(components.CustomToolDefinition{/* values here */})
```

### WebSearchPreviewToolDefinition

```go
livekitTokenRequestTool := components.CreateLivekitTokenRequestToolWebSearchPreviewToolDefinition(components.WebSearchPreviewToolDefinition{/* values here */})
```

### HostedToolShorthandDefinition

```go
livekitTokenRequestTool := components.CreateLivekitTokenRequestToolHostedToolShorthandDefinition(components.HostedToolShorthandDefinition{/* values here */})
```

### SleepToolDefinition

```go
livekitTokenRequestTool := components.CreateLivekitTokenRequestToolSleepToolDefinition(components.SleepToolDefinition{/* values here */})
```

### HistoryToolDefinition

```go
livekitTokenRequestTool := components.CreateLivekitTokenRequestToolHistoryToolDefinition(components.HistoryToolDefinition{/* values here */})
```

### AgentToolDefinition

```go
livekitTokenRequestTool := components.CreateLivekitTokenRequestToolAgentToolDefinition(components.AgentToolDefinition{/* values here */})
```

### OpenAPIToolDefinition

```go
livekitTokenRequestTool := components.CreateLivekitTokenRequestToolOpenAPIToolDefinition(components.OpenAPIToolDefinition{/* values here */})
```

## Union Discrimination

Use the `Type` field to determine which variant is active, then access the corresponding field:

```go
switch livekitTokenRequestTool.Type {
	case components.LivekitTokenRequestToolTypeFunctionToolDefinition:
		// livekitTokenRequestTool.FunctionToolDefinition is populated
	case components.LivekitTokenRequestToolTypeFileSearchToolDefinition:
		// livekitTokenRequestTool.FileSearchToolDefinition is populated
	case components.LivekitTokenRequestToolTypeComputerUseToolDefinition:
		// livekitTokenRequestTool.ComputerUseToolDefinition is populated
	case components.LivekitTokenRequestToolTypeWebSearchToolDefinition:
		// livekitTokenRequestTool.WebSearchToolDefinition is populated
	case components.LivekitTokenRequestToolTypeMCPToolDefinition:
		// livekitTokenRequestTool.MCPToolDefinition is populated
	case components.LivekitTokenRequestToolTypeCodeInterpreterToolRequest:
		// livekitTokenRequestTool.CodeInterpreterToolRequest is populated
	case components.LivekitTokenRequestToolTypeImageGenerationToolDefinition:
		// livekitTokenRequestTool.ImageGenerationToolDefinition is populated
	case components.LivekitTokenRequestToolTypeLocalShellToolDefinition:
		// livekitTokenRequestTool.LocalShellToolDefinition is populated
	case components.LivekitTokenRequestToolTypeShellToolRequest:
		// livekitTokenRequestTool.ShellToolRequest is populated
	case components.LivekitTokenRequestToolTypeCustomToolDefinition:
		// livekitTokenRequestTool.CustomToolDefinition is populated
	case components.LivekitTokenRequestToolTypeWebSearchPreviewToolDefinition:
		// livekitTokenRequestTool.WebSearchPreviewToolDefinition is populated
	case components.LivekitTokenRequestToolTypeHostedToolShorthandDefinition:
		// livekitTokenRequestTool.HostedToolShorthandDefinition is populated
	case components.LivekitTokenRequestToolTypeSleepToolDefinition:
		// livekitTokenRequestTool.SleepToolDefinition is populated
	case components.LivekitTokenRequestToolTypeHistoryToolDefinition:
		// livekitTokenRequestTool.HistoryToolDefinition is populated
	case components.LivekitTokenRequestToolTypeAgentToolDefinition:
		// livekitTokenRequestTool.AgentToolDefinition is populated
	case components.LivekitTokenRequestToolTypeOpenAPIToolDefinition:
		// livekitTokenRequestTool.OpenAPIToolDefinition is populated
}
```
