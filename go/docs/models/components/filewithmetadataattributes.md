# FileWithMetadataAttributes


## Supported Types

### 

```go
fileWithMetadataAttributes := components.CreateFileWithMetadataAttributesStr(string{/* values here */})
```

### 

```go
fileWithMetadataAttributes := components.CreateFileWithMetadataAttributesBoolean(bool{/* values here */})
```

### 

```go
fileWithMetadataAttributes := components.CreateFileWithMetadataAttributesNumber(float64{/* values here */})
```

## Union Discrimination

Use the `Type` field to determine which variant is active, then access the corresponding field:

```go
switch fileWithMetadataAttributes.Type {
	case components.FileWithMetadataAttributesTypeStr:
		// fileWithMetadataAttributes.Str is populated
	case components.FileWithMetadataAttributesTypeBoolean:
		// fileWithMetadataAttributes.Boolean is populated
	case components.FileWithMetadataAttributesTypeNumber:
		// fileWithMetadataAttributes.Number is populated
}
```
