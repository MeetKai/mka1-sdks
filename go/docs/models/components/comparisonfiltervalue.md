# ComparisonFilterValue


## Supported Types

### 

```go
comparisonFilterValue := components.CreateComparisonFilterValueStr(string{/* values here */})
```

### 

```go
comparisonFilterValue := components.CreateComparisonFilterValueNumber(float64{/* values here */})
```

### 

```go
comparisonFilterValue := components.CreateComparisonFilterValueBoolean(bool{/* values here */})
```

## Union Discrimination

Use the `Type` field to determine which variant is active, then access the corresponding field:

```go
switch comparisonFilterValue.Type {
	case components.ComparisonFilterValueTypeStr:
		// comparisonFilterValue.Str is populated
	case components.ComparisonFilterValueTypeNumber:
		// comparisonFilterValue.Number is populated
	case components.ComparisonFilterValueTypeBoolean:
		// comparisonFilterValue.Boolean is populated
	default:
		// Unknown type - use comparisonFilterValue.GetUnknownRaw() for raw JSON
}
```
