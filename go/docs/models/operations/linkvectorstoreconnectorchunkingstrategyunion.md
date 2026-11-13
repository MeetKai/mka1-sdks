# LinkVectorStoreConnectorChunkingStrategyUnion


## Supported Types

### LinkVectorStoreConnectorChunkingStrategy1

```go
linkVectorStoreConnectorChunkingStrategyUnion := operations.CreateLinkVectorStoreConnectorChunkingStrategyUnionAuto(operations.LinkVectorStoreConnectorChunkingStrategy1{/* values here */})
```

### LinkVectorStoreConnectorChunkingStrategy2

```go
linkVectorStoreConnectorChunkingStrategyUnion := operations.CreateLinkVectorStoreConnectorChunkingStrategyUnionStatic(operations.LinkVectorStoreConnectorChunkingStrategy2{/* values here */})
```

## Union Discrimination

Use the `Type` field to determine which variant is active, then access the corresponding field:

```go
switch linkVectorStoreConnectorChunkingStrategyUnion.Type {
	case operations.LinkVectorStoreConnectorChunkingStrategyUnionTypeAuto:
		// linkVectorStoreConnectorChunkingStrategyUnion.LinkVectorStoreConnectorChunkingStrategy1 is populated
	case operations.LinkVectorStoreConnectorChunkingStrategyUnionTypeStatic:
		// linkVectorStoreConnectorChunkingStrategyUnion.LinkVectorStoreConnectorChunkingStrategy2 is populated
	default:
		// Unknown type - use linkVectorStoreConnectorChunkingStrategyUnion.GetUnknownRaw() for raw JSON
}
```
