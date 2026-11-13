# ChunkingStrategyRequestUnion1


## Supported Types

### ChunkingStrategyRequest1

```go
chunkingStrategyRequestUnion1 := operations.CreateChunkingStrategyRequestUnion1Auto(operations.ChunkingStrategyRequest1{/* values here */})
```

### ChunkingStrategyRequest2

```go
chunkingStrategyRequestUnion1 := operations.CreateChunkingStrategyRequestUnion1Static(operations.ChunkingStrategyRequest2{/* values here */})
```

## Union Discrimination

Use the `Type` field to determine which variant is active, then access the corresponding field:

```go
switch chunkingStrategyRequestUnion1.Type {
	case operations.ChunkingStrategyRequestUnion1TypeAuto:
		// chunkingStrategyRequestUnion1.ChunkingStrategyRequest1 is populated
	case operations.ChunkingStrategyRequestUnion1TypeStatic:
		// chunkingStrategyRequestUnion1.ChunkingStrategyRequest2 is populated
}
```
