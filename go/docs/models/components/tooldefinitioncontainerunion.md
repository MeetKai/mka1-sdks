# ToolDefinitionContainerUnion


## Supported Types

### 

```go
toolDefinitionContainerUnion := components.CreateToolDefinitionContainerUnionStr(string{/* values here */})
```

### ContainerAuto

```go
toolDefinitionContainerUnion := components.CreateToolDefinitionContainerUnionContainerAuto(components.ContainerAuto{/* values here */})
```

## Union Discrimination

Use the `Type` field to determine which variant is active, then access the corresponding field:

```go
switch toolDefinitionContainerUnion.Type {
	case components.ToolDefinitionContainerUnionTypeStr:
		// toolDefinitionContainerUnion.Str is populated
	case components.ToolDefinitionContainerUnionTypeContainerAuto:
		// toolDefinitionContainerUnion.ContainerAuto is populated
	default:
		// Unknown type - use toolDefinitionContainerUnion.GetUnknownRaw() for raw JSON
}
```
