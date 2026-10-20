# CreateAgentScheduleRequestInputUnion


## Supported Types

### 

```go
createAgentScheduleRequestInputUnion := components.CreateCreateAgentScheduleRequestInputUnionStr(string{/* values here */})
```

### 

```go
createAgentScheduleRequestInputUnion := components.CreateCreateAgentScheduleRequestInputUnionArrayOfCreateAgentScheduleRequestInput([]components.CreateAgentScheduleRequestInput{/* values here */})
```

## Union Discrimination

Use the `Type` field to determine which variant is active, then access the corresponding field:

```go
switch createAgentScheduleRequestInputUnion.Type {
	case components.CreateAgentScheduleRequestInputUnionTypeStr:
		// createAgentScheduleRequestInputUnion.Str is populated
	case components.CreateAgentScheduleRequestInputUnionTypeArrayOfCreateAgentScheduleRequestInput:
		// createAgentScheduleRequestInputUnion.ArrayOfCreateAgentScheduleRequestInput is populated
}
```
