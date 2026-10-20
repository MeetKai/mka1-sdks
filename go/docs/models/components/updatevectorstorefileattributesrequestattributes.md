# UpdateVectorStoreFileAttributesRequestAttributes


## Supported Types

### 

```go
updateVectorStoreFileAttributesRequestAttributes := components.CreateUpdateVectorStoreFileAttributesRequestAttributesStr(string{/* values here */})
```

### 

```go
updateVectorStoreFileAttributesRequestAttributes := components.CreateUpdateVectorStoreFileAttributesRequestAttributesBoolean(bool{/* values here */})
```

### 

```go
updateVectorStoreFileAttributesRequestAttributes := components.CreateUpdateVectorStoreFileAttributesRequestAttributesNumber(float64{/* values here */})
```

## Union Discrimination

Use the `Type` field to determine which variant is active, then access the corresponding field:

```go
switch updateVectorStoreFileAttributesRequestAttributes.Type {
	case components.UpdateVectorStoreFileAttributesRequestAttributesTypeStr:
		// updateVectorStoreFileAttributesRequestAttributes.Str is populated
	case components.UpdateVectorStoreFileAttributesRequestAttributesTypeBoolean:
		// updateVectorStoreFileAttributesRequestAttributes.Boolean is populated
	case components.UpdateVectorStoreFileAttributesRequestAttributesTypeNumber:
		// updateVectorStoreFileAttributesRequestAttributes.Number is populated
}
```
