# OpenAIChatCompletionChoiceContentUnion2

The contents of the assistant message. Null when the message contains tool calls only; null or absent on a refusal, where the text is in `refusal` instead.


## Supported Types

### 

```go
openAIChatCompletionChoiceContentUnion2 := components.CreateOpenAIChatCompletionChoiceContentUnion2Str(string{/* values here */})
```

### 

```go
openAIChatCompletionChoiceContentUnion2 := components.CreateOpenAIChatCompletionChoiceContentUnion2ArrayOfOpenAIChatCompletionChoiceContentUnion1([]components.OpenAIChatCompletionChoiceContentUnion1{/* values here */})
```

## Union Discrimination

Use the `Type` field to determine which variant is active, then access the corresponding field:

```go
switch openAIChatCompletionChoiceContentUnion2.Type {
	case components.OpenAIChatCompletionChoiceContentUnion2TypeStr:
		// openAIChatCompletionChoiceContentUnion2.Str is populated
	case components.OpenAIChatCompletionChoiceContentUnion2TypeArrayOfOpenAIChatCompletionChoiceContentUnion1:
		// openAIChatCompletionChoiceContentUnion2.ArrayOfOpenAIChatCompletionChoiceContentUnion1 is populated
	default:
		// Unknown type - use openAIChatCompletionChoiceContentUnion2.GetUnknownRaw() for raw JSON
}
```
