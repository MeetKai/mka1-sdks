# VectorStoreFileAttributes


## Supported Types

### 

```go
vectorStoreFileAttributes := components.CreateVectorStoreFileAttributesStr(string{/* values here */})
```

### 

```go
vectorStoreFileAttributes := components.CreateVectorStoreFileAttributesBoolean(bool{/* values here */})
```

### 

```go
vectorStoreFileAttributes := components.CreateVectorStoreFileAttributesNumber(float64{/* values here */})
```

## Union Discrimination

Use the `Type` field to determine which variant is active, then access the corresponding field:

```go
switch vectorStoreFileAttributes.Type {
	case components.VectorStoreFileAttributesTypeStr:
		// vectorStoreFileAttributes.Str is populated
	case components.VectorStoreFileAttributesTypeBoolean:
		// vectorStoreFileAttributes.Boolean is populated
	case components.VectorStoreFileAttributesTypeNumber:
		// vectorStoreFileAttributes.Number is populated
	default:
		// Unknown type - use vectorStoreFileAttributes.GetUnknownRaw() for raw JSON
}
```
