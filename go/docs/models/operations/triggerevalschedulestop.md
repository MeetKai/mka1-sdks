# TriggerEvalScheduleStop


## Supported Types

### 

```go
triggerEvalScheduleStop := operations.CreateTriggerEvalScheduleStopStr(string{/* values here */})
```

### 

```go
triggerEvalScheduleStop := operations.CreateTriggerEvalScheduleStopArrayOfStr([]string{/* values here */})
```

## Union Discrimination

Use the `Type` field to determine which variant is active, then access the corresponding field:

```go
switch triggerEvalScheduleStop.Type {
	case operations.TriggerEvalScheduleStopTypeStr:
		// triggerEvalScheduleStop.Str is populated
	case operations.TriggerEvalScheduleStopTypeArrayOfStr:
		// triggerEvalScheduleStop.ArrayOfStr is populated
	default:
		// Unknown type - use triggerEvalScheduleStop.GetUnknownRaw() for raw JSON
}
```
