# OrgAutoModel


## Supported Types

### DirectOrgAutoModel

```go
orgAutoModel := components.CreateOrgAutoModelDirect(components.DirectOrgAutoModel{/* values here */})
```

### BalancedOrgAutoModel

```go
orgAutoModel := components.CreateOrgAutoModelBalanced(components.BalancedOrgAutoModel{/* values here */})
```

### PriceOrgAutoModel

```go
orgAutoModel := components.CreateOrgAutoModelPrice(components.PriceOrgAutoModel{/* values here */})
```

### QualityOrgAutoModel

```go
orgAutoModel := components.CreateOrgAutoModelQuality(components.QualityOrgAutoModel{/* values here */})
```

### SpeedOrgAutoModel

```go
orgAutoModel := components.CreateOrgAutoModelSpeed(components.SpeedOrgAutoModel{/* values here */})
```

## Union Discrimination

Use the `Type` field to determine which variant is active, then access the corresponding field:

```go
switch orgAutoModel.Type {
	case components.OrgAutoModelTypeDirect:
		// orgAutoModel.DirectOrgAutoModel is populated
	case components.OrgAutoModelTypeBalanced:
		// orgAutoModel.BalancedOrgAutoModel is populated
	case components.OrgAutoModelTypePrice:
		// orgAutoModel.PriceOrgAutoModel is populated
	case components.OrgAutoModelTypeQuality:
		// orgAutoModel.QualityOrgAutoModel is populated
	case components.OrgAutoModelTypeSpeed:
		// orgAutoModel.SpeedOrgAutoModel is populated
	default:
		// Unknown type - use orgAutoModel.GetUnknownRaw() for raw JSON
}
```
