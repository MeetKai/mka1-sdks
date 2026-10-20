# ListEvalSuiteLeaderboardRunsPrefillThink


## Supported Types

### 

```go
listEvalSuiteLeaderboardRunsPrefillThink := operations.CreateListEvalSuiteLeaderboardRunsPrefillThinkBoolean(bool{/* values here */})
```

### 

```go
listEvalSuiteLeaderboardRunsPrefillThink := operations.CreateListEvalSuiteLeaderboardRunsPrefillThinkStr(string{/* values here */})
```

## Union Discrimination

Use the `Type` field to determine which variant is active, then access the corresponding field:

```go
switch listEvalSuiteLeaderboardRunsPrefillThink.Type {
	case operations.ListEvalSuiteLeaderboardRunsPrefillThinkTypeBoolean:
		// listEvalSuiteLeaderboardRunsPrefillThink.Boolean is populated
	case operations.ListEvalSuiteLeaderboardRunsPrefillThinkTypeStr:
		// listEvalSuiteLeaderboardRunsPrefillThink.Str is populated
	default:
		// Unknown type - use listEvalSuiteLeaderboardRunsPrefillThink.GetUnknownRaw() for raw JSON
}
```
