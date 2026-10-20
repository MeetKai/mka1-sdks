# ConversationsItemsRetrieveResponseBody

OK


## Supported Types

### ConversationsItemsRetrieveInputMessageItem

```go
conversationsItemsRetrieveResponseBody := operations.CreateConversationsItemsRetrieveResponseBodyConversationsItemsRetrieveInputMessageItem(operations.ConversationsItemsRetrieveInputMessageItem{/* values here */})
```

### OutputMessageWithID

```go
conversationsItemsRetrieveResponseBody := operations.CreateConversationsItemsRetrieveResponseBodyOutputMessageWithID(components.OutputMessageWithID{/* values here */})
```

### OutputAudioItemWithID

```go
conversationsItemsRetrieveResponseBody := operations.CreateConversationsItemsRetrieveResponseBodyOutputAudioItemWithID(components.OutputAudioItemWithID{/* values here */})
```

### FileSearchToolCallWithID

```go
conversationsItemsRetrieveResponseBody := operations.CreateConversationsItemsRetrieveResponseBodyFileSearchToolCallWithID(components.FileSearchToolCallWithID{/* values here */})
```

### ComputerToolCallWithID

```go
conversationsItemsRetrieveResponseBody := operations.CreateConversationsItemsRetrieveResponseBodyComputerToolCallWithID(components.ComputerToolCallWithID{/* values here */})
```

### ComputerToolCallOutputWithID

```go
conversationsItemsRetrieveResponseBody := operations.CreateConversationsItemsRetrieveResponseBodyComputerToolCallOutputWithID(components.ComputerToolCallOutputWithID{/* values here */})
```

### WebSearchToolCallWithID

```go
conversationsItemsRetrieveResponseBody := operations.CreateConversationsItemsRetrieveResponseBodyWebSearchToolCallWithID(components.WebSearchToolCallWithID{/* values here */})
```

### FunctionToolCallWithID

```go
conversationsItemsRetrieveResponseBody := operations.CreateConversationsItemsRetrieveResponseBodyFunctionToolCallWithID(components.FunctionToolCallWithID{/* values here */})
```

### FunctionToolCallOutputWithID

```go
conversationsItemsRetrieveResponseBody := operations.CreateConversationsItemsRetrieveResponseBodyFunctionToolCallOutputWithID(components.FunctionToolCallOutputWithID{/* values here */})
```

### ReasoningWithID

```go
conversationsItemsRetrieveResponseBody := operations.CreateConversationsItemsRetrieveResponseBodyReasoningWithID(components.ReasoningWithID{/* values here */})
```

### ImageGenerationCallWithID

```go
conversationsItemsRetrieveResponseBody := operations.CreateConversationsItemsRetrieveResponseBodyImageGenerationCallWithID(components.ImageGenerationCallWithID{/* values here */})
```

### CodeInterpreterToolCallWithID

```go
conversationsItemsRetrieveResponseBody := operations.CreateConversationsItemsRetrieveResponseBodyCodeInterpreterToolCallWithID(components.CodeInterpreterToolCallWithID{/* values here */})
```

### LocalShellCallWithID

```go
conversationsItemsRetrieveResponseBody := operations.CreateConversationsItemsRetrieveResponseBodyLocalShellCallWithID(components.LocalShellCallWithID{/* values here */})
```

### LocalShellCallOutputWithID

```go
conversationsItemsRetrieveResponseBody := operations.CreateConversationsItemsRetrieveResponseBodyLocalShellCallOutputWithID(components.LocalShellCallOutputWithID{/* values here */})
```

### ShellCallWithID

```go
conversationsItemsRetrieveResponseBody := operations.CreateConversationsItemsRetrieveResponseBodyShellCallWithID(components.ShellCallWithID{/* values here */})
```

### ShellCallOutputWithID

```go
conversationsItemsRetrieveResponseBody := operations.CreateConversationsItemsRetrieveResponseBodyShellCallOutputWithID(components.ShellCallOutputWithID{/* values here */})
```

### MCPListToolsWithID

```go
conversationsItemsRetrieveResponseBody := operations.CreateConversationsItemsRetrieveResponseBodyMCPListToolsWithID(components.MCPListToolsWithID{/* values here */})
```

### MCPApprovalRequestWithID

```go
conversationsItemsRetrieveResponseBody := operations.CreateConversationsItemsRetrieveResponseBodyMCPApprovalRequestWithID(components.MCPApprovalRequestWithID{/* values here */})
```

### MCPApprovalResponseWithID

```go
conversationsItemsRetrieveResponseBody := operations.CreateConversationsItemsRetrieveResponseBodyMCPApprovalResponseWithID(components.MCPApprovalResponseWithID{/* values here */})
```

### MCPToolCallWithID

```go
conversationsItemsRetrieveResponseBody := operations.CreateConversationsItemsRetrieveResponseBodyMCPToolCallWithID(components.MCPToolCallWithID{/* values here */})
```

### CustomToolCallWithID

```go
conversationsItemsRetrieveResponseBody := operations.CreateConversationsItemsRetrieveResponseBodyCustomToolCallWithID(components.CustomToolCallWithID{/* values here */})
```

### CustomToolCallOutputWithID

```go
conversationsItemsRetrieveResponseBody := operations.CreateConversationsItemsRetrieveResponseBodyCustomToolCallOutputWithID(components.CustomToolCallOutputWithID{/* values here */})
```

### ItemReferenceWithID

```go
conversationsItemsRetrieveResponseBody := operations.CreateConversationsItemsRetrieveResponseBodyItemReferenceWithID(components.ItemReferenceWithID{/* values here */})
```

### ResponseCompactionItemWithID

```go
conversationsItemsRetrieveResponseBody := operations.CreateConversationsItemsRetrieveResponseBodyResponseCompactionItemWithID(components.ResponseCompactionItemWithID{/* values here */})
```

## Union Discrimination

Use the `Type` field to determine which variant is active, then access the corresponding field:

```go
switch conversationsItemsRetrieveResponseBody.Type {
	case operations.ConversationsItemsRetrieveResponseBodyTypeConversationsItemsRetrieveInputMessageItem:
		// conversationsItemsRetrieveResponseBody.ConversationsItemsRetrieveInputMessageItem is populated
	case operations.ConversationsItemsRetrieveResponseBodyTypeOutputMessageWithID:
		// conversationsItemsRetrieveResponseBody.OutputMessageWithID is populated
	case operations.ConversationsItemsRetrieveResponseBodyTypeOutputAudioItemWithID:
		// conversationsItemsRetrieveResponseBody.OutputAudioItemWithID is populated
	case operations.ConversationsItemsRetrieveResponseBodyTypeFileSearchToolCallWithID:
		// conversationsItemsRetrieveResponseBody.FileSearchToolCallWithID is populated
	case operations.ConversationsItemsRetrieveResponseBodyTypeComputerToolCallWithID:
		// conversationsItemsRetrieveResponseBody.ComputerToolCallWithID is populated
	case operations.ConversationsItemsRetrieveResponseBodyTypeComputerToolCallOutputWithID:
		// conversationsItemsRetrieveResponseBody.ComputerToolCallOutputWithID is populated
	case operations.ConversationsItemsRetrieveResponseBodyTypeWebSearchToolCallWithID:
		// conversationsItemsRetrieveResponseBody.WebSearchToolCallWithID is populated
	case operations.ConversationsItemsRetrieveResponseBodyTypeFunctionToolCallWithID:
		// conversationsItemsRetrieveResponseBody.FunctionToolCallWithID is populated
	case operations.ConversationsItemsRetrieveResponseBodyTypeFunctionToolCallOutputWithID:
		// conversationsItemsRetrieveResponseBody.FunctionToolCallOutputWithID is populated
	case operations.ConversationsItemsRetrieveResponseBodyTypeReasoningWithID:
		// conversationsItemsRetrieveResponseBody.ReasoningWithID is populated
	case operations.ConversationsItemsRetrieveResponseBodyTypeImageGenerationCallWithID:
		// conversationsItemsRetrieveResponseBody.ImageGenerationCallWithID is populated
	case operations.ConversationsItemsRetrieveResponseBodyTypeCodeInterpreterToolCallWithID:
		// conversationsItemsRetrieveResponseBody.CodeInterpreterToolCallWithID is populated
	case operations.ConversationsItemsRetrieveResponseBodyTypeLocalShellCallWithID:
		// conversationsItemsRetrieveResponseBody.LocalShellCallWithID is populated
	case operations.ConversationsItemsRetrieveResponseBodyTypeLocalShellCallOutputWithID:
		// conversationsItemsRetrieveResponseBody.LocalShellCallOutputWithID is populated
	case operations.ConversationsItemsRetrieveResponseBodyTypeShellCallWithID:
		// conversationsItemsRetrieveResponseBody.ShellCallWithID is populated
	case operations.ConversationsItemsRetrieveResponseBodyTypeShellCallOutputWithID:
		// conversationsItemsRetrieveResponseBody.ShellCallOutputWithID is populated
	case operations.ConversationsItemsRetrieveResponseBodyTypeMCPListToolsWithID:
		// conversationsItemsRetrieveResponseBody.MCPListToolsWithID is populated
	case operations.ConversationsItemsRetrieveResponseBodyTypeMCPApprovalRequestWithID:
		// conversationsItemsRetrieveResponseBody.MCPApprovalRequestWithID is populated
	case operations.ConversationsItemsRetrieveResponseBodyTypeMCPApprovalResponseWithID:
		// conversationsItemsRetrieveResponseBody.MCPApprovalResponseWithID is populated
	case operations.ConversationsItemsRetrieveResponseBodyTypeMCPToolCallWithID:
		// conversationsItemsRetrieveResponseBody.MCPToolCallWithID is populated
	case operations.ConversationsItemsRetrieveResponseBodyTypeCustomToolCallWithID:
		// conversationsItemsRetrieveResponseBody.CustomToolCallWithID is populated
	case operations.ConversationsItemsRetrieveResponseBodyTypeCustomToolCallOutputWithID:
		// conversationsItemsRetrieveResponseBody.CustomToolCallOutputWithID is populated
	case operations.ConversationsItemsRetrieveResponseBodyTypeItemReferenceWithID:
		// conversationsItemsRetrieveResponseBody.ItemReferenceWithID is populated
	case operations.ConversationsItemsRetrieveResponseBodyTypeResponseCompactionItemWithID:
		// conversationsItemsRetrieveResponseBody.ResponseCompactionItemWithID is populated
	default:
		// Unknown type - use conversationsItemsRetrieveResponseBody.GetUnknownRaw() for raw JSON
}
```
