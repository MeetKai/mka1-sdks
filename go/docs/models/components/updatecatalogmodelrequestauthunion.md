# UpdateCatalogModelRequestAuthUnion


## Supported Types

### UpdateCatalogModelRequestAuth1

```go
updateCatalogModelRequestAuthUnion := components.CreateUpdateCatalogModelRequestAuthUnionAPIKey(components.UpdateCatalogModelRequestAuth1{/* values here */})
```

### UpdateCatalogModelRequestAuth2

```go
updateCatalogModelRequestAuthUnion := components.CreateUpdateCatalogModelRequestAuthUnionCustomHeaders(components.UpdateCatalogModelRequestAuth2{/* values here */})
```

### UpdateCatalogModelRequestAuth3

```go
updateCatalogModelRequestAuthUnion := components.CreateUpdateCatalogModelRequestAuthUnionNone(components.UpdateCatalogModelRequestAuth3{/* values here */})
```

### UpdateCatalogModelRequestAuth4

```go
updateCatalogModelRequestAuthUnion := components.CreateUpdateCatalogModelRequestAuthUnionComposite(components.UpdateCatalogModelRequestAuth4{/* values here */})
```

## Union Discrimination

Use the `Type` field to determine which variant is active, then access the corresponding field:

```go
switch updateCatalogModelRequestAuthUnion.Type {
	case components.UpdateCatalogModelRequestAuthUnionTypeAPIKey:
		// updateCatalogModelRequestAuthUnion.UpdateCatalogModelRequestAuth1 is populated
	case components.UpdateCatalogModelRequestAuthUnionTypeCustomHeaders:
		// updateCatalogModelRequestAuthUnion.UpdateCatalogModelRequestAuth2 is populated
	case components.UpdateCatalogModelRequestAuthUnionTypeNone:
		// updateCatalogModelRequestAuthUnion.UpdateCatalogModelRequestAuth3 is populated
	case components.UpdateCatalogModelRequestAuthUnionTypeComposite:
		// updateCatalogModelRequestAuthUnion.UpdateCatalogModelRequestAuth4 is populated
}
```
