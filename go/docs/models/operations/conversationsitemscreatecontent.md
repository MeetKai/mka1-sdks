# ConversationsItemsCreateContent

The message content. Can be a simple text string or an array of multimodal content items (text, images, files, audio).


## Supported Types

### 

```go
conversationsItemsCreateContent := operations.CreateConversationsItemsCreateContentStr(string{/* values here */})
```

### 

```go
conversationsItemsCreateContent := operations.CreateConversationsItemsCreateContentArrayOfInputMessageContent([]components.InputMessageContent{/* values here */})
```

## Union Discrimination

Use the `Type` field to determine which variant is active, then access the corresponding field:

```go
switch conversationsItemsCreateContent.Type {
	case operations.ConversationsItemsCreateContentTypeStr:
		// conversationsItemsCreateContent.Str is populated
	case operations.ConversationsItemsCreateContentTypeArrayOfInputMessageContent:
		// conversationsItemsCreateContent.ArrayOfInputMessageContent is populated
	default:
		// Unknown type - use conversationsItemsCreateContent.GetUnknownRaw() for raw JSON
}
```
