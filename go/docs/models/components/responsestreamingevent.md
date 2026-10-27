# ResponseStreamingEvent


## Supported Types

### ResponseCreatedEvent

```go
responseStreamingEvent := components.CreateResponseStreamingEventResponseCreated(components.ResponseCreatedEvent{/* values here */})
```

### ResponseInProgressEvent

```go
responseStreamingEvent := components.CreateResponseStreamingEventResponseInProgress(components.ResponseInProgressEvent{/* values here */})
```

### ResponseCompletedEvent

```go
responseStreamingEvent := components.CreateResponseStreamingEventResponseCompleted(components.ResponseCompletedEvent{/* values here */})
```

### ResponseFailedEvent

```go
responseStreamingEvent := components.CreateResponseStreamingEventResponseFailed(components.ResponseFailedEvent{/* values here */})
```

### ResponseIncompleteEvent

```go
responseStreamingEvent := components.CreateResponseStreamingEventResponseIncomplete(components.ResponseIncompleteEvent{/* values here */})
```

### ResponseQueuedEvent

```go
responseStreamingEvent := components.CreateResponseStreamingEventResponseQueued(components.ResponseQueuedEvent{/* values here */})
```

### ResponseCancelledEvent

```go
responseStreamingEvent := components.CreateResponseStreamingEventResponseCancelled(components.ResponseCancelledEvent{/* values here */})
```

### ResponseOutputItemAddedEvent

```go
responseStreamingEvent := components.CreateResponseStreamingEventResponseOutputItemAdded(components.ResponseOutputItemAddedEvent{/* values here */})
```

### ResponseOutputItemDoneEvent

```go
responseStreamingEvent := components.CreateResponseStreamingEventResponseOutputItemDone(components.ResponseOutputItemDoneEvent{/* values here */})
```

### ResponseContentPartAddedEvent

```go
responseStreamingEvent := components.CreateResponseStreamingEventResponseContentPartAdded(components.ResponseContentPartAddedEvent{/* values here */})
```

### ResponseContentPartDoneEvent

```go
responseStreamingEvent := components.CreateResponseStreamingEventResponseContentPartDone(components.ResponseContentPartDoneEvent{/* values here */})
```

### ResponseOutputTextDeltaEvent

```go
responseStreamingEvent := components.CreateResponseStreamingEventResponseOutputTextDelta(components.ResponseOutputTextDeltaEvent{/* values here */})
```

### ResponseOutputTextDoneEvent

```go
responseStreamingEvent := components.CreateResponseStreamingEventResponseOutputTextDone(components.ResponseOutputTextDoneEvent{/* values here */})
```

### ResponseRefusalDeltaEvent

```go
responseStreamingEvent := components.CreateResponseStreamingEventResponseRefusalDelta(components.ResponseRefusalDeltaEvent{/* values here */})
```

### ResponseRefusalDoneEvent

```go
responseStreamingEvent := components.CreateResponseStreamingEventResponseRefusalDone(components.ResponseRefusalDoneEvent{/* values here */})
```

### ResponseFunctionCallArgumentsDeltaEvent

```go
responseStreamingEvent := components.CreateResponseStreamingEventResponseFunctionCallArgumentsDelta(components.ResponseFunctionCallArgumentsDeltaEvent{/* values here */})
```

### ResponseFunctionCallArgumentsDoneEvent

```go
responseStreamingEvent := components.CreateResponseStreamingEventResponseFunctionCallArgumentsDone(components.ResponseFunctionCallArgumentsDoneEvent{/* values here */})
```

### ResponseFileSearchCallInProgressEvent

```go
responseStreamingEvent := components.CreateResponseStreamingEventResponseFileSearchCallInProgress(components.ResponseFileSearchCallInProgressEvent{/* values here */})
```

### ResponseFileSearchCallSearchingEvent

```go
responseStreamingEvent := components.CreateResponseStreamingEventResponseFileSearchCallSearching(components.ResponseFileSearchCallSearchingEvent{/* values here */})
```

### ResponseFileSearchCallCompletedEvent

```go
responseStreamingEvent := components.CreateResponseStreamingEventResponseFileSearchCallCompleted(components.ResponseFileSearchCallCompletedEvent{/* values here */})
```

### ResponseFileSearchCallFailedEvent

```go
responseStreamingEvent := components.CreateResponseStreamingEventResponseFileSearchCallFailed(components.ResponseFileSearchCallFailedEvent{/* values here */})
```

### ResponseWebSearchCallInProgressEvent

```go
responseStreamingEvent := components.CreateResponseStreamingEventResponseWebSearchCallInProgress(components.ResponseWebSearchCallInProgressEvent{/* values here */})
```

### ResponseWebSearchCallSearchingEvent

```go
responseStreamingEvent := components.CreateResponseStreamingEventResponseWebSearchCallSearching(components.ResponseWebSearchCallSearchingEvent{/* values here */})
```

### ResponseWebSearchCallCompletedEvent

```go
responseStreamingEvent := components.CreateResponseStreamingEventResponseWebSearchCallCompleted(components.ResponseWebSearchCallCompletedEvent{/* values here */})
```

### ResponseHistoryCallInProgressEvent

```go
responseStreamingEvent := components.CreateResponseStreamingEventResponseHistoryCallInProgress(components.ResponseHistoryCallInProgressEvent{/* values here */})
```

### ResponseHistoryCallSearchingEvent

```go
responseStreamingEvent := components.CreateResponseStreamingEventResponseHistoryCallSearching(components.ResponseHistoryCallSearchingEvent{/* values here */})
```

### ResponseHistoryCallCompletedEvent

```go
responseStreamingEvent := components.CreateResponseStreamingEventResponseHistoryCallCompleted(components.ResponseHistoryCallCompletedEvent{/* values here */})
```

### ResponseSleepCallInProgressEvent

```go
responseStreamingEvent := components.CreateResponseStreamingEventResponseSleepCallInProgress(components.ResponseSleepCallInProgressEvent{/* values here */})
```

### ResponseSleepCallSleepingEvent

```go
responseStreamingEvent := components.CreateResponseStreamingEventResponseSleepCallSleeping(components.ResponseSleepCallSleepingEvent{/* values here */})
```

### ResponseSleepCallCompletedEvent

```go
responseStreamingEvent := components.CreateResponseStreamingEventResponseSleepCallCompleted(components.ResponseSleepCallCompletedEvent{/* values here */})
```

### ResponseToolSearchCallInProgressEvent

```go
responseStreamingEvent := components.CreateResponseStreamingEventResponseToolSearchCallInProgress(components.ResponseToolSearchCallInProgressEvent{/* values here */})
```

### ResponseToolSearchCallSearchingEvent

```go
responseStreamingEvent := components.CreateResponseStreamingEventResponseToolSearchCallSearching(components.ResponseToolSearchCallSearchingEvent{/* values here */})
```

### ResponseToolSearchCallCompletedEvent

```go
responseStreamingEvent := components.CreateResponseStreamingEventResponseToolSearchCallCompleted(components.ResponseToolSearchCallCompletedEvent{/* values here */})
```

### ResponseReasoningSummaryPartAddedEvent

```go
responseStreamingEvent := components.CreateResponseStreamingEventResponseReasoningSummaryPartAdded(components.ResponseReasoningSummaryPartAddedEvent{/* values here */})
```

### ResponseReasoningSummaryPartDoneEvent

```go
responseStreamingEvent := components.CreateResponseStreamingEventResponseReasoningSummaryPartDone(components.ResponseReasoningSummaryPartDoneEvent{/* values here */})
```

### ResponseReasoningSummaryTextDeltaEvent

```go
responseStreamingEvent := components.CreateResponseStreamingEventResponseReasoningSummaryTextDelta(components.ResponseReasoningSummaryTextDeltaEvent{/* values here */})
```

### ResponseReasoningSummaryTextDoneEvent

```go
responseStreamingEvent := components.CreateResponseStreamingEventResponseReasoningSummaryTextDone(components.ResponseReasoningSummaryTextDoneEvent{/* values here */})
```

### ResponseReasoningTextDeltaEvent

```go
responseStreamingEvent := components.CreateResponseStreamingEventResponseReasoningTextDelta(components.ResponseReasoningTextDeltaEvent{/* values here */})
```

### ResponseReasoningTextDoneEvent

```go
responseStreamingEvent := components.CreateResponseStreamingEventResponseReasoningTextDone(components.ResponseReasoningTextDoneEvent{/* values here */})
```

### ResponseImageGenerationCallInProgressEvent

```go
responseStreamingEvent := components.CreateResponseStreamingEventResponseImageGenerationCallInProgress(components.ResponseImageGenerationCallInProgressEvent{/* values here */})
```

### ResponseImageGenerationCallGeneratingEvent

```go
responseStreamingEvent := components.CreateResponseStreamingEventResponseImageGenerationCallGenerating(components.ResponseImageGenerationCallGeneratingEvent{/* values here */})
```

### ResponseImageGenerationCallCompletedEvent

```go
responseStreamingEvent := components.CreateResponseStreamingEventResponseImageGenerationCallCompleted(components.ResponseImageGenerationCallCompletedEvent{/* values here */})
```

### ResponseImageGenerationCallFailedEvent

```go
responseStreamingEvent := components.CreateResponseStreamingEventResponseImageGenerationCallFailed(components.ResponseImageGenerationCallFailedEvent{/* values here */})
```

### ResponseImageGenerationCallPartialImageEvent

```go
responseStreamingEvent := components.CreateResponseStreamingEventResponseImageGenerationCallPartialImage(components.ResponseImageGenerationCallPartialImageEvent{/* values here */})
```

### ResponseMCPCallArgumentsDeltaEvent

```go
responseStreamingEvent := components.CreateResponseStreamingEventResponseMcpCallArgumentsDelta(components.ResponseMCPCallArgumentsDeltaEvent{/* values here */})
```

### ResponseMCPCallArgumentsDoneEvent

```go
responseStreamingEvent := components.CreateResponseStreamingEventResponseMcpCallArgumentsDone(components.ResponseMCPCallArgumentsDoneEvent{/* values here */})
```

### ResponseMCPCallInProgressEvent

```go
responseStreamingEvent := components.CreateResponseStreamingEventResponseMcpCallInProgress(components.ResponseMCPCallInProgressEvent{/* values here */})
```

### ResponseMCPCallCompletedEvent

```go
responseStreamingEvent := components.CreateResponseStreamingEventResponseMcpCallCompleted(components.ResponseMCPCallCompletedEvent{/* values here */})
```

### ResponseMCPCallFailedEvent

```go
responseStreamingEvent := components.CreateResponseStreamingEventResponseMcpCallFailed(components.ResponseMCPCallFailedEvent{/* values here */})
```

### ResponseAgentCallInProgressEvent

```go
responseStreamingEvent := components.CreateResponseStreamingEventResponseAgentCallInProgress(components.ResponseAgentCallInProgressEvent{/* values here */})
```

### ResponseAgentCallCompletedEvent

```go
responseStreamingEvent := components.CreateResponseStreamingEventResponseAgentCallCompleted(components.ResponseAgentCallCompletedEvent{/* values here */})
```

### ResponseAgentCallFailedEvent

```go
responseStreamingEvent := components.CreateResponseStreamingEventResponseAgentCallFailed(components.ResponseAgentCallFailedEvent{/* values here */})
```

### ResponseMCPListToolsInProgressEvent

```go
responseStreamingEvent := components.CreateResponseStreamingEventResponseMcpListToolsInProgress(components.ResponseMCPListToolsInProgressEvent{/* values here */})
```

### ResponseMCPListToolsCompletedEvent

```go
responseStreamingEvent := components.CreateResponseStreamingEventResponseMcpListToolsCompleted(components.ResponseMCPListToolsCompletedEvent{/* values here */})
```

### ResponseMCPListToolsFailedEvent

```go
responseStreamingEvent := components.CreateResponseStreamingEventResponseMcpListToolsFailed(components.ResponseMCPListToolsFailedEvent{/* values here */})
```

### ResponseReadFileCallInProgressEvent

```go
responseStreamingEvent := components.CreateResponseStreamingEventResponseReadFileCallInProgress(components.ResponseReadFileCallInProgressEvent{/* values here */})
```

### ResponseReadFileCallReadingEvent

```go
responseStreamingEvent := components.CreateResponseStreamingEventResponseReadFileCallReading(components.ResponseReadFileCallReadingEvent{/* values here */})
```

### ResponseReadFileCallCompletedEvent

```go
responseStreamingEvent := components.CreateResponseStreamingEventResponseReadFileCallCompleted(components.ResponseReadFileCallCompletedEvent{/* values here */})
```

### ResponseCodeInterpreterCallInProgressEvent

```go
responseStreamingEvent := components.CreateResponseStreamingEventResponseCodeInterpreterCallInProgress(components.ResponseCodeInterpreterCallInProgressEvent{/* values here */})
```

### ResponseCodeInterpreterCallInterpretingEvent

```go
responseStreamingEvent := components.CreateResponseStreamingEventResponseCodeInterpreterCallInterpreting(components.ResponseCodeInterpreterCallInterpretingEvent{/* values here */})
```

### ResponseCodeInterpreterCallCompletedEvent

```go
responseStreamingEvent := components.CreateResponseStreamingEventResponseCodeInterpreterCallCompleted(components.ResponseCodeInterpreterCallCompletedEvent{/* values here */})
```

### ResponseCodeInterpreterCallCodeDeltaEvent

```go
responseStreamingEvent := components.CreateResponseStreamingEventResponseCodeInterpreterCallCodeDelta(components.ResponseCodeInterpreterCallCodeDeltaEvent{/* values here */})
```

### ResponseCodeInterpreterCallCodeDoneEvent

```go
responseStreamingEvent := components.CreateResponseStreamingEventResponseCodeInterpreterCallCodeDone(components.ResponseCodeInterpreterCallCodeDoneEvent{/* values here */})
```

### ResponseShellCallInProgressEvent

```go
responseStreamingEvent := components.CreateResponseStreamingEventResponseShellCallInProgress(components.ResponseShellCallInProgressEvent{/* values here */})
```

### ResponseShellCallExecutingEvent

```go
responseStreamingEvent := components.CreateResponseStreamingEventResponseShellCallExecuting(components.ResponseShellCallExecutingEvent{/* values here */})
```

### ResponseShellCallCompletedEvent

```go
responseStreamingEvent := components.CreateResponseStreamingEventResponseShellCallCompleted(components.ResponseShellCallCompletedEvent{/* values here */})
```

### ResponseCustomToolCallInputDeltaEvent

```go
responseStreamingEvent := components.CreateResponseStreamingEventResponseCustomToolCallInputDelta(components.ResponseCustomToolCallInputDeltaEvent{/* values here */})
```

### ResponseCustomToolCallInputDoneEvent

```go
responseStreamingEvent := components.CreateResponseStreamingEventResponseCustomToolCallInputDone(components.ResponseCustomToolCallInputDoneEvent{/* values here */})
```

### ResponseOutputTextAnnotationAddedEvent

```go
responseStreamingEvent := components.CreateResponseStreamingEventResponseOutputTextAnnotationAdded(components.ResponseOutputTextAnnotationAddedEvent{/* values here */})
```

### ErrorEvent

```go
responseStreamingEvent := components.CreateResponseStreamingEventError(components.ErrorEvent{/* values here */})
```

## Union Discrimination

Use the `Type` field to determine which variant is active, then access the corresponding field:

```go
switch responseStreamingEvent.Type {
	case components.ResponseStreamingEventTypeResponseCreated:
		// responseStreamingEvent.ResponseCreatedEvent is populated
	case components.ResponseStreamingEventTypeResponseInProgress:
		// responseStreamingEvent.ResponseInProgressEvent is populated
	case components.ResponseStreamingEventTypeResponseCompleted:
		// responseStreamingEvent.ResponseCompletedEvent is populated
	case components.ResponseStreamingEventTypeResponseFailed:
		// responseStreamingEvent.ResponseFailedEvent is populated
	case components.ResponseStreamingEventTypeResponseIncomplete:
		// responseStreamingEvent.ResponseIncompleteEvent is populated
	case components.ResponseStreamingEventTypeResponseQueued:
		// responseStreamingEvent.ResponseQueuedEvent is populated
	case components.ResponseStreamingEventTypeResponseCancelled:
		// responseStreamingEvent.ResponseCancelledEvent is populated
	case components.ResponseStreamingEventTypeResponseOutputItemAdded:
		// responseStreamingEvent.ResponseOutputItemAddedEvent is populated
	case components.ResponseStreamingEventTypeResponseOutputItemDone:
		// responseStreamingEvent.ResponseOutputItemDoneEvent is populated
	case components.ResponseStreamingEventTypeResponseContentPartAdded:
		// responseStreamingEvent.ResponseContentPartAddedEvent is populated
	case components.ResponseStreamingEventTypeResponseContentPartDone:
		// responseStreamingEvent.ResponseContentPartDoneEvent is populated
	case components.ResponseStreamingEventTypeResponseOutputTextDelta:
		// responseStreamingEvent.ResponseOutputTextDeltaEvent is populated
	case components.ResponseStreamingEventTypeResponseOutputTextDone:
		// responseStreamingEvent.ResponseOutputTextDoneEvent is populated
	case components.ResponseStreamingEventTypeResponseRefusalDelta:
		// responseStreamingEvent.ResponseRefusalDeltaEvent is populated
	case components.ResponseStreamingEventTypeResponseRefusalDone:
		// responseStreamingEvent.ResponseRefusalDoneEvent is populated
	case components.ResponseStreamingEventTypeResponseFunctionCallArgumentsDelta:
		// responseStreamingEvent.ResponseFunctionCallArgumentsDeltaEvent is populated
	case components.ResponseStreamingEventTypeResponseFunctionCallArgumentsDone:
		// responseStreamingEvent.ResponseFunctionCallArgumentsDoneEvent is populated
	case components.ResponseStreamingEventTypeResponseFileSearchCallInProgress:
		// responseStreamingEvent.ResponseFileSearchCallInProgressEvent is populated
	case components.ResponseStreamingEventTypeResponseFileSearchCallSearching:
		// responseStreamingEvent.ResponseFileSearchCallSearchingEvent is populated
	case components.ResponseStreamingEventTypeResponseFileSearchCallCompleted:
		// responseStreamingEvent.ResponseFileSearchCallCompletedEvent is populated
	case components.ResponseStreamingEventTypeResponseFileSearchCallFailed:
		// responseStreamingEvent.ResponseFileSearchCallFailedEvent is populated
	case components.ResponseStreamingEventTypeResponseWebSearchCallInProgress:
		// responseStreamingEvent.ResponseWebSearchCallInProgressEvent is populated
	case components.ResponseStreamingEventTypeResponseWebSearchCallSearching:
		// responseStreamingEvent.ResponseWebSearchCallSearchingEvent is populated
	case components.ResponseStreamingEventTypeResponseWebSearchCallCompleted:
		// responseStreamingEvent.ResponseWebSearchCallCompletedEvent is populated
	case components.ResponseStreamingEventTypeResponseHistoryCallInProgress:
		// responseStreamingEvent.ResponseHistoryCallInProgressEvent is populated
	case components.ResponseStreamingEventTypeResponseHistoryCallSearching:
		// responseStreamingEvent.ResponseHistoryCallSearchingEvent is populated
	case components.ResponseStreamingEventTypeResponseHistoryCallCompleted:
		// responseStreamingEvent.ResponseHistoryCallCompletedEvent is populated
	case components.ResponseStreamingEventTypeResponseSleepCallInProgress:
		// responseStreamingEvent.ResponseSleepCallInProgressEvent is populated
	case components.ResponseStreamingEventTypeResponseSleepCallSleeping:
		// responseStreamingEvent.ResponseSleepCallSleepingEvent is populated
	case components.ResponseStreamingEventTypeResponseSleepCallCompleted:
		// responseStreamingEvent.ResponseSleepCallCompletedEvent is populated
	case components.ResponseStreamingEventTypeResponseToolSearchCallInProgress:
		// responseStreamingEvent.ResponseToolSearchCallInProgressEvent is populated
	case components.ResponseStreamingEventTypeResponseToolSearchCallSearching:
		// responseStreamingEvent.ResponseToolSearchCallSearchingEvent is populated
	case components.ResponseStreamingEventTypeResponseToolSearchCallCompleted:
		// responseStreamingEvent.ResponseToolSearchCallCompletedEvent is populated
	case components.ResponseStreamingEventTypeResponseReasoningSummaryPartAdded:
		// responseStreamingEvent.ResponseReasoningSummaryPartAddedEvent is populated
	case components.ResponseStreamingEventTypeResponseReasoningSummaryPartDone:
		// responseStreamingEvent.ResponseReasoningSummaryPartDoneEvent is populated
	case components.ResponseStreamingEventTypeResponseReasoningSummaryTextDelta:
		// responseStreamingEvent.ResponseReasoningSummaryTextDeltaEvent is populated
	case components.ResponseStreamingEventTypeResponseReasoningSummaryTextDone:
		// responseStreamingEvent.ResponseReasoningSummaryTextDoneEvent is populated
	case components.ResponseStreamingEventTypeResponseReasoningTextDelta:
		// responseStreamingEvent.ResponseReasoningTextDeltaEvent is populated
	case components.ResponseStreamingEventTypeResponseReasoningTextDone:
		// responseStreamingEvent.ResponseReasoningTextDoneEvent is populated
	case components.ResponseStreamingEventTypeResponseImageGenerationCallInProgress:
		// responseStreamingEvent.ResponseImageGenerationCallInProgressEvent is populated
	case components.ResponseStreamingEventTypeResponseImageGenerationCallGenerating:
		// responseStreamingEvent.ResponseImageGenerationCallGeneratingEvent is populated
	case components.ResponseStreamingEventTypeResponseImageGenerationCallCompleted:
		// responseStreamingEvent.ResponseImageGenerationCallCompletedEvent is populated
	case components.ResponseStreamingEventTypeResponseImageGenerationCallFailed:
		// responseStreamingEvent.ResponseImageGenerationCallFailedEvent is populated
	case components.ResponseStreamingEventTypeResponseImageGenerationCallPartialImage:
		// responseStreamingEvent.ResponseImageGenerationCallPartialImageEvent is populated
	case components.ResponseStreamingEventTypeResponseMcpCallArgumentsDelta:
		// responseStreamingEvent.ResponseMCPCallArgumentsDeltaEvent is populated
	case components.ResponseStreamingEventTypeResponseMcpCallArgumentsDone:
		// responseStreamingEvent.ResponseMCPCallArgumentsDoneEvent is populated
	case components.ResponseStreamingEventTypeResponseMcpCallInProgress:
		// responseStreamingEvent.ResponseMCPCallInProgressEvent is populated
	case components.ResponseStreamingEventTypeResponseMcpCallCompleted:
		// responseStreamingEvent.ResponseMCPCallCompletedEvent is populated
	case components.ResponseStreamingEventTypeResponseMcpCallFailed:
		// responseStreamingEvent.ResponseMCPCallFailedEvent is populated
	case components.ResponseStreamingEventTypeResponseAgentCallInProgress:
		// responseStreamingEvent.ResponseAgentCallInProgressEvent is populated
	case components.ResponseStreamingEventTypeResponseAgentCallCompleted:
		// responseStreamingEvent.ResponseAgentCallCompletedEvent is populated
	case components.ResponseStreamingEventTypeResponseAgentCallFailed:
		// responseStreamingEvent.ResponseAgentCallFailedEvent is populated
	case components.ResponseStreamingEventTypeResponseMcpListToolsInProgress:
		// responseStreamingEvent.ResponseMCPListToolsInProgressEvent is populated
	case components.ResponseStreamingEventTypeResponseMcpListToolsCompleted:
		// responseStreamingEvent.ResponseMCPListToolsCompletedEvent is populated
	case components.ResponseStreamingEventTypeResponseMcpListToolsFailed:
		// responseStreamingEvent.ResponseMCPListToolsFailedEvent is populated
	case components.ResponseStreamingEventTypeResponseReadFileCallInProgress:
		// responseStreamingEvent.ResponseReadFileCallInProgressEvent is populated
	case components.ResponseStreamingEventTypeResponseReadFileCallReading:
		// responseStreamingEvent.ResponseReadFileCallReadingEvent is populated
	case components.ResponseStreamingEventTypeResponseReadFileCallCompleted:
		// responseStreamingEvent.ResponseReadFileCallCompletedEvent is populated
	case components.ResponseStreamingEventTypeResponseCodeInterpreterCallInProgress:
		// responseStreamingEvent.ResponseCodeInterpreterCallInProgressEvent is populated
	case components.ResponseStreamingEventTypeResponseCodeInterpreterCallInterpreting:
		// responseStreamingEvent.ResponseCodeInterpreterCallInterpretingEvent is populated
	case components.ResponseStreamingEventTypeResponseCodeInterpreterCallCompleted:
		// responseStreamingEvent.ResponseCodeInterpreterCallCompletedEvent is populated
	case components.ResponseStreamingEventTypeResponseCodeInterpreterCallCodeDelta:
		// responseStreamingEvent.ResponseCodeInterpreterCallCodeDeltaEvent is populated
	case components.ResponseStreamingEventTypeResponseCodeInterpreterCallCodeDone:
		// responseStreamingEvent.ResponseCodeInterpreterCallCodeDoneEvent is populated
	case components.ResponseStreamingEventTypeResponseShellCallInProgress:
		// responseStreamingEvent.ResponseShellCallInProgressEvent is populated
	case components.ResponseStreamingEventTypeResponseShellCallExecuting:
		// responseStreamingEvent.ResponseShellCallExecutingEvent is populated
	case components.ResponseStreamingEventTypeResponseShellCallCompleted:
		// responseStreamingEvent.ResponseShellCallCompletedEvent is populated
	case components.ResponseStreamingEventTypeResponseCustomToolCallInputDelta:
		// responseStreamingEvent.ResponseCustomToolCallInputDeltaEvent is populated
	case components.ResponseStreamingEventTypeResponseCustomToolCallInputDone:
		// responseStreamingEvent.ResponseCustomToolCallInputDoneEvent is populated
	case components.ResponseStreamingEventTypeResponseOutputTextAnnotationAdded:
		// responseStreamingEvent.ResponseOutputTextAnnotationAddedEvent is populated
	case components.ResponseStreamingEventTypeError:
		// responseStreamingEvent.ErrorEvent is populated
	default:
		// Unknown type - use responseStreamingEvent.GetUnknownRaw() for raw JSON
}
```
