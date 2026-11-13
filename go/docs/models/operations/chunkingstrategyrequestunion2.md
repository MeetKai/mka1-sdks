# ChunkingStrategyRequestUnion2


## Supported Types

### ChunkingStrategyRequest3

```go
chunkingStrategyRequestUnion2 := operations.CreateChunkingStrategyRequestUnion2Auto(operations.ChunkingStrategyRequest3{/* values here */})
```

### ChunkingStrategyRequest4

```go
chunkingStrategyRequestUnion2 := operations.CreateChunkingStrategyRequestUnion2Static(operations.ChunkingStrategyRequest4{/* values here */})
```

## Union Discrimination

Use the `Type` field to determine which variant is active, then access the corresponding field:

```go
switch chunkingStrategyRequestUnion2.Type {
	case operations.ChunkingStrategyRequestUnion2TypeAuto:
		// chunkingStrategyRequestUnion2.ChunkingStrategyRequest3 is populated
	case operations.ChunkingStrategyRequestUnion2TypeStatic:
		// chunkingStrategyRequestUnion2.ChunkingStrategyRequest4 is populated
}
```
