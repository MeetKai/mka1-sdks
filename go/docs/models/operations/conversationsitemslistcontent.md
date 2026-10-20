# ConversationsItemsListContent

The message content. Can be a simple text string or an array of multimodal content items (text, images, files, audio).


## Supported Types

### 

```go
conversationsItemsListContent := operations.CreateConversationsItemsListContentStr(string{/* values here */})
```

### 

```go
conversationsItemsListContent := operations.CreateConversationsItemsListContentArrayOfInputMessageContent([]components.InputMessageContent{/* values here */})
```

## Union Discrimination

Use the `Type` field to determine which variant is active, then access the corresponding field:

```go
switch conversationsItemsListContent.Type {
	case operations.ConversationsItemsListContentTypeStr:
		// conversationsItemsListContent.Str is populated
	case operations.ConversationsItemsListContentTypeArrayOfInputMessageContent:
		// conversationsItemsListContent.ArrayOfInputMessageContent is populated
	default:
		// Unknown type - use conversationsItemsListContent.GetUnknownRaw() for raw JSON
}
```
