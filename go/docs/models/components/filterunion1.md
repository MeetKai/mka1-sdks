# FilterUnion1


## Supported Types

### Filter3

```go
filterUnion1 := components.CreateFilterUnion1Filter3(components.Filter3{/* values here */})
```

### 

```go
filterUnion1 := components.CreateFilterUnion1Any(any{/* values here */})
```

## Union Discrimination

Use the `Type` field to determine which variant is active, then access the corresponding field:

```go
switch filterUnion1.Type {
	case components.FilterUnion1TypeFilter3:
		// filterUnion1.Filter3 is populated
	case components.FilterUnion1TypeAny:
		// filterUnion1.Any is populated
}
```
