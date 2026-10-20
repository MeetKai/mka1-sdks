# AddCatalogModelRequestHealthCheckUnion


## Supported Types

### AddCatalogModelRequestHealthCheck1

```go
addCatalogModelRequestHealthCheckUnion := components.CreateAddCatalogModelRequestHealthCheckUnionOff(components.AddCatalogModelRequestHealthCheck1{/* values here */})
```

### AddCatalogModelRequestHealthCheck2

```go
addCatalogModelRequestHealthCheckUnion := components.CreateAddCatalogModelRequestHealthCheckUnionPreflight(components.AddCatalogModelRequestHealthCheck2{/* values here */})
```

### AddCatalogModelRequestHealthCheck3

```go
addCatalogModelRequestHealthCheckUnion := components.CreateAddCatalogModelRequestHealthCheckUnionPeriodic(components.AddCatalogModelRequestHealthCheck3{/* values here */})
```

## Union Discrimination

Use the `Type` field to determine which variant is active, then access the corresponding field:

```go
switch addCatalogModelRequestHealthCheckUnion.Type {
	case components.AddCatalogModelRequestHealthCheckUnionTypeOff:
		// addCatalogModelRequestHealthCheckUnion.AddCatalogModelRequestHealthCheck1 is populated
	case components.AddCatalogModelRequestHealthCheckUnionTypePreflight:
		// addCatalogModelRequestHealthCheckUnion.AddCatalogModelRequestHealthCheck2 is populated
	case components.AddCatalogModelRequestHealthCheckUnionTypePeriodic:
		// addCatalogModelRequestHealthCheckUnion.AddCatalogModelRequestHealthCheck3 is populated
}
```
