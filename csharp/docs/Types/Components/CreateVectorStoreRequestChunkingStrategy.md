# CreateVectorStoreRequestChunkingStrategy

The chunking strategy used to chunk the file(s). If not set, will use the auto strategy. Only applicable if file_ids is non-empty.


## Supported Types

### Auto

```csharp
CreateVectorStoreRequestChunkingStrategy.CreateAuto(/* values here */);
```

### Static

```csharp
CreateVectorStoreRequestChunkingStrategy.CreateStatic(/* values here */);
```
