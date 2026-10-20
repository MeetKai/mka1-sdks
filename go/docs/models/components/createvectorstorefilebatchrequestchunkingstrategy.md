# CreateVectorStoreFileBatchRequestChunkingStrategy

Batch-wide default chunking strategy, applied to every file that does not carry its own (a 'files' entry's chunking_strategy overrides this).


## Supported Types

### AutoChunkingStrategy

```go
createVectorStoreFileBatchRequestChunkingStrategy := components.CreateCreateVectorStoreFileBatchRequestChunkingStrategyAuto(components.AutoChunkingStrategy{/* values here */})
```

### StaticChunkingStrategy

```go
createVectorStoreFileBatchRequestChunkingStrategy := components.CreateCreateVectorStoreFileBatchRequestChunkingStrategyStatic(components.StaticChunkingStrategy{/* values here */})
```

## Union Discrimination

Use the `Type` field to determine which variant is active, then access the corresponding field:

```go
switch createVectorStoreFileBatchRequestChunkingStrategy.Type {
	case components.CreateVectorStoreFileBatchRequestChunkingStrategyTypeAuto:
		// createVectorStoreFileBatchRequestChunkingStrategy.AutoChunkingStrategy is populated
	case components.CreateVectorStoreFileBatchRequestChunkingStrategyTypeStatic:
		// createVectorStoreFileBatchRequestChunkingStrategy.StaticChunkingStrategy is populated
}
```
