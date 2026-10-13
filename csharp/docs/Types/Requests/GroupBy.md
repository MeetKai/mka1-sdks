# GroupBy

Group cost by model / api_key_id (tenant key) / team_id (sub-tenant within an org) / external_user_id (caller-supplied end user, X-On-Behalf-Of, for resale chargeback) / org_id


## Supported Types

### ArrayOfCostsUsageGroupBy

```csharp
GroupBy.CreateArrayOfCostsUsageGroupBy(/* values here */);
```

### CostsUsageGroupBy

```csharp
GroupBy.CreateCostsUsageGroupBy(/* values here */);
```
