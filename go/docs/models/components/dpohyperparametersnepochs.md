# DpoHyperparametersNEpochs


## Supported Types

### 

```go
dpoHyperparametersNEpochs := components.CreateDpoHyperparametersNEpochsStr(string{/* values here */})
```

### 

```go
dpoHyperparametersNEpochs := components.CreateDpoHyperparametersNEpochsInteger(int64{/* values here */})
```

## Union Discrimination

Use the `Type` field to determine which variant is active, then access the corresponding field:

```go
switch dpoHyperparametersNEpochs.Type {
	case components.DpoHyperparametersNEpochsTypeStr:
		// dpoHyperparametersNEpochs.Str is populated
	case components.DpoHyperparametersNEpochsTypeInteger:
		// dpoHyperparametersNEpochs.Integer is populated
	default:
		// Unknown type - use dpoHyperparametersNEpochs.GetUnknownRaw() for raw JSON
}
```
