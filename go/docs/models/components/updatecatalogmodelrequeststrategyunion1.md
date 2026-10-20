# UpdateCatalogModelRequestStrategyUnion1


## Supported Types

### UpdateCatalogModelRequestStrategy4

```go
updateCatalogModelRequestStrategyUnion1 := components.CreateUpdateCatalogModelRequestStrategyUnion1APIKey(components.UpdateCatalogModelRequestStrategy4{/* values here */})
```

### UpdateCatalogModelRequestStrategy5

```go
updateCatalogModelRequestStrategyUnion1 := components.CreateUpdateCatalogModelRequestStrategyUnion1CustomHeaders(components.UpdateCatalogModelRequestStrategy5{/* values here */})
```

### UpdateCatalogModelRequestStrategy6

```go
updateCatalogModelRequestStrategyUnion1 := components.CreateUpdateCatalogModelRequestStrategyUnion1None(components.UpdateCatalogModelRequestStrategy6{/* values here */})
```

### UpdateCatalogModelRequestStrategy7

```go
updateCatalogModelRequestStrategyUnion1 := components.CreateUpdateCatalogModelRequestStrategyUnion1Composite(components.UpdateCatalogModelRequestStrategy7{/* values here */})
```

## Union Discrimination

Use the `Type` field to determine which variant is active, then access the corresponding field:

```go
switch updateCatalogModelRequestStrategyUnion1.Type {
	case components.UpdateCatalogModelRequestStrategyUnion1TypeAPIKey:
		// updateCatalogModelRequestStrategyUnion1.UpdateCatalogModelRequestStrategy4 is populated
	case components.UpdateCatalogModelRequestStrategyUnion1TypeCustomHeaders:
		// updateCatalogModelRequestStrategyUnion1.UpdateCatalogModelRequestStrategy5 is populated
	case components.UpdateCatalogModelRequestStrategyUnion1TypeNone:
		// updateCatalogModelRequestStrategyUnion1.UpdateCatalogModelRequestStrategy6 is populated
	case components.UpdateCatalogModelRequestStrategyUnion1TypeComposite:
		// updateCatalogModelRequestStrategyUnion1.UpdateCatalogModelRequestStrategy7 is populated
}
```
