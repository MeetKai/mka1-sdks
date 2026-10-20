# CancelEvalRunStop


## Supported Types

### 

```go
cancelEvalRunStop := operations.CreateCancelEvalRunStopStr(string{/* values here */})
```

### 

```go
cancelEvalRunStop := operations.CreateCancelEvalRunStopArrayOfStr([]string{/* values here */})
```

## Union Discrimination

Use the `Type` field to determine which variant is active, then access the corresponding field:

```go
switch cancelEvalRunStop.Type {
	case operations.CancelEvalRunStopTypeStr:
		// cancelEvalRunStop.Str is populated
	case operations.CancelEvalRunStopTypeArrayOfStr:
		// cancelEvalRunStop.ArrayOfStr is populated
	default:
		// Unknown type - use cancelEvalRunStop.GetUnknownRaw() for raw JSON
}
```
