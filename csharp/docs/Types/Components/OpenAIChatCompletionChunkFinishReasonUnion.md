# OpenAIChatCompletionChunkFinishReasonUnion

The reason the model stopped generating tokens. Only present in the final chunk. 'stop' means natural stop point, 'length' means max_tokens limit reached, 'tool_calls' means the model called a tool, 'content_filter' means content was filtered.


## Supported Types

### OpenAIChatCompletionChunkFinishReasonEnum

```csharp
OpenAIChatCompletionChunkFinishReasonUnion.CreateOpenAIChatCompletionChunkFinishReasonEnum(/* values here */);
```

### Str

```csharp
OpenAIChatCompletionChunkFinishReasonUnion.CreateStr(/* values here */);
```
