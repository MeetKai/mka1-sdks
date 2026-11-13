# LinkVectorStoreConnectorLocationUnion

Where the connector reads from, in the shape of its `type`. Fixed at creation.


## Supported Types

### LinkVectorStoreConnectorLocation1

```go
linkVectorStoreConnectorLocationUnion := operations.CreateLinkVectorStoreConnectorLocationUnionLinkVectorStoreConnectorLocation1(operations.LinkVectorStoreConnectorLocation1{/* values here */})
```

### LinkVectorStoreConnectorLocation2

```go
linkVectorStoreConnectorLocationUnion := operations.CreateLinkVectorStoreConnectorLocationUnionLinkVectorStoreConnectorLocation2(operations.LinkVectorStoreConnectorLocation2{/* values here */})
```

## Union Discrimination

Use the `Type` field to determine which variant is active, then access the corresponding field:

```go
switch linkVectorStoreConnectorLocationUnion.Type {
	case operations.LinkVectorStoreConnectorLocationUnionTypeLinkVectorStoreConnectorLocation1:
		// linkVectorStoreConnectorLocationUnion.LinkVectorStoreConnectorLocation1 is populated
	case operations.LinkVectorStoreConnectorLocationUnionTypeLinkVectorStoreConnectorLocation2:
		// linkVectorStoreConnectorLocationUnion.LinkVectorStoreConnectorLocation2 is populated
	default:
		// Unknown type - use linkVectorStoreConnectorLocationUnion.GetUnknownRaw() for raw JSON
}
```
