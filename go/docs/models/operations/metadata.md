# Metadata

Filter conversations by metadata key-value pairs (JSON string or object). Only conversations with matching metadata will be returned.


## Supported Types

### 

```go
metadata := operations.CreateMetadataStr(string{/* values here */})
```

### 

```go
metadata := operations.CreateMetadataMapOfStr(map[string]string{/* values here */})
```

## Union Discrimination

Use the `Type` field to determine which variant is active, then access the corresponding field:

```go
switch metadata.Type {
	case operations.MetadataTypeStr:
		// metadata.Str is populated
	case operations.MetadataTypeMapOfStr:
		// metadata.MapOfStr is populated
}
```
