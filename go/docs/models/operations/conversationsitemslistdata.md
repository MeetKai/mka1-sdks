# ConversationsItemsListData


## Supported Types

### ConversationsItemsListInputMessageItem

```go
conversationsItemsListData := operations.CreateConversationsItemsListDataConversationsItemsListInputMessageItem(operations.ConversationsItemsListInputMessageItem{/* values here */})
```

### OutputMessageWithID

```go
conversationsItemsListData := operations.CreateConversationsItemsListDataOutputMessageWithID(components.OutputMessageWithID{/* values here */})
```

### OutputAudioItemWithID

```go
conversationsItemsListData := operations.CreateConversationsItemsListDataOutputAudioItemWithID(components.OutputAudioItemWithID{/* values here */})
```

### FileSearchToolCallWithID

```go
conversationsItemsListData := operations.CreateConversationsItemsListDataFileSearchToolCallWithID(components.FileSearchToolCallWithID{/* values here */})
```

### ComputerToolCallWithID

```go
conversationsItemsListData := operations.CreateConversationsItemsListDataComputerToolCallWithID(components.ComputerToolCallWithID{/* values here */})
```

### ComputerToolCallOutputWithID

```go
conversationsItemsListData := operations.CreateConversationsItemsListDataComputerToolCallOutputWithID(components.ComputerToolCallOutputWithID{/* values here */})
```

### WebSearchToolCallWithID

```go
conversationsItemsListData := operations.CreateConversationsItemsListDataWebSearchToolCallWithID(components.WebSearchToolCallWithID{/* values here */})
```

### FunctionToolCallWithID

```go
conversationsItemsListData := operations.CreateConversationsItemsListDataFunctionToolCallWithID(components.FunctionToolCallWithID{/* values here */})
```

### FunctionToolCallOutputWithID

```go
conversationsItemsListData := operations.CreateConversationsItemsListDataFunctionToolCallOutputWithID(components.FunctionToolCallOutputWithID{/* values here */})
```

### ReasoningWithID

```go
conversationsItemsListData := operations.CreateConversationsItemsListDataReasoningWithID(components.ReasoningWithID{/* values here */})
```

### ImageGenerationCallWithID

```go
conversationsItemsListData := operations.CreateConversationsItemsListDataImageGenerationCallWithID(components.ImageGenerationCallWithID{/* values here */})
```

### CodeInterpreterToolCallWithID

```go
conversationsItemsListData := operations.CreateConversationsItemsListDataCodeInterpreterToolCallWithID(components.CodeInterpreterToolCallWithID{/* values here */})
```

### LocalShellCallWithID

```go
conversationsItemsListData := operations.CreateConversationsItemsListDataLocalShellCallWithID(components.LocalShellCallWithID{/* values here */})
```

### LocalShellCallOutputWithID

```go
conversationsItemsListData := operations.CreateConversationsItemsListDataLocalShellCallOutputWithID(components.LocalShellCallOutputWithID{/* values here */})
```

### ShellCallWithID

```go
conversationsItemsListData := operations.CreateConversationsItemsListDataShellCallWithID(components.ShellCallWithID{/* values here */})
```

### ShellCallOutputWithID

```go
conversationsItemsListData := operations.CreateConversationsItemsListDataShellCallOutputWithID(components.ShellCallOutputWithID{/* values here */})
```

### MCPListToolsWithID

```go
conversationsItemsListData := operations.CreateConversationsItemsListDataMCPListToolsWithID(components.MCPListToolsWithID{/* values here */})
```

### MCPApprovalRequestWithID

```go
conversationsItemsListData := operations.CreateConversationsItemsListDataMCPApprovalRequestWithID(components.MCPApprovalRequestWithID{/* values here */})
```

### MCPApprovalResponseWithID

```go
conversationsItemsListData := operations.CreateConversationsItemsListDataMCPApprovalResponseWithID(components.MCPApprovalResponseWithID{/* values here */})
```

### MCPToolCallWithID

```go
conversationsItemsListData := operations.CreateConversationsItemsListDataMCPToolCallWithID(components.MCPToolCallWithID{/* values here */})
```

### CustomToolCallWithID

```go
conversationsItemsListData := operations.CreateConversationsItemsListDataCustomToolCallWithID(components.CustomToolCallWithID{/* values here */})
```

### CustomToolCallOutputWithID

```go
conversationsItemsListData := operations.CreateConversationsItemsListDataCustomToolCallOutputWithID(components.CustomToolCallOutputWithID{/* values here */})
```

### ItemReferenceWithID

```go
conversationsItemsListData := operations.CreateConversationsItemsListDataItemReferenceWithID(components.ItemReferenceWithID{/* values here */})
```

### ResponseCompactionItemWithID

```go
conversationsItemsListData := operations.CreateConversationsItemsListDataResponseCompactionItemWithID(components.ResponseCompactionItemWithID{/* values here */})
```

## Union Discrimination

Use the `Type` field to determine which variant is active, then access the corresponding field:

```go
switch conversationsItemsListData.Type {
	case operations.ConversationsItemsListDataTypeConversationsItemsListInputMessageItem:
		// conversationsItemsListData.ConversationsItemsListInputMessageItem is populated
	case operations.ConversationsItemsListDataTypeOutputMessageWithID:
		// conversationsItemsListData.OutputMessageWithID is populated
	case operations.ConversationsItemsListDataTypeOutputAudioItemWithID:
		// conversationsItemsListData.OutputAudioItemWithID is populated
	case operations.ConversationsItemsListDataTypeFileSearchToolCallWithID:
		// conversationsItemsListData.FileSearchToolCallWithID is populated
	case operations.ConversationsItemsListDataTypeComputerToolCallWithID:
		// conversationsItemsListData.ComputerToolCallWithID is populated
	case operations.ConversationsItemsListDataTypeComputerToolCallOutputWithID:
		// conversationsItemsListData.ComputerToolCallOutputWithID is populated
	case operations.ConversationsItemsListDataTypeWebSearchToolCallWithID:
		// conversationsItemsListData.WebSearchToolCallWithID is populated
	case operations.ConversationsItemsListDataTypeFunctionToolCallWithID:
		// conversationsItemsListData.FunctionToolCallWithID is populated
	case operations.ConversationsItemsListDataTypeFunctionToolCallOutputWithID:
		// conversationsItemsListData.FunctionToolCallOutputWithID is populated
	case operations.ConversationsItemsListDataTypeReasoningWithID:
		// conversationsItemsListData.ReasoningWithID is populated
	case operations.ConversationsItemsListDataTypeImageGenerationCallWithID:
		// conversationsItemsListData.ImageGenerationCallWithID is populated
	case operations.ConversationsItemsListDataTypeCodeInterpreterToolCallWithID:
		// conversationsItemsListData.CodeInterpreterToolCallWithID is populated
	case operations.ConversationsItemsListDataTypeLocalShellCallWithID:
		// conversationsItemsListData.LocalShellCallWithID is populated
	case operations.ConversationsItemsListDataTypeLocalShellCallOutputWithID:
		// conversationsItemsListData.LocalShellCallOutputWithID is populated
	case operations.ConversationsItemsListDataTypeShellCallWithID:
		// conversationsItemsListData.ShellCallWithID is populated
	case operations.ConversationsItemsListDataTypeShellCallOutputWithID:
		// conversationsItemsListData.ShellCallOutputWithID is populated
	case operations.ConversationsItemsListDataTypeMCPListToolsWithID:
		// conversationsItemsListData.MCPListToolsWithID is populated
	case operations.ConversationsItemsListDataTypeMCPApprovalRequestWithID:
		// conversationsItemsListData.MCPApprovalRequestWithID is populated
	case operations.ConversationsItemsListDataTypeMCPApprovalResponseWithID:
		// conversationsItemsListData.MCPApprovalResponseWithID is populated
	case operations.ConversationsItemsListDataTypeMCPToolCallWithID:
		// conversationsItemsListData.MCPToolCallWithID is populated
	case operations.ConversationsItemsListDataTypeCustomToolCallWithID:
		// conversationsItemsListData.CustomToolCallWithID is populated
	case operations.ConversationsItemsListDataTypeCustomToolCallOutputWithID:
		// conversationsItemsListData.CustomToolCallOutputWithID is populated
	case operations.ConversationsItemsListDataTypeItemReferenceWithID:
		// conversationsItemsListData.ItemReferenceWithID is populated
	case operations.ConversationsItemsListDataTypeResponseCompactionItemWithID:
		// conversationsItemsListData.ResponseCompactionItemWithID is populated
	default:
		// Unknown type - use conversationsItemsListData.GetUnknownRaw() for raw JSON
}
```
