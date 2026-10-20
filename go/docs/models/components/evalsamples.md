# EvalSamples


## Supported Types

### 

```go
evalSamples := components.CreateEvalSamplesStr(string{/* values here */})
```

### 

```go
evalSamples := components.CreateEvalSamplesInteger(int64{/* values here */})
```

## Union Discrimination

Use the `Type` field to determine which variant is active, then access the corresponding field:

```go
switch evalSamples.Type {
	case components.EvalSamplesTypeStr:
		// evalSamples.Str is populated
	case components.EvalSamplesTypeInteger:
		// evalSamples.Integer is populated
	default:
		// Unknown type - use evalSamples.GetUnknownRaw() for raw JSON
}
```
