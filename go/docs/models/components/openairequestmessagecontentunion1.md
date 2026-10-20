# OpenAIRequestMessageContentUnion1

A content part that can be included in a message. Supports text, images, audio, and files.


## Supported Types

### OpenAIRequestMessageContent1

```go
openAIRequestMessageContentUnion1 := components.CreateOpenAIRequestMessageContentUnion1Text(components.OpenAIRequestMessageContent1{/* values here */})
```

### OpenAIRequestMessageContent2

```go
openAIRequestMessageContentUnion1 := components.CreateOpenAIRequestMessageContentUnion1ImageURL(components.OpenAIRequestMessageContent2{/* values here */})
```

### OpenAIRequestMessageContent3

```go
openAIRequestMessageContentUnion1 := components.CreateOpenAIRequestMessageContentUnion1InputAudio(components.OpenAIRequestMessageContent3{/* values here */})
```

### OpenAIRequestMessageContent4

```go
openAIRequestMessageContentUnion1 := components.CreateOpenAIRequestMessageContentUnion1File(components.OpenAIRequestMessageContent4{/* values here */})
```

## Union Discrimination

Use the `Type` field to determine which variant is active, then access the corresponding field:

```go
switch openAIRequestMessageContentUnion1.Type {
	case components.OpenAIRequestMessageContentUnion1TypeText:
		// openAIRequestMessageContentUnion1.OpenAIRequestMessageContent1 is populated
	case components.OpenAIRequestMessageContentUnion1TypeImageURL:
		// openAIRequestMessageContentUnion1.OpenAIRequestMessageContent2 is populated
	case components.OpenAIRequestMessageContentUnion1TypeInputAudio:
		// openAIRequestMessageContentUnion1.OpenAIRequestMessageContent3 is populated
	case components.OpenAIRequestMessageContentUnion1TypeFile:
		// openAIRequestMessageContentUnion1.OpenAIRequestMessageContent4 is populated
}
```
