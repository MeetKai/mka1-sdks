# ReinforcementHyperparametersBatchSize


## Supported Types

### 

```go
reinforcementHyperparametersBatchSize := components.CreateReinforcementHyperparametersBatchSizeStr(string{/* values here */})
```

### 

```go
reinforcementHyperparametersBatchSize := components.CreateReinforcementHyperparametersBatchSizeInteger(int64{/* values here */})
```

## Union Discrimination

Use the `Type` field to determine which variant is active, then access the corresponding field:

```go
switch reinforcementHyperparametersBatchSize.Type {
	case components.ReinforcementHyperparametersBatchSizeTypeStr:
		// reinforcementHyperparametersBatchSize.Str is populated
	case components.ReinforcementHyperparametersBatchSizeTypeInteger:
		// reinforcementHyperparametersBatchSize.Integer is populated
	default:
		// Unknown type - use reinforcementHyperparametersBatchSize.GetUnknownRaw() for raw JSON
}
```
