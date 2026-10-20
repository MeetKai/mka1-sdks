# CancelEvalRunPrefillThink


## Supported Types

### 

```go
cancelEvalRunPrefillThink := operations.CreateCancelEvalRunPrefillThinkBoolean(bool{/* values here */})
```

### 

```go
cancelEvalRunPrefillThink := operations.CreateCancelEvalRunPrefillThinkStr(string{/* values here */})
```

## Union Discrimination

Use the `Type` field to determine which variant is active, then access the corresponding field:

```go
switch cancelEvalRunPrefillThink.Type {
	case operations.CancelEvalRunPrefillThinkTypeBoolean:
		// cancelEvalRunPrefillThink.Boolean is populated
	case operations.CancelEvalRunPrefillThinkTypeStr:
		// cancelEvalRunPrefillThink.Str is populated
	default:
		// Unknown type - use cancelEvalRunPrefillThink.GetUnknownRaw() for raw JSON
}
```
