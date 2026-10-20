# AddCatalogModelRequestStrategyUnion1


## Supported Types

### AddCatalogModelRequestStrategy4

```go
addCatalogModelRequestStrategyUnion1 := components.CreateAddCatalogModelRequestStrategyUnion1APIKey(components.AddCatalogModelRequestStrategy4{/* values here */})
```

### AddCatalogModelRequestStrategy5

```go
addCatalogModelRequestStrategyUnion1 := components.CreateAddCatalogModelRequestStrategyUnion1CustomHeaders(components.AddCatalogModelRequestStrategy5{/* values here */})
```

### AddCatalogModelRequestStrategy6

```go
addCatalogModelRequestStrategyUnion1 := components.CreateAddCatalogModelRequestStrategyUnion1None(components.AddCatalogModelRequestStrategy6{/* values here */})
```

### AddCatalogModelRequestStrategy7

```go
addCatalogModelRequestStrategyUnion1 := components.CreateAddCatalogModelRequestStrategyUnion1Composite(components.AddCatalogModelRequestStrategy7{/* values here */})
```

## Union Discrimination

Use the `Type` field to determine which variant is active, then access the corresponding field:

```go
switch addCatalogModelRequestStrategyUnion1.Type {
	case components.AddCatalogModelRequestStrategyUnion1TypeAPIKey:
		// addCatalogModelRequestStrategyUnion1.AddCatalogModelRequestStrategy4 is populated
	case components.AddCatalogModelRequestStrategyUnion1TypeCustomHeaders:
		// addCatalogModelRequestStrategyUnion1.AddCatalogModelRequestStrategy5 is populated
	case components.AddCatalogModelRequestStrategyUnion1TypeNone:
		// addCatalogModelRequestStrategyUnion1.AddCatalogModelRequestStrategy6 is populated
	case components.AddCatalogModelRequestStrategyUnion1TypeComposite:
		// addCatalogModelRequestStrategyUnion1.AddCatalogModelRequestStrategy7 is populated
}
```
