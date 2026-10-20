# ToolDefinitionFiltersUnion


## Supported Types

### FileSearchComparisonFilter

```go
toolDefinitionFiltersUnion := components.CreateToolDefinitionFiltersUnionEq(components.FileSearchComparisonFilter{/* values here */})
```

### FileSearchComparisonFilter

```go
toolDefinitionFiltersUnion := components.CreateToolDefinitionFiltersUnionNe(components.FileSearchComparisonFilter{/* values here */})
```

### FileSearchComparisonFilter

```go
toolDefinitionFiltersUnion := components.CreateToolDefinitionFiltersUnionGt(components.FileSearchComparisonFilter{/* values here */})
```

### FileSearchComparisonFilter

```go
toolDefinitionFiltersUnion := components.CreateToolDefinitionFiltersUnionGte(components.FileSearchComparisonFilter{/* values here */})
```

### FileSearchComparisonFilter

```go
toolDefinitionFiltersUnion := components.CreateToolDefinitionFiltersUnionLt(components.FileSearchComparisonFilter{/* values here */})
```

### FileSearchComparisonFilter

```go
toolDefinitionFiltersUnion := components.CreateToolDefinitionFiltersUnionLte(components.FileSearchComparisonFilter{/* values here */})
```

### FileSearchCompoundFilter

```go
toolDefinitionFiltersUnion := components.CreateToolDefinitionFiltersUnionAnd(components.FileSearchCompoundFilter{/* values here */})
```

### FileSearchCompoundFilter

```go
toolDefinitionFiltersUnion := components.CreateToolDefinitionFiltersUnionOr(components.FileSearchCompoundFilter{/* values here */})
```

## Union Discrimination

Use the `Type` field to determine which variant is active, then access the corresponding field:

```go
switch toolDefinitionFiltersUnion.Type {
	case components.ToolDefinitionFiltersUnionTypeEq:
		// toolDefinitionFiltersUnion.FileSearchComparisonFilter is populated
	case components.ToolDefinitionFiltersUnionTypeNe:
		// toolDefinitionFiltersUnion.FileSearchComparisonFilter is populated
	case components.ToolDefinitionFiltersUnionTypeGt:
		// toolDefinitionFiltersUnion.FileSearchComparisonFilter is populated
	case components.ToolDefinitionFiltersUnionTypeGte:
		// toolDefinitionFiltersUnion.FileSearchComparisonFilter is populated
	case components.ToolDefinitionFiltersUnionTypeLt:
		// toolDefinitionFiltersUnion.FileSearchComparisonFilter is populated
	case components.ToolDefinitionFiltersUnionTypeLte:
		// toolDefinitionFiltersUnion.FileSearchComparisonFilter is populated
	case components.ToolDefinitionFiltersUnionTypeAnd:
		// toolDefinitionFiltersUnion.FileSearchCompoundFilter is populated
	case components.ToolDefinitionFiltersUnionTypeOr:
		// toolDefinitionFiltersUnion.FileSearchCompoundFilter is populated
	default:
		// Unknown type - use toolDefinitionFiltersUnion.GetUnknownRaw() for raw JSON
}
```
