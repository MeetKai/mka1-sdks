# PutOrgAutoModelResponseBody

OK


## Supported Types

### DirectOrgAutoModel

```go
putOrgAutoModelResponseBody := operations.CreatePutOrgAutoModelResponseBodyDirect(components.DirectOrgAutoModel{/* values here */})
```

### BalancedOrgAutoModel

```go
putOrgAutoModelResponseBody := operations.CreatePutOrgAutoModelResponseBodyBalanced(components.BalancedOrgAutoModel{/* values here */})
```

### PriceOrgAutoModel

```go
putOrgAutoModelResponseBody := operations.CreatePutOrgAutoModelResponseBodyPrice(components.PriceOrgAutoModel{/* values here */})
```

### QualityOrgAutoModel

```go
putOrgAutoModelResponseBody := operations.CreatePutOrgAutoModelResponseBodyQuality(components.QualityOrgAutoModel{/* values here */})
```

### SpeedOrgAutoModel

```go
putOrgAutoModelResponseBody := operations.CreatePutOrgAutoModelResponseBodySpeed(components.SpeedOrgAutoModel{/* values here */})
```

## Union Discrimination

Use the `Type` field to determine which variant is active, then access the corresponding field:

```go
switch putOrgAutoModelResponseBody.Type {
	case operations.PutOrgAutoModelResponseBodyTypeDirect:
		// putOrgAutoModelResponseBody.DirectOrgAutoModel is populated
	case operations.PutOrgAutoModelResponseBodyTypeBalanced:
		// putOrgAutoModelResponseBody.BalancedOrgAutoModel is populated
	case operations.PutOrgAutoModelResponseBodyTypePrice:
		// putOrgAutoModelResponseBody.PriceOrgAutoModel is populated
	case operations.PutOrgAutoModelResponseBodyTypeQuality:
		// putOrgAutoModelResponseBody.QualityOrgAutoModel is populated
	case operations.PutOrgAutoModelResponseBodyTypeSpeed:
		// putOrgAutoModelResponseBody.SpeedOrgAutoModel is populated
	default:
		// Unknown type - use putOrgAutoModelResponseBody.GetUnknownRaw() for raw JSON
}
```
