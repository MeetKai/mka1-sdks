# ResponsesCreateRequestPrefillThink

Gateway extension. Provider-specific thinking prefill toggle or prefill text.


## Supported Types

### 

```go
responsesCreateRequestPrefillThink := components.CreateResponsesCreateRequestPrefillThinkBoolean(bool{/* values here */})
```

### 

```go
responsesCreateRequestPrefillThink := components.CreateResponsesCreateRequestPrefillThinkStr(string{/* values here */})
```

## Union Discrimination

Use the `Type` field to determine which variant is active, then access the corresponding field:

```go
switch responsesCreateRequestPrefillThink.Type {
	case components.ResponsesCreateRequestPrefillThinkTypeBoolean:
		// responsesCreateRequestPrefillThink.Boolean is populated
	case components.ResponsesCreateRequestPrefillThinkTypeStr:
		// responsesCreateRequestPrefillThink.Str is populated
}
```
