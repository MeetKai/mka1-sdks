# FileWithMetadataChunkingStrategy

Optional chunking strategy for this specific file.


## Supported Types

### AutoChunkingStrategy

```go
fileWithMetadataChunkingStrategy := components.CreateFileWithMetadataChunkingStrategyAuto(components.AutoChunkingStrategy{/* values here */})
```

### StaticChunkingStrategy

```go
fileWithMetadataChunkingStrategy := components.CreateFileWithMetadataChunkingStrategyStatic(components.StaticChunkingStrategy{/* values here */})
```

## Union Discrimination

Use the `Type` field to determine which variant is active, then access the corresponding field:

```go
switch fileWithMetadataChunkingStrategy.Type {
	case components.FileWithMetadataChunkingStrategyTypeAuto:
		// fileWithMetadataChunkingStrategy.AutoChunkingStrategy is populated
	case components.FileWithMetadataChunkingStrategyTypeStatic:
		// fileWithMetadataChunkingStrategy.StaticChunkingStrategy is populated
}
```
