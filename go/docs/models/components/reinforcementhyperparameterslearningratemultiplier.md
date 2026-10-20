# ReinforcementHyperparametersLearningRateMultiplier


## Supported Types

### 

```go
reinforcementHyperparametersLearningRateMultiplier := components.CreateReinforcementHyperparametersLearningRateMultiplierStr(string{/* values here */})
```

### 

```go
reinforcementHyperparametersLearningRateMultiplier := components.CreateReinforcementHyperparametersLearningRateMultiplierNumber(float64{/* values here */})
```

## Union Discrimination

Use the `Type` field to determine which variant is active, then access the corresponding field:

```go
switch reinforcementHyperparametersLearningRateMultiplier.Type {
	case components.ReinforcementHyperparametersLearningRateMultiplierTypeStr:
		// reinforcementHyperparametersLearningRateMultiplier.Str is populated
	case components.ReinforcementHyperparametersLearningRateMultiplierTypeNumber:
		// reinforcementHyperparametersLearningRateMultiplier.Number is populated
	default:
		// Unknown type - use reinforcementHyperparametersLearningRateMultiplier.GetUnknownRaw() for raw JSON
}
```
