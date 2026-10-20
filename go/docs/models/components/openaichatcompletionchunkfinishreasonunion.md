# OpenAIChatCompletionChunkFinishReasonUnion

The reason the model stopped generating tokens. Only present in the final chunk. 'stop' means natural stop point, 'length' means max_tokens limit reached, 'tool_calls' means the model called a tool, 'content_filter' means content was filtered.


## Supported Types

### OpenAIChatCompletionChunkFinishReasonEnum

```go
openAIChatCompletionChunkFinishReasonUnion := components.CreateOpenAIChatCompletionChunkFinishReasonUnionOpenAIChatCompletionChunkFinishReasonEnum(components.OpenAIChatCompletionChunkFinishReasonEnum{/* values here */})
```

### 

```go
openAIChatCompletionChunkFinishReasonUnion := components.CreateOpenAIChatCompletionChunkFinishReasonUnionStr(string{/* values here */})
```

## Union Discrimination

Use the `Type` field to determine which variant is active, then access the corresponding field:

```go
switch openAIChatCompletionChunkFinishReasonUnion.Type {
	case components.OpenAIChatCompletionChunkFinishReasonUnionTypeOpenAIChatCompletionChunkFinishReasonEnum:
		// openAIChatCompletionChunkFinishReasonUnion.OpenAIChatCompletionChunkFinishReasonEnum is populated
	case components.OpenAIChatCompletionChunkFinishReasonUnionTypeStr:
		// openAIChatCompletionChunkFinishReasonUnion.Str is populated
	default:
		// Unknown type - use openAIChatCompletionChunkFinishReasonUnion.GetUnknownRaw() for raw JSON
}
```
