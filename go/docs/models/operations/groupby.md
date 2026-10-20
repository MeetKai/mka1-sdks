# GroupBy

Group cost by model / api_key_id (tenant key) / team_id (sub-tenant within an org) / external_user_id (caller-supplied end user, X-On-Behalf-Of, for resale chargeback) / org_id


## Supported Types

### 

```go
groupBy := operations.CreateGroupByArrayOfCostsUsageGroupBy([]components.CostsUsageGroupBy{/* values here */})
```

### CostsUsageGroupBy

```go
groupBy := operations.CreateGroupByCostsUsageGroupBy(components.CostsUsageGroupBy{/* values here */})
```

## Union Discrimination

Use the `Type` field to determine which variant is active, then access the corresponding field:

```go
switch groupBy.Type {
	case operations.GroupByTypeArrayOfCostsUsageGroupBy:
		// groupBy.ArrayOfCostsUsageGroupBy is populated
	case operations.GroupByTypeCostsUsageGroupBy:
		// groupBy.CostsUsageGroupBy is populated
}
```
