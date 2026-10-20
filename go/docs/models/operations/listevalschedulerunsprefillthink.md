# ListEvalScheduleRunsPrefillThink


## Supported Types

### 

```go
listEvalScheduleRunsPrefillThink := operations.CreateListEvalScheduleRunsPrefillThinkBoolean(bool{/* values here */})
```

### 

```go
listEvalScheduleRunsPrefillThink := operations.CreateListEvalScheduleRunsPrefillThinkStr(string{/* values here */})
```

## Union Discrimination

Use the `Type` field to determine which variant is active, then access the corresponding field:

```go
switch listEvalScheduleRunsPrefillThink.Type {
	case operations.ListEvalScheduleRunsPrefillThinkTypeBoolean:
		// listEvalScheduleRunsPrefillThink.Boolean is populated
	case operations.ListEvalScheduleRunsPrefillThinkTypeStr:
		// listEvalScheduleRunsPrefillThink.Str is populated
	default:
		// Unknown type - use listEvalScheduleRunsPrefillThink.GetUnknownRaw() for raw JSON
}
```
