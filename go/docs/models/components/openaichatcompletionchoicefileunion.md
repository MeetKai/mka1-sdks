# OpenAIChatCompletionChoiceFileUnion

The file to include in the message, either as raw data or by reference


## Supported Types

### OpenAIChatCompletionChoiceFile1

```go
openAIChatCompletionChoiceFileUnion := components.CreateOpenAIChatCompletionChoiceFileUnionOpenAIChatCompletionChoiceFile1(components.OpenAIChatCompletionChoiceFile1{/* values here */})
```

### OpenAIChatCompletionChoiceFile2

```go
openAIChatCompletionChoiceFileUnion := components.CreateOpenAIChatCompletionChoiceFileUnionOpenAIChatCompletionChoiceFile2(components.OpenAIChatCompletionChoiceFile2{/* values here */})
```

## Union Discrimination

Use the `Type` field to determine which variant is active, then access the corresponding field:

```go
switch openAIChatCompletionChoiceFileUnion.Type {
	case components.OpenAIChatCompletionChoiceFileUnionTypeOpenAIChatCompletionChoiceFile1:
		// openAIChatCompletionChoiceFileUnion.OpenAIChatCompletionChoiceFile1 is populated
	case components.OpenAIChatCompletionChoiceFileUnionTypeOpenAIChatCompletionChoiceFile2:
		// openAIChatCompletionChoiceFileUnion.OpenAIChatCompletionChoiceFile2 is populated
	default:
		// Unknown type - use openAIChatCompletionChoiceFileUnion.GetUnknownRaw() for raw JSON
}
```
