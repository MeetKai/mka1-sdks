# ListVectorStoreConnectorsChunkingStrategyUnion


## Supported Types

### ListVectorStoreConnectorsChunkingStrategy1

```go
listVectorStoreConnectorsChunkingStrategyUnion := operations.CreateListVectorStoreConnectorsChunkingStrategyUnionAuto(operations.ListVectorStoreConnectorsChunkingStrategy1{/* values here */})
```

### ListVectorStoreConnectorsChunkingStrategy2

```go
listVectorStoreConnectorsChunkingStrategyUnion := operations.CreateListVectorStoreConnectorsChunkingStrategyUnionStatic(operations.ListVectorStoreConnectorsChunkingStrategy2{/* values here */})
```

## Union Discrimination

Use the `Type` field to determine which variant is active, then access the corresponding field:

```go
switch listVectorStoreConnectorsChunkingStrategyUnion.Type {
	case operations.ListVectorStoreConnectorsChunkingStrategyUnionTypeAuto:
		// listVectorStoreConnectorsChunkingStrategyUnion.ListVectorStoreConnectorsChunkingStrategy1 is populated
	case operations.ListVectorStoreConnectorsChunkingStrategyUnionTypeStatic:
		// listVectorStoreConnectorsChunkingStrategyUnion.ListVectorStoreConnectorsChunkingStrategy2 is populated
	default:
		// Unknown type - use listVectorStoreConnectorsChunkingStrategyUnion.GetUnknownRaw() for raw JSON
}
```
