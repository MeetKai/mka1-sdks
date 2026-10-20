# WebSearchAction


## Supported Types

### SearchAction

```go
webSearchAction := components.CreateWebSearchActionSearch(components.SearchAction{/* values here */})
```

### OpenPageAction

```go
webSearchAction := components.CreateWebSearchActionOpenPage(components.OpenPageAction{/* values here */})
```

### FindAction

```go
webSearchAction := components.CreateWebSearchActionFind(components.FindAction{/* values here */})
```

## Union Discrimination

Use the `Type` field to determine which variant is active, then access the corresponding field:

```go
switch webSearchAction.Type {
	case components.WebSearchActionTypeSearch:
		// webSearchAction.SearchAction is populated
	case components.WebSearchActionTypeOpenPage:
		// webSearchAction.OpenPageAction is populated
	case components.WebSearchActionTypeFind:
		// webSearchAction.FindAction is populated
	default:
		// Unknown type - use webSearchAction.GetUnknownRaw() for raw JSON
}
```
