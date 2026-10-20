# FilterValue4

The value to compare against the attribute key; supports string, number, boolean, or array types.


## Supported Types

### 

```go
filterValue4 := components.CreateFilterValue4Str(string{/* values here */})
```

### 

```go
filterValue4 := components.CreateFilterValue4Number(float64{/* values here */})
```

### 

```go
filterValue4 := components.CreateFilterValue4Boolean(bool{/* values here */})
```

### 

```go
filterValue4 := components.CreateFilterValue4ArrayOfFilterValue3([]components.FilterValue3{/* values here */})
```

## Union Discrimination

Use the `Type` field to determine which variant is active, then access the corresponding field:

```go
switch filterValue4.Type {
	case components.FilterValue4TypeStr:
		// filterValue4.Str is populated
	case components.FilterValue4TypeNumber:
		// filterValue4.Number is populated
	case components.FilterValue4TypeBoolean:
		// filterValue4.Boolean is populated
	case components.FilterValue4TypeArrayOfFilterValue3:
		// filterValue4.ArrayOfFilterValue3 is populated
}
```
