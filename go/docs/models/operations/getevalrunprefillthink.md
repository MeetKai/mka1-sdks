# GetEvalRunPrefillThink


## Supported Types

### 

```go
getEvalRunPrefillThink := operations.CreateGetEvalRunPrefillThinkBoolean(bool{/* values here */})
```

### 

```go
getEvalRunPrefillThink := operations.CreateGetEvalRunPrefillThinkStr(string{/* values here */})
```

## Union Discrimination

Use the `Type` field to determine which variant is active, then access the corresponding field:

```go
switch getEvalRunPrefillThink.Type {
	case operations.GetEvalRunPrefillThinkTypeBoolean:
		// getEvalRunPrefillThink.Boolean is populated
	case operations.GetEvalRunPrefillThinkTypeStr:
		// getEvalRunPrefillThink.Str is populated
	default:
		// Unknown type - use getEvalRunPrefillThink.GetUnknownRaw() for raw JSON
}
```
