# CreateAgentRunRequestInputUnion


## Supported Types

### 

```go
createAgentRunRequestInputUnion := components.CreateCreateAgentRunRequestInputUnionStr(string{/* values here */})
```

### 

```go
createAgentRunRequestInputUnion := components.CreateCreateAgentRunRequestInputUnionArrayOfCreateAgentRunRequestInput([]components.CreateAgentRunRequestInput{/* values here */})
```

## Union Discrimination

Use the `Type` field to determine which variant is active, then access the corresponding field:

```go
switch createAgentRunRequestInputUnion.Type {
	case components.CreateAgentRunRequestInputUnionTypeStr:
		// createAgentRunRequestInputUnion.Str is populated
	case components.CreateAgentRunRequestInputUnionTypeArrayOfCreateAgentRunRequestInput:
		// createAgentRunRequestInputUnion.ArrayOfCreateAgentRunRequestInput is populated
}
```
