# CodeInterpreterOutput


## Supported Types

### CodeInterpreterOutputLogs

```go
codeInterpreterOutput := components.CreateCodeInterpreterOutputLogs(components.CodeInterpreterOutputLogs{/* values here */})
```

### CodeInterpreterOutputImage

```go
codeInterpreterOutput := components.CreateCodeInterpreterOutputImage(components.CodeInterpreterOutputImage{/* values here */})
```

## Union Discrimination

Use the `Type` field to determine which variant is active, then access the corresponding field:

```go
switch codeInterpreterOutput.Type {
	case components.CodeInterpreterOutputTypeLogs:
		// codeInterpreterOutput.CodeInterpreterOutputLogs is populated
	case components.CodeInterpreterOutputTypeImage:
		// codeInterpreterOutput.CodeInterpreterOutputImage is populated
	default:
		// Unknown type - use codeInterpreterOutput.GetUnknownRaw() for raw JSON
}
```
