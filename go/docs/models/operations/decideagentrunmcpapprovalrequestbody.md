# DecideAgentRunMcpApprovalRequestBody


## Supported Types

### DecideAgentRunMcpApprovalRequest

```go
decideAgentRunMcpApprovalRequestBody := operations.CreateDecideAgentRunMcpApprovalRequestBodyDecideAgentRunMcpApprovalRequest(components.DecideAgentRunMcpApprovalRequest{/* values here */})
```

### DecideAgentRunApprovalsRequest

```go
decideAgentRunMcpApprovalRequestBody := operations.CreateDecideAgentRunMcpApprovalRequestBodyDecideAgentRunApprovalsRequest(components.DecideAgentRunApprovalsRequest{/* values here */})
```

## Union Discrimination

Use the `Type` field to determine which variant is active, then access the corresponding field:

```go
switch decideAgentRunMcpApprovalRequestBody.Type {
	case operations.DecideAgentRunMcpApprovalRequestBodyTypeDecideAgentRunMcpApprovalRequest:
		// decideAgentRunMcpApprovalRequestBody.DecideAgentRunMcpApprovalRequest is populated
	case operations.DecideAgentRunMcpApprovalRequestBodyTypeDecideAgentRunApprovalsRequest:
		// decideAgentRunMcpApprovalRequestBody.DecideAgentRunApprovalsRequest is populated
}
```
