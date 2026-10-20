# VectorStoreFileContentAttributes


## Supported Types

### 

```go
vectorStoreFileContentAttributes := components.CreateVectorStoreFileContentAttributesStr(string{/* values here */})
```

### 

```go
vectorStoreFileContentAttributes := components.CreateVectorStoreFileContentAttributesBoolean(bool{/* values here */})
```

### 

```go
vectorStoreFileContentAttributes := components.CreateVectorStoreFileContentAttributesNumber(float64{/* values here */})
```

## Union Discrimination

Use the `Type` field to determine which variant is active, then access the corresponding field:

```go
switch vectorStoreFileContentAttributes.Type {
	case components.VectorStoreFileContentAttributesTypeStr:
		// vectorStoreFileContentAttributes.Str is populated
	case components.VectorStoreFileContentAttributesTypeBoolean:
		// vectorStoreFileContentAttributes.Boolean is populated
	case components.VectorStoreFileContentAttributesTypeNumber:
		// vectorStoreFileContentAttributes.Number is populated
	default:
		// Unknown type - use vectorStoreFileContentAttributes.GetUnknownRaw() for raw JSON
}
```
