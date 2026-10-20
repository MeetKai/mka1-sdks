# ListEvalRunsPrefillThink


## Supported Types

### 

```go
listEvalRunsPrefillThink := operations.CreateListEvalRunsPrefillThinkBoolean(bool{/* values here */})
```

### 

```go
listEvalRunsPrefillThink := operations.CreateListEvalRunsPrefillThinkStr(string{/* values here */})
```

## Union Discrimination

Use the `Type` field to determine which variant is active, then access the corresponding field:

```go
switch listEvalRunsPrefillThink.Type {
	case operations.ListEvalRunsPrefillThinkTypeBoolean:
		// listEvalRunsPrefillThink.Boolean is populated
	case operations.ListEvalRunsPrefillThinkTypeStr:
		// listEvalRunsPrefillThink.Str is populated
	default:
		// Unknown type - use listEvalRunsPrefillThink.GetUnknownRaw() for raw JSON
}
```
