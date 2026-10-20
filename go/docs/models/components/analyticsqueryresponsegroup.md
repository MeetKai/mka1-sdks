# AnalyticsQueryResponseGroup


## Supported Types

### 

```go
analyticsQueryResponseGroup := components.CreateAnalyticsQueryResponseGroupStr(string{/* values here */})
```

### 

```go
analyticsQueryResponseGroup := components.CreateAnalyticsQueryResponseGroupNumber(float64{/* values here */})
```

### 

```go
analyticsQueryResponseGroup := components.CreateAnalyticsQueryResponseGroupBoolean(bool{/* values here */})
```

## Union Discrimination

Use the `Type` field to determine which variant is active, then access the corresponding field:

```go
switch analyticsQueryResponseGroup.Type {
	case components.AnalyticsQueryResponseGroupTypeStr:
		// analyticsQueryResponseGroup.Str is populated
	case components.AnalyticsQueryResponseGroupTypeNumber:
		// analyticsQueryResponseGroup.Number is populated
	case components.AnalyticsQueryResponseGroupTypeBoolean:
		// analyticsQueryResponseGroup.Boolean is populated
	default:
		// Unknown type - use analyticsQueryResponseGroup.GetUnknownRaw() for raw JSON
}
```
