# FineTuningJobLearningRateMultiplier


## Supported Types

### 

```go
fineTuningJobLearningRateMultiplier := components.CreateFineTuningJobLearningRateMultiplierStr(string{/* values here */})
```

### 

```go
fineTuningJobLearningRateMultiplier := components.CreateFineTuningJobLearningRateMultiplierNumber(float64{/* values here */})
```

## Union Discrimination

Use the `Type` field to determine which variant is active, then access the corresponding field:

```go
switch fineTuningJobLearningRateMultiplier.Type {
	case components.FineTuningJobLearningRateMultiplierTypeStr:
		// fineTuningJobLearningRateMultiplier.Str is populated
	case components.FineTuningJobLearningRateMultiplierTypeNumber:
		// fineTuningJobLearningRateMultiplier.Number is populated
	default:
		// Unknown type - use fineTuningJobLearningRateMultiplier.GetUnknownRaw() for raw JSON
}
```
