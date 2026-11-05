# OutputTextAnnotation


## Supported Types

### FileCitation

```go
outputTextAnnotation := components.CreateOutputTextAnnotationFileCitation(components.FileCitation{/* values here */})
```

### URLCitation

```go
outputTextAnnotation := components.CreateOutputTextAnnotationURLCitation(components.URLCitation{/* values here */})
```

### ContainerFileCitation

```go
outputTextAnnotation := components.CreateOutputTextAnnotationContainerFileCitation(components.ContainerFileCitation{/* values here */})
```

### FilePath

```go
outputTextAnnotation := components.CreateOutputTextAnnotationFilePath(components.FilePath{/* values here */})
```

## Union Discrimination

Use the `Type` field to determine which variant is active, then access the corresponding field:

```go
switch outputTextAnnotation.Type {
	case components.OutputTextAnnotationTypeFileCitation:
		// outputTextAnnotation.FileCitation is populated
	case components.OutputTextAnnotationTypeURLCitation:
		// outputTextAnnotation.URLCitation is populated
	case components.OutputTextAnnotationTypeContainerFileCitation:
		// outputTextAnnotation.ContainerFileCitation is populated
	case components.OutputTextAnnotationTypeFilePath:
		// outputTextAnnotation.FilePath is populated
	default:
		// Unknown type - use outputTextAnnotation.GetUnknownRaw() for raw JSON
}
```
