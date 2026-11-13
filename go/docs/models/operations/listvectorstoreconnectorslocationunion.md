# ListVectorStoreConnectorsLocationUnion

Where the connector reads from, in the shape of its `type`. Fixed at creation.


## Supported Types

### ListVectorStoreConnectorsLocation1

```go
listVectorStoreConnectorsLocationUnion := operations.CreateListVectorStoreConnectorsLocationUnionListVectorStoreConnectorsLocation1(operations.ListVectorStoreConnectorsLocation1{/* values here */})
```

### ListVectorStoreConnectorsLocation2

```go
listVectorStoreConnectorsLocationUnion := operations.CreateListVectorStoreConnectorsLocationUnionListVectorStoreConnectorsLocation2(operations.ListVectorStoreConnectorsLocation2{/* values here */})
```

## Union Discrimination

Use the `Type` field to determine which variant is active, then access the corresponding field:

```go
switch listVectorStoreConnectorsLocationUnion.Type {
	case operations.ListVectorStoreConnectorsLocationUnionTypeListVectorStoreConnectorsLocation1:
		// listVectorStoreConnectorsLocationUnion.ListVectorStoreConnectorsLocation1 is populated
	case operations.ListVectorStoreConnectorsLocationUnionTypeListVectorStoreConnectorsLocation2:
		// listVectorStoreConnectorsLocationUnion.ListVectorStoreConnectorsLocation2 is populated
	default:
		// Unknown type - use listVectorStoreConnectorsLocationUnion.GetUnknownRaw() for raw JSON
}
```
