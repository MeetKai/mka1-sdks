# Credentials

Replaces the stored credential, in the shape of the connector's `type`; takes effect at the next sync.


## Supported Types

### UpdateVectorStoreConnectorCredentials1

```go
credentials := operations.CreateCredentialsUpdateVectorStoreConnectorCredentials1(operations.UpdateVectorStoreConnectorCredentials1{/* values here */})
```

### UpdateVectorStoreConnectorCredentials2

```go
credentials := operations.CreateCredentialsUpdateVectorStoreConnectorCredentials2(operations.UpdateVectorStoreConnectorCredentials2{/* values here */})
```

## Union Discrimination

Use the `Type` field to determine which variant is active, then access the corresponding field:

```go
switch credentials.Type {
	case operations.CredentialsTypeUpdateVectorStoreConnectorCredentials1:
		// credentials.UpdateVectorStoreConnectorCredentials1 is populated
	case operations.CredentialsTypeUpdateVectorStoreConnectorCredentials2:
		// credentials.UpdateVectorStoreConnectorCredentials2 is populated
}
```
