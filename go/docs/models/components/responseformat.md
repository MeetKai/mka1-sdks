# ResponseFormat


## Supported Types

### TextResponseFormat

```go
responseFormat := components.CreateResponseFormatText(components.TextResponseFormat{/* values here */})
```

### JSONSchemaResponseFormat

```go
responseFormat := components.CreateResponseFormatJSONSchema(components.JSONSchemaResponseFormat{/* values here */})
```

### JSONObjectResponseFormat

```go
responseFormat := components.CreateResponseFormatJSONObject(components.JSONObjectResponseFormat{/* values here */})
```

## Union Discrimination

Use the `Type` field to determine which variant is active, then access the corresponding field:

```go
switch responseFormat.Type {
	case components.ResponseFormatTypeText:
		// responseFormat.TextResponseFormat is populated
	case components.ResponseFormatTypeJSONSchema:
		// responseFormat.JSONSchemaResponseFormat is populated
	case components.ResponseFormatTypeJSONObject:
		// responseFormat.JSONObjectResponseFormat is populated
	default:
		// Unknown type - use responseFormat.GetUnknownRaw() for raw JSON
}
```
