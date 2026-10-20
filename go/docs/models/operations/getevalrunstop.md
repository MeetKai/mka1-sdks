# GetEvalRunStop


## Supported Types

### 

```go
getEvalRunStop := operations.CreateGetEvalRunStopStr(string{/* values here */})
```

### 

```go
getEvalRunStop := operations.CreateGetEvalRunStopArrayOfStr([]string{/* values here */})
```

## Union Discrimination

Use the `Type` field to determine which variant is active, then access the corresponding field:

```go
switch getEvalRunStop.Type {
	case operations.GetEvalRunStopTypeStr:
		// getEvalRunStop.Str is populated
	case operations.GetEvalRunStopTypeArrayOfStr:
		// getEvalRunStop.ArrayOfStr is populated
	default:
		// Unknown type - use getEvalRunStop.GetUnknownRaw() for raw JSON
}
```
