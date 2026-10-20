# ListEvalSchedulesPrefillThink


## Supported Types

### 

```go
listEvalSchedulesPrefillThink := operations.CreateListEvalSchedulesPrefillThinkBoolean(bool{/* values here */})
```

### 

```go
listEvalSchedulesPrefillThink := operations.CreateListEvalSchedulesPrefillThinkStr(string{/* values here */})
```

## Union Discrimination

Use the `Type` field to determine which variant is active, then access the corresponding field:

```go
switch listEvalSchedulesPrefillThink.Type {
	case operations.ListEvalSchedulesPrefillThinkTypeBoolean:
		// listEvalSchedulesPrefillThink.Boolean is populated
	case operations.ListEvalSchedulesPrefillThinkTypeStr:
		// listEvalSchedulesPrefillThink.Str is populated
	default:
		// Unknown type - use listEvalSchedulesPrefillThink.GetUnknownRaw() for raw JSON
}
```
