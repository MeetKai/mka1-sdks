# CreateResourcePermissionRequestUnion

Grants a role on the resource, replacing any role the principal already holds. `grantee_type` defaults to `user`.


## Supported Types

### CreateResourcePermissionRequest1

```go
createResourcePermissionRequestUnion := components.CreateCreateResourcePermissionRequestUnionUser(components.CreateResourcePermissionRequest1{/* values here */})
```

### CreateResourcePermissionRequest2

```go
createResourcePermissionRequestUnion := components.CreateCreateResourcePermissionRequestUnionTeam(components.CreateResourcePermissionRequest2{/* values here */})
```

## Union Discrimination

Use the `Type` field to determine which variant is active, then access the corresponding field:

```go
switch createResourcePermissionRequestUnion.Type {
	case components.CreateResourcePermissionRequestUnionTypeUser:
		// createResourcePermissionRequestUnion.CreateResourcePermissionRequest1 is populated
	case components.CreateResourcePermissionRequestUnionTypeTeam:
		// createResourcePermissionRequestUnion.CreateResourcePermissionRequest2 is populated
}
```
