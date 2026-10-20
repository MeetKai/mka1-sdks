# EvalOutputExtractionGroup2


## Supported Types

### 

```go
evalOutputExtractionGroup2 := components.CreateEvalOutputExtractionGroup2Integer(int64{/* values here */})
```

### 

```go
evalOutputExtractionGroup2 := components.CreateEvalOutputExtractionGroup2Str(string{/* values here */})
```

## Union Discrimination

Use the `Type` field to determine which variant is active, then access the corresponding field:

```go
switch evalOutputExtractionGroup2.Type {
	case components.EvalOutputExtractionGroup2TypeInteger:
		// evalOutputExtractionGroup2.Integer is populated
	case components.EvalOutputExtractionGroup2TypeStr:
		// evalOutputExtractionGroup2.Str is populated
}
```
