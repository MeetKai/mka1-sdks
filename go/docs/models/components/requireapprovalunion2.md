# RequireApprovalUnion2


## Supported Types

### RequireApprovalEnum2

```go
requireApprovalUnion2 := components.CreateRequireApprovalUnion2RequireApprovalEnum2(components.RequireApprovalEnum2{/* values here */})
```

### RequireApproval2

```go
requireApprovalUnion2 := components.CreateRequireApprovalUnion2RequireApproval2(components.RequireApproval2{/* values here */})
```

## Union Discrimination

Use the `Type` field to determine which variant is active, then access the corresponding field:

```go
switch requireApprovalUnion2.Type {
	case components.RequireApprovalUnion2TypeRequireApprovalEnum2:
		// requireApprovalUnion2.RequireApprovalEnum2 is populated
	case components.RequireApprovalUnion2TypeRequireApproval2:
		// requireApprovalUnion2.RequireApproval2 is populated
	default:
		// Unknown type - use requireApprovalUnion2.GetUnknownRaw() for raw JSON
}
```
