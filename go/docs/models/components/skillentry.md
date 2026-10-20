# SkillEntry


## Supported Types

### SkillReference

```go
skillEntry := components.CreateSkillEntrySkillReference(components.SkillReference{/* values here */})
```

### PreconfiguredSkillReference

```go
skillEntry := components.CreateSkillEntryPreconfigured(components.PreconfiguredSkillReference{/* values here */})
```

## Union Discrimination

Use the `Type` field to determine which variant is active, then access the corresponding field:

```go
switch skillEntry.Type {
	case components.SkillEntryTypeSkillReference:
		// skillEntry.SkillReference is populated
	case components.SkillEntryTypePreconfigured:
		// skillEntry.PreconfiguredSkillReference is populated
	default:
		// Unknown type - use skillEntry.GetUnknownRaw() for raw JSON
}
```
