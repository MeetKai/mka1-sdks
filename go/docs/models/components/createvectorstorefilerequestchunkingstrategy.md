# CreateVectorStoreFileRequestChunkingStrategy

The chunking strategy used to chunk the file(s). If not set, will use the auto strategy.


## Supported Types

### AutoChunkingStrategy

```go
createVectorStoreFileRequestChunkingStrategy := components.CreateCreateVectorStoreFileRequestChunkingStrategyAuto(components.AutoChunkingStrategy{/* values here */})
```

### StaticChunkingStrategy

```go
createVectorStoreFileRequestChunkingStrategy := components.CreateCreateVectorStoreFileRequestChunkingStrategyStatic(components.StaticChunkingStrategy{/* values here */})
```

## Union Discrimination

Use the `Type` field to determine which variant is active, then access the corresponding field:

```go
switch createVectorStoreFileRequestChunkingStrategy.Type {
	case components.CreateVectorStoreFileRequestChunkingStrategyTypeAuto:
		// createVectorStoreFileRequestChunkingStrategy.AutoChunkingStrategy is populated
	case components.CreateVectorStoreFileRequestChunkingStrategyTypeStatic:
		// createVectorStoreFileRequestChunkingStrategy.StaticChunkingStrategy is populated
}
```
