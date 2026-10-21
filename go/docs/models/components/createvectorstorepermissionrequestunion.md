# CreateVectorStorePermissionRequestUnion

Grants a role on the store, replacing any role the principal already holds. `grantee_type` defaults to `user`.


## Supported Types

### CreateVectorStorePermissionRequest1

```go
createVectorStorePermissionRequestUnion := components.CreateCreateVectorStorePermissionRequestUnionUser(components.CreateVectorStorePermissionRequest1{/* values here */})
```

### CreateVectorStorePermissionRequest2

```go
createVectorStorePermissionRequestUnion := components.CreateCreateVectorStorePermissionRequestUnionTeam(components.CreateVectorStorePermissionRequest2{/* values here */})
```

## Union Discrimination

Use the `Type` field to determine which variant is active, then access the corresponding field:

```go
switch createVectorStorePermissionRequestUnion.Type {
	case components.CreateVectorStorePermissionRequestUnionTypeUser:
		// createVectorStorePermissionRequestUnion.CreateVectorStorePermissionRequest1 is populated
	case components.CreateVectorStorePermissionRequestUnionTypeTeam:
		// createVectorStorePermissionRequestUnion.CreateVectorStorePermissionRequest2 is populated
}
```
