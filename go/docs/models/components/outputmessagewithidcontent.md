# OutputMessageWithIDContent


## Supported Types

### OutputText

```go
outputMessageWithIDContent := components.CreateOutputMessageWithIDContentOutputText(components.OutputText{/* values here */})
```

### Refusal

```go
outputMessageWithIDContent := components.CreateOutputMessageWithIDContentRefusal(components.Refusal{/* values here */})
```

## Union Discrimination

Use the `Type` field to determine which variant is active, then access the corresponding field:

```go
switch outputMessageWithIDContent.Type {
	case components.OutputMessageWithIDContentTypeOutputText:
		// outputMessageWithIDContent.OutputText is populated
	case components.OutputMessageWithIDContentTypeRefusal:
		// outputMessageWithIDContent.Refusal is populated
	default:
		// Unknown type - use outputMessageWithIDContent.GetUnknownRaw() for raw JSON
}
```
