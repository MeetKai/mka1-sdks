# ListEvalScheduleRunsStop


## Supported Types

### 

```go
listEvalScheduleRunsStop := operations.CreateListEvalScheduleRunsStopStr(string{/* values here */})
```

### 

```go
listEvalScheduleRunsStop := operations.CreateListEvalScheduleRunsStopArrayOfStr([]string{/* values here */})
```

## Union Discrimination

Use the `Type` field to determine which variant is active, then access the corresponding field:

```go
switch listEvalScheduleRunsStop.Type {
	case operations.ListEvalScheduleRunsStopTypeStr:
		// listEvalScheduleRunsStop.Str is populated
	case operations.ListEvalScheduleRunsStopTypeArrayOfStr:
		// listEvalScheduleRunsStop.ArrayOfStr is populated
	default:
		// Unknown type - use listEvalScheduleRunsStop.GetUnknownRaw() for raw JSON
}
```
