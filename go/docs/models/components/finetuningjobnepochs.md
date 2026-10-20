# FineTuningJobNEpochs


## Supported Types

### 

```go
fineTuningJobNEpochs := components.CreateFineTuningJobNEpochsStr(string{/* values here */})
```

### 

```go
fineTuningJobNEpochs := components.CreateFineTuningJobNEpochsInteger(int64{/* values here */})
```

## Union Discrimination

Use the `Type` field to determine which variant is active, then access the corresponding field:

```go
switch fineTuningJobNEpochs.Type {
	case components.FineTuningJobNEpochsTypeStr:
		// fineTuningJobNEpochs.Str is populated
	case components.FineTuningJobNEpochsTypeInteger:
		// fineTuningJobNEpochs.Integer is populated
	default:
		// Unknown type - use fineTuningJobNEpochs.GetUnknownRaw() for raw JSON
}
```
