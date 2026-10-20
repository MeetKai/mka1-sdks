# ListEvalSchedulesStop


## Supported Types

### 

```go
listEvalSchedulesStop := operations.CreateListEvalSchedulesStopStr(string{/* values here */})
```

### 

```go
listEvalSchedulesStop := operations.CreateListEvalSchedulesStopArrayOfStr([]string{/* values here */})
```

## Union Discrimination

Use the `Type` field to determine which variant is active, then access the corresponding field:

```go
switch listEvalSchedulesStop.Type {
	case operations.ListEvalSchedulesStopTypeStr:
		// listEvalSchedulesStop.Str is populated
	case operations.ListEvalSchedulesStopTypeArrayOfStr:
		// listEvalSchedulesStop.ArrayOfStr is populated
	default:
		// Unknown type - use listEvalSchedulesStop.GetUnknownRaw() for raw JSON
}
```
