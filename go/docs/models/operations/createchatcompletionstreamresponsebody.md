# CreateChatCompletionStreamResponseBody

OK


## Supported Types

### CreateChatCompletionStreamResponseBody1

```go
createChatCompletionStreamResponseBody := operations.CreateCreateChatCompletionStreamResponseBodyMessage(operations.CreateChatCompletionStreamResponseBody1{/* values here */})
```

### CreateChatCompletionStreamResponseBody2

```go
createChatCompletionStreamResponseBody := operations.CreateCreateChatCompletionStreamResponseBodyDone(operations.CreateChatCompletionStreamResponseBody2{/* values here */})
```

### CreateChatCompletionStreamResponseBody3

```go
createChatCompletionStreamResponseBody := operations.CreateCreateChatCompletionStreamResponseBodyError(operations.CreateChatCompletionStreamResponseBody3{/* values here */})
```

## Union Discrimination

Use the `Type` field to determine which variant is active, then access the corresponding field:

```go
switch createChatCompletionStreamResponseBody.Type {
	case operations.CreateChatCompletionStreamResponseBodyTypeMessage:
		// createChatCompletionStreamResponseBody.CreateChatCompletionStreamResponseBody1 is populated
	case operations.CreateChatCompletionStreamResponseBodyTypeDone:
		// createChatCompletionStreamResponseBody.CreateChatCompletionStreamResponseBody2 is populated
	case operations.CreateChatCompletionStreamResponseBodyTypeError:
		// createChatCompletionStreamResponseBody.CreateChatCompletionStreamResponseBody3 is populated
	default:
		// Unknown type - use createChatCompletionStreamResponseBody.GetUnknownRaw() for raw JSON
}
```
