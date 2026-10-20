# CompactResponseRequestInput

Text, image, or file inputs to the model, used to generate a response.


## Supported Types

### 

```go
compactResponseRequestInput := components.CreateCompactResponseRequestInputStr(string{/* values here */})
```

### 

```go
compactResponseRequestInput := components.CreateCompactResponseRequestInputArrayOfItem([]components.Item{/* values here */})
```

## Union Discrimination

Use the `Type` field to determine which variant is active, then access the corresponding field:

```go
switch compactResponseRequestInput.Type {
	case components.CompactResponseRequestInputTypeStr:
		// compactResponseRequestInput.Str is populated
	case components.CompactResponseRequestInputTypeArrayOfItem:
		// compactResponseRequestInput.ArrayOfItem is populated
}
```
