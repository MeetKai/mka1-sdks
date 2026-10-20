# FileSearchResultAttributes


## Supported Types

### 

```go
fileSearchResultAttributes := components.CreateFileSearchResultAttributesStr(string{/* values here */})
```

### 

```go
fileSearchResultAttributes := components.CreateFileSearchResultAttributesBoolean(bool{/* values here */})
```

### 

```go
fileSearchResultAttributes := components.CreateFileSearchResultAttributesNumber(float64{/* values here */})
```

## Union Discrimination

Use the `Type` field to determine which variant is active, then access the corresponding field:

```go
switch fileSearchResultAttributes.Type {
	case components.FileSearchResultAttributesTypeStr:
		// fileSearchResultAttributes.Str is populated
	case components.FileSearchResultAttributesTypeBoolean:
		// fileSearchResultAttributes.Boolean is populated
	case components.FileSearchResultAttributesTypeNumber:
		// fileSearchResultAttributes.Number is populated
	default:
		// Unknown type - use fileSearchResultAttributes.GetUnknownRaw() for raw JSON
}
```
