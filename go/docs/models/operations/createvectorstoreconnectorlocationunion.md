# CreateVectorStoreConnectorLocationUnion

Where the connector reads from, in the shape of its `type`. Fixed at creation.


## Supported Types

### CreateVectorStoreConnectorLocationResponse1

```go
createVectorStoreConnectorLocationUnion := operations.CreateCreateVectorStoreConnectorLocationUnionCreateVectorStoreConnectorLocationResponse1(operations.CreateVectorStoreConnectorLocationResponse1{/* values here */})
```

### CreateVectorStoreConnectorLocationResponse2

```go
createVectorStoreConnectorLocationUnion := operations.CreateCreateVectorStoreConnectorLocationUnionCreateVectorStoreConnectorLocationResponse2(operations.CreateVectorStoreConnectorLocationResponse2{/* values here */})
```

## Union Discrimination

Use the `Type` field to determine which variant is active, then access the corresponding field:

```go
switch createVectorStoreConnectorLocationUnion.Type {
	case operations.CreateVectorStoreConnectorLocationUnionTypeCreateVectorStoreConnectorLocationResponse1:
		// createVectorStoreConnectorLocationUnion.CreateVectorStoreConnectorLocationResponse1 is populated
	case operations.CreateVectorStoreConnectorLocationUnionTypeCreateVectorStoreConnectorLocationResponse2:
		// createVectorStoreConnectorLocationUnion.CreateVectorStoreConnectorLocationResponse2 is populated
	default:
		// Unknown type - use createVectorStoreConnectorLocationUnion.GetUnknownRaw() for raw JSON
}
```
