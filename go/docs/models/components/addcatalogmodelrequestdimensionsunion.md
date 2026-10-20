# AddCatalogModelRequestDimensionsUnion


## Supported Types

### 

```go
addCatalogModelRequestDimensionsUnion := components.CreateAddCatalogModelRequestDimensionsUnionInteger(int64{/* values here */})
```

### AddCatalogModelRequestDimensions

```go
addCatalogModelRequestDimensionsUnion := components.CreateAddCatalogModelRequestDimensionsUnionAddCatalogModelRequestDimensions(components.AddCatalogModelRequestDimensions{/* values here */})
```

## Union Discrimination

Use the `Type` field to determine which variant is active, then access the corresponding field:

```go
switch addCatalogModelRequestDimensionsUnion.Type {
	case components.AddCatalogModelRequestDimensionsUnionTypeInteger:
		// addCatalogModelRequestDimensionsUnion.Integer is populated
	case components.AddCatalogModelRequestDimensionsUnionTypeAddCatalogModelRequestDimensions:
		// addCatalogModelRequestDimensionsUnion.AddCatalogModelRequestDimensions is populated
}
```
