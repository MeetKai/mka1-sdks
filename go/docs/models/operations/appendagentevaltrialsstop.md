# AppendAgentEvalTrialsStop


## Supported Types

### 

```go
appendAgentEvalTrialsStop := operations.CreateAppendAgentEvalTrialsStopStr(string{/* values here */})
```

### 

```go
appendAgentEvalTrialsStop := operations.CreateAppendAgentEvalTrialsStopArrayOfStr([]string{/* values here */})
```

## Union Discrimination

Use the `Type` field to determine which variant is active, then access the corresponding field:

```go
switch appendAgentEvalTrialsStop.Type {
	case operations.AppendAgentEvalTrialsStopTypeStr:
		// appendAgentEvalTrialsStop.Str is populated
	case operations.AppendAgentEvalTrialsStopTypeArrayOfStr:
		// appendAgentEvalTrialsStop.ArrayOfStr is populated
	default:
		// Unknown type - use appendAgentEvalTrialsStop.GetUnknownRaw() for raw JSON
}
```
