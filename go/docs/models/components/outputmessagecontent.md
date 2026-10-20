# OutputMessageContent


## Supported Types

### OutputText

```go
outputMessageContent := components.CreateOutputMessageContentOutputText(components.OutputText{/* values here */})
```

### Refusal

```go
outputMessageContent := components.CreateOutputMessageContentRefusal(components.Refusal{/* values here */})
```

## Union Discrimination

Use the `Type` field to determine which variant is active, then access the corresponding field:

```go
switch outputMessageContent.Type {
	case components.OutputMessageContentTypeOutputText:
		// outputMessageContent.OutputText is populated
	case components.OutputMessageContentTypeRefusal:
		// outputMessageContent.Refusal is populated
	default:
		// Unknown type - use outputMessageContent.GetUnknownRaw() for raw JSON
}
```
