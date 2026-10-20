# RequireApprovalUnion1


## Supported Types

### RequireApprovalEnum1

```go
requireApprovalUnion1 := components.CreateRequireApprovalUnion1RequireApprovalEnum1(components.RequireApprovalEnum1{/* values here */})
```

### RequireApproval1

```go
requireApprovalUnion1 := components.CreateRequireApprovalUnion1RequireApproval1(components.RequireApproval1{/* values here */})
```

## Union Discrimination

Use the `Type` field to determine which variant is active, then access the corresponding field:

```go
switch requireApprovalUnion1.Type {
	case components.RequireApprovalUnion1TypeRequireApprovalEnum1:
		// requireApprovalUnion1.RequireApprovalEnum1 is populated
	case components.RequireApprovalUnion1TypeRequireApproval1:
		// requireApprovalUnion1.RequireApproval1 is populated
	default:
		// Unknown type - use requireApprovalUnion1.GetUnknownRaw() for raw JSON
}
```
