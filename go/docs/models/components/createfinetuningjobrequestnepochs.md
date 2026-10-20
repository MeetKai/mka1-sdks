# CreateFineTuningJobRequestNEpochs


## Supported Types

### 

```go
createFineTuningJobRequestNEpochs := components.CreateCreateFineTuningJobRequestNEpochsStr(string{/* values here */})
```

### 

```go
createFineTuningJobRequestNEpochs := components.CreateCreateFineTuningJobRequestNEpochsInteger(int64{/* values here */})
```

## Union Discrimination

Use the `Type` field to determine which variant is active, then access the corresponding field:

```go
switch createFineTuningJobRequestNEpochs.Type {
	case components.CreateFineTuningJobRequestNEpochsTypeStr:
		// createFineTuningJobRequestNEpochs.Str is populated
	case components.CreateFineTuningJobRequestNEpochsTypeInteger:
		// createFineTuningJobRequestNEpochs.Integer is populated
}
```
