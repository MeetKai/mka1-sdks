# Query

A query string for a search, or an array of query strings.


## Supported Types

### 

```go
query := components.CreateQueryStr(string{/* values here */})
```

### 

```go
query := components.CreateQueryArrayOfStr([]string{/* values here */})
```

## Union Discrimination

Use the `Type` field to determine which variant is active, then access the corresponding field:

```go
switch query.Type {
	case components.QueryTypeStr:
		// query.Str is populated
	case components.QueryTypeArrayOfStr:
		// query.ArrayOfStr is populated
}
```
