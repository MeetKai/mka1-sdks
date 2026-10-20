# ToolDefinitionUnion1


## Supported Types

### ToolDefinitionMcp1

```go
toolDefinitionUnion1 := components.CreateToolDefinitionUnion1ToolDefinitionMcp1(components.ToolDefinitionMcp1{/* values here */})
```

### ToolDefinitionMcp2

```go
toolDefinitionUnion1 := components.CreateToolDefinitionUnion1ToolDefinitionMcp2(components.ToolDefinitionMcp2{/* values here */})
```

## Union Discrimination

Use the `Type` field to determine which variant is active, then access the corresponding field:

```go
switch toolDefinitionUnion1.Type {
	case components.ToolDefinitionUnion1TypeToolDefinitionMcp1:
		// toolDefinitionUnion1.ToolDefinitionMcp1 is populated
	case components.ToolDefinitionUnion1TypeToolDefinitionMcp2:
		// toolDefinitionUnion1.ToolDefinitionMcp2 is populated
	default:
		// Unknown type - use toolDefinitionUnion1.GetUnknownRaw() for raw JSON
}
```
