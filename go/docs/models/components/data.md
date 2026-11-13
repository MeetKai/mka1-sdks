# Data

A folder or an object directly inside the browsed folder. Only objects say whether the rules select them: a folder's answer is that of everything beneath it.


## Supported Types

### VectorStoreConnectorBrowseFolder

```go
data := components.CreateDataFolder(components.VectorStoreConnectorBrowseFolder{/* values here */})
```

### VectorStoreConnectorBrowseObject

```go
data := components.CreateDataObject(components.VectorStoreConnectorBrowseObject{/* values here */})
```

## Union Discrimination

Use the `Type` field to determine which variant is active, then access the corresponding field:

```go
switch data.Type {
	case components.DataTypeFolder:
		// data.VectorStoreConnectorBrowseFolder is populated
	case components.DataTypeObject:
		// data.VectorStoreConnectorBrowseObject is populated
	default:
		// Unknown type - use data.GetUnknownRaw() for raw JSON
}
```
