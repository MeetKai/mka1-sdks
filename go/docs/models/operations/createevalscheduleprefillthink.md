# CreateEvalSchedulePrefillThink


## Supported Types

### 

```go
createEvalSchedulePrefillThink := operations.CreateCreateEvalSchedulePrefillThinkBoolean(bool{/* values here */})
```

### 

```go
createEvalSchedulePrefillThink := operations.CreateCreateEvalSchedulePrefillThinkStr(string{/* values here */})
```

## Union Discrimination

Use the `Type` field to determine which variant is active, then access the corresponding field:

```go
switch createEvalSchedulePrefillThink.Type {
	case operations.CreateEvalSchedulePrefillThinkTypeBoolean:
		// createEvalSchedulePrefillThink.Boolean is populated
	case operations.CreateEvalSchedulePrefillThinkTypeStr:
		// createEvalSchedulePrefillThink.Str is populated
	default:
		// Unknown type - use createEvalSchedulePrefillThink.GetUnknownRaw() for raw JSON
}
```
