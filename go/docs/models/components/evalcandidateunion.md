# EvalCandidateUnion


## Supported Types

### EvalCandidate1

```go
evalCandidateUnion := components.CreateEvalCandidateUnionModel(components.EvalCandidate1{/* values here */})
```

### EvalCandidate2

```go
evalCandidateUnion := components.CreateEvalCandidateUnionSavedAgent(components.EvalCandidate2{/* values here */})
```

## Union Discrimination

Use the `Type` field to determine which variant is active, then access the corresponding field:

```go
switch evalCandidateUnion.Type {
	case components.EvalCandidateUnionTypeModel:
		// evalCandidateUnion.EvalCandidate1 is populated
	case components.EvalCandidateUnionTypeSavedAgent:
		// evalCandidateUnion.EvalCandidate2 is populated
}
```
