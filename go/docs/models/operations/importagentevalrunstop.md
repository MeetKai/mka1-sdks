# ImportAgentEvalRunStop


## Supported Types

### 

```go
importAgentEvalRunStop := operations.CreateImportAgentEvalRunStopStr(string{/* values here */})
```

### 

```go
importAgentEvalRunStop := operations.CreateImportAgentEvalRunStopArrayOfStr([]string{/* values here */})
```

## Union Discrimination

Use the `Type` field to determine which variant is active, then access the corresponding field:

```go
switch importAgentEvalRunStop.Type {
	case operations.ImportAgentEvalRunStopTypeStr:
		// importAgentEvalRunStop.Str is populated
	case operations.ImportAgentEvalRunStopTypeArrayOfStr:
		// importAgentEvalRunStop.ArrayOfStr is populated
	default:
		// Unknown type - use importAgentEvalRunStop.GetUnknownRaw() for raw JSON
}
```
