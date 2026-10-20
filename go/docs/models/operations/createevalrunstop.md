# CreateEvalRunStop


## Supported Types

### 

```go
createEvalRunStop := operations.CreateCreateEvalRunStopStr(string{/* values here */})
```

### 

```go
createEvalRunStop := operations.CreateCreateEvalRunStopArrayOfStr([]string{/* values here */})
```

## Union Discrimination

Use the `Type` field to determine which variant is active, then access the corresponding field:

```go
switch createEvalRunStop.Type {
	case operations.CreateEvalRunStopTypeStr:
		// createEvalRunStop.Str is populated
	case operations.CreateEvalRunStopTypeArrayOfStr:
		// createEvalRunStop.ArrayOfStr is populated
	default:
		// Unknown type - use createEvalRunStop.GetUnknownRaw() for raw JSON
}
```
