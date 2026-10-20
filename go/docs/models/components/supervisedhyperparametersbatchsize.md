# SupervisedHyperparametersBatchSize


## Supported Types

### 

```go
supervisedHyperparametersBatchSize := components.CreateSupervisedHyperparametersBatchSizeStr(string{/* values here */})
```

### 

```go
supervisedHyperparametersBatchSize := components.CreateSupervisedHyperparametersBatchSizeInteger(int64{/* values here */})
```

## Union Discrimination

Use the `Type` field to determine which variant is active, then access the corresponding field:

```go
switch supervisedHyperparametersBatchSize.Type {
	case components.SupervisedHyperparametersBatchSizeTypeStr:
		// supervisedHyperparametersBatchSize.Str is populated
	case components.SupervisedHyperparametersBatchSizeTypeInteger:
		// supervisedHyperparametersBatchSize.Integer is populated
	default:
		// Unknown type - use supervisedHyperparametersBatchSize.GetUnknownRaw() for raw JSON
}
```
