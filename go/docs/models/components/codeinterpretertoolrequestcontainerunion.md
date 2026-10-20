# CodeInterpreterToolRequestContainerUnion


## Supported Types

### 

```go
codeInterpreterToolRequestContainerUnion := components.CreateCodeInterpreterToolRequestContainerUnionStr(string{/* values here */})
```

### CodeInterpreterToolRequestContainer

```go
codeInterpreterToolRequestContainerUnion := components.CreateCodeInterpreterToolRequestContainerUnionCodeInterpreterToolRequestContainer(components.CodeInterpreterToolRequestContainer{/* values here */})
```

## Union Discrimination

Use the `Type` field to determine which variant is active, then access the corresponding field:

```go
switch codeInterpreterToolRequestContainerUnion.Type {
	case components.CodeInterpreterToolRequestContainerUnionTypeStr:
		// codeInterpreterToolRequestContainerUnion.Str is populated
	case components.CodeInterpreterToolRequestContainerUnionTypeCodeInterpreterToolRequestContainer:
		// codeInterpreterToolRequestContainerUnion.CodeInterpreterToolRequestContainer is populated
}
```
