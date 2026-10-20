# FilterValue3


## Supported Types

### 

```go
filterValue3 := components.CreateFilterValue3Str(string{/* values here */})
```

### 

```go
filterValue3 := components.CreateFilterValue3Number(float64{/* values here */})
```

### 

```go
filterValue3 := components.CreateFilterValue3Boolean(bool{/* values here */})
```

## Union Discrimination

Use the `Type` field to determine which variant is active, then access the corresponding field:

```go
switch filterValue3.Type {
	case components.FilterValue3TypeStr:
		// filterValue3.Str is populated
	case components.FilterValue3TypeNumber:
		// filterValue3.Number is populated
	case components.FilterValue3TypeBoolean:
		// filterValue3.Boolean is populated
}
```
