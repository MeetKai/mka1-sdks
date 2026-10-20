# ResponseContentPartAddedEventPart


## Supported Types

### OutputText

```go
responseContentPartAddedEventPart := components.CreateResponseContentPartAddedEventPartOutputText(components.OutputText{/* values here */})
```

### Refusal

```go
responseContentPartAddedEventPart := components.CreateResponseContentPartAddedEventPartRefusal(components.Refusal{/* values here */})
```

### ReasoningText

```go
responseContentPartAddedEventPart := components.CreateResponseContentPartAddedEventPartReasoningText(components.ReasoningText{/* values here */})
```

## Union Discrimination

Use the `Type` field to determine which variant is active, then access the corresponding field:

```go
switch responseContentPartAddedEventPart.Type {
	case components.ResponseContentPartAddedEventPartTypeOutputText:
		// responseContentPartAddedEventPart.OutputText is populated
	case components.ResponseContentPartAddedEventPartTypeRefusal:
		// responseContentPartAddedEventPart.Refusal is populated
	case components.ResponseContentPartAddedEventPartTypeReasoningText:
		// responseContentPartAddedEventPart.ReasoningText is populated
	default:
		// Unknown type - use responseContentPartAddedEventPart.GetUnknownRaw() for raw JSON
}
```
