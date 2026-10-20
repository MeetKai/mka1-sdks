# UpdateCatalogModelRequestHealthCheckUnion


## Supported Types

### UpdateCatalogModelRequestHealthCheck1

```go
updateCatalogModelRequestHealthCheckUnion := components.CreateUpdateCatalogModelRequestHealthCheckUnionOff(components.UpdateCatalogModelRequestHealthCheck1{/* values here */})
```

### UpdateCatalogModelRequestHealthCheck2

```go
updateCatalogModelRequestHealthCheckUnion := components.CreateUpdateCatalogModelRequestHealthCheckUnionPreflight(components.UpdateCatalogModelRequestHealthCheck2{/* values here */})
```

### UpdateCatalogModelRequestHealthCheck3

```go
updateCatalogModelRequestHealthCheckUnion := components.CreateUpdateCatalogModelRequestHealthCheckUnionPeriodic(components.UpdateCatalogModelRequestHealthCheck3{/* values here */})
```

## Union Discrimination

Use the `Type` field to determine which variant is active, then access the corresponding field:

```go
switch updateCatalogModelRequestHealthCheckUnion.Type {
	case components.UpdateCatalogModelRequestHealthCheckUnionTypeOff:
		// updateCatalogModelRequestHealthCheckUnion.UpdateCatalogModelRequestHealthCheck1 is populated
	case components.UpdateCatalogModelRequestHealthCheckUnionTypePreflight:
		// updateCatalogModelRequestHealthCheckUnion.UpdateCatalogModelRequestHealthCheck2 is populated
	case components.UpdateCatalogModelRequestHealthCheckUnionTypePeriodic:
		// updateCatalogModelRequestHealthCheckUnion.UpdateCatalogModelRequestHealthCheck3 is populated
}
```
