# RerunFailedEvalSamplesPrefillThink


## Supported Types

### 

```go
rerunFailedEvalSamplesPrefillThink := operations.CreateRerunFailedEvalSamplesPrefillThinkBoolean(bool{/* values here */})
```

### 

```go
rerunFailedEvalSamplesPrefillThink := operations.CreateRerunFailedEvalSamplesPrefillThinkStr(string{/* values here */})
```

## Union Discrimination

Use the `Type` field to determine which variant is active, then access the corresponding field:

```go
switch rerunFailedEvalSamplesPrefillThink.Type {
	case operations.RerunFailedEvalSamplesPrefillThinkTypeBoolean:
		// rerunFailedEvalSamplesPrefillThink.Boolean is populated
	case operations.RerunFailedEvalSamplesPrefillThinkTypeStr:
		// rerunFailedEvalSamplesPrefillThink.Str is populated
	default:
		// Unknown type - use rerunFailedEvalSamplesPrefillThink.GetUnknownRaw() for raw JSON
}
```
