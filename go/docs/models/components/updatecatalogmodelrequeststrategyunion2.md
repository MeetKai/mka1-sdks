# UpdateCatalogModelRequestStrategyUnion2


## Supported Types

### UpdateCatalogModelRequestStrategy1

```go
updateCatalogModelRequestStrategyUnion2 := components.CreateUpdateCatalogModelRequestStrategyUnion2APIKey(components.UpdateCatalogModelRequestStrategy1{/* values here */})
```

### UpdateCatalogModelRequestStrategy2

```go
updateCatalogModelRequestStrategyUnion2 := components.CreateUpdateCatalogModelRequestStrategyUnion2CustomHeaders(components.UpdateCatalogModelRequestStrategy2{/* values here */})
```

### UpdateCatalogModelRequestStrategy3

```go
updateCatalogModelRequestStrategyUnion2 := components.CreateUpdateCatalogModelRequestStrategyUnion2None(components.UpdateCatalogModelRequestStrategy3{/* values here */})
```

### UpdateCatalogModelRequestStrategy8

```go
updateCatalogModelRequestStrategyUnion2 := components.CreateUpdateCatalogModelRequestStrategyUnion2Composite(components.UpdateCatalogModelRequestStrategy8{/* values here */})
```

## Union Discrimination

Use the `Type` field to determine which variant is active, then access the corresponding field:

```go
switch updateCatalogModelRequestStrategyUnion2.Type {
	case components.UpdateCatalogModelRequestStrategyUnion2TypeAPIKey:
		// updateCatalogModelRequestStrategyUnion2.UpdateCatalogModelRequestStrategy1 is populated
	case components.UpdateCatalogModelRequestStrategyUnion2TypeCustomHeaders:
		// updateCatalogModelRequestStrategyUnion2.UpdateCatalogModelRequestStrategy2 is populated
	case components.UpdateCatalogModelRequestStrategyUnion2TypeNone:
		// updateCatalogModelRequestStrategyUnion2.UpdateCatalogModelRequestStrategy3 is populated
	case components.UpdateCatalogModelRequestStrategyUnion2TypeComposite:
		// updateCatalogModelRequestStrategyUnion2.UpdateCatalogModelRequestStrategy8 is populated
}
```
