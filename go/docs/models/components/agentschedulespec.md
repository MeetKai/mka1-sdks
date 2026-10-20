# AgentScheduleSpec


## Supported Types

### AgentScheduleSpecOnce

```go
agentScheduleSpec := components.CreateAgentScheduleSpecOnce(components.AgentScheduleSpecOnce{/* values here */})
```

### AgentScheduleSpecInterval

```go
agentScheduleSpec := components.CreateAgentScheduleSpecInterval(components.AgentScheduleSpecInterval{/* values here */})
```

### AgentScheduleSpecCron

```go
agentScheduleSpec := components.CreateAgentScheduleSpecCron(components.AgentScheduleSpecCron{/* values here */})
```

## Union Discrimination

Use the `Type` field to determine which variant is active, then access the corresponding field:

```go
switch agentScheduleSpec.Type {
	case components.AgentScheduleSpecTypeOnce:
		// agentScheduleSpec.AgentScheduleSpecOnce is populated
	case components.AgentScheduleSpecTypeInterval:
		// agentScheduleSpec.AgentScheduleSpecInterval is populated
	case components.AgentScheduleSpecTypeCron:
		// agentScheduleSpec.AgentScheduleSpecCron is populated
	default:
		// Unknown type - use agentScheduleSpec.GetUnknownRaw() for raw JSON
}
```
