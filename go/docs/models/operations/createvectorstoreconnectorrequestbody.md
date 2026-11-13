# CreateVectorStoreConnectorRequestBody


## Supported Types

### VectorStoreConnectorCreateS3

```go
createVectorStoreConnectorRequestBody := operations.CreateCreateVectorStoreConnectorRequestBodyS3(components.VectorStoreConnectorCreateS3{/* values here */})
```

### VectorStoreConnectorCreateSharePoint

```go
createVectorStoreConnectorRequestBody := operations.CreateCreateVectorStoreConnectorRequestBodySharepoint(components.VectorStoreConnectorCreateSharePoint{/* values here */})
```

## Union Discrimination

Use the `Type` field to determine which variant is active, then access the corresponding field:

```go
switch createVectorStoreConnectorRequestBody.Type {
	case operations.CreateVectorStoreConnectorRequestBodyTypeS3:
		// createVectorStoreConnectorRequestBody.VectorStoreConnectorCreateS3 is populated
	case operations.CreateVectorStoreConnectorRequestBodyTypeSharepoint:
		// createVectorStoreConnectorRequestBody.VectorStoreConnectorCreateSharePoint is populated
}
```
