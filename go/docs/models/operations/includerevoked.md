# IncludeRevoked


## Supported Types

### 

```go
includeRevoked := operations.CreateIncludeRevokedBoolean(bool{/* values here */})
```

### 

```go
includeRevoked := operations.CreateIncludeRevokedStr(string{/* values here */})
```

## Union Discrimination

Use the `Type` field to determine which variant is active, then access the corresponding field:

```go
switch includeRevoked.Type {
	case operations.IncludeRevokedTypeBoolean:
		// includeRevoked.Boolean is populated
	case operations.IncludeRevokedTypeStr:
		// includeRevoked.Str is populated
}
```
