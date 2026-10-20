# AnalyticsQueryRequestValue

Value to compare. The number 1 differs from the string '1'. Omit for exists and not_exists.


## Supported Types

### 

```go
analyticsQueryRequestValue := components.CreateAnalyticsQueryRequestValueStr(string{/* values here */})
```

### 

```go
analyticsQueryRequestValue := components.CreateAnalyticsQueryRequestValueNumber(float64{/* values here */})
```

### 

```go
analyticsQueryRequestValue := components.CreateAnalyticsQueryRequestValueBoolean(bool{/* values here */})
```

## Union Discrimination

Use the `Type` field to determine which variant is active, then access the corresponding field:

```go
switch analyticsQueryRequestValue.Type {
	case components.AnalyticsQueryRequestValueTypeStr:
		// analyticsQueryRequestValue.Str is populated
	case components.AnalyticsQueryRequestValueTypeNumber:
		// analyticsQueryRequestValue.Number is populated
	case components.AnalyticsQueryRequestValueTypeBoolean:
		// analyticsQueryRequestValue.Boolean is populated
}
```
