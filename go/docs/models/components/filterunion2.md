# FilterUnion2


## Supported Types

### Filter2

```go
filterUnion2 := components.CreateFilterUnion2Eq(components.Filter2{/* values here */})
```

### Filter2

```go
filterUnion2 := components.CreateFilterUnion2Ne(components.Filter2{/* values here */})
```

### Filter2

```go
filterUnion2 := components.CreateFilterUnion2Gt(components.Filter2{/* values here */})
```

### Filter2

```go
filterUnion2 := components.CreateFilterUnion2Gte(components.Filter2{/* values here */})
```

### Filter2

```go
filterUnion2 := components.CreateFilterUnion2Lt(components.Filter2{/* values here */})
```

### Filter2

```go
filterUnion2 := components.CreateFilterUnion2Lte(components.Filter2{/* values here */})
```

### Filter2

```go
filterUnion2 := components.CreateFilterUnion2In(components.Filter2{/* values here */})
```

### Filter2

```go
filterUnion2 := components.CreateFilterUnion2Nin(components.Filter2{/* values here */})
```

### Filter4

```go
filterUnion2 := components.CreateFilterUnion2And(components.Filter4{/* values here */})
```

### Filter4

```go
filterUnion2 := components.CreateFilterUnion2Or(components.Filter4{/* values here */})
```

## Union Discrimination

Use the `Type` field to determine which variant is active, then access the corresponding field:

```go
switch filterUnion2.Type {
	case components.FilterUnion2TypeEq:
		// filterUnion2.Filter2 is populated
	case components.FilterUnion2TypeNe:
		// filterUnion2.Filter2 is populated
	case components.FilterUnion2TypeGt:
		// filterUnion2.Filter2 is populated
	case components.FilterUnion2TypeGte:
		// filterUnion2.Filter2 is populated
	case components.FilterUnion2TypeLt:
		// filterUnion2.Filter2 is populated
	case components.FilterUnion2TypeLte:
		// filterUnion2.Filter2 is populated
	case components.FilterUnion2TypeIn:
		// filterUnion2.Filter2 is populated
	case components.FilterUnion2TypeNin:
		// filterUnion2.Filter2 is populated
	case components.FilterUnion2TypeAnd:
		// filterUnion2.Filter4 is populated
	case components.FilterUnion2TypeOr:
		// filterUnion2.Filter4 is populated
}
```
