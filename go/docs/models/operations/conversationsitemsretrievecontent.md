# ConversationsItemsRetrieveContent

The message content. Can be a simple text string or an array of multimodal content items (text, images, files, audio).


## Supported Types

### 

```go
conversationsItemsRetrieveContent := operations.CreateConversationsItemsRetrieveContentStr(string{/* values here */})
```

### 

```go
conversationsItemsRetrieveContent := operations.CreateConversationsItemsRetrieveContentArrayOfInputMessageContent([]components.InputMessageContent{/* values here */})
```

## Union Discrimination

Use the `Type` field to determine which variant is active, then access the corresponding field:

```go
switch conversationsItemsRetrieveContent.Type {
	case operations.ConversationsItemsRetrieveContentTypeStr:
		// conversationsItemsRetrieveContent.Str is populated
	case operations.ConversationsItemsRetrieveContentTypeArrayOfInputMessageContent:
		// conversationsItemsRetrieveContent.ArrayOfInputMessageContent is populated
	default:
		// Unknown type - use conversationsItemsRetrieveContent.GetUnknownRaw() for raw JSON
}
```
