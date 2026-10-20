# DpoHyperparametersLearningRateMultiplier


## Supported Types

### 

```go
dpoHyperparametersLearningRateMultiplier := components.CreateDpoHyperparametersLearningRateMultiplierStr(string{/* values here */})
```

### 

```go
dpoHyperparametersLearningRateMultiplier := components.CreateDpoHyperparametersLearningRateMultiplierNumber(float64{/* values here */})
```

## Union Discrimination

Use the `Type` field to determine which variant is active, then access the corresponding field:

```go
switch dpoHyperparametersLearningRateMultiplier.Type {
	case components.DpoHyperparametersLearningRateMultiplierTypeStr:
		// dpoHyperparametersLearningRateMultiplier.Str is populated
	case components.DpoHyperparametersLearningRateMultiplierTypeNumber:
		// dpoHyperparametersLearningRateMultiplier.Number is populated
	default:
		// Unknown type - use dpoHyperparametersLearningRateMultiplier.GetUnknownRaw() for raw JSON
}
```
