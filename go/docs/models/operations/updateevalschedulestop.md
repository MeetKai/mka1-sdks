# UpdateEvalScheduleStop


## Supported Types

### 

```go
updateEvalScheduleStop := operations.CreateUpdateEvalScheduleStopStr(string{/* values here */})
```

### 

```go
updateEvalScheduleStop := operations.CreateUpdateEvalScheduleStopArrayOfStr([]string{/* values here */})
```

## Union Discrimination

Use the `Type` field to determine which variant is active, then access the corresponding field:

```go
switch updateEvalScheduleStop.Type {
	case operations.UpdateEvalScheduleStopTypeStr:
		// updateEvalScheduleStop.Str is populated
	case operations.UpdateEvalScheduleStopTypeArrayOfStr:
		// updateEvalScheduleStop.ArrayOfStr is populated
	default:
		// Unknown type - use updateEvalScheduleStop.GetUnknownRaw() for raw JSON
}
```
