# CustomToolFormat


## Supported Types

### TextFormat

```go
customToolFormat := components.CreateCustomToolFormatText(components.TextFormat{/* values here */})
```

### GrammarFormat

```go
customToolFormat := components.CreateCustomToolFormatGrammar(components.GrammarFormat{/* values here */})
```

## Union Discrimination

Use the `Type` field to determine which variant is active, then access the corresponding field:

```go
switch customToolFormat.Type {
	case components.CustomToolFormatTypeText:
		// customToolFormat.TextFormat is populated
	case components.CustomToolFormatTypeGrammar:
		// customToolFormat.GrammarFormat is populated
	default:
		// Unknown type - use customToolFormat.GetUnknownRaw() for raw JSON
}
```
