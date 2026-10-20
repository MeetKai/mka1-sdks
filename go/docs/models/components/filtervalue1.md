# FilterValue1


## Supported Types

### 

```go
filterValue1 := components.CreateFilterValue1Str(string{/* values here */})
```

### 

```go
filterValue1 := components.CreateFilterValue1Number(float64{/* values here */})
```

### 

```go
filterValue1 := components.CreateFilterValue1Boolean(bool{/* values here */})
```

## Union Discrimination

Use the `Type` field to determine which variant is active, then access the corresponding field:

```go
switch filterValue1.Type {
	case components.FilterValue1TypeStr:
		// filterValue1.Str is populated
	case components.FilterValue1TypeNumber:
		// filterValue1.Number is populated
	case components.FilterValue1TypeBoolean:
		// filterValue1.Boolean is populated
}
```
