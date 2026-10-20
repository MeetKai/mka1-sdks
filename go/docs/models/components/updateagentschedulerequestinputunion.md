# UpdateAgentScheduleRequestInputUnion


## Supported Types

### 

```go
updateAgentScheduleRequestInputUnion := components.CreateUpdateAgentScheduleRequestInputUnionStr(string{/* values here */})
```

### 

```go
updateAgentScheduleRequestInputUnion := components.CreateUpdateAgentScheduleRequestInputUnionArrayOfUpdateAgentScheduleRequestInput([]components.UpdateAgentScheduleRequestInput{/* values here */})
```

## Union Discrimination

Use the `Type` field to determine which variant is active, then access the corresponding field:

```go
switch updateAgentScheduleRequestInputUnion.Type {
	case components.UpdateAgentScheduleRequestInputUnionTypeStr:
		// updateAgentScheduleRequestInputUnion.Str is populated
	case components.UpdateAgentScheduleRequestInputUnionTypeArrayOfUpdateAgentScheduleRequestInput:
		// updateAgentScheduleRequestInputUnion.ArrayOfUpdateAgentScheduleRequestInput is populated
}
```
