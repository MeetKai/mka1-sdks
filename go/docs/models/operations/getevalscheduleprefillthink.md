# GetEvalSchedulePrefillThink


## Supported Types

### 

```go
getEvalSchedulePrefillThink := operations.CreateGetEvalSchedulePrefillThinkBoolean(bool{/* values here */})
```

### 

```go
getEvalSchedulePrefillThink := operations.CreateGetEvalSchedulePrefillThinkStr(string{/* values here */})
```

## Union Discrimination

Use the `Type` field to determine which variant is active, then access the corresponding field:

```go
switch getEvalSchedulePrefillThink.Type {
	case operations.GetEvalSchedulePrefillThinkTypeBoolean:
		// getEvalSchedulePrefillThink.Boolean is populated
	case operations.GetEvalSchedulePrefillThinkTypeStr:
		// getEvalSchedulePrefillThink.Str is populated
	default:
		// Unknown type - use getEvalSchedulePrefillThink.GetUnknownRaw() for raw JSON
}
```
