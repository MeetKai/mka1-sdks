# CreateEvalRunPrefillThink


## Supported Types

### 

```go
createEvalRunPrefillThink := operations.CreateCreateEvalRunPrefillThinkBoolean(bool{/* values here */})
```

### 

```go
createEvalRunPrefillThink := operations.CreateCreateEvalRunPrefillThinkStr(string{/* values here */})
```

## Union Discrimination

Use the `Type` field to determine which variant is active, then access the corresponding field:

```go
switch createEvalRunPrefillThink.Type {
	case operations.CreateEvalRunPrefillThinkTypeBoolean:
		// createEvalRunPrefillThink.Boolean is populated
	case operations.CreateEvalRunPrefillThinkTypeStr:
		// createEvalRunPrefillThink.Str is populated
	default:
		// Unknown type - use createEvalRunPrefillThink.GetUnknownRaw() for raw JSON
}
```
