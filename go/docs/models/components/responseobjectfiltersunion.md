# ResponseObjectFiltersUnion


## Supported Types

### ComparisonFilter

```go
responseObjectFiltersUnion := components.CreateResponseObjectFiltersUnionEq(components.ComparisonFilter{/* values here */})
```

### ComparisonFilter

```go
responseObjectFiltersUnion := components.CreateResponseObjectFiltersUnionNe(components.ComparisonFilter{/* values here */})
```

### ComparisonFilter

```go
responseObjectFiltersUnion := components.CreateResponseObjectFiltersUnionGt(components.ComparisonFilter{/* values here */})
```

### ComparisonFilter

```go
responseObjectFiltersUnion := components.CreateResponseObjectFiltersUnionGte(components.ComparisonFilter{/* values here */})
```

### ComparisonFilter

```go
responseObjectFiltersUnion := components.CreateResponseObjectFiltersUnionLt(components.ComparisonFilter{/* values here */})
```

### ComparisonFilter

```go
responseObjectFiltersUnion := components.CreateResponseObjectFiltersUnionLte(components.ComparisonFilter{/* values here */})
```

### ResponseObjectFilters

```go
responseObjectFiltersUnion := components.CreateResponseObjectFiltersUnionAnd(components.ResponseObjectFilters{/* values here */})
```

### ResponseObjectFilters

```go
responseObjectFiltersUnion := components.CreateResponseObjectFiltersUnionOr(components.ResponseObjectFilters{/* values here */})
```

## Union Discrimination

Use the `Type` field to determine which variant is active, then access the corresponding field:

```go
switch responseObjectFiltersUnion.Type {
	case components.ResponseObjectFiltersUnionTypeEq:
		// responseObjectFiltersUnion.ComparisonFilter is populated
	case components.ResponseObjectFiltersUnionTypeNe:
		// responseObjectFiltersUnion.ComparisonFilter is populated
	case components.ResponseObjectFiltersUnionTypeGt:
		// responseObjectFiltersUnion.ComparisonFilter is populated
	case components.ResponseObjectFiltersUnionTypeGte:
		// responseObjectFiltersUnion.ComparisonFilter is populated
	case components.ResponseObjectFiltersUnionTypeLt:
		// responseObjectFiltersUnion.ComparisonFilter is populated
	case components.ResponseObjectFiltersUnionTypeLte:
		// responseObjectFiltersUnion.ComparisonFilter is populated
	case components.ResponseObjectFiltersUnionTypeAnd:
		// responseObjectFiltersUnion.ResponseObjectFilters is populated
	case components.ResponseObjectFiltersUnionTypeOr:
		// responseObjectFiltersUnion.ResponseObjectFilters is populated
	default:
		// Unknown type - use responseObjectFiltersUnion.GetUnknownRaw() for raw JSON
}
```
