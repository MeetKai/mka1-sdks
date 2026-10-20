# FileSearchCompoundFilterFilter


## Supported Types

### FileSearchComparisonFilter

```go
fileSearchCompoundFilterFilter := components.CreateFileSearchCompoundFilterFilterEq(components.FileSearchComparisonFilter{/* values here */})
```

### FileSearchComparisonFilter

```go
fileSearchCompoundFilterFilter := components.CreateFileSearchCompoundFilterFilterNe(components.FileSearchComparisonFilter{/* values here */})
```

### FileSearchComparisonFilter

```go
fileSearchCompoundFilterFilter := components.CreateFileSearchCompoundFilterFilterGt(components.FileSearchComparisonFilter{/* values here */})
```

### FileSearchComparisonFilter

```go
fileSearchCompoundFilterFilter := components.CreateFileSearchCompoundFilterFilterGte(components.FileSearchComparisonFilter{/* values here */})
```

### FileSearchComparisonFilter

```go
fileSearchCompoundFilterFilter := components.CreateFileSearchCompoundFilterFilterLt(components.FileSearchComparisonFilter{/* values here */})
```

### FileSearchComparisonFilter

```go
fileSearchCompoundFilterFilter := components.CreateFileSearchCompoundFilterFilterLte(components.FileSearchComparisonFilter{/* values here */})
```

### FileSearchCompoundFilter

```go
fileSearchCompoundFilterFilter := components.CreateFileSearchCompoundFilterFilterAnd(components.FileSearchCompoundFilter{/* values here */})
```

### FileSearchCompoundFilter

```go
fileSearchCompoundFilterFilter := components.CreateFileSearchCompoundFilterFilterOr(components.FileSearchCompoundFilter{/* values here */})
```

## Union Discrimination

Use the `Type` field to determine which variant is active, then access the corresponding field:

```go
switch fileSearchCompoundFilterFilter.Type {
	case components.FileSearchCompoundFilterFilterTypeEq:
		// fileSearchCompoundFilterFilter.FileSearchComparisonFilter is populated
	case components.FileSearchCompoundFilterFilterTypeNe:
		// fileSearchCompoundFilterFilter.FileSearchComparisonFilter is populated
	case components.FileSearchCompoundFilterFilterTypeGt:
		// fileSearchCompoundFilterFilter.FileSearchComparisonFilter is populated
	case components.FileSearchCompoundFilterFilterTypeGte:
		// fileSearchCompoundFilterFilter.FileSearchComparisonFilter is populated
	case components.FileSearchCompoundFilterFilterTypeLt:
		// fileSearchCompoundFilterFilter.FileSearchComparisonFilter is populated
	case components.FileSearchCompoundFilterFilterTypeLte:
		// fileSearchCompoundFilterFilter.FileSearchComparisonFilter is populated
	case components.FileSearchCompoundFilterFilterTypeAnd:
		// fileSearchCompoundFilterFilter.FileSearchCompoundFilter is populated
	case components.FileSearchCompoundFilterFilterTypeOr:
		// fileSearchCompoundFilterFilter.FileSearchCompoundFilter is populated
	default:
		// Unknown type - use fileSearchCompoundFilterFilter.GetUnknownRaw() for raw JSON
}
```
