# EmbeddingsRequestInput

The input text or array of texts to generate embeddings for. Can be a single string or an array of strings. Note: batch size and input length limits vary by model. See GET /embeddings/models for model-specific limits.


## Supported Types

### 

```go
embeddingsRequestInput := components.CreateEmbeddingsRequestInputStr(string{/* values here */})
```

### 

```go
embeddingsRequestInput := components.CreateEmbeddingsRequestInputArrayOfStr([]string{/* values here */})
```

## Union Discrimination

Use the `Type` field to determine which variant is active, then access the corresponding field:

```go
switch embeddingsRequestInput.Type {
	case components.EmbeddingsRequestInputTypeStr:
		// embeddingsRequestInput.Str is populated
	case components.EmbeddingsRequestInputTypeArrayOfStr:
		// embeddingsRequestInput.ArrayOfStr is populated
}
```
