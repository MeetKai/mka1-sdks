# ToolDefinitionAllowedTools2


## Supported Types

### 

```go
toolDefinitionAllowedTools2 := components.CreateToolDefinitionAllowedTools2ArrayOfStr([]string{/* values here */})
```

### MCPToolFilter

```go
toolDefinitionAllowedTools2 := components.CreateToolDefinitionAllowedTools2MCPToolFilter(components.MCPToolFilter{/* values here */})
```

## Union Discrimination

Use the `Type` field to determine which variant is active, then access the corresponding field:

```go
switch toolDefinitionAllowedTools2.Type {
	case components.ToolDefinitionAllowedTools2TypeArrayOfStr:
		// toolDefinitionAllowedTools2.ArrayOfStr is populated
	case components.ToolDefinitionAllowedTools2TypeMCPToolFilter:
		// toolDefinitionAllowedTools2.MCPToolFilter is populated
	default:
		// Unknown type - use toolDefinitionAllowedTools2.GetUnknownRaw() for raw JSON
}
```
