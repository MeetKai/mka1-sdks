# EvalGenerationRequestConfigPrefillThink


## Supported Types

### 

```go
evalGenerationRequestConfigPrefillThink := components.CreateEvalGenerationRequestConfigPrefillThinkBoolean(bool{/* values here */})
```

### 

```go
evalGenerationRequestConfigPrefillThink := components.CreateEvalGenerationRequestConfigPrefillThinkStr(string{/* values here */})
```

## Union Discrimination

Use the `Type` field to determine which variant is active, then access the corresponding field:

```go
switch evalGenerationRequestConfigPrefillThink.Type {
	case components.EvalGenerationRequestConfigPrefillThinkTypeBoolean:
		// evalGenerationRequestConfigPrefillThink.Boolean is populated
	case components.EvalGenerationRequestConfigPrefillThinkTypeStr:
		// evalGenerationRequestConfigPrefillThink.Str is populated
}
```
