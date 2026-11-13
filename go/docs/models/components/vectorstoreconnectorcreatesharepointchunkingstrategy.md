# VectorStoreConnectorCreateSharePointChunkingStrategy


## Supported Types

### VectorStoreConnectorAutoChunking

```go
vectorStoreConnectorCreateSharePointChunkingStrategy := components.CreateVectorStoreConnectorCreateSharePointChunkingStrategyAuto(components.VectorStoreConnectorAutoChunking{/* values here */})
```

### VectorStoreConnectorStaticChunking

```go
vectorStoreConnectorCreateSharePointChunkingStrategy := components.CreateVectorStoreConnectorCreateSharePointChunkingStrategyStatic(components.VectorStoreConnectorStaticChunking{/* values here */})
```

## Union Discrimination

Use the `Type` field to determine which variant is active, then access the corresponding field:

```go
switch vectorStoreConnectorCreateSharePointChunkingStrategy.Type {
	case components.VectorStoreConnectorCreateSharePointChunkingStrategyTypeAuto:
		// vectorStoreConnectorCreateSharePointChunkingStrategy.VectorStoreConnectorAutoChunking is populated
	case components.VectorStoreConnectorCreateSharePointChunkingStrategyTypeStatic:
		// vectorStoreConnectorCreateSharePointChunkingStrategy.VectorStoreConnectorStaticChunking is populated
}
```
