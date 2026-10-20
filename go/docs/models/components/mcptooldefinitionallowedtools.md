# MCPToolDefinitionAllowedTools


## Supported Types

### 

```go
mcpToolDefinitionAllowedTools := components.CreateMCPToolDefinitionAllowedToolsArrayOfStr([]string{/* values here */})
```

### MCPToolFilter

```go
mcpToolDefinitionAllowedTools := components.CreateMCPToolDefinitionAllowedToolsMCPToolFilter(components.MCPToolFilter{/* values here */})
```

## Union Discrimination

Use the `Type` field to determine which variant is active, then access the corresponding field:

```go
switch mcpToolDefinitionAllowedTools.Type {
	case components.MCPToolDefinitionAllowedToolsTypeArrayOfStr:
		// mcpToolDefinitionAllowedTools.ArrayOfStr is populated
	case components.MCPToolDefinitionAllowedToolsTypeMCPToolFilter:
		// mcpToolDefinitionAllowedTools.MCPToolFilter is populated
}
```
