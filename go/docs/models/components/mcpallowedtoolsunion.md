# MCPAllowedToolsUnion


## Supported Types

### 

```go
mcpAllowedToolsUnion := components.CreateMCPAllowedToolsUnionArrayOfStr([]string{/* values here */})
```

### MCPAllowedTools

```go
mcpAllowedToolsUnion := components.CreateMCPAllowedToolsUnionMCPAllowedTools(components.MCPAllowedTools{/* values here */})
```

## Union Discrimination

Use the `Type` field to determine which variant is active, then access the corresponding field:

```go
switch mcpAllowedToolsUnion.Type {
	case components.MCPAllowedToolsUnionTypeArrayOfStr:
		// mcpAllowedToolsUnion.ArrayOfStr is populated
	case components.MCPAllowedToolsUnionTypeMCPAllowedTools:
		// mcpAllowedToolsUnion.MCPAllowedTools is populated
	default:
		// Unknown type - use mcpAllowedToolsUnion.GetUnknownRaw() for raw JSON
}
```
