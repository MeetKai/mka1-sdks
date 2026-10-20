# OpenAIChatCompletionChunkContentUnion1

A content part that can be included in a message. Supports text, images, audio, and files.


## Supported Types

### OpenAIChatCompletionChunkContent1

```go
openAIChatCompletionChunkContentUnion1 := components.CreateOpenAIChatCompletionChunkContentUnion1Text(components.OpenAIChatCompletionChunkContent1{/* values here */})
```

### OpenAIChatCompletionChunkContent2

```go
openAIChatCompletionChunkContentUnion1 := components.CreateOpenAIChatCompletionChunkContentUnion1ImageURL(components.OpenAIChatCompletionChunkContent2{/* values here */})
```

### OpenAIChatCompletionChunkContent3

```go
openAIChatCompletionChunkContentUnion1 := components.CreateOpenAIChatCompletionChunkContentUnion1InputAudio(components.OpenAIChatCompletionChunkContent3{/* values here */})
```

### OpenAIChatCompletionChunkContent4

```go
openAIChatCompletionChunkContentUnion1 := components.CreateOpenAIChatCompletionChunkContentUnion1File(components.OpenAIChatCompletionChunkContent4{/* values here */})
```

## Union Discrimination

Use the `Type` field to determine which variant is active, then access the corresponding field:

```go
switch openAIChatCompletionChunkContentUnion1.Type {
	case components.OpenAIChatCompletionChunkContentUnion1TypeText:
		// openAIChatCompletionChunkContentUnion1.OpenAIChatCompletionChunkContent1 is populated
	case components.OpenAIChatCompletionChunkContentUnion1TypeImageURL:
		// openAIChatCompletionChunkContentUnion1.OpenAIChatCompletionChunkContent2 is populated
	case components.OpenAIChatCompletionChunkContentUnion1TypeInputAudio:
		// openAIChatCompletionChunkContentUnion1.OpenAIChatCompletionChunkContent3 is populated
	case components.OpenAIChatCompletionChunkContentUnion1TypeFile:
		// openAIChatCompletionChunkContentUnion1.OpenAIChatCompletionChunkContent4 is populated
	default:
		// Unknown type - use openAIChatCompletionChunkContentUnion1.GetUnknownRaw() for raw JSON
}
```
