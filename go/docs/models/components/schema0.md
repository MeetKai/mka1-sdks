# Schema0


## Supported Types

### 

```go
schema0 := components.CreateSchema0Str(string{/* values here */})
```

### 

```go
schema0 := components.CreateSchema0Number(float64{/* values here */})
```

### 

```go
schema0 := components.CreateSchema0Boolean(bool{/* values here */})
```

### 

```go
schema0 := components.CreateSchema0ArrayOfSchema0([]*components.Schema0{/* values here */})
```

### 

```go
schema0 := components.CreateSchema0MapOfSchema0(map[string]*components.Schema0{/* values here */})
```

## Union Discrimination

Use the `Type` field to determine which variant is active, then access the corresponding field:

```go
switch schema0.Type {
	case components.Schema0TypeStr:
		// schema0.Str is populated
	case components.Schema0TypeNumber:
		// schema0.Number is populated
	case components.Schema0TypeBoolean:
		// schema0.Boolean is populated
	case components.Schema0TypeArrayOfSchema0:
		// schema0.ArrayOfSchema0 is populated
	case components.Schema0TypeMapOfSchema0:
		// schema0.MapOfSchema0 is populated
}
```
