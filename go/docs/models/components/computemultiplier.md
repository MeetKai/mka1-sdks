# ComputeMultiplier


## Supported Types

### 

```go
computeMultiplier := components.CreateComputeMultiplierStr(string{/* values here */})
```

### 

```go
computeMultiplier := components.CreateComputeMultiplierNumber(float64{/* values here */})
```

## Union Discrimination

Use the `Type` field to determine which variant is active, then access the corresponding field:

```go
switch computeMultiplier.Type {
	case components.ComputeMultiplierTypeStr:
		// computeMultiplier.Str is populated
	case components.ComputeMultiplierTypeNumber:
		// computeMultiplier.Number is populated
	default:
		// Unknown type - use computeMultiplier.GetUnknownRaw() for raw JSON
}
```
