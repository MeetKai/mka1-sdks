# PutOrgAutoModelRequestUnion


## Supported Types

### PutOrgAutoModelRequest1

```go
putOrgAutoModelRequestUnion := components.CreatePutOrgAutoModelRequestUnionPutOrgAutoModelRequest1(components.PutOrgAutoModelRequest1{/* values here */})
```

### PutOrgAutoModelRequest2

```go
putOrgAutoModelRequestUnion := components.CreatePutOrgAutoModelRequestUnionPutOrgAutoModelRequest2(components.PutOrgAutoModelRequest2{/* values here */})
```

## Union Discrimination

Use the `Type` field to determine which variant is active, then access the corresponding field:

```go
switch putOrgAutoModelRequestUnion.Type {
	case components.PutOrgAutoModelRequestUnionTypePutOrgAutoModelRequest1:
		// putOrgAutoModelRequestUnion.PutOrgAutoModelRequest1 is populated
	case components.PutOrgAutoModelRequestUnionTypePutOrgAutoModelRequest2:
		// putOrgAutoModelRequestUnion.PutOrgAutoModelRequest2 is populated
}
```
