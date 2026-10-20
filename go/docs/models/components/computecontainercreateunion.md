# ComputeContainerCreateUnion


## Supported Types

### ComputeContainerCreate1

```go
computeContainerCreateUnion := components.CreateComputeContainerCreateUnionComputeContainerCreate1(components.ComputeContainerCreate1{/* values here */})
```

### ComputeContainerCreate2

```go
computeContainerCreateUnion := components.CreateComputeContainerCreateUnionComputeContainerCreate2(components.ComputeContainerCreate2{/* values here */})
```

## Union Discrimination

Use the `Type` field to determine which variant is active, then access the corresponding field:

```go
switch computeContainerCreateUnion.Type {
	case components.ComputeContainerCreateUnionTypeComputeContainerCreate1:
		// computeContainerCreateUnion.ComputeContainerCreate1 is populated
	case components.ComputeContainerCreateUnionTypeComputeContainerCreate2:
		// computeContainerCreateUnion.ComputeContainerCreate2 is populated
}
```
