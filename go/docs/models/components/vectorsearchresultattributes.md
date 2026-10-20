# VectorSearchResultAttributes


## Supported Types

### 

```go
vectorSearchResultAttributes := components.CreateVectorSearchResultAttributesStr(string{/* values here */})
```

### 

```go
vectorSearchResultAttributes := components.CreateVectorSearchResultAttributesBoolean(bool{/* values here */})
```

### 

```go
vectorSearchResultAttributes := components.CreateVectorSearchResultAttributesNumber(float64{/* values here */})
```

## Union Discrimination

Use the `Type` field to determine which variant is active, then access the corresponding field:

```go
switch vectorSearchResultAttributes.Type {
	case components.VectorSearchResultAttributesTypeStr:
		// vectorSearchResultAttributes.Str is populated
	case components.VectorSearchResultAttributesTypeBoolean:
		// vectorSearchResultAttributes.Boolean is populated
	case components.VectorSearchResultAttributesTypeNumber:
		// vectorSearchResultAttributes.Number is populated
	default:
		// Unknown type - use vectorSearchResultAttributes.GetUnknownRaw() for raw JSON
}
```
