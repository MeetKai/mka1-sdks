# UpdateCatalogModelRequestDimensionsUnion


## Supported Types

### 

```go
updateCatalogModelRequestDimensionsUnion := components.CreateUpdateCatalogModelRequestDimensionsUnionInteger(int64{/* values here */})
```

### UpdateCatalogModelRequestDimensions

```go
updateCatalogModelRequestDimensionsUnion := components.CreateUpdateCatalogModelRequestDimensionsUnionUpdateCatalogModelRequestDimensions(components.UpdateCatalogModelRequestDimensions{/* values here */})
```

## Union Discrimination

Use the `Type` field to determine which variant is active, then access the corresponding field:

```go
switch updateCatalogModelRequestDimensionsUnion.Type {
	case components.UpdateCatalogModelRequestDimensionsUnionTypeInteger:
		// updateCatalogModelRequestDimensionsUnion.Integer is populated
	case components.UpdateCatalogModelRequestDimensionsUnionTypeUpdateCatalogModelRequestDimensions:
		// updateCatalogModelRequestDimensionsUnion.UpdateCatalogModelRequestDimensions is populated
}
```
