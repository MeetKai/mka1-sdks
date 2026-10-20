# OpenAIRequestMessageFileUnion

The file to include in the message, either as raw data or by reference


## Supported Types

### OpenAIRequestMessageFile1

```go
openAIRequestMessageFileUnion := components.CreateOpenAIRequestMessageFileUnionOpenAIRequestMessageFile1(components.OpenAIRequestMessageFile1{/* values here */})
```

### OpenAIRequestMessageFile2

```go
openAIRequestMessageFileUnion := components.CreateOpenAIRequestMessageFileUnionOpenAIRequestMessageFile2(components.OpenAIRequestMessageFile2{/* values here */})
```

## Union Discrimination

Use the `Type` field to determine which variant is active, then access the corresponding field:

```go
switch openAIRequestMessageFileUnion.Type {
	case components.OpenAIRequestMessageFileUnionTypeOpenAIRequestMessageFile1:
		// openAIRequestMessageFileUnion.OpenAIRequestMessageFile1 is populated
	case components.OpenAIRequestMessageFileUnionTypeOpenAIRequestMessageFile2:
		// openAIRequestMessageFileUnion.OpenAIRequestMessageFile2 is populated
}
```
