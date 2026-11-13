# BrowseVectorStoreConnectorDataUnion

A folder or an object directly inside the browsed folder. Only objects say whether the rules select them: a folder's answer is that of everything beneath it.


## Supported Types

### BrowseVectorStoreConnectorData1

```go
browseVectorStoreConnectorDataUnion := operations.CreateBrowseVectorStoreConnectorDataUnionFolder(operations.BrowseVectorStoreConnectorData1{/* values here */})
```

### BrowseVectorStoreConnectorData2

```go
browseVectorStoreConnectorDataUnion := operations.CreateBrowseVectorStoreConnectorDataUnionObject(operations.BrowseVectorStoreConnectorData2{/* values here */})
```

## Union Discrimination

Use the `Type` field to determine which variant is active, then access the corresponding field:

```go
switch browseVectorStoreConnectorDataUnion.Type {
	case operations.BrowseVectorStoreConnectorDataUnionTypeFolder:
		// browseVectorStoreConnectorDataUnion.BrowseVectorStoreConnectorData1 is populated
	case operations.BrowseVectorStoreConnectorDataUnionTypeObject:
		// browseVectorStoreConnectorDataUnion.BrowseVectorStoreConnectorData2 is populated
	default:
		// Unknown type - use browseVectorStoreConnectorDataUnion.GetUnknownRaw() for raw JSON
}
```
