# Type

The format type. Use 'json_object' to enable JSON mode, guaranteeing the message the model generates is valid JSON.


## Supported Types

### 

```go
type := components.CreateTypeStr(string{/* values here */})
```

### OpenAIChatCompletionRequestParamsTypeEnum

```go
type := components.CreateTypeOpenAIChatCompletionRequestParamsTypeEnum(components.OpenAIChatCompletionRequestParamsTypeEnum{/* values here */})
```

## Union Discrimination

Use the `Type` field to determine which variant is active, then access the corresponding field:

```go
switch type.Type {
	case components.TypeTypeStr:
		// type.Str is populated
	case components.TypeTypeOpenAIChatCompletionRequestParamsTypeEnum:
		// type.OpenAIChatCompletionRequestParamsTypeEnum is populated
}
```
