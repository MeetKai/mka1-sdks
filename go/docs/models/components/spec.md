# Spec

The OpenAPI 3.0 or 3.1 document, as an object or as JSON or YAML text (at most 4 MiB).


## Supported Types

### 

```go
spec := components.CreateSpecStr(string{/* values here */})
```

### 

```go
spec := components.CreateSpecMapOfAny(map[string]any{/* values here */})
```

## Union Discrimination

Use the `Type` field to determine which variant is active, then access the corresponding field:

```go
switch spec.Type {
	case components.SpecTypeStr:
		// spec.Str is populated
	case components.SpecTypeMapOfAny:
		// spec.MapOfAny is populated
}
```
