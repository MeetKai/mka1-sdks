# Schema1


## Supported Types

### 

```go
schema1 := components.CreateSchema1Str(string{/* values here */})
```

### 

```go
schema1 := components.CreateSchema1Number(float64{/* values here */})
```

### 

```go
schema1 := components.CreateSchema1Boolean(bool{/* values here */})
```

### 

```go
schema1 := components.CreateSchema1ArrayOfSchema1([]*components.Schema1{/* values here */})
```

### 

```go
schema1 := components.CreateSchema1MapOfSchema1(map[string]*components.Schema1{/* values here */})
```

## Union Discrimination

Use the `Type` field to determine which variant is active, then access the corresponding field:

```go
switch schema1.Type {
	case components.Schema1TypeStr:
		// schema1.Str is populated
	case components.Schema1TypeNumber:
		// schema1.Number is populated
	case components.Schema1TypeBoolean:
		// schema1.Boolean is populated
	case components.Schema1TypeArrayOfSchema1:
		// schema1.ArrayOfSchema1 is populated
	case components.Schema1TypeMapOfSchema1:
		// schema1.MapOfSchema1 is populated
	default:
		// Unknown type - use schema1.GetUnknownRaw() for raw JSON
}
```
