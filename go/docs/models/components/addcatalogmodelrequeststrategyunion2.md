# AddCatalogModelRequestStrategyUnion2


## Supported Types

### AddCatalogModelRequestStrategy1

```go
addCatalogModelRequestStrategyUnion2 := components.CreateAddCatalogModelRequestStrategyUnion2APIKey(components.AddCatalogModelRequestStrategy1{/* values here */})
```

### AddCatalogModelRequestStrategy2

```go
addCatalogModelRequestStrategyUnion2 := components.CreateAddCatalogModelRequestStrategyUnion2CustomHeaders(components.AddCatalogModelRequestStrategy2{/* values here */})
```

### AddCatalogModelRequestStrategy3

```go
addCatalogModelRequestStrategyUnion2 := components.CreateAddCatalogModelRequestStrategyUnion2None(components.AddCatalogModelRequestStrategy3{/* values here */})
```

### AddCatalogModelRequestStrategy8

```go
addCatalogModelRequestStrategyUnion2 := components.CreateAddCatalogModelRequestStrategyUnion2Composite(components.AddCatalogModelRequestStrategy8{/* values here */})
```

## Union Discrimination

Use the `Type` field to determine which variant is active, then access the corresponding field:

```go
switch addCatalogModelRequestStrategyUnion2.Type {
	case components.AddCatalogModelRequestStrategyUnion2TypeAPIKey:
		// addCatalogModelRequestStrategyUnion2.AddCatalogModelRequestStrategy1 is populated
	case components.AddCatalogModelRequestStrategyUnion2TypeCustomHeaders:
		// addCatalogModelRequestStrategyUnion2.AddCatalogModelRequestStrategy2 is populated
	case components.AddCatalogModelRequestStrategyUnion2TypeNone:
		// addCatalogModelRequestStrategyUnion2.AddCatalogModelRequestStrategy3 is populated
	case components.AddCatalogModelRequestStrategyUnion2TypeComposite:
		// addCatalogModelRequestStrategyUnion2.AddCatalogModelRequestStrategy8 is populated
}
```
