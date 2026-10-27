# ResponseObjectTool


## Supported Types

### FunctionToolDefinition

```go
responseObjectTool := components.CreateResponseObjectToolFunctionToolDefinition(components.FunctionToolDefinition{/* values here */})
```

### ResponseObjectFileSearchToolDefinition

```go
responseObjectTool := components.CreateResponseObjectToolResponseObjectFileSearchToolDefinition(components.ResponseObjectFileSearchToolDefinition{/* values here */})
```

### ComputerUseToolDefinition

```go
responseObjectTool := components.CreateResponseObjectToolComputerUseToolDefinition(components.ComputerUseToolDefinition{/* values here */})
```

### WebSearchToolDefinition

```go
responseObjectTool := components.CreateResponseObjectToolWebSearchToolDefinition(components.WebSearchToolDefinition{/* values here */})
```

### 

```go
responseObjectTool := components.CreateResponseObjectToolAny(any{/* values here */})
```

### CodeInterpreterToolDefinition

```go
responseObjectTool := components.CreateResponseObjectToolCodeInterpreterToolDefinition(components.CodeInterpreterToolDefinition{/* values here */})
```

### ImageGenerationToolDefinition

```go
responseObjectTool := components.CreateResponseObjectToolImageGenerationToolDefinition(components.ImageGenerationToolDefinition{/* values here */})
```

### LocalShellToolDefinition

```go
responseObjectTool := components.CreateResponseObjectToolLocalShellToolDefinition(components.LocalShellToolDefinition{/* values here */})
```

### ShellToolDefinition

```go
responseObjectTool := components.CreateResponseObjectToolShellToolDefinition(components.ShellToolDefinition{/* values here */})
```

### CustomToolDefinition

```go
responseObjectTool := components.CreateResponseObjectToolCustomToolDefinition(components.CustomToolDefinition{/* values here */})
```

### WebSearchPreviewToolDefinition

```go
responseObjectTool := components.CreateResponseObjectToolWebSearchPreviewToolDefinition(components.WebSearchPreviewToolDefinition{/* values here */})
```

### HostedToolDefinition

```go
responseObjectTool := components.CreateResponseObjectToolHostedToolDefinition(components.HostedToolDefinition{/* values here */})
```

### SleepToolDefinition

```go
responseObjectTool := components.CreateResponseObjectToolSleepToolDefinition(components.SleepToolDefinition{/* values here */})
```

### HistoryToolDefinition

```go
responseObjectTool := components.CreateResponseObjectToolHistoryToolDefinition(components.HistoryToolDefinition{/* values here */})
```

### AgentToolDefinition

```go
responseObjectTool := components.CreateResponseObjectToolAgentToolDefinition(components.AgentToolDefinition{/* values here */})
```

## Union Discrimination

Use the `Type` field to determine which variant is active, then access the corresponding field:

```go
switch responseObjectTool.Type {
	case components.ResponseObjectToolTypeFunctionToolDefinition:
		// responseObjectTool.FunctionToolDefinition is populated
	case components.ResponseObjectToolTypeResponseObjectFileSearchToolDefinition:
		// responseObjectTool.ResponseObjectFileSearchToolDefinition is populated
	case components.ResponseObjectToolTypeComputerUseToolDefinition:
		// responseObjectTool.ComputerUseToolDefinition is populated
	case components.ResponseObjectToolTypeWebSearchToolDefinition:
		// responseObjectTool.WebSearchToolDefinition is populated
	case components.ResponseObjectToolTypeAny:
		// responseObjectTool.Any is populated
	case components.ResponseObjectToolTypeCodeInterpreterToolDefinition:
		// responseObjectTool.CodeInterpreterToolDefinition is populated
	case components.ResponseObjectToolTypeImageGenerationToolDefinition:
		// responseObjectTool.ImageGenerationToolDefinition is populated
	case components.ResponseObjectToolTypeLocalShellToolDefinition:
		// responseObjectTool.LocalShellToolDefinition is populated
	case components.ResponseObjectToolTypeShellToolDefinition:
		// responseObjectTool.ShellToolDefinition is populated
	case components.ResponseObjectToolTypeCustomToolDefinition:
		// responseObjectTool.CustomToolDefinition is populated
	case components.ResponseObjectToolTypeWebSearchPreviewToolDefinition:
		// responseObjectTool.WebSearchPreviewToolDefinition is populated
	case components.ResponseObjectToolTypeHostedToolDefinition:
		// responseObjectTool.HostedToolDefinition is populated
	case components.ResponseObjectToolTypeSleepToolDefinition:
		// responseObjectTool.SleepToolDefinition is populated
	case components.ResponseObjectToolTypeHistoryToolDefinition:
		// responseObjectTool.HistoryToolDefinition is populated
	case components.ResponseObjectToolTypeAgentToolDefinition:
		// responseObjectTool.AgentToolDefinition is populated
	default:
		// Unknown type - use responseObjectTool.GetUnknownRaw() for raw JSON
}
```
