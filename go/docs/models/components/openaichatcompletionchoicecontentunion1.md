# OpenAIChatCompletionChoiceContentUnion1

A content part that can be included in a message. Supports text, images, audio, and files.


## Supported Types

### OpenAIChatCompletionChoiceContent1

```go
openAIChatCompletionChoiceContentUnion1 := components.CreateOpenAIChatCompletionChoiceContentUnion1Text(components.OpenAIChatCompletionChoiceContent1{/* values here */})
```

### OpenAIChatCompletionChoiceContent2

```go
openAIChatCompletionChoiceContentUnion1 := components.CreateOpenAIChatCompletionChoiceContentUnion1ImageURL(components.OpenAIChatCompletionChoiceContent2{/* values here */})
```

### OpenAIChatCompletionChoiceContent3

```go
openAIChatCompletionChoiceContentUnion1 := components.CreateOpenAIChatCompletionChoiceContentUnion1InputAudio(components.OpenAIChatCompletionChoiceContent3{/* values here */})
```

### OpenAIChatCompletionChoiceContent4

```go
openAIChatCompletionChoiceContentUnion1 := components.CreateOpenAIChatCompletionChoiceContentUnion1File(components.OpenAIChatCompletionChoiceContent4{/* values here */})
```

## Union Discrimination

Use the `Type` field to determine which variant is active, then access the corresponding field:

```go
switch openAIChatCompletionChoiceContentUnion1.Type {
	case components.OpenAIChatCompletionChoiceContentUnion1TypeText:
		// openAIChatCompletionChoiceContentUnion1.OpenAIChatCompletionChoiceContent1 is populated
	case components.OpenAIChatCompletionChoiceContentUnion1TypeImageURL:
		// openAIChatCompletionChoiceContentUnion1.OpenAIChatCompletionChoiceContent2 is populated
	case components.OpenAIChatCompletionChoiceContentUnion1TypeInputAudio:
		// openAIChatCompletionChoiceContentUnion1.OpenAIChatCompletionChoiceContent3 is populated
	case components.OpenAIChatCompletionChoiceContentUnion1TypeFile:
		// openAIChatCompletionChoiceContentUnion1.OpenAIChatCompletionChoiceContent4 is populated
	default:
		// Unknown type - use openAIChatCompletionChoiceContentUnion1.GetUnknownRaw() for raw JSON
}
```
