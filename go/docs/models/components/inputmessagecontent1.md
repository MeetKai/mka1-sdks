# InputMessageContent1

The message content. Can be a simple text string or an array of multimodal content items (text, images, files, audio).


## Supported Types

### 

```go
inputMessageContent1 := components.CreateInputMessageContent1Str(string{/* values here */})
```

### 

```go
inputMessageContent1 := components.CreateInputMessageContent1ArrayOfInputMessageContent([]components.InputMessageContent{/* values here */})
```

## Union Discrimination

Use the `Type` field to determine which variant is active, then access the corresponding field:

```go
switch inputMessageContent1.Type {
	case components.InputMessageContent1TypeStr:
		// inputMessageContent1.Str is populated
	case components.InputMessageContent1TypeArrayOfInputMessageContent:
		// inputMessageContent1.ArrayOfInputMessageContent is populated
	default:
		// Unknown type - use inputMessageContent1.GetUnknownRaw() for raw JSON
}
```
