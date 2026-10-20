# InputMessageContent


## Supported Types

### 

```go
inputMessageContent := components.CreateInputMessageContentStr(string{/* values here */})
```

### InputText

```go
inputMessageContent := components.CreateInputMessageContentInputText(components.InputText{/* values here */})
```

### InputImage

```go
inputMessageContent := components.CreateInputMessageContentInputImage(components.InputImage{/* values here */})
```

### InputFile

```go
inputMessageContent := components.CreateInputMessageContentInputFile(components.InputFile{/* values here */})
```

### InputAudio

```go
inputMessageContent := components.CreateInputMessageContentInputAudio(components.InputAudio{/* values here */})
```

### OutputText

```go
inputMessageContent := components.CreateInputMessageContentOutputText(components.OutputText{/* values here */})
```

### Refusal

```go
inputMessageContent := components.CreateInputMessageContentRefusal(components.Refusal{/* values here */})
```

## Union Discrimination

Use the `Type` field to determine which variant is active, then access the corresponding field:

```go
switch inputMessageContent.Type {
	case components.InputMessageContentTypeStr:
		// inputMessageContent.Str is populated
	case components.InputMessageContentTypeInputText:
		// inputMessageContent.InputText is populated
	case components.InputMessageContentTypeInputImage:
		// inputMessageContent.InputImage is populated
	case components.InputMessageContentTypeInputFile:
		// inputMessageContent.InputFile is populated
	case components.InputMessageContentTypeInputAudio:
		// inputMessageContent.InputAudio is populated
	case components.InputMessageContentTypeOutputText:
		// inputMessageContent.OutputText is populated
	case components.InputMessageContentTypeRefusal:
		// inputMessageContent.Refusal is populated
	default:
		// Unknown type - use inputMessageContent.GetUnknownRaw() for raw JSON
}
```
