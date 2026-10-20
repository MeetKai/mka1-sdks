# Environment


## Supported Types

### EnvironmentContainerAuto

```go
environment := components.CreateEnvironmentContainerAuto(components.EnvironmentContainerAuto{/* values here */})
```

### EnvironmentContainerReference

```go
environment := components.CreateEnvironmentContainerReference(components.EnvironmentContainerReference{/* values here */})
```

## Union Discrimination

Use the `Type` field to determine which variant is active, then access the corresponding field:

```go
switch environment.Type {
	case components.EnvironmentTypeContainerAuto:
		// environment.EnvironmentContainerAuto is populated
	case components.EnvironmentTypeContainerReference:
		// environment.EnvironmentContainerReference is populated
	default:
		// Unknown type - use environment.GetUnknownRaw() for raw JSON
}
```
