# FilterValue2

The value to compare against the attribute key; supports string, number, boolean, or array types.


## Supported Types

### 

```go
filterValue2 := components.CreateFilterValue2Str(string{/* values here */})
```

### 

```go
filterValue2 := components.CreateFilterValue2Number(float64{/* values here */})
```

### 

```go
filterValue2 := components.CreateFilterValue2Boolean(bool{/* values here */})
```

### 

```go
filterValue2 := components.CreateFilterValue2ArrayOfFilterValue1([]components.FilterValue1{/* values here */})
```

## Union Discrimination

Use the `Type` field to determine which variant is active, then access the corresponding field:

```go
switch filterValue2.Type {
	case components.FilterValue2TypeStr:
		// filterValue2.Str is populated
	case components.FilterValue2TypeNumber:
		// filterValue2.Number is populated
	case components.FilterValue2TypeBoolean:
		// filterValue2.Boolean is populated
	case components.FilterValue2TypeArrayOfFilterValue1:
		// filterValue2.ArrayOfFilterValue1 is populated
}
```
