# SupervisedHyperparametersNEpochs


## Supported Types

### 

```go
supervisedHyperparametersNEpochs := components.CreateSupervisedHyperparametersNEpochsStr(string{/* values here */})
```

### 

```go
supervisedHyperparametersNEpochs := components.CreateSupervisedHyperparametersNEpochsInteger(int64{/* values here */})
```

## Union Discrimination

Use the `Type` field to determine which variant is active, then access the corresponding field:

```go
switch supervisedHyperparametersNEpochs.Type {
	case components.SupervisedHyperparametersNEpochsTypeStr:
		// supervisedHyperparametersNEpochs.Str is populated
	case components.SupervisedHyperparametersNEpochsTypeInteger:
		// supervisedHyperparametersNEpochs.Integer is populated
	default:
		// Unknown type - use supervisedHyperparametersNEpochs.GetUnknownRaw() for raw JSON
}
```
