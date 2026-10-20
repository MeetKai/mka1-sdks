# Instructions


## Supported Types

### 

```go
instructions := components.CreateInstructionsStr(string{/* values here */})
```

### 

```go
instructions := components.CreateInstructionsArrayOfItem([]components.Item{/* values here */})
```

## Union Discrimination

Use the `Type` field to determine which variant is active, then access the corresponding field:

```go
switch instructions.Type {
	case components.InstructionsTypeStr:
		// instructions.Str is populated
	case components.InstructionsTypeArrayOfItem:
		// instructions.ArrayOfItem is populated
	default:
		// Unknown type - use instructions.GetUnknownRaw() for raw JSON
}
```
