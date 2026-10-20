# Annotation


## Supported Types

### FileCitation

```go
annotation := components.CreateAnnotationFileCitation(components.FileCitation{/* values here */})
```

### URLCitation

```go
annotation := components.CreateAnnotationURLCitation(components.URLCitation{/* values here */})
```

### ContainerFileCitation

```go
annotation := components.CreateAnnotationContainerFileCitation(components.ContainerFileCitation{/* values here */})
```

### FilePath

```go
annotation := components.CreateAnnotationFilePath(components.FilePath{/* values here */})
```

## Union Discrimination

Use the `Type` field to determine which variant is active, then access the corresponding field:

```go
switch annotation.Type {
	case components.AnnotationTypeFileCitation:
		// annotation.FileCitation is populated
	case components.AnnotationTypeURLCitation:
		// annotation.URLCitation is populated
	case components.AnnotationTypeContainerFileCitation:
		// annotation.ContainerFileCitation is populated
	case components.AnnotationTypeFilePath:
		// annotation.FilePath is populated
	default:
		// Unknown type - use annotation.GetUnknownRaw() for raw JSON
}
```
