# ResponseObjectFilterUnion


## Supported Types

### ComparisonFilter

```go
responseObjectFilterUnion := components.CreateResponseObjectFilterUnionEq(components.ComparisonFilter{/* values here */})
```

### ComparisonFilter

```go
responseObjectFilterUnion := components.CreateResponseObjectFilterUnionNe(components.ComparisonFilter{/* values here */})
```

### ComparisonFilter

```go
responseObjectFilterUnion := components.CreateResponseObjectFilterUnionGt(components.ComparisonFilter{/* values here */})
```

### ComparisonFilter

```go
responseObjectFilterUnion := components.CreateResponseObjectFilterUnionGte(components.ComparisonFilter{/* values here */})
```

### ComparisonFilter

```go
responseObjectFilterUnion := components.CreateResponseObjectFilterUnionLt(components.ComparisonFilter{/* values here */})
```

### ComparisonFilter

```go
responseObjectFilterUnion := components.CreateResponseObjectFilterUnionLte(components.ComparisonFilter{/* values here */})
```

### ResponseObjectFilter

```go
responseObjectFilterUnion := components.CreateResponseObjectFilterUnionAnd(components.ResponseObjectFilter{/* values here */})
```

### ResponseObjectFilter

```go
responseObjectFilterUnion := components.CreateResponseObjectFilterUnionOr(components.ResponseObjectFilter{/* values here */})
```

## Union Discrimination

Use the `Type` field to determine which variant is active, then access the corresponding field:

```go
switch responseObjectFilterUnion.Type {
	case components.ResponseObjectFilterUnionTypeEq:
		// responseObjectFilterUnion.ComparisonFilter is populated
	case components.ResponseObjectFilterUnionTypeNe:
		// responseObjectFilterUnion.ComparisonFilter is populated
	case components.ResponseObjectFilterUnionTypeGt:
		// responseObjectFilterUnion.ComparisonFilter is populated
	case components.ResponseObjectFilterUnionTypeGte:
		// responseObjectFilterUnion.ComparisonFilter is populated
	case components.ResponseObjectFilterUnionTypeLt:
		// responseObjectFilterUnion.ComparisonFilter is populated
	case components.ResponseObjectFilterUnionTypeLte:
		// responseObjectFilterUnion.ComparisonFilter is populated
	case components.ResponseObjectFilterUnionTypeAnd:
		// responseObjectFilterUnion.ResponseObjectFilter is populated
	case components.ResponseObjectFilterUnionTypeOr:
		// responseObjectFilterUnion.ResponseObjectFilter is populated
	default:
		// Unknown type - use responseObjectFilterUnion.GetUnknownRaw() for raw JSON
}
```
