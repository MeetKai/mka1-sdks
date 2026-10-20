# AnalyticsVisitorSearchRequestValue

Value to compare. The number 1 differs from the string '1'. Omit for exists and not_exists.


## Supported Types

### 

```go
analyticsVisitorSearchRequestValue := components.CreateAnalyticsVisitorSearchRequestValueStr(string{/* values here */})
```

### 

```go
analyticsVisitorSearchRequestValue := components.CreateAnalyticsVisitorSearchRequestValueNumber(float64{/* values here */})
```

### 

```go
analyticsVisitorSearchRequestValue := components.CreateAnalyticsVisitorSearchRequestValueBoolean(bool{/* values here */})
```

## Union Discrimination

Use the `Type` field to determine which variant is active, then access the corresponding field:

```go
switch analyticsVisitorSearchRequestValue.Type {
	case components.AnalyticsVisitorSearchRequestValueTypeStr:
		// analyticsVisitorSearchRequestValue.Str is populated
	case components.AnalyticsVisitorSearchRequestValueTypeNumber:
		// analyticsVisitorSearchRequestValue.Number is populated
	case components.AnalyticsVisitorSearchRequestValueTypeBoolean:
		// analyticsVisitorSearchRequestValue.Boolean is populated
}
```
