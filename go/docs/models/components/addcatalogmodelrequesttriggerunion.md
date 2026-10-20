# AddCatalogModelRequestTriggerUnion


## Supported Types

### AddCatalogModelRequestTrigger1

```go
addCatalogModelRequestTriggerUnion := components.CreateAddCatalogModelRequestTriggerUnionInputModality(components.AddCatalogModelRequestTrigger1{/* values here */})
```

### AddCatalogModelRequestTrigger2

```go
addCatalogModelRequestTriggerUnion := components.CreateAddCatalogModelRequestTriggerUnionErrorFallback(components.AddCatalogModelRequestTrigger2{/* values here */})
```

## Union Discrimination

Use the `Type` field to determine which variant is active, then access the corresponding field:

```go
switch addCatalogModelRequestTriggerUnion.Type {
	case components.AddCatalogModelRequestTriggerUnionTypeInputModality:
		// addCatalogModelRequestTriggerUnion.AddCatalogModelRequestTrigger1 is populated
	case components.AddCatalogModelRequestTriggerUnionTypeErrorFallback:
		// addCatalogModelRequestTriggerUnion.AddCatalogModelRequestTrigger2 is populated
}
```
