# EvalOutputExtractionUnion


## Supported Types

### EvalOutputExtraction1

```go
evalOutputExtractionUnion := components.CreateEvalOutputExtractionUnionNone(components.EvalOutputExtraction1{/* values here */})
```

### EvalOutputExtraction2

```go
evalOutputExtractionUnion := components.CreateEvalOutputExtractionUnionTakeFirst(components.EvalOutputExtraction2{/* values here */})
```

### EvalOutputExtraction3

```go
evalOutputExtractionUnion := components.CreateEvalOutputExtractionUnionRegex(components.EvalOutputExtraction3{/* values here */})
```

### EvalOutputExtraction4

```go
evalOutputExtractionUnion := components.CreateEvalOutputExtractionUnionRegexLast(components.EvalOutputExtraction4{/* values here */})
```

### EvalOutputExtraction5

```go
evalOutputExtractionUnion := components.CreateEvalOutputExtractionUnionLabelSet(components.EvalOutputExtraction5{/* values here */})
```

### EvalOutputExtraction6

```go
evalOutputExtractionUnion := components.CreateEvalOutputExtractionUnionNumber(components.EvalOutputExtraction6{/* values here */})
```

## Union Discrimination

Use the `Type` field to determine which variant is active, then access the corresponding field:

```go
switch evalOutputExtractionUnion.Type {
	case components.EvalOutputExtractionUnionTypeNone:
		// evalOutputExtractionUnion.EvalOutputExtraction1 is populated
	case components.EvalOutputExtractionUnionTypeTakeFirst:
		// evalOutputExtractionUnion.EvalOutputExtraction2 is populated
	case components.EvalOutputExtractionUnionTypeRegex:
		// evalOutputExtractionUnion.EvalOutputExtraction3 is populated
	case components.EvalOutputExtractionUnionTypeRegexLast:
		// evalOutputExtractionUnion.EvalOutputExtraction4 is populated
	case components.EvalOutputExtractionUnionTypeLabelSet:
		// evalOutputExtractionUnion.EvalOutputExtraction5 is populated
	case components.EvalOutputExtractionUnionTypeNumber:
		// evalOutputExtractionUnion.EvalOutputExtraction6 is populated
}
```
