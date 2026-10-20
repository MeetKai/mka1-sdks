# Invitation


## Supported Types

### InvitationOrganization

```go
invitation := operations.CreateInvitationOrganization(operations.InvitationOrganization{/* values here */})
```

### InvitationCluster

```go
invitation := operations.CreateInvitationCluster(operations.InvitationCluster{/* values here */})
```

## Union Discrimination

Use the `Type` field to determine which variant is active, then access the corresponding field:

```go
switch invitation.Type {
	case operations.InvitationTypeOrganization:
		// invitation.InvitationOrganization is populated
	case operations.InvitationTypeCluster:
		// invitation.InvitationCluster is populated
	default:
		// Unknown type - use invitation.GetUnknownRaw() for raw JSON
}
```
