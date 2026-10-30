# EvalCandidateObjectUnion


## Supported Types

### EvalCandidateObject1

```go
evalCandidateObjectUnion := components.CreateEvalCandidateObjectUnionModel(components.EvalCandidateObject1{/* values here */})
```

### EvalCandidateObject2

```go
evalCandidateObjectUnion := components.CreateEvalCandidateObjectUnionSavedAgent(components.EvalCandidateObject2{/* values here */})
```

## Union Discrimination

Use the `Type` field to determine which variant is active, then access the corresponding field:

```go
switch evalCandidateObjectUnion.Type {
	case components.EvalCandidateObjectUnionTypeModel:
		// evalCandidateObjectUnion.EvalCandidateObject1 is populated
	case components.EvalCandidateObjectUnionTypeSavedAgent:
		// evalCandidateObjectUnion.EvalCandidateObject2 is populated
	default:
		// Unknown type - use evalCandidateObjectUnion.GetUnknownRaw() for raw JSON
}
```
