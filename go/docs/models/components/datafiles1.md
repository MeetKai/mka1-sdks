# DataFiles1


## Supported Types

### 

```go
dataFiles1 := components.CreateDataFiles1Str(string{/* values here */})
```

### 

```go
dataFiles1 := components.CreateDataFiles1ArrayOfStr([]string{/* values here */})
```

## Union Discrimination

Use the `Type` field to determine which variant is active, then access the corresponding field:

```go
switch dataFiles1.Type {
	case components.DataFiles1TypeStr:
		// dataFiles1.Str is populated
	case components.DataFiles1TypeArrayOfStr:
		// dataFiles1.ArrayOfStr is populated
}
```
