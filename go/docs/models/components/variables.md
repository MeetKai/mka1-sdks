# Variables


## Supported Types

### 

```go
variables := components.CreateVariablesStr(string{/* values here */})
```

### 

```go
variables := components.CreateVariablesAny(any{/* values here */})
```

## Union Discrimination

Use the `Type` field to determine which variant is active, then access the corresponding field:

```go
switch variables.Type {
	case components.VariablesTypeStr:
		// variables.Str is populated
	case components.VariablesTypeAny:
		// variables.Any is populated
	default:
		// Unknown type - use variables.GetUnknownRaw() for raw JSON
}
```
