# ReinforcementHyperparametersNEpochs


## Supported Types

### 

```go
reinforcementHyperparametersNEpochs := components.CreateReinforcementHyperparametersNEpochsStr(string{/* values here */})
```

### 

```go
reinforcementHyperparametersNEpochs := components.CreateReinforcementHyperparametersNEpochsInteger(int64{/* values here */})
```

## Union Discrimination

Use the `Type` field to determine which variant is active, then access the corresponding field:

```go
switch reinforcementHyperparametersNEpochs.Type {
	case components.ReinforcementHyperparametersNEpochsTypeStr:
		// reinforcementHyperparametersNEpochs.Str is populated
	case components.ReinforcementHyperparametersNEpochsTypeInteger:
		// reinforcementHyperparametersNEpochs.Integer is populated
	default:
		// Unknown type - use reinforcementHyperparametersNEpochs.GetUnknownRaw() for raw JSON
}
```
