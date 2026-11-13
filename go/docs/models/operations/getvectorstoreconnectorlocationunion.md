# GetVectorStoreConnectorLocationUnion

Where the connector reads from, in the shape of its `type`. Fixed at creation.


## Supported Types

### GetVectorStoreConnectorLocation1

```go
getVectorStoreConnectorLocationUnion := operations.CreateGetVectorStoreConnectorLocationUnionGetVectorStoreConnectorLocation1(operations.GetVectorStoreConnectorLocation1{/* values here */})
```

### GetVectorStoreConnectorLocation2

```go
getVectorStoreConnectorLocationUnion := operations.CreateGetVectorStoreConnectorLocationUnionGetVectorStoreConnectorLocation2(operations.GetVectorStoreConnectorLocation2{/* values here */})
```

## Union Discrimination

Use the `Type` field to determine which variant is active, then access the corresponding field:

```go
switch getVectorStoreConnectorLocationUnion.Type {
	case operations.GetVectorStoreConnectorLocationUnionTypeGetVectorStoreConnectorLocation1:
		// getVectorStoreConnectorLocationUnion.GetVectorStoreConnectorLocation1 is populated
	case operations.GetVectorStoreConnectorLocationUnionTypeGetVectorStoreConnectorLocation2:
		// getVectorStoreConnectorLocationUnion.GetVectorStoreConnectorLocation2 is populated
	default:
		// Unknown type - use getVectorStoreConnectorLocationUnion.GetUnknownRaw() for raw JSON
}
```
