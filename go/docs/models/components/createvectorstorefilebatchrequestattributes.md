# CreateVectorStoreFileBatchRequestAttributes


## Supported Types

### 

```go
createVectorStoreFileBatchRequestAttributes := components.CreateCreateVectorStoreFileBatchRequestAttributesStr(string{/* values here */})
```

### 

```go
createVectorStoreFileBatchRequestAttributes := components.CreateCreateVectorStoreFileBatchRequestAttributesBoolean(bool{/* values here */})
```

### 

```go
createVectorStoreFileBatchRequestAttributes := components.CreateCreateVectorStoreFileBatchRequestAttributesNumber(float64{/* values here */})
```

## Union Discrimination

Use the `Type` field to determine which variant is active, then access the corresponding field:

```go
switch createVectorStoreFileBatchRequestAttributes.Type {
	case components.CreateVectorStoreFileBatchRequestAttributesTypeStr:
		// createVectorStoreFileBatchRequestAttributes.Str is populated
	case components.CreateVectorStoreFileBatchRequestAttributesTypeBoolean:
		// createVectorStoreFileBatchRequestAttributes.Boolean is populated
	case components.CreateVectorStoreFileBatchRequestAttributesTypeNumber:
		// createVectorStoreFileBatchRequestAttributes.Number is populated
}
```
