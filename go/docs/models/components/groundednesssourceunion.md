# GroundednessSourceUnion


## Supported Types

### GroundednessSource1

```go
groundednessSourceUnion := components.CreateGroundednessSourceUnionFile(components.GroundednessSource1{/* values here */})
```

### GroundednessSource2

```go
groundednessSourceUnion := components.CreateGroundednessSourceUnionURLObj(components.GroundednessSource2{/* values here */})
```

## Union Discrimination

Use the `Type` field to determine which variant is active, then access the corresponding field:

```go
switch groundednessSourceUnion.Type {
	case components.GroundednessSourceUnionTypeFile:
		// groundednessSourceUnion.GroundednessSource1 is populated
	case components.GroundednessSourceUnionTypeURLObj:
		// groundednessSourceUnion.GroundednessSource2 is populated
	default:
		// Unknown type - use groundednessSourceUnion.GetUnknownRaw() for raw JSON
}
```
