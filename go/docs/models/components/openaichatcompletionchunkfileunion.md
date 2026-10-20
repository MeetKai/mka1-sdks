# OpenAIChatCompletionChunkFileUnion

The file to include in the message, either as raw data or by reference


## Supported Types

### OpenAIChatCompletionChunkFile1

```go
openAIChatCompletionChunkFileUnion := components.CreateOpenAIChatCompletionChunkFileUnionOpenAIChatCompletionChunkFile1(components.OpenAIChatCompletionChunkFile1{/* values here */})
```

### OpenAIChatCompletionChunkFile2

```go
openAIChatCompletionChunkFileUnion := components.CreateOpenAIChatCompletionChunkFileUnionOpenAIChatCompletionChunkFile2(components.OpenAIChatCompletionChunkFile2{/* values here */})
```

## Union Discrimination

Use the `Type` field to determine which variant is active, then access the corresponding field:

```go
switch openAIChatCompletionChunkFileUnion.Type {
	case components.OpenAIChatCompletionChunkFileUnionTypeOpenAIChatCompletionChunkFile1:
		// openAIChatCompletionChunkFileUnion.OpenAIChatCompletionChunkFile1 is populated
	case components.OpenAIChatCompletionChunkFileUnionTypeOpenAIChatCompletionChunkFile2:
		// openAIChatCompletionChunkFileUnion.OpenAIChatCompletionChunkFile2 is populated
	default:
		// Unknown type - use openAIChatCompletionChunkFileUnion.GetUnknownRaw() for raw JSON
}
```
