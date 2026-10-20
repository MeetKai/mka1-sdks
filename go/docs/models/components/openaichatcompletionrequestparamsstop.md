# OpenAIChatCompletionRequestParamsStop

Up to 4 sequences where the API will stop generating further tokens. The returned text will not contain the stop sequence.


## Supported Types

### 

```go
openAIChatCompletionRequestParamsStop := components.CreateOpenAIChatCompletionRequestParamsStopStr(string{/* values here */})
```

### 

```go
openAIChatCompletionRequestParamsStop := components.CreateOpenAIChatCompletionRequestParamsStopArrayOfStr([]string{/* values here */})
```

## Union Discrimination

Use the `Type` field to determine which variant is active, then access the corresponding field:

```go
switch openAIChatCompletionRequestParamsStop.Type {
	case components.OpenAIChatCompletionRequestParamsStopTypeStr:
		// openAIChatCompletionRequestParamsStop.Str is populated
	case components.OpenAIChatCompletionRequestParamsStopTypeArrayOfStr:
		// openAIChatCompletionRequestParamsStop.ArrayOfStr is populated
}
```
