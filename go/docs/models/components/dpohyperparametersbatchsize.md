# DpoHyperparametersBatchSize


## Supported Types

### 

```go
dpoHyperparametersBatchSize := components.CreateDpoHyperparametersBatchSizeStr(string{/* values here */})
```

### 

```go
dpoHyperparametersBatchSize := components.CreateDpoHyperparametersBatchSizeInteger(int64{/* values here */})
```

## Union Discrimination

Use the `Type` field to determine which variant is active, then access the corresponding field:

```go
switch dpoHyperparametersBatchSize.Type {
	case components.DpoHyperparametersBatchSizeTypeStr:
		// dpoHyperparametersBatchSize.Str is populated
	case components.DpoHyperparametersBatchSizeTypeInteger:
		// dpoHyperparametersBatchSize.Integer is populated
	default:
		// Unknown type - use dpoHyperparametersBatchSize.GetUnknownRaw() for raw JSON
}
```
