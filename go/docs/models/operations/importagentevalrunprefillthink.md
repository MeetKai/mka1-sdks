# ImportAgentEvalRunPrefillThink


## Supported Types

### 

```go
importAgentEvalRunPrefillThink := operations.CreateImportAgentEvalRunPrefillThinkBoolean(bool{/* values here */})
```

### 

```go
importAgentEvalRunPrefillThink := operations.CreateImportAgentEvalRunPrefillThinkStr(string{/* values here */})
```

## Union Discrimination

Use the `Type` field to determine which variant is active, then access the corresponding field:

```go
switch importAgentEvalRunPrefillThink.Type {
	case operations.ImportAgentEvalRunPrefillThinkTypeBoolean:
		// importAgentEvalRunPrefillThink.Boolean is populated
	case operations.ImportAgentEvalRunPrefillThinkTypeStr:
		// importAgentEvalRunPrefillThink.Str is populated
	default:
		// Unknown type - use importAgentEvalRunPrefillThink.GetUnknownRaw() for raw JSON
}
```
