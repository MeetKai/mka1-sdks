# ResponsesCreateRequestInput

The user input to send to the agent. Can be a simple text string for basic queries, or an array of item objects containing text, images, files, or audio for multimodal interactions. This is the main content the agent will respond to.


## Supported Types

### 

```go
responsesCreateRequestInput := components.CreateResponsesCreateRequestInputStr(string{/* values here */})
```

### 

```go
responsesCreateRequestInput := components.CreateResponsesCreateRequestInputArrayOfItem([]components.Item{/* values here */})
```

## Union Discrimination

Use the `Type` field to determine which variant is active, then access the corresponding field:

```go
switch responsesCreateRequestInput.Type {
	case components.ResponsesCreateRequestInputTypeStr:
		// responsesCreateRequestInput.Str is populated
	case components.ResponsesCreateRequestInputTypeArrayOfItem:
		// responsesCreateRequestInput.ArrayOfItem is populated
}
```
