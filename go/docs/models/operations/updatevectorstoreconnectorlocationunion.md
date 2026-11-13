# UpdateVectorStoreConnectorLocationUnion

Where the connector reads from, in the shape of its `type`. Fixed at creation.


## Supported Types

### UpdateVectorStoreConnectorLocation1

```go
updateVectorStoreConnectorLocationUnion := operations.CreateUpdateVectorStoreConnectorLocationUnionUpdateVectorStoreConnectorLocation1(operations.UpdateVectorStoreConnectorLocation1{/* values here */})
```

### UpdateVectorStoreConnectorLocation2

```go
updateVectorStoreConnectorLocationUnion := operations.CreateUpdateVectorStoreConnectorLocationUnionUpdateVectorStoreConnectorLocation2(operations.UpdateVectorStoreConnectorLocation2{/* values here */})
```

## Union Discrimination

Use the `Type` field to determine which variant is active, then access the corresponding field:

```go
switch updateVectorStoreConnectorLocationUnion.Type {
	case operations.UpdateVectorStoreConnectorLocationUnionTypeUpdateVectorStoreConnectorLocation1:
		// updateVectorStoreConnectorLocationUnion.UpdateVectorStoreConnectorLocation1 is populated
	case operations.UpdateVectorStoreConnectorLocationUnionTypeUpdateVectorStoreConnectorLocation2:
		// updateVectorStoreConnectorLocationUnion.UpdateVectorStoreConnectorLocation2 is populated
	default:
		// Unknown type - use updateVectorStoreConnectorLocationUnion.GetUnknownRaw() for raw JSON
}
```
