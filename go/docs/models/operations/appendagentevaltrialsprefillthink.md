# AppendAgentEvalTrialsPrefillThink


## Supported Types

### 

```go
appendAgentEvalTrialsPrefillThink := operations.CreateAppendAgentEvalTrialsPrefillThinkBoolean(bool{/* values here */})
```

### 

```go
appendAgentEvalTrialsPrefillThink := operations.CreateAppendAgentEvalTrialsPrefillThinkStr(string{/* values here */})
```

## Union Discrimination

Use the `Type` field to determine which variant is active, then access the corresponding field:

```go
switch appendAgentEvalTrialsPrefillThink.Type {
	case operations.AppendAgentEvalTrialsPrefillThinkTypeBoolean:
		// appendAgentEvalTrialsPrefillThink.Boolean is populated
	case operations.AppendAgentEvalTrialsPrefillThinkTypeStr:
		// appendAgentEvalTrialsPrefillThink.Str is populated
	default:
		// Unknown type - use appendAgentEvalTrialsPrefillThink.GetUnknownRaw() for raw JSON
}
```
