# CompoundFilterFilter


## Supported Types

### ComparisonFilter

```go
compoundFilterFilter := components.CreateCompoundFilterFilterEq(components.ComparisonFilter{/* values here */})
```

### ComparisonFilter

```go
compoundFilterFilter := components.CreateCompoundFilterFilterNe(components.ComparisonFilter{/* values here */})
```

### ComparisonFilter

```go
compoundFilterFilter := components.CreateCompoundFilterFilterGt(components.ComparisonFilter{/* values here */})
```

### ComparisonFilter

```go
compoundFilterFilter := components.CreateCompoundFilterFilterGte(components.ComparisonFilter{/* values here */})
```

### ComparisonFilter

```go
compoundFilterFilter := components.CreateCompoundFilterFilterLt(components.ComparisonFilter{/* values here */})
```

### ComparisonFilter

```go
compoundFilterFilter := components.CreateCompoundFilterFilterLte(components.ComparisonFilter{/* values here */})
```

### CompoundFilter

```go
compoundFilterFilter := components.CreateCompoundFilterFilterAnd(components.CompoundFilter{/* values here */})
```

### CompoundFilter

```go
compoundFilterFilter := components.CreateCompoundFilterFilterOr(components.CompoundFilter{/* values here */})
```

## Union Discrimination

Use the `Type` field to determine which variant is active, then access the corresponding field:

```go
switch compoundFilterFilter.Type {
	case components.CompoundFilterFilterTypeEq:
		// compoundFilterFilter.ComparisonFilter is populated
	case components.CompoundFilterFilterTypeNe:
		// compoundFilterFilter.ComparisonFilter is populated
	case components.CompoundFilterFilterTypeGt:
		// compoundFilterFilter.ComparisonFilter is populated
	case components.CompoundFilterFilterTypeGte:
		// compoundFilterFilter.ComparisonFilter is populated
	case components.CompoundFilterFilterTypeLt:
		// compoundFilterFilter.ComparisonFilter is populated
	case components.CompoundFilterFilterTypeLte:
		// compoundFilterFilter.ComparisonFilter is populated
	case components.CompoundFilterFilterTypeAnd:
		// compoundFilterFilter.CompoundFilter is populated
	case components.CompoundFilterFilterTypeOr:
		// compoundFilterFilter.CompoundFilter is populated
}
```
