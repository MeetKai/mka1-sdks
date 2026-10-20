# ConversationsItemsCreateData


## Supported Types

### ConversationsItemsCreateInputMessageItem

```go
conversationsItemsCreateData := operations.CreateConversationsItemsCreateDataConversationsItemsCreateInputMessageItem(operations.ConversationsItemsCreateInputMessageItem{/* values here */})
```

### OutputMessageWithID

```go
conversationsItemsCreateData := operations.CreateConversationsItemsCreateDataOutputMessageWithID(components.OutputMessageWithID{/* values here */})
```

### OutputAudioItemWithID

```go
conversationsItemsCreateData := operations.CreateConversationsItemsCreateDataOutputAudioItemWithID(components.OutputAudioItemWithID{/* values here */})
```

### FileSearchToolCallWithID

```go
conversationsItemsCreateData := operations.CreateConversationsItemsCreateDataFileSearchToolCallWithID(components.FileSearchToolCallWithID{/* values here */})
```

### ComputerToolCallWithID

```go
conversationsItemsCreateData := operations.CreateConversationsItemsCreateDataComputerToolCallWithID(components.ComputerToolCallWithID{/* values here */})
```

### ComputerToolCallOutputWithID

```go
conversationsItemsCreateData := operations.CreateConversationsItemsCreateDataComputerToolCallOutputWithID(components.ComputerToolCallOutputWithID{/* values here */})
```

### WebSearchToolCallWithID

```go
conversationsItemsCreateData := operations.CreateConversationsItemsCreateDataWebSearchToolCallWithID(components.WebSearchToolCallWithID{/* values here */})
```

### FunctionToolCallWithID

```go
conversationsItemsCreateData := operations.CreateConversationsItemsCreateDataFunctionToolCallWithID(components.FunctionToolCallWithID{/* values here */})
```

### FunctionToolCallOutputWithID

```go
conversationsItemsCreateData := operations.CreateConversationsItemsCreateDataFunctionToolCallOutputWithID(components.FunctionToolCallOutputWithID{/* values here */})
```

### ReasoningWithID

```go
conversationsItemsCreateData := operations.CreateConversationsItemsCreateDataReasoningWithID(components.ReasoningWithID{/* values here */})
```

### ImageGenerationCallWithID

```go
conversationsItemsCreateData := operations.CreateConversationsItemsCreateDataImageGenerationCallWithID(components.ImageGenerationCallWithID{/* values here */})
```

### CodeInterpreterToolCallWithID

```go
conversationsItemsCreateData := operations.CreateConversationsItemsCreateDataCodeInterpreterToolCallWithID(components.CodeInterpreterToolCallWithID{/* values here */})
```

### LocalShellCallWithID

```go
conversationsItemsCreateData := operations.CreateConversationsItemsCreateDataLocalShellCallWithID(components.LocalShellCallWithID{/* values here */})
```

### LocalShellCallOutputWithID

```go
conversationsItemsCreateData := operations.CreateConversationsItemsCreateDataLocalShellCallOutputWithID(components.LocalShellCallOutputWithID{/* values here */})
```

### ShellCallWithID

```go
conversationsItemsCreateData := operations.CreateConversationsItemsCreateDataShellCallWithID(components.ShellCallWithID{/* values here */})
```

### ShellCallOutputWithID

```go
conversationsItemsCreateData := operations.CreateConversationsItemsCreateDataShellCallOutputWithID(components.ShellCallOutputWithID{/* values here */})
```

### MCPListToolsWithID

```go
conversationsItemsCreateData := operations.CreateConversationsItemsCreateDataMCPListToolsWithID(components.MCPListToolsWithID{/* values here */})
```

### MCPApprovalRequestWithID

```go
conversationsItemsCreateData := operations.CreateConversationsItemsCreateDataMCPApprovalRequestWithID(components.MCPApprovalRequestWithID{/* values here */})
```

### MCPApprovalResponseWithID

```go
conversationsItemsCreateData := operations.CreateConversationsItemsCreateDataMCPApprovalResponseWithID(components.MCPApprovalResponseWithID{/* values here */})
```

### MCPToolCallWithID

```go
conversationsItemsCreateData := operations.CreateConversationsItemsCreateDataMCPToolCallWithID(components.MCPToolCallWithID{/* values here */})
```

### CustomToolCallWithID

```go
conversationsItemsCreateData := operations.CreateConversationsItemsCreateDataCustomToolCallWithID(components.CustomToolCallWithID{/* values here */})
```

### CustomToolCallOutputWithID

```go
conversationsItemsCreateData := operations.CreateConversationsItemsCreateDataCustomToolCallOutputWithID(components.CustomToolCallOutputWithID{/* values here */})
```

### ItemReferenceWithID

```go
conversationsItemsCreateData := operations.CreateConversationsItemsCreateDataItemReferenceWithID(components.ItemReferenceWithID{/* values here */})
```

### ResponseCompactionItemWithID

```go
conversationsItemsCreateData := operations.CreateConversationsItemsCreateDataResponseCompactionItemWithID(components.ResponseCompactionItemWithID{/* values here */})
```

## Union Discrimination

Use the `Type` field to determine which variant is active, then access the corresponding field:

```go
switch conversationsItemsCreateData.Type {
	case operations.ConversationsItemsCreateDataTypeConversationsItemsCreateInputMessageItem:
		// conversationsItemsCreateData.ConversationsItemsCreateInputMessageItem is populated
	case operations.ConversationsItemsCreateDataTypeOutputMessageWithID:
		// conversationsItemsCreateData.OutputMessageWithID is populated
	case operations.ConversationsItemsCreateDataTypeOutputAudioItemWithID:
		// conversationsItemsCreateData.OutputAudioItemWithID is populated
	case operations.ConversationsItemsCreateDataTypeFileSearchToolCallWithID:
		// conversationsItemsCreateData.FileSearchToolCallWithID is populated
	case operations.ConversationsItemsCreateDataTypeComputerToolCallWithID:
		// conversationsItemsCreateData.ComputerToolCallWithID is populated
	case operations.ConversationsItemsCreateDataTypeComputerToolCallOutputWithID:
		// conversationsItemsCreateData.ComputerToolCallOutputWithID is populated
	case operations.ConversationsItemsCreateDataTypeWebSearchToolCallWithID:
		// conversationsItemsCreateData.WebSearchToolCallWithID is populated
	case operations.ConversationsItemsCreateDataTypeFunctionToolCallWithID:
		// conversationsItemsCreateData.FunctionToolCallWithID is populated
	case operations.ConversationsItemsCreateDataTypeFunctionToolCallOutputWithID:
		// conversationsItemsCreateData.FunctionToolCallOutputWithID is populated
	case operations.ConversationsItemsCreateDataTypeReasoningWithID:
		// conversationsItemsCreateData.ReasoningWithID is populated
	case operations.ConversationsItemsCreateDataTypeImageGenerationCallWithID:
		// conversationsItemsCreateData.ImageGenerationCallWithID is populated
	case operations.ConversationsItemsCreateDataTypeCodeInterpreterToolCallWithID:
		// conversationsItemsCreateData.CodeInterpreterToolCallWithID is populated
	case operations.ConversationsItemsCreateDataTypeLocalShellCallWithID:
		// conversationsItemsCreateData.LocalShellCallWithID is populated
	case operations.ConversationsItemsCreateDataTypeLocalShellCallOutputWithID:
		// conversationsItemsCreateData.LocalShellCallOutputWithID is populated
	case operations.ConversationsItemsCreateDataTypeShellCallWithID:
		// conversationsItemsCreateData.ShellCallWithID is populated
	case operations.ConversationsItemsCreateDataTypeShellCallOutputWithID:
		// conversationsItemsCreateData.ShellCallOutputWithID is populated
	case operations.ConversationsItemsCreateDataTypeMCPListToolsWithID:
		// conversationsItemsCreateData.MCPListToolsWithID is populated
	case operations.ConversationsItemsCreateDataTypeMCPApprovalRequestWithID:
		// conversationsItemsCreateData.MCPApprovalRequestWithID is populated
	case operations.ConversationsItemsCreateDataTypeMCPApprovalResponseWithID:
		// conversationsItemsCreateData.MCPApprovalResponseWithID is populated
	case operations.ConversationsItemsCreateDataTypeMCPToolCallWithID:
		// conversationsItemsCreateData.MCPToolCallWithID is populated
	case operations.ConversationsItemsCreateDataTypeCustomToolCallWithID:
		// conversationsItemsCreateData.CustomToolCallWithID is populated
	case operations.ConversationsItemsCreateDataTypeCustomToolCallOutputWithID:
		// conversationsItemsCreateData.CustomToolCallOutputWithID is populated
	case operations.ConversationsItemsCreateDataTypeItemReferenceWithID:
		// conversationsItemsCreateData.ItemReferenceWithID is populated
	case operations.ConversationsItemsCreateDataTypeResponseCompactionItemWithID:
		// conversationsItemsCreateData.ResponseCompactionItemWithID is populated
	default:
		// Unknown type - use conversationsItemsCreateData.GetUnknownRaw() for raw JSON
}
```
