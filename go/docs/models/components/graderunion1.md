# GraderUnion1


## Supported Types

### Grader1

```go
graderUnion1 := components.CreateGraderUnion1StringCheck(components.Grader1{/* values here */})
```

### Grader2

```go
graderUnion1 := components.CreateGraderUnion1TextSimilarity(components.Grader2{/* values here */})
```

### Grader3

```go
graderUnion1 := components.CreateGraderUnion1Python(components.Grader3{/* values here */})
```

### Grader4

```go
graderUnion1 := components.CreateGraderUnion1ScoreModel(components.Grader4{/* values here */})
```

### Grader5

```go
graderUnion1 := components.CreateGraderUnion1LabelModel(components.Grader5{/* values here */})
```

## Union Discrimination

Use the `Type` field to determine which variant is active, then access the corresponding field:

```go
switch graderUnion1.Type {
	case components.GraderUnion1TypeStringCheck:
		// graderUnion1.Grader1 is populated
	case components.GraderUnion1TypeTextSimilarity:
		// graderUnion1.Grader2 is populated
	case components.GraderUnion1TypePython:
		// graderUnion1.Grader3 is populated
	case components.GraderUnion1TypeScoreModel:
		// graderUnion1.Grader4 is populated
	case components.GraderUnion1TypeLabelModel:
		// graderUnion1.Grader5 is populated
	default:
		// Unknown type - use graderUnion1.GetUnknownRaw() for raw JSON
}
```
