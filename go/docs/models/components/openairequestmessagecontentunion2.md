# OpenAIRequestMessageContentUnion2

The contents of the message. Can be a string, an array of content parts (for multimodal inputs), or null for assistant messages with tool calls.


## Supported Types

### 

```go
openAIRequestMessageContentUnion2 := components.CreateOpenAIRequestMessageContentUnion2Str(string{/* values here */})
```

### 

```go
openAIRequestMessageContentUnion2 := components.CreateOpenAIRequestMessageContentUnion2ArrayOfOpenAIRequestMessageContentUnion1([]components.OpenAIRequestMessageContentUnion1{/* values here */})
```

## Union Discrimination

Use the `Type` field to determine which variant is active, then access the corresponding field:

```go
switch openAIRequestMessageContentUnion2.Type {
	case components.OpenAIRequestMessageContentUnion2TypeStr:
		// openAIRequestMessageContentUnion2.Str is populated
	case components.OpenAIRequestMessageContentUnion2TypeArrayOfOpenAIRequestMessageContentUnion1:
		// openAIRequestMessageContentUnion2.ArrayOfOpenAIRequestMessageContentUnion1 is populated
}
```
