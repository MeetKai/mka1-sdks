# CreateVectorStoreRequestChunkingStrategy

The chunking strategy used to chunk the file(s). If not set, will use the auto strategy. Only applicable if file_ids is non-empty.


## Supported Types

### AutoChunkingStrategy

```go
createVectorStoreRequestChunkingStrategy := components.CreateCreateVectorStoreRequestChunkingStrategyAuto(components.AutoChunkingStrategy{/* values here */})
```

### StaticChunkingStrategy

```go
createVectorStoreRequestChunkingStrategy := components.CreateCreateVectorStoreRequestChunkingStrategyStatic(components.StaticChunkingStrategy{/* values here */})
```

## Union Discrimination

Use the `Type` field to determine which variant is active, then access the corresponding field:

```go
switch createVectorStoreRequestChunkingStrategy.Type {
	case components.CreateVectorStoreRequestChunkingStrategyTypeAuto:
		// createVectorStoreRequestChunkingStrategy.AutoChunkingStrategy is populated
	case components.CreateVectorStoreRequestChunkingStrategyTypeStatic:
		// createVectorStoreRequestChunkingStrategy.StaticChunkingStrategy is populated
}
```
