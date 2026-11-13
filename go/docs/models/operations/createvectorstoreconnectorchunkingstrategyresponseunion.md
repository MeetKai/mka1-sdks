# CreateVectorStoreConnectorChunkingStrategyResponseUnion


## Supported Types

### CreateVectorStoreConnectorChunkingStrategyResponse1

```go
createVectorStoreConnectorChunkingStrategyResponseUnion := operations.CreateCreateVectorStoreConnectorChunkingStrategyResponseUnionAuto(operations.CreateVectorStoreConnectorChunkingStrategyResponse1{/* values here */})
```

### CreateVectorStoreConnectorChunkingStrategyResponse2

```go
createVectorStoreConnectorChunkingStrategyResponseUnion := operations.CreateCreateVectorStoreConnectorChunkingStrategyResponseUnionStatic(operations.CreateVectorStoreConnectorChunkingStrategyResponse2{/* values here */})
```

## Union Discrimination

Use the `Type` field to determine which variant is active, then access the corresponding field:

```go
switch createVectorStoreConnectorChunkingStrategyResponseUnion.Type {
	case operations.CreateVectorStoreConnectorChunkingStrategyResponseUnionTypeAuto:
		// createVectorStoreConnectorChunkingStrategyResponseUnion.CreateVectorStoreConnectorChunkingStrategyResponse1 is populated
	case operations.CreateVectorStoreConnectorChunkingStrategyResponseUnionTypeStatic:
		// createVectorStoreConnectorChunkingStrategyResponseUnion.CreateVectorStoreConnectorChunkingStrategyResponse2 is populated
	default:
		// Unknown type - use createVectorStoreConnectorChunkingStrategyResponseUnion.GetUnknownRaw() for raw JSON
}
```
