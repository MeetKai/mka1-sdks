# FilterValue6

The value to compare against the attribute key; supports string, number, boolean, or array types.


## Supported Types

### 

```go
filterValue6 := components.CreateFilterValue6Str(string{/* values here */})
```

### 

```go
filterValue6 := components.CreateFilterValue6Number(float64{/* values here */})
```

### 

```go
filterValue6 := components.CreateFilterValue6Boolean(bool{/* values here */})
```

### 

```go
filterValue6 := components.CreateFilterValue6ArrayOfFilterValue5([]components.FilterValue5{/* values here */})
```

## Union Discrimination

Use the `Type` field to determine which variant is active, then access the corresponding field:

```go
switch filterValue6.Type {
	case components.FilterValue6TypeStr:
		// filterValue6.Str is populated
	case components.FilterValue6TypeNumber:
		// filterValue6.Number is populated
	case components.FilterValue6TypeBoolean:
		// filterValue6.Boolean is populated
	case components.FilterValue6TypeArrayOfFilterValue5:
		// filterValue6.ArrayOfFilterValue5 is populated
}
```
