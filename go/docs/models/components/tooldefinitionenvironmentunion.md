# ToolDefinitionEnvironmentUnion


## Supported Types

### EnvironmentContainerAuto

```go
toolDefinitionEnvironmentUnion := components.CreateToolDefinitionEnvironmentUnionContainerAuto(components.EnvironmentContainerAuto{/* values here */})
```

### EnvironmentContainerReference

```go
toolDefinitionEnvironmentUnion := components.CreateToolDefinitionEnvironmentUnionContainerReference(components.EnvironmentContainerReference{/* values here */})
```

## Union Discrimination

Use the `Type` field to determine which variant is active, then access the corresponding field:

```go
switch toolDefinitionEnvironmentUnion.Type {
	case components.ToolDefinitionEnvironmentUnionTypeContainerAuto:
		// toolDefinitionEnvironmentUnion.EnvironmentContainerAuto is populated
	case components.ToolDefinitionEnvironmentUnionTypeContainerReference:
		// toolDefinitionEnvironmentUnion.EnvironmentContainerReference is populated
	default:
		// Unknown type - use toolDefinitionEnvironmentUnion.GetUnknownRaw() for raw JSON
}
```
