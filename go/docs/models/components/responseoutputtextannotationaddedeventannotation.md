# ResponseOutputTextAnnotationAddedEventAnnotation


## Supported Types

### FileCitation

```go
responseOutputTextAnnotationAddedEventAnnotation := components.CreateResponseOutputTextAnnotationAddedEventAnnotationFileCitation(components.FileCitation{/* values here */})
```

### URLCitation

```go
responseOutputTextAnnotationAddedEventAnnotation := components.CreateResponseOutputTextAnnotationAddedEventAnnotationURLCitation(components.URLCitation{/* values here */})
```

### ContainerFileCitation

```go
responseOutputTextAnnotationAddedEventAnnotation := components.CreateResponseOutputTextAnnotationAddedEventAnnotationContainerFileCitation(components.ContainerFileCitation{/* values here */})
```

### FilePath

```go
responseOutputTextAnnotationAddedEventAnnotation := components.CreateResponseOutputTextAnnotationAddedEventAnnotationFilePath(components.FilePath{/* values here */})
```

## Union Discrimination

Use the `Type` field to determine which variant is active, then access the corresponding field:

```go
switch responseOutputTextAnnotationAddedEventAnnotation.Type {
	case components.ResponseOutputTextAnnotationAddedEventAnnotationTypeFileCitation:
		// responseOutputTextAnnotationAddedEventAnnotation.FileCitation is populated
	case components.ResponseOutputTextAnnotationAddedEventAnnotationTypeURLCitation:
		// responseOutputTextAnnotationAddedEventAnnotation.URLCitation is populated
	case components.ResponseOutputTextAnnotationAddedEventAnnotationTypeContainerFileCitation:
		// responseOutputTextAnnotationAddedEventAnnotation.ContainerFileCitation is populated
	case components.ResponseOutputTextAnnotationAddedEventAnnotationTypeFilePath:
		// responseOutputTextAnnotationAddedEventAnnotation.FilePath is populated
	default:
		// Unknown type - use responseOutputTextAnnotationAddedEventAnnotation.GetUnknownRaw() for raw JSON
}
```
