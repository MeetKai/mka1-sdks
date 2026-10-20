# GetEvalScheduleStop


## Supported Types

### 

```go
getEvalScheduleStop := operations.CreateGetEvalScheduleStopStr(string{/* values here */})
```

### 

```go
getEvalScheduleStop := operations.CreateGetEvalScheduleStopArrayOfStr([]string{/* values here */})
```

## Union Discrimination

Use the `Type` field to determine which variant is active, then access the corresponding field:

```go
switch getEvalScheduleStop.Type {
	case operations.GetEvalScheduleStopTypeStr:
		// getEvalScheduleStop.Str is populated
	case operations.GetEvalScheduleStopTypeArrayOfStr:
		// getEvalScheduleStop.ArrayOfStr is populated
	default:
		// Unknown type - use getEvalScheduleStop.GetUnknownRaw() for raw JSON
}
```
