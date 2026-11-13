# Location

Where the connector reads from, in the shape of its `type`. Fixed at creation.


## Supported Types

### VectorStoreConnectorS3Location

```go
location := components.CreateLocationVectorStoreConnectorS3Location(components.VectorStoreConnectorS3Location{/* values here */})
```

### VectorStoreConnectorSharePointLocation

```go
location := components.CreateLocationVectorStoreConnectorSharePointLocation(components.VectorStoreConnectorSharePointLocation{/* values here */})
```

## Union Discrimination

Use the `Type` field to determine which variant is active, then access the corresponding field:

```go
switch location.Type {
	case components.LocationTypeVectorStoreConnectorS3Location:
		// location.VectorStoreConnectorS3Location is populated
	case components.LocationTypeVectorStoreConnectorSharePointLocation:
		// location.VectorStoreConnectorSharePointLocation is populated
	default:
		// Unknown type - use location.GetUnknownRaw() for raw JSON
}
```
