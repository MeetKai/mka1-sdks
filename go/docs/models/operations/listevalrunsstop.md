# ListEvalRunsStop


## Supported Types

### 

```go
listEvalRunsStop := operations.CreateListEvalRunsStopStr(string{/* values here */})
```

### 

```go
listEvalRunsStop := operations.CreateListEvalRunsStopArrayOfStr([]string{/* values here */})
```

## Union Discrimination

Use the `Type` field to determine which variant is active, then access the corresponding field:

```go
switch listEvalRunsStop.Type {
	case operations.ListEvalRunsStopTypeStr:
		// listEvalRunsStop.Str is populated
	case operations.ListEvalRunsStopTypeArrayOfStr:
		// listEvalRunsStop.ArrayOfStr is populated
	default:
		// Unknown type - use listEvalRunsStop.GetUnknownRaw() for raw JSON
}
```
