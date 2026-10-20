# Result


## Supported Types

### BatchGetFeedbackResponseResult1

```go
result := components.CreateResultBatchGetFeedbackResponseResult1(components.BatchGetFeedbackResponseResult1{/* values here */})
```

### BatchGetFeedbackResponseResult2

```go
result := components.CreateResultBatchGetFeedbackResponseResult2(components.BatchGetFeedbackResponseResult2{/* values here */})
```

## Union Discrimination

Use the `Type` field to determine which variant is active, then access the corresponding field:

```go
switch result.Type {
	case components.ResultTypeBatchGetFeedbackResponseResult1:
		// result.BatchGetFeedbackResponseResult1 is populated
	case components.ResultTypeBatchGetFeedbackResponseResult2:
		// result.BatchGetFeedbackResponseResult2 is populated
	default:
		// Unknown type - use result.GetUnknownRaw() for raw JSON
}
```
