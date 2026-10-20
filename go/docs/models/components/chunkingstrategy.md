# ChunkingStrategy


## Supported Types

### AutoChunkingStrategy

```go
chunkingStrategy := components.CreateChunkingStrategyAuto(components.AutoChunkingStrategy{/* values here */})
```

### StaticChunkingStrategy

```go
chunkingStrategy := components.CreateChunkingStrategyStatic(components.StaticChunkingStrategy{/* values here */})
```

### OtherChunkingStrategy

```go
chunkingStrategy := components.CreateChunkingStrategyOther(components.OtherChunkingStrategy{/* values here */})
```

## Union Discrimination

Use the `Type` field to determine which variant is active, then access the corresponding field:

```go
switch chunkingStrategy.Type {
	case components.ChunkingStrategyTypeAuto:
		// chunkingStrategy.AutoChunkingStrategy is populated
	case components.ChunkingStrategyTypeStatic:
		// chunkingStrategy.StaticChunkingStrategy is populated
	case components.ChunkingStrategyTypeOther:
		// chunkingStrategy.OtherChunkingStrategy is populated
	default:
		// Unknown type - use chunkingStrategy.GetUnknownRaw() for raw JSON
}
```
