# ResponsesCreateRequestConversation


## Supported Types

### 

```go
responsesCreateRequestConversation := components.CreateResponsesCreateRequestConversationStr(string{/* values here */})
```

### Conversation

```go
responsesCreateRequestConversation := components.CreateResponsesCreateRequestConversationConversation(components.Conversation{/* values here */})
```

## Union Discrimination

Use the `Type` field to determine which variant is active, then access the corresponding field:

```go
switch responsesCreateRequestConversation.Type {
	case components.ResponsesCreateRequestConversationTypeStr:
		// responsesCreateRequestConversation.Str is populated
	case components.ResponsesCreateRequestConversationTypeConversation:
		// responsesCreateRequestConversation.Conversation is populated
}
```
