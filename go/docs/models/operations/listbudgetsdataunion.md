# ListBudgetsDataUnion


## Supported Types

### ListBudgetsData1

```go
listBudgetsDataUnion := operations.CreateListBudgetsDataUnionListBudgetsData1(operations.ListBudgetsData1{/* values here */})
```

### ListBudgetsData2

```go
listBudgetsDataUnion := operations.CreateListBudgetsDataUnionListBudgetsData2(operations.ListBudgetsData2{/* values here */})
```

## Union Discrimination

Use the `Type` field to determine which variant is active, then access the corresponding field:

```go
switch listBudgetsDataUnion.Type {
	case operations.ListBudgetsDataUnionTypeListBudgetsData1:
		// listBudgetsDataUnion.ListBudgetsData1 is populated
	case operations.ListBudgetsDataUnionTypeListBudgetsData2:
		// listBudgetsDataUnion.ListBudgetsData2 is populated
	default:
		// Unknown type - use listBudgetsDataUnion.GetUnknownRaw() for raw JSON
}
```
