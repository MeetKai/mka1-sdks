# LivekitTokenRequestConversation


## Supported Types

### 

```go
livekitTokenRequestConversation := components.CreateLivekitTokenRequestConversationStr(string{/* values here */})
```

### Conversation

```go
livekitTokenRequestConversation := components.CreateLivekitTokenRequestConversationConversation(components.Conversation{/* values here */})
```

## Union Discrimination

Use the `Type` field to determine which variant is active, then access the corresponding field:

```go
switch livekitTokenRequestConversation.Type {
	case components.LivekitTokenRequestConversationTypeStr:
		// livekitTokenRequestConversation.Str is populated
	case components.LivekitTokenRequestConversationTypeConversation:
		// livekitTokenRequestConversation.Conversation is populated
}
```
