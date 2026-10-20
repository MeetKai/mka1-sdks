# CreateAgentConnectorRequest


## Supported Types

### CreateTelegramAgentConnectorRequest

```go
createAgentConnectorRequest := components.CreateCreateAgentConnectorRequestTelegram(components.CreateTelegramAgentConnectorRequest{/* values here */})
```

### CreateWhatsAppAgentConnectorRequest

```go
createAgentConnectorRequest := components.CreateCreateAgentConnectorRequestWhatsapp(components.CreateWhatsAppAgentConnectorRequest{/* values here */})
```

## Union Discrimination

Use the `Type` field to determine which variant is active, then access the corresponding field:

```go
switch createAgentConnectorRequest.Type {
	case components.CreateAgentConnectorRequestTypeTelegram:
		// createAgentConnectorRequest.CreateTelegramAgentConnectorRequest is populated
	case components.CreateAgentConnectorRequestTypeWhatsapp:
		// createAgentConnectorRequest.CreateWhatsAppAgentConnectorRequest is populated
}
```
