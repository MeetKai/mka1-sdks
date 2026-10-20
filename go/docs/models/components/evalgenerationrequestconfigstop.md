# EvalGenerationRequestConfigStop


## Supported Types

### 

```go
evalGenerationRequestConfigStop := components.CreateEvalGenerationRequestConfigStopStr(string{/* values here */})
```

### 

```go
evalGenerationRequestConfigStop := components.CreateEvalGenerationRequestConfigStopArrayOfStr([]string{/* values here */})
```

## Union Discrimination

Use the `Type` field to determine which variant is active, then access the corresponding field:

```go
switch evalGenerationRequestConfigStop.Type {
	case components.EvalGenerationRequestConfigStopTypeStr:
		// evalGenerationRequestConfigStop.Str is populated
	case components.EvalGenerationRequestConfigStopTypeArrayOfStr:
		// evalGenerationRequestConfigStop.ArrayOfStr is populated
}
```
