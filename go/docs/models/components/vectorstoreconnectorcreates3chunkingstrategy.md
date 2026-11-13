# VectorStoreConnectorCreateS3ChunkingStrategy


## Supported Types

### VectorStoreConnectorAutoChunking

```go
vectorStoreConnectorCreateS3ChunkingStrategy := components.CreateVectorStoreConnectorCreateS3ChunkingStrategyAuto(components.VectorStoreConnectorAutoChunking{/* values here */})
```

### VectorStoreConnectorStaticChunking

```go
vectorStoreConnectorCreateS3ChunkingStrategy := components.CreateVectorStoreConnectorCreateS3ChunkingStrategyStatic(components.VectorStoreConnectorStaticChunking{/* values here */})
```

## Union Discrimination

Use the `Type` field to determine which variant is active, then access the corresponding field:

```go
switch vectorStoreConnectorCreateS3ChunkingStrategy.Type {
	case components.VectorStoreConnectorCreateS3ChunkingStrategyTypeAuto:
		// vectorStoreConnectorCreateS3ChunkingStrategy.VectorStoreConnectorAutoChunking is populated
	case components.VectorStoreConnectorCreateS3ChunkingStrategyTypeStatic:
		// vectorStoreConnectorCreateS3ChunkingStrategy.VectorStoreConnectorStaticChunking is populated
}
```
