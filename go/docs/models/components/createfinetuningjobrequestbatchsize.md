# CreateFineTuningJobRequestBatchSize


## Supported Types

### 

```go
createFineTuningJobRequestBatchSize := components.CreateCreateFineTuningJobRequestBatchSizeStr(string{/* values here */})
```

### 

```go
createFineTuningJobRequestBatchSize := components.CreateCreateFineTuningJobRequestBatchSizeInteger(int64{/* values here */})
```

## Union Discrimination

Use the `Type` field to determine which variant is active, then access the corresponding field:

```go
switch createFineTuningJobRequestBatchSize.Type {
	case components.CreateFineTuningJobRequestBatchSizeTypeStr:
		// createFineTuningJobRequestBatchSize.Str is populated
	case components.CreateFineTuningJobRequestBatchSizeTypeInteger:
		// createFineTuningJobRequestBatchSize.Integer is populated
}
```
