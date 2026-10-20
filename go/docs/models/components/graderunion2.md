# GraderUnion2


## Supported Types

### GraderUnion1

```go
graderUnion2 := components.CreateGraderUnion2GraderUnion1(components.GraderUnion1{/* values here */})
```

### Grader6

```go
graderUnion2 := components.CreateGraderUnion2Grader6(components.Grader6{/* values here */})
```

## Union Discrimination

Use the `Type` field to determine which variant is active, then access the corresponding field:

```go
switch graderUnion2.Type {
	case components.GraderUnion2TypeGraderUnion1:
		// graderUnion2.GraderUnion1 is populated
	case components.GraderUnion2TypeGrader6:
		// graderUnion2.Grader6 is populated
	default:
		// Unknown type - use graderUnion2.GetUnknownRaw() for raw JSON
}
```
