# ResponsesCreateRequestStop

Gateway extension. Stop sequence(s) where compatible upstream providers should stop generation. Eval runs also enforce this as a post-processing guard.


## Supported Types

### 

```go
responsesCreateRequestStop := components.CreateResponsesCreateRequestStopStr(string{/* values here */})
```

### 

```go
responsesCreateRequestStop := components.CreateResponsesCreateRequestStopArrayOfStr([]string{/* values here */})
```

## Union Discrimination

Use the `Type` field to determine which variant is active, then access the corresponding field:

```go
switch responsesCreateRequestStop.Type {
	case components.ResponsesCreateRequestStopTypeStr:
		// responsesCreateRequestStop.Str is populated
	case components.ResponsesCreateRequestStopTypeArrayOfStr:
		// responsesCreateRequestStop.ArrayOfStr is populated
}
```
