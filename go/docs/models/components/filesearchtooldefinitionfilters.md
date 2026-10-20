# FileSearchToolDefinitionFilters


## Supported Types

### ComparisonFilter

```go
fileSearchToolDefinitionFilters := components.CreateFileSearchToolDefinitionFiltersEq(components.ComparisonFilter{/* values here */})
```

### ComparisonFilter

```go
fileSearchToolDefinitionFilters := components.CreateFileSearchToolDefinitionFiltersNe(components.ComparisonFilter{/* values here */})
```

### ComparisonFilter

```go
fileSearchToolDefinitionFilters := components.CreateFileSearchToolDefinitionFiltersGt(components.ComparisonFilter{/* values here */})
```

### ComparisonFilter

```go
fileSearchToolDefinitionFilters := components.CreateFileSearchToolDefinitionFiltersGte(components.ComparisonFilter{/* values here */})
```

### ComparisonFilter

```go
fileSearchToolDefinitionFilters := components.CreateFileSearchToolDefinitionFiltersLt(components.ComparisonFilter{/* values here */})
```

### ComparisonFilter

```go
fileSearchToolDefinitionFilters := components.CreateFileSearchToolDefinitionFiltersLte(components.ComparisonFilter{/* values here */})
```

### CompoundFilter

```go
fileSearchToolDefinitionFilters := components.CreateFileSearchToolDefinitionFiltersAnd(components.CompoundFilter{/* values here */})
```

### CompoundFilter

```go
fileSearchToolDefinitionFilters := components.CreateFileSearchToolDefinitionFiltersOr(components.CompoundFilter{/* values here */})
```

## Union Discrimination

Use the `Type` field to determine which variant is active, then access the corresponding field:

```go
switch fileSearchToolDefinitionFilters.Type {
	case components.FileSearchToolDefinitionFiltersTypeEq:
		// fileSearchToolDefinitionFilters.ComparisonFilter is populated
	case components.FileSearchToolDefinitionFiltersTypeNe:
		// fileSearchToolDefinitionFilters.ComparisonFilter is populated
	case components.FileSearchToolDefinitionFiltersTypeGt:
		// fileSearchToolDefinitionFilters.ComparisonFilter is populated
	case components.FileSearchToolDefinitionFiltersTypeGte:
		// fileSearchToolDefinitionFilters.ComparisonFilter is populated
	case components.FileSearchToolDefinitionFiltersTypeLt:
		// fileSearchToolDefinitionFilters.ComparisonFilter is populated
	case components.FileSearchToolDefinitionFiltersTypeLte:
		// fileSearchToolDefinitionFilters.ComparisonFilter is populated
	case components.FileSearchToolDefinitionFiltersTypeAnd:
		// fileSearchToolDefinitionFilters.CompoundFilter is populated
	case components.FileSearchToolDefinitionFiltersTypeOr:
		// fileSearchToolDefinitionFilters.CompoundFilter is populated
}
```
