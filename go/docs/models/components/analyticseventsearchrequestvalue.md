# AnalyticsEventSearchRequestValue

Value to compare. The number 1 differs from the string '1'. Omit for exists and not_exists.


## Supported Types

### 

```go
analyticsEventSearchRequestValue := components.CreateAnalyticsEventSearchRequestValueStr(string{/* values here */})
```

### 

```go
analyticsEventSearchRequestValue := components.CreateAnalyticsEventSearchRequestValueNumber(float64{/* values here */})
```

### 

```go
analyticsEventSearchRequestValue := components.CreateAnalyticsEventSearchRequestValueBoolean(bool{/* values here */})
```

## Union Discrimination

Use the `Type` field to determine which variant is active, then access the corresponding field:

```go
switch analyticsEventSearchRequestValue.Type {
	case components.AnalyticsEventSearchRequestValueTypeStr:
		// analyticsEventSearchRequestValue.Str is populated
	case components.AnalyticsEventSearchRequestValueTypeNumber:
		// analyticsEventSearchRequestValue.Number is populated
	case components.AnalyticsEventSearchRequestValueTypeBoolean:
		// analyticsEventSearchRequestValue.Boolean is populated
}
```
