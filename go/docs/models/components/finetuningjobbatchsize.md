# FineTuningJobBatchSize


## Supported Types

### 

```go
fineTuningJobBatchSize := components.CreateFineTuningJobBatchSizeStr(string{/* values here */})
```

### 

```go
fineTuningJobBatchSize := components.CreateFineTuningJobBatchSizeInteger(int64{/* values here */})
```

## Union Discrimination

Use the `Type` field to determine which variant is active, then access the corresponding field:

```go
switch fineTuningJobBatchSize.Type {
	case components.FineTuningJobBatchSizeTypeStr:
		// fineTuningJobBatchSize.Str is populated
	case components.FineTuningJobBatchSizeTypeInteger:
		// fineTuningJobBatchSize.Integer is populated
	default:
		// Unknown type - use fineTuningJobBatchSize.GetUnknownRaw() for raw JSON
}
```
