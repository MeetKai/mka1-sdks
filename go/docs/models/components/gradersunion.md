# GradersUnion


## Supported Types

### Graders1

```go
gradersUnion := components.CreateGradersUnionStringCheck(components.Graders1{/* values here */})
```

### Graders2

```go
gradersUnion := components.CreateGradersUnionTextSimilarity(components.Graders2{/* values here */})
```

### Graders3

```go
gradersUnion := components.CreateGradersUnionPython(components.Graders3{/* values here */})
```

### Graders4

```go
gradersUnion := components.CreateGradersUnionScoreModel(components.Graders4{/* values here */})
```

### Graders5

```go
gradersUnion := components.CreateGradersUnionLabelModel(components.Graders5{/* values here */})
```

## Union Discrimination

Use the `Type` field to determine which variant is active, then access the corresponding field:

```go
switch gradersUnion.Type {
	case components.GradersUnionTypeStringCheck:
		// gradersUnion.Graders1 is populated
	case components.GradersUnionTypeTextSimilarity:
		// gradersUnion.Graders2 is populated
	case components.GradersUnionTypePython:
		// gradersUnion.Graders3 is populated
	case components.GradersUnionTypeScoreModel:
		// gradersUnion.Graders4 is populated
	case components.GradersUnionTypeLabelModel:
		// gradersUnion.Graders5 is populated
	default:
		// Unknown type - use gradersUnion.GetUnknownRaw() for raw JSON
}
```
