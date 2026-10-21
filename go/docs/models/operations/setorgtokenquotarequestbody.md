# SetOrgTokenQuotaRequestBody


## Supported Types

### RequestBody1

```go
setOrgTokenQuotaRequestBody := operations.CreateSetOrgTokenQuotaRequestBodyRequestBody1(operations.RequestBody1{/* values here */})
```

### RequestBody2

```go
setOrgTokenQuotaRequestBody := operations.CreateSetOrgTokenQuotaRequestBodyRequestBody2(operations.RequestBody2{/* values here */})
```

## Union Discrimination

Use the `Type` field to determine which variant is active, then access the corresponding field:

```go
switch setOrgTokenQuotaRequestBody.Type {
	case operations.SetOrgTokenQuotaRequestBodyTypeRequestBody1:
		// setOrgTokenQuotaRequestBody.RequestBody1 is populated
	case operations.SetOrgTokenQuotaRequestBodyTypeRequestBody2:
		// setOrgTokenQuotaRequestBody.RequestBody2 is populated
}
```
