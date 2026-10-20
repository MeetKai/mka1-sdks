# ComputerAction


## Supported Types

### ClickAction

```go
computerAction := components.CreateComputerActionClick(components.ClickAction{/* values here */})
```

### DoubleClickAction

```go
computerAction := components.CreateComputerActionDoubleClick(components.DoubleClickAction{/* values here */})
```

### DragAction

```go
computerAction := components.CreateComputerActionDrag(components.DragAction{/* values here */})
```

### KeyPressAction

```go
computerAction := components.CreateComputerActionKeypress(components.KeyPressAction{/* values here */})
```

### MoveAction

```go
computerAction := components.CreateComputerActionMove(components.MoveAction{/* values here */})
```

### ScreenshotAction

```go
computerAction := components.CreateComputerActionScreenshot(components.ScreenshotAction{/* values here */})
```

### ScrollAction

```go
computerAction := components.CreateComputerActionScroll(components.ScrollAction{/* values here */})
```

### TypeAction

```go
computerAction := components.CreateComputerActionType(components.TypeAction{/* values here */})
```

### WaitAction

```go
computerAction := components.CreateComputerActionWait(components.WaitAction{/* values here */})
```

## Union Discrimination

Use the `Type` field to determine which variant is active, then access the corresponding field:

```go
switch computerAction.Type {
	case components.ComputerActionTypeClick:
		// computerAction.ClickAction is populated
	case components.ComputerActionTypeDoubleClick:
		// computerAction.DoubleClickAction is populated
	case components.ComputerActionTypeDrag:
		// computerAction.DragAction is populated
	case components.ComputerActionTypeKeypress:
		// computerAction.KeyPressAction is populated
	case components.ComputerActionTypeMove:
		// computerAction.MoveAction is populated
	case components.ComputerActionTypeScreenshot:
		// computerAction.ScreenshotAction is populated
	case components.ComputerActionTypeScroll:
		// computerAction.ScrollAction is populated
	case components.ComputerActionTypeType:
		// computerAction.TypeAction is populated
	case components.ComputerActionTypeWait:
		// computerAction.WaitAction is populated
	default:
		// Unknown type - use computerAction.GetUnknownRaw() for raw JSON
}
```
