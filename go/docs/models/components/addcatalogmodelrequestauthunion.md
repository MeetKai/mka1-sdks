# AddCatalogModelRequestAuthUnion


## Supported Types

### AddCatalogModelRequestAuth1

```go
addCatalogModelRequestAuthUnion := components.CreateAddCatalogModelRequestAuthUnionAPIKey(components.AddCatalogModelRequestAuth1{/* values here */})
```

### AddCatalogModelRequestAuth2

```go
addCatalogModelRequestAuthUnion := components.CreateAddCatalogModelRequestAuthUnionCustomHeaders(components.AddCatalogModelRequestAuth2{/* values here */})
```

### AddCatalogModelRequestAuth3

```go
addCatalogModelRequestAuthUnion := components.CreateAddCatalogModelRequestAuthUnionNone(components.AddCatalogModelRequestAuth3{/* values here */})
```

### AddCatalogModelRequestAuth4

```go
addCatalogModelRequestAuthUnion := components.CreateAddCatalogModelRequestAuthUnionComposite(components.AddCatalogModelRequestAuth4{/* values here */})
```

## Union Discrimination

Use the `Type` field to determine which variant is active, then access the corresponding field:

```go
switch addCatalogModelRequestAuthUnion.Type {
	case components.AddCatalogModelRequestAuthUnionTypeAPIKey:
		// addCatalogModelRequestAuthUnion.AddCatalogModelRequestAuth1 is populated
	case components.AddCatalogModelRequestAuthUnionTypeCustomHeaders:
		// addCatalogModelRequestAuthUnion.AddCatalogModelRequestAuth2 is populated
	case components.AddCatalogModelRequestAuthUnionTypeNone:
		// addCatalogModelRequestAuthUnion.AddCatalogModelRequestAuth3 is populated
	case components.AddCatalogModelRequestAuthUnionTypeComposite:
		// addCatalogModelRequestAuthUnion.AddCatalogModelRequestAuth4 is populated
}
```
