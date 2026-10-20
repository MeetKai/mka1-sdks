# EvalInterval


## Supported Types

### 

```go
evalInterval := components.CreateEvalIntervalStr(string{/* values here */})
```

### 

```go
evalInterval := components.CreateEvalIntervalInteger(int64{/* values here */})
```

## Union Discrimination

Use the `Type` field to determine which variant is active, then access the corresponding field:

```go
switch evalInterval.Type {
	case components.EvalIntervalTypeStr:
		// evalInterval.Str is populated
	case components.EvalIntervalTypeInteger:
		// evalInterval.Integer is populated
	default:
		// Unknown type - use evalInterval.GetUnknownRaw() for raw JSON
}
```
