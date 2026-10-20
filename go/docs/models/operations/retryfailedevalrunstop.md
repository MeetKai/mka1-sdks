# RetryFailedEvalRunStop


## Supported Types

### 

```go
retryFailedEvalRunStop := operations.CreateRetryFailedEvalRunStopStr(string{/* values here */})
```

### 

```go
retryFailedEvalRunStop := operations.CreateRetryFailedEvalRunStopArrayOfStr([]string{/* values here */})
```

## Union Discrimination

Use the `Type` field to determine which variant is active, then access the corresponding field:

```go
switch retryFailedEvalRunStop.Type {
	case operations.RetryFailedEvalRunStopTypeStr:
		// retryFailedEvalRunStop.Str is populated
	case operations.RetryFailedEvalRunStopTypeArrayOfStr:
		// retryFailedEvalRunStop.ArrayOfStr is populated
	default:
		// Unknown type - use retryFailedEvalRunStop.GetUnknownRaw() for raw JSON
}
```
