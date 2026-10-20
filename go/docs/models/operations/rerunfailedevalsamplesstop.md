# RerunFailedEvalSamplesStop


## Supported Types

### 

```go
rerunFailedEvalSamplesStop := operations.CreateRerunFailedEvalSamplesStopStr(string{/* values here */})
```

### 

```go
rerunFailedEvalSamplesStop := operations.CreateRerunFailedEvalSamplesStopArrayOfStr([]string{/* values here */})
```

## Union Discrimination

Use the `Type` field to determine which variant is active, then access the corresponding field:

```go
switch rerunFailedEvalSamplesStop.Type {
	case operations.RerunFailedEvalSamplesStopTypeStr:
		// rerunFailedEvalSamplesStop.Str is populated
	case operations.RerunFailedEvalSamplesStopTypeArrayOfStr:
		// rerunFailedEvalSamplesStop.ArrayOfStr is populated
	default:
		// Unknown type - use rerunFailedEvalSamplesStop.GetUnknownRaw() for raw JSON
}
```
