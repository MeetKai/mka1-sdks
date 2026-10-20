# Item


## Supported Types

### InputMessage

```go
item := components.CreateItemInputMessage(components.InputMessage{/* values here */})
```

### OutputMessage

```go
item := components.CreateItemOutputMessage(components.OutputMessage{/* values here */})
```

### OutputAudioItem

```go
item := components.CreateItemOutputAudioItem(components.OutputAudioItem{/* values here */})
```

### FileSearchToolCall

```go
item := components.CreateItemFileSearchToolCall(components.FileSearchToolCall{/* values here */})
```

### ComputerToolCall

```go
item := components.CreateItemComputerToolCall(components.ComputerToolCall{/* values here */})
```

### ComputerToolCallOutput

```go
item := components.CreateItemComputerToolCallOutput(components.ComputerToolCallOutput{/* values here */})
```

### WebSearchToolCall

```go
item := components.CreateItemWebSearchToolCall(components.WebSearchToolCall{/* values here */})
```

### FunctionToolCall

```go
item := components.CreateItemFunctionToolCall(components.FunctionToolCall{/* values here */})
```

### FunctionToolCallOutput

```go
item := components.CreateItemFunctionToolCallOutput(components.FunctionToolCallOutput{/* values here */})
```

### Reasoning

```go
item := components.CreateItemReasoning(components.Reasoning{/* values here */})
```

### ImageGenerationCall

```go
item := components.CreateItemImageGenerationCall(components.ImageGenerationCall{/* values here */})
```

### CodeInterpreterToolCall

```go
item := components.CreateItemCodeInterpreterToolCall(components.CodeInterpreterToolCall{/* values here */})
```

### LocalShellCall

```go
item := components.CreateItemLocalShellCall(components.LocalShellCall{/* values here */})
```

### LocalShellCallOutput

```go
item := components.CreateItemLocalShellCallOutput(components.LocalShellCallOutput{/* values here */})
```

### ShellCall

```go
item := components.CreateItemShellCall(components.ShellCall{/* values here */})
```

### ShellCallOutput

```go
item := components.CreateItemShellCallOutput(components.ShellCallOutput{/* values here */})
```

### MCPListTools

```go
item := components.CreateItemMCPListTools(components.MCPListTools{/* values here */})
```

### MCPApprovalRequest

```go
item := components.CreateItemMCPApprovalRequest(components.MCPApprovalRequest{/* values here */})
```

### MCPApprovalResponse

```go
item := components.CreateItemMCPApprovalResponse(components.MCPApprovalResponse{/* values here */})
```

### MCPToolCall

```go
item := components.CreateItemMCPToolCall(components.MCPToolCall{/* values here */})
```

### CustomToolCall

```go
item := components.CreateItemCustomToolCall(components.CustomToolCall{/* values here */})
```

### CustomToolCallOutput

```go
item := components.CreateItemCustomToolCallOutput(components.CustomToolCallOutput{/* values here */})
```

### ItemReference

```go
item := components.CreateItemItemReference(components.ItemReference{/* values here */})
```

### ResponseCompactionItem

```go
item := components.CreateItemResponseCompactionItem(components.ResponseCompactionItem{/* values here */})
```

## Union Discrimination

Use the `Type` field to determine which variant is active, then access the corresponding field:

```go
switch item.Type {
	case components.ItemTypeInputMessage:
		// item.InputMessage is populated
	case components.ItemTypeOutputMessage:
		// item.OutputMessage is populated
	case components.ItemTypeOutputAudioItem:
		// item.OutputAudioItem is populated
	case components.ItemTypeFileSearchToolCall:
		// item.FileSearchToolCall is populated
	case components.ItemTypeComputerToolCall:
		// item.ComputerToolCall is populated
	case components.ItemTypeComputerToolCallOutput:
		// item.ComputerToolCallOutput is populated
	case components.ItemTypeWebSearchToolCall:
		// item.WebSearchToolCall is populated
	case components.ItemTypeFunctionToolCall:
		// item.FunctionToolCall is populated
	case components.ItemTypeFunctionToolCallOutput:
		// item.FunctionToolCallOutput is populated
	case components.ItemTypeReasoning:
		// item.Reasoning is populated
	case components.ItemTypeImageGenerationCall:
		// item.ImageGenerationCall is populated
	case components.ItemTypeCodeInterpreterToolCall:
		// item.CodeInterpreterToolCall is populated
	case components.ItemTypeLocalShellCall:
		// item.LocalShellCall is populated
	case components.ItemTypeLocalShellCallOutput:
		// item.LocalShellCallOutput is populated
	case components.ItemTypeShellCall:
		// item.ShellCall is populated
	case components.ItemTypeShellCallOutput:
		// item.ShellCallOutput is populated
	case components.ItemTypeMCPListTools:
		// item.MCPListTools is populated
	case components.ItemTypeMCPApprovalRequest:
		// item.MCPApprovalRequest is populated
	case components.ItemTypeMCPApprovalResponse:
		// item.MCPApprovalResponse is populated
	case components.ItemTypeMCPToolCall:
		// item.MCPToolCall is populated
	case components.ItemTypeCustomToolCall:
		// item.CustomToolCall is populated
	case components.ItemTypeCustomToolCallOutput:
		// item.CustomToolCallOutput is populated
	case components.ItemTypeItemReference:
		// item.ItemReference is populated
	case components.ItemTypeResponseCompactionItem:
		// item.ResponseCompactionItem is populated
	default:
		// Unknown type - use item.GetUnknownRaw() for raw JSON
}
```
