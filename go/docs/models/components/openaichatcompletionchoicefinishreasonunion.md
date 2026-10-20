# OpenAIChatCompletionChoiceFinishReasonUnion


## Supported Types

### OpenAIChatCompletionChoiceFinishReasonEnum

```go
openAIChatCompletionChoiceFinishReasonUnion := components.CreateOpenAIChatCompletionChoiceFinishReasonUnionOpenAIChatCompletionChoiceFinishReasonEnum(components.OpenAIChatCompletionChoiceFinishReasonEnum{/* values here */})
```

### 

```go
openAIChatCompletionChoiceFinishReasonUnion := components.CreateOpenAIChatCompletionChoiceFinishReasonUnionStr(string{/* values here */})
```

## Union Discrimination

Use the `Type` field to determine which variant is active, then access the corresponding field:

```go
switch openAIChatCompletionChoiceFinishReasonUnion.Type {
	case components.OpenAIChatCompletionChoiceFinishReasonUnionTypeOpenAIChatCompletionChoiceFinishReasonEnum:
		// openAIChatCompletionChoiceFinishReasonUnion.OpenAIChatCompletionChoiceFinishReasonEnum is populated
	case components.OpenAIChatCompletionChoiceFinishReasonUnionTypeStr:
		// openAIChatCompletionChoiceFinishReasonUnion.Str is populated
	default:
		// Unknown type - use openAIChatCompletionChoiceFinishReasonUnion.GetUnknownRaw() for raw JSON
}
```
