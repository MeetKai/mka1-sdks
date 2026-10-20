# SupervisedHyperparametersLearningRateMultiplier


## Supported Types

### 

```go
supervisedHyperparametersLearningRateMultiplier := components.CreateSupervisedHyperparametersLearningRateMultiplierStr(string{/* values here */})
```

### 

```go
supervisedHyperparametersLearningRateMultiplier := components.CreateSupervisedHyperparametersLearningRateMultiplierNumber(float64{/* values here */})
```

## Union Discrimination

Use the `Type` field to determine which variant is active, then access the corresponding field:

```go
switch supervisedHyperparametersLearningRateMultiplier.Type {
	case components.SupervisedHyperparametersLearningRateMultiplierTypeStr:
		// supervisedHyperparametersLearningRateMultiplier.Str is populated
	case components.SupervisedHyperparametersLearningRateMultiplierTypeNumber:
		// supervisedHyperparametersLearningRateMultiplier.Number is populated
	default:
		// Unknown type - use supervisedHyperparametersLearningRateMultiplier.GetUnknownRaw() for raw JSON
}
```
