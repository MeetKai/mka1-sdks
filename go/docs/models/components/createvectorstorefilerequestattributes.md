# CreateVectorStoreFileRequestAttributes


## Supported Types

### 

```go
createVectorStoreFileRequestAttributes := components.CreateCreateVectorStoreFileRequestAttributesStr(string{/* values here */})
```

### 

```go
createVectorStoreFileRequestAttributes := components.CreateCreateVectorStoreFileRequestAttributesBoolean(bool{/* values here */})
```

### 

```go
createVectorStoreFileRequestAttributes := components.CreateCreateVectorStoreFileRequestAttributesNumber(float64{/* values here */})
```

## Union Discrimination

Use the `Type` field to determine which variant is active, then access the corresponding field:

```go
switch createVectorStoreFileRequestAttributes.Type {
	case components.CreateVectorStoreFileRequestAttributesTypeStr:
		// createVectorStoreFileRequestAttributes.Str is populated
	case components.CreateVectorStoreFileRequestAttributesTypeBoolean:
		// createVectorStoreFileRequestAttributes.Boolean is populated
	case components.CreateVectorStoreFileRequestAttributesTypeNumber:
		// createVectorStoreFileRequestAttributes.Number is populated
}
```
