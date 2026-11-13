# GetVectorStoreConnectorChunkingStrategyUnion


## Supported Types

### GetVectorStoreConnectorChunkingStrategy1

```go
getVectorStoreConnectorChunkingStrategyUnion := operations.CreateGetVectorStoreConnectorChunkingStrategyUnionAuto(operations.GetVectorStoreConnectorChunkingStrategy1{/* values here */})
```

### GetVectorStoreConnectorChunkingStrategy2

```go
getVectorStoreConnectorChunkingStrategyUnion := operations.CreateGetVectorStoreConnectorChunkingStrategyUnionStatic(operations.GetVectorStoreConnectorChunkingStrategy2{/* values here */})
```

## Union Discrimination

Use the `Type` field to determine which variant is active, then access the corresponding field:

```go
switch getVectorStoreConnectorChunkingStrategyUnion.Type {
	case operations.GetVectorStoreConnectorChunkingStrategyUnionTypeAuto:
		// getVectorStoreConnectorChunkingStrategyUnion.GetVectorStoreConnectorChunkingStrategy1 is populated
	case operations.GetVectorStoreConnectorChunkingStrategyUnionTypeStatic:
		// getVectorStoreConnectorChunkingStrategyUnion.GetVectorStoreConnectorChunkingStrategy2 is populated
	default:
		// Unknown type - use getVectorStoreConnectorChunkingStrategyUnion.GetUnknownRaw() for raw JSON
}
```
