# ListEvalSuiteLeaderboardRunsStop


## Supported Types

### 

```go
listEvalSuiteLeaderboardRunsStop := operations.CreateListEvalSuiteLeaderboardRunsStopStr(string{/* values here */})
```

### 

```go
listEvalSuiteLeaderboardRunsStop := operations.CreateListEvalSuiteLeaderboardRunsStopArrayOfStr([]string{/* values here */})
```

## Union Discrimination

Use the `Type` field to determine which variant is active, then access the corresponding field:

```go
switch listEvalSuiteLeaderboardRunsStop.Type {
	case operations.ListEvalSuiteLeaderboardRunsStopTypeStr:
		// listEvalSuiteLeaderboardRunsStop.Str is populated
	case operations.ListEvalSuiteLeaderboardRunsStopTypeArrayOfStr:
		// listEvalSuiteLeaderboardRunsStop.ArrayOfStr is populated
	default:
		// Unknown type - use listEvalSuiteLeaderboardRunsStop.GetUnknownRaw() for raw JSON
}
```
