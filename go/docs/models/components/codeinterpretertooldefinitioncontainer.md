# CodeInterpreterToolDefinitionContainer


## Supported Types

### 

```go
codeInterpreterToolDefinitionContainer := components.CreateCodeInterpreterToolDefinitionContainerStr(string{/* values here */})
```

### CodeInterpreterContainerAuto

```go
codeInterpreterToolDefinitionContainer := components.CreateCodeInterpreterToolDefinitionContainerCodeInterpreterContainerAuto(components.CodeInterpreterContainerAuto{/* values here */})
```

## Union Discrimination

Use the `Type` field to determine which variant is active, then access the corresponding field:

```go
switch codeInterpreterToolDefinitionContainer.Type {
	case components.CodeInterpreterToolDefinitionContainerTypeStr:
		// codeInterpreterToolDefinitionContainer.Str is populated
	case components.CodeInterpreterToolDefinitionContainerTypeCodeInterpreterContainerAuto:
		// codeInterpreterToolDefinitionContainer.CodeInterpreterContainerAuto is populated
	default:
		// Unknown type - use codeInterpreterToolDefinitionContainer.GetUnknownRaw() for raw JSON
}
```
