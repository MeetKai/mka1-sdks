# Properties


## Supported Types

### 

```go
properties := components.CreatePropertiesStr(string{/* values here */})
```

### 

```go
properties := components.CreatePropertiesNumber(float64{/* values here */})
```

### 

```go
properties := components.CreatePropertiesBoolean(bool{/* values here */})
```

## Union Discrimination

Use the `Type` field to determine which variant is active, then access the corresponding field:

```go
switch properties.Type {
	case components.PropertiesTypeStr:
		// properties.Str is populated
	case components.PropertiesTypeNumber:
		// properties.Number is populated
	case components.PropertiesTypeBoolean:
		// properties.Boolean is populated
	default:
		// Unknown type - use properties.GetUnknownRaw() for raw JSON
}
```
