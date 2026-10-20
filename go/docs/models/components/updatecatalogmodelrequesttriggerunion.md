# UpdateCatalogModelRequestTriggerUnion


## Supported Types

### UpdateCatalogModelRequestTrigger1

```go
updateCatalogModelRequestTriggerUnion := components.CreateUpdateCatalogModelRequestTriggerUnionInputModality(components.UpdateCatalogModelRequestTrigger1{/* values here */})
```

### UpdateCatalogModelRequestTrigger2

```go
updateCatalogModelRequestTriggerUnion := components.CreateUpdateCatalogModelRequestTriggerUnionErrorFallback(components.UpdateCatalogModelRequestTrigger2{/* values here */})
```

## Union Discrimination

Use the `Type` field to determine which variant is active, then access the corresponding field:

```go
switch updateCatalogModelRequestTriggerUnion.Type {
	case components.UpdateCatalogModelRequestTriggerUnionTypeInputModality:
		// updateCatalogModelRequestTriggerUnion.UpdateCatalogModelRequestTrigger1 is populated
	case components.UpdateCatalogModelRequestTriggerUnionTypeErrorFallback:
		// updateCatalogModelRequestTriggerUnion.UpdateCatalogModelRequestTrigger2 is populated
}
```
