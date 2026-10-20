# OpenAIChatCompletionChunkContentUnion2

The content of the chunk. May be a string, content parts, or null.


## Supported Types

### 

```go
openAIChatCompletionChunkContentUnion2 := components.CreateOpenAIChatCompletionChunkContentUnion2Str(string{/* values here */})
```

### 

```go
openAIChatCompletionChunkContentUnion2 := components.CreateOpenAIChatCompletionChunkContentUnion2ArrayOfOpenAIChatCompletionChunkContentUnion1([]components.OpenAIChatCompletionChunkContentUnion1{/* values here */})
```

## Union Discrimination

Use the `Type` field to determine which variant is active, then access the corresponding field:

```go
switch openAIChatCompletionChunkContentUnion2.Type {
	case components.OpenAIChatCompletionChunkContentUnion2TypeStr:
		// openAIChatCompletionChunkContentUnion2.Str is populated
	case components.OpenAIChatCompletionChunkContentUnion2TypeArrayOfOpenAIChatCompletionChunkContentUnion1:
		// openAIChatCompletionChunkContentUnion2.ArrayOfOpenAIChatCompletionChunkContentUnion1 is populated
	default:
		// Unknown type - use openAIChatCompletionChunkContentUnion2.GetUnknownRaw() for raw JSON
}
```
