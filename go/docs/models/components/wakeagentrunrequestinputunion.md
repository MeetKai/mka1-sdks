# WakeAgentRunRequestInputUnion


## Supported Types

### 

```go
wakeAgentRunRequestInputUnion := components.CreateWakeAgentRunRequestInputUnionStr(string{/* values here */})
```

### 

```go
wakeAgentRunRequestInputUnion := components.CreateWakeAgentRunRequestInputUnionArrayOfWakeAgentRunRequestInput([]components.WakeAgentRunRequestInput{/* values here */})
```

## Union Discrimination

Use the `Type` field to determine which variant is active, then access the corresponding field:

```go
switch wakeAgentRunRequestInputUnion.Type {
	case components.WakeAgentRunRequestInputUnionTypeStr:
		// wakeAgentRunRequestInputUnion.Str is populated
	case components.WakeAgentRunRequestInputUnionTypeArrayOfWakeAgentRunRequestInput:
		// wakeAgentRunRequestInputUnion.ArrayOfWakeAgentRunRequestInput is populated
}
```
