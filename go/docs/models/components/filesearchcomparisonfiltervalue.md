# FileSearchComparisonFilterValue


## Supported Types

### 

```go
fileSearchComparisonFilterValue := components.CreateFileSearchComparisonFilterValueStr(string{/* values here */})
```

### 

```go
fileSearchComparisonFilterValue := components.CreateFileSearchComparisonFilterValueNumber(float64{/* values here */})
```

### 

```go
fileSearchComparisonFilterValue := components.CreateFileSearchComparisonFilterValueBoolean(bool{/* values here */})
```

## Union Discrimination

Use the `Type` field to determine which variant is active, then access the corresponding field:

```go
switch fileSearchComparisonFilterValue.Type {
	case components.FileSearchComparisonFilterValueTypeStr:
		// fileSearchComparisonFilterValue.Str is populated
	case components.FileSearchComparisonFilterValueTypeNumber:
		// fileSearchComparisonFilterValue.Number is populated
	case components.FileSearchComparisonFilterValueTypeBoolean:
		// fileSearchComparisonFilterValue.Boolean is populated
	default:
		// Unknown type - use fileSearchComparisonFilterValue.GetUnknownRaw() for raw JSON
}
```
