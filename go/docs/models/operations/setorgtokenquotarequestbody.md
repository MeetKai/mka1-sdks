# SetOrgTokenQuotaRequestBody


## Supported Types

### SetOrgTokenQuotaRequestBody1

```go
setOrgTokenQuotaRequestBody := operations.CreateSetOrgTokenQuotaRequestBodySetOrgTokenQuotaRequestBody1(operations.SetOrgTokenQuotaRequestBody1{/* values here */})
```

### SetOrgTokenQuotaRequestBody2

```go
setOrgTokenQuotaRequestBody := operations.CreateSetOrgTokenQuotaRequestBodySetOrgTokenQuotaRequestBody2(operations.SetOrgTokenQuotaRequestBody2{/* values here */})
```

## Union Discrimination

Use the `Type` field to determine which variant is active, then access the corresponding field:

```go
switch setOrgTokenQuotaRequestBody.Type {
	case operations.SetOrgTokenQuotaRequestBodyTypeSetOrgTokenQuotaRequestBody1:
		// setOrgTokenQuotaRequestBody.SetOrgTokenQuotaRequestBody1 is populated
	case operations.SetOrgTokenQuotaRequestBodyTypeSetOrgTokenQuotaRequestBody2:
		// setOrgTokenQuotaRequestBody.SetOrgTokenQuotaRequestBody2 is populated
}
```
