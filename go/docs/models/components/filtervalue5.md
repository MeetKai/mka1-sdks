# FilterValue5


## Supported Types

### 

```go
filterValue5 := components.CreateFilterValue5Str(string{/* values here */})
```

### 

```go
filterValue5 := components.CreateFilterValue5Number(float64{/* values here */})
```

### 

```go
filterValue5 := components.CreateFilterValue5Boolean(bool{/* values here */})
```

## Union Discrimination

Use the `Type` field to determine which variant is active, then access the corresponding field:

```go
switch filterValue5.Type {
	case components.FilterValue5TypeStr:
		// filterValue5.Str is populated
	case components.FilterValue5TypeNumber:
		// filterValue5.Number is populated
	case components.FilterValue5TypeBoolean:
		// filterValue5.Boolean is populated
}
```
