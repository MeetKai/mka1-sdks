# VectorStoreConnectorChunkingStrategy


## Supported Types

### VectorStoreConnectorAutoChunking

```go
vectorStoreConnectorChunkingStrategy := components.CreateVectorStoreConnectorChunkingStrategyAuto(components.VectorStoreConnectorAutoChunking{/* values here */})
```

### VectorStoreConnectorStaticChunking

```go
vectorStoreConnectorChunkingStrategy := components.CreateVectorStoreConnectorChunkingStrategyStatic(components.VectorStoreConnectorStaticChunking{/* values here */})
```

## Union Discrimination

Use the `Type` field to determine which variant is active, then access the corresponding field:

```go
switch vectorStoreConnectorChunkingStrategy.Type {
	case components.VectorStoreConnectorChunkingStrategyTypeAuto:
		// vectorStoreConnectorChunkingStrategy.VectorStoreConnectorAutoChunking is populated
	case components.VectorStoreConnectorChunkingStrategyTypeStatic:
		// vectorStoreConnectorChunkingStrategy.VectorStoreConnectorStaticChunking is populated
	default:
		// Unknown type - use vectorStoreConnectorChunkingStrategy.GetUnknownRaw() for raw JSON
}
```
