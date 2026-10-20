# CreateEvalScheduleStop


## Supported Types

### 

```go
createEvalScheduleStop := operations.CreateCreateEvalScheduleStopStr(string{/* values here */})
```

### 

```go
createEvalScheduleStop := operations.CreateCreateEvalScheduleStopArrayOfStr([]string{/* values here */})
```

## Union Discrimination

Use the `Type` field to determine which variant is active, then access the corresponding field:

```go
switch createEvalScheduleStop.Type {
	case operations.CreateEvalScheduleStopTypeStr:
		// createEvalScheduleStop.Str is populated
	case operations.CreateEvalScheduleStopTypeArrayOfStr:
		// createEvalScheduleStop.ArrayOfStr is populated
	default:
		// Unknown type - use createEvalScheduleStop.GetUnknownRaw() for raw JSON
}
```
