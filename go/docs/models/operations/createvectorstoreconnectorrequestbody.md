# CreateVectorStoreConnectorRequestBody


## Supported Types

### CreateVectorStoreConnectorRequestBody1

```go
createVectorStoreConnectorRequestBody := operations.CreateCreateVectorStoreConnectorRequestBodyS3(operations.CreateVectorStoreConnectorRequestBody1{/* values here */})
```

### CreateVectorStoreConnectorRequestBody2

```go
createVectorStoreConnectorRequestBody := operations.CreateCreateVectorStoreConnectorRequestBodySharepoint(operations.CreateVectorStoreConnectorRequestBody2{/* values here */})
```

## Union Discrimination

Use the `Type` field to determine which variant is active, then access the corresponding field:

```go
switch createVectorStoreConnectorRequestBody.Type {
	case operations.CreateVectorStoreConnectorRequestBodyTypeS3:
		// createVectorStoreConnectorRequestBody.CreateVectorStoreConnectorRequestBody1 is populated
	case operations.CreateVectorStoreConnectorRequestBodyTypeSharepoint:
		// createVectorStoreConnectorRequestBody.CreateVectorStoreConnectorRequestBody2 is populated
}
```
