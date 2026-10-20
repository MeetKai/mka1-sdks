# ComputeReadinessUnion


## Supported Types

### ComputeReadiness1

```go
computeReadinessUnion := components.CreateComputeReadinessUnionHTTP(components.ComputeReadiness1{/* values here */})
```

### ComputeReadiness2

```go
computeReadinessUnion := components.CreateComputeReadinessUnionTCP(components.ComputeReadiness2{/* values here */})
```

## Union Discrimination

Use the `Type` field to determine which variant is active, then access the corresponding field:

```go
switch computeReadinessUnion.Type {
	case components.ComputeReadinessUnionTypeHTTP:
		// computeReadinessUnion.ComputeReadiness1 is populated
	case components.ComputeReadinessUnionTypeTCP:
		// computeReadinessUnion.ComputeReadiness2 is populated
}
```
