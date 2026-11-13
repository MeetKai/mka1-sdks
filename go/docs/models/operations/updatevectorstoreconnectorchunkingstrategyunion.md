# UpdateVectorStoreConnectorChunkingStrategyUnion


## Supported Types

### UpdateVectorStoreConnectorChunkingStrategy1

```go
updateVectorStoreConnectorChunkingStrategyUnion := operations.CreateUpdateVectorStoreConnectorChunkingStrategyUnionAuto(operations.UpdateVectorStoreConnectorChunkingStrategy1{/* values here */})
```

### UpdateVectorStoreConnectorChunkingStrategy2

```go
updateVectorStoreConnectorChunkingStrategyUnion := operations.CreateUpdateVectorStoreConnectorChunkingStrategyUnionStatic(operations.UpdateVectorStoreConnectorChunkingStrategy2{/* values here */})
```

## Union Discrimination

Use the `Type` field to determine which variant is active, then access the corresponding field:

```go
switch updateVectorStoreConnectorChunkingStrategyUnion.Type {
	case operations.UpdateVectorStoreConnectorChunkingStrategyUnionTypeAuto:
		// updateVectorStoreConnectorChunkingStrategyUnion.UpdateVectorStoreConnectorChunkingStrategy1 is populated
	case operations.UpdateVectorStoreConnectorChunkingStrategyUnionTypeStatic:
		// updateVectorStoreConnectorChunkingStrategyUnion.UpdateVectorStoreConnectorChunkingStrategy2 is populated
	default:
		// Unknown type - use updateVectorStoreConnectorChunkingStrategyUnion.GetUnknownRaw() for raw JSON
}
```
