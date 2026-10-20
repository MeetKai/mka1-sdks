# RetryFailedEvalRunPrefillThink


## Supported Types

### 

```go
retryFailedEvalRunPrefillThink := operations.CreateRetryFailedEvalRunPrefillThinkBoolean(bool{/* values here */})
```

### 

```go
retryFailedEvalRunPrefillThink := operations.CreateRetryFailedEvalRunPrefillThinkStr(string{/* values here */})
```

## Union Discrimination

Use the `Type` field to determine which variant is active, then access the corresponding field:

```go
switch retryFailedEvalRunPrefillThink.Type {
	case operations.RetryFailedEvalRunPrefillThinkTypeBoolean:
		// retryFailedEvalRunPrefillThink.Boolean is populated
	case operations.RetryFailedEvalRunPrefillThinkTypeStr:
		// retryFailedEvalRunPrefillThink.Str is populated
	default:
		// Unknown type - use retryFailedEvalRunPrefillThink.GetUnknownRaw() for raw JSON
}
```
