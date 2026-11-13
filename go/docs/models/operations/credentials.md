# Credentials

Replaces the stored credential, in the shape of the connector's `type`; takes effect at the next sync.


## Supported Types

### VectorStoreConnectorS3Credentials

```go
credentials := operations.CreateCredentialsVectorStoreConnectorS3Credentials(components.VectorStoreConnectorS3Credentials{/* values here */})
```

### VectorStoreConnectorSharePointCredentials

```go
credentials := operations.CreateCredentialsVectorStoreConnectorSharePointCredentials(components.VectorStoreConnectorSharePointCredentials{/* values here */})
```

## Union Discrimination

Use the `Type` field to determine which variant is active, then access the corresponding field:

```go
switch credentials.Type {
	case operations.CredentialsTypeVectorStoreConnectorS3Credentials:
		// credentials.VectorStoreConnectorS3Credentials is populated
	case operations.CredentialsTypeVectorStoreConnectorSharePointCredentials:
		// credentials.VectorStoreConnectorSharePointCredentials is populated
}
```
