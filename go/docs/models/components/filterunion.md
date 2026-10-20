# FilterUnion


## Supported Types

### Filter1

```go
filterUnion := components.CreateFilterUnionEq(components.Filter1{/* values here */})
```

### Filter1

```go
filterUnion := components.CreateFilterUnionNe(components.Filter1{/* values here */})
```

### Filter1

```go
filterUnion := components.CreateFilterUnionGt(components.Filter1{/* values here */})
```

### Filter1

```go
filterUnion := components.CreateFilterUnionGte(components.Filter1{/* values here */})
```

### Filter1

```go
filterUnion := components.CreateFilterUnionLt(components.Filter1{/* values here */})
```

### Filter1

```go
filterUnion := components.CreateFilterUnionLte(components.Filter1{/* values here */})
```

### Filter1

```go
filterUnion := components.CreateFilterUnionIn(components.Filter1{/* values here */})
```

### Filter1

```go
filterUnion := components.CreateFilterUnionNin(components.Filter1{/* values here */})
```

### Filter5

```go
filterUnion := components.CreateFilterUnionAnd(components.Filter5{/* values here */})
```

### Filter5

```go
filterUnion := components.CreateFilterUnionOr(components.Filter5{/* values here */})
```

## Union Discrimination

Use the `Type` field to determine which variant is active, then access the corresponding field:

```go
switch filterUnion.Type {
	case components.FilterUnionTypeEq:
		// filterUnion.Filter1 is populated
	case components.FilterUnionTypeNe:
		// filterUnion.Filter1 is populated
	case components.FilterUnionTypeGt:
		// filterUnion.Filter1 is populated
	case components.FilterUnionTypeGte:
		// filterUnion.Filter1 is populated
	case components.FilterUnionTypeLt:
		// filterUnion.Filter1 is populated
	case components.FilterUnionTypeLte:
		// filterUnion.Filter1 is populated
	case components.FilterUnionTypeIn:
		// filterUnion.Filter1 is populated
	case components.FilterUnionTypeNin:
		// filterUnion.Filter1 is populated
	case components.FilterUnionTypeAnd:
		// filterUnion.Filter5 is populated
	case components.FilterUnionTypeOr:
		// filterUnion.Filter5 is populated
}
```
