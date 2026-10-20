# ToolDefinitionAllowedTools1


## Supported Types

### 

```go
toolDefinitionAllowedTools1 := components.CreateToolDefinitionAllowedTools1ArrayOfStr([]string{/* values here */})
```

### MCPToolFilter

```go
toolDefinitionAllowedTools1 := components.CreateToolDefinitionAllowedTools1MCPToolFilter(components.MCPToolFilter{/* values here */})
```

## Union Discrimination

Use the `Type` field to determine which variant is active, then access the corresponding field:

```go
switch toolDefinitionAllowedTools1.Type {
	case components.ToolDefinitionAllowedTools1TypeArrayOfStr:
		// toolDefinitionAllowedTools1.ArrayOfStr is populated
	case components.ToolDefinitionAllowedTools1TypeMCPToolFilter:
		// toolDefinitionAllowedTools1.MCPToolFilter is populated
	default:
		// Unknown type - use toolDefinitionAllowedTools1.GetUnknownRaw() for raw JSON
}
```
