# Beta


## Supported Types

### 

```go
beta := components.CreateBetaStr(string{/* values here */})
```

### 

```go
beta := components.CreateBetaNumber(float64{/* values here */})
```

## Union Discrimination

Use the `Type` field to determine which variant is active, then access the corresponding field:

```go
switch beta.Type {
	case components.BetaTypeStr:
		// beta.Str is populated
	case components.BetaTypeNumber:
		// beta.Number is populated
	default:
		// Unknown type - use beta.GetUnknownRaw() for raw JSON
}
```
