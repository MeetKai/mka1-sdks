# Version

Version number, or 'latest' for the most recent version. Defaults to the skill's default_version.


## Supported Types

### 

```go
version := components.CreateVersionStr(string{/* values here */})
```

### 

```go
version := components.CreateVersionInteger(int64{/* values here */})
```

## Union Discrimination

Use the `Type` field to determine which variant is active, then access the corresponding field:

```go
switch version.Type {
	case components.VersionTypeStr:
		// version.Str is populated
	case components.VersionTypeInteger:
		// version.Integer is populated
	default:
		// Unknown type - use version.GetUnknownRaw() for raw JSON
}
```
