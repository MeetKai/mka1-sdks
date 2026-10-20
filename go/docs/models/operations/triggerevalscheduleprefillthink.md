# TriggerEvalSchedulePrefillThink


## Supported Types

### 

```go
triggerEvalSchedulePrefillThink := operations.CreateTriggerEvalSchedulePrefillThinkBoolean(bool{/* values here */})
```

### 

```go
triggerEvalSchedulePrefillThink := operations.CreateTriggerEvalSchedulePrefillThinkStr(string{/* values here */})
```

## Union Discrimination

Use the `Type` field to determine which variant is active, then access the corresponding field:

```go
switch triggerEvalSchedulePrefillThink.Type {
	case operations.TriggerEvalSchedulePrefillThinkTypeBoolean:
		// triggerEvalSchedulePrefillThink.Boolean is populated
	case operations.TriggerEvalSchedulePrefillThinkTypeStr:
		// triggerEvalSchedulePrefillThink.Str is populated
	default:
		// Unknown type - use triggerEvalSchedulePrefillThink.GetUnknownRaw() for raw JSON
}
```
