# EvalOutputExtractionGroup1


## Supported Types

### 

```go
evalOutputExtractionGroup1 := components.CreateEvalOutputExtractionGroup1Integer(int64{/* values here */})
```

### 

```go
evalOutputExtractionGroup1 := components.CreateEvalOutputExtractionGroup1Str(string{/* values here */})
```

## Union Discrimination

Use the `Type` field to determine which variant is active, then access the corresponding field:

```go
switch evalOutputExtractionGroup1.Type {
	case components.EvalOutputExtractionGroup1TypeInteger:
		// evalOutputExtractionGroup1.Integer is populated
	case components.EvalOutputExtractionGroup1TypeStr:
		// evalOutputExtractionGroup1.Str is populated
}
```
