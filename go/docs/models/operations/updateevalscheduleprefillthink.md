# UpdateEvalSchedulePrefillThink


## Supported Types

### 

```go
updateEvalSchedulePrefillThink := operations.CreateUpdateEvalSchedulePrefillThinkBoolean(bool{/* values here */})
```

### 

```go
updateEvalSchedulePrefillThink := operations.CreateUpdateEvalSchedulePrefillThinkStr(string{/* values here */})
```

## Union Discrimination

Use the `Type` field to determine which variant is active, then access the corresponding field:

```go
switch updateEvalSchedulePrefillThink.Type {
	case operations.UpdateEvalSchedulePrefillThinkTypeBoolean:
		// updateEvalSchedulePrefillThink.Boolean is populated
	case operations.UpdateEvalSchedulePrefillThinkTypeStr:
		// updateEvalSchedulePrefillThink.Str is populated
	default:
		// Unknown type - use updateEvalSchedulePrefillThink.GetUnknownRaw() for raw JSON
}
```
