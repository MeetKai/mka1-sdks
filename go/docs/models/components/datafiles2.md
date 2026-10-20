# DataFiles2

Optional Hugging Face data_files value for json/csv/parquet style datasets.


## Supported Types

### 

```go
dataFiles2 := components.CreateDataFiles2Str(string{/* values here */})
```

### 

```go
dataFiles2 := components.CreateDataFiles2ArrayOfStr([]string{/* values here */})
```

### 

```go
dataFiles2 := components.CreateDataFiles2MapOfDataFiles1(map[string]components.DataFiles1{/* values here */})
```

## Union Discrimination

Use the `Type` field to determine which variant is active, then access the corresponding field:

```go
switch dataFiles2.Type {
	case components.DataFiles2TypeStr:
		// dataFiles2.Str is populated
	case components.DataFiles2TypeArrayOfStr:
		// dataFiles2.ArrayOfStr is populated
	case components.DataFiles2TypeMapOfDataFiles1:
		// dataFiles2.MapOfDataFiles1 is populated
}
```
