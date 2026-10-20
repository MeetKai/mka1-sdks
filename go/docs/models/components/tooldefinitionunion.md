# ToolDefinitionUnion


## Supported Types

### FunctionToolReference

```go
toolDefinitionUnion := components.CreateToolDefinitionUnionFunctionToolReference(components.FunctionToolReference{/* values here */})
```

### ToolDefinition1

```go
toolDefinitionUnion := components.CreateToolDefinitionUnionToolDefinition1(components.ToolDefinition1{/* values here */})
```

### ToolDefinitionFunction

```go
toolDefinitionUnion := components.CreateToolDefinitionUnionToolDefinitionFunction(components.ToolDefinitionFunction{/* values here */})
```

### ToolDefinitionUnion1

```go
toolDefinitionUnion := components.CreateToolDefinitionUnionToolDefinitionUnion1(components.ToolDefinitionUnion1{/* values here */})
```

### ToolDefinitionFileSearch

```go
toolDefinitionUnion := components.CreateToolDefinitionUnionToolDefinitionFileSearch(components.ToolDefinitionFileSearch{/* values here */})
```

### ToolDefinition2

```go
toolDefinitionUnion := components.CreateToolDefinitionUnionToolDefinition2(components.ToolDefinition2{/* values here */})
```

### ToolDefinitionSleep

```go
toolDefinitionUnion := components.CreateToolDefinitionUnionToolDefinitionSleep(components.ToolDefinitionSleep{/* values here */})
```

### ToolDefinitionShell

```go
toolDefinitionUnion := components.CreateToolDefinitionUnionToolDefinitionShell(components.ToolDefinitionShell{/* values here */})
```

## Union Discrimination

Use the `Type` field to determine which variant is active, then access the corresponding field:

```go
switch toolDefinitionUnion.Type {
	case components.ToolDefinitionUnionTypeFunctionToolReference:
		// toolDefinitionUnion.FunctionToolReference is populated
	case components.ToolDefinitionUnionTypeToolDefinition1:
		// toolDefinitionUnion.ToolDefinition1 is populated
	case components.ToolDefinitionUnionTypeToolDefinitionFunction:
		// toolDefinitionUnion.ToolDefinitionFunction is populated
	case components.ToolDefinitionUnionTypeToolDefinitionUnion1:
		// toolDefinitionUnion.ToolDefinitionUnion1 is populated
	case components.ToolDefinitionUnionTypeToolDefinitionFileSearch:
		// toolDefinitionUnion.ToolDefinitionFileSearch is populated
	case components.ToolDefinitionUnionTypeToolDefinition2:
		// toolDefinitionUnion.ToolDefinition2 is populated
	case components.ToolDefinitionUnionTypeToolDefinitionSleep:
		// toolDefinitionUnion.ToolDefinitionSleep is populated
	case components.ToolDefinitionUnionTypeToolDefinitionShell:
		// toolDefinitionUnion.ToolDefinitionShell is populated
	default:
		// Unknown type - use toolDefinitionUnion.GetUnknownRaw() for raw JSON
}
```
