# ResponseContentPartDoneEventPart


## Supported Types

### OutputText

```go
responseContentPartDoneEventPart := components.CreateResponseContentPartDoneEventPartOutputText(components.OutputText{/* values here */})
```

### Refusal

```go
responseContentPartDoneEventPart := components.CreateResponseContentPartDoneEventPartRefusal(components.Refusal{/* values here */})
```

### ReasoningText

```go
responseContentPartDoneEventPart := components.CreateResponseContentPartDoneEventPartReasoningText(components.ReasoningText{/* values here */})
```

## Union Discrimination

Use the `Type` field to determine which variant is active, then access the corresponding field:

```go
switch responseContentPartDoneEventPart.Type {
	case components.ResponseContentPartDoneEventPartTypeOutputText:
		// responseContentPartDoneEventPart.OutputText is populated
	case components.ResponseContentPartDoneEventPartTypeRefusal:
		// responseContentPartDoneEventPart.Refusal is populated
	case components.ResponseContentPartDoneEventPartTypeReasoningText:
		// responseContentPartDoneEventPart.ReasoningText is populated
	default:
		// Unknown type - use responseContentPartDoneEventPart.GetUnknownRaw() for raw JSON
}
```
