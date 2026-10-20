# CreateFineTuningJobRequestLearningRateMultiplier


## Supported Types

### 

```go
createFineTuningJobRequestLearningRateMultiplier := components.CreateCreateFineTuningJobRequestLearningRateMultiplierStr(string{/* values here */})
```

### 

```go
createFineTuningJobRequestLearningRateMultiplier := components.CreateCreateFineTuningJobRequestLearningRateMultiplierNumber(float64{/* values here */})
```

## Union Discrimination

Use the `Type` field to determine which variant is active, then access the corresponding field:

```go
switch createFineTuningJobRequestLearningRateMultiplier.Type {
	case components.CreateFineTuningJobRequestLearningRateMultiplierTypeStr:
		// createFineTuningJobRequestLearningRateMultiplier.Str is populated
	case components.CreateFineTuningJobRequestLearningRateMultiplierTypeNumber:
		// createFineTuningJobRequestLearningRateMultiplier.Number is populated
}
```
