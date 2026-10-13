# AnalyticsQueryRequestOp

Comparison operator. gt, gte, lt, and lte require a numeric value. exists and not_exists check whether the property is present and do not take a value.

## Example Usage

```csharp
using MeetKai.MKA1.Types.Components;

var value = AnalyticsQueryRequestOp.Eq;
```


## Values

| Name        | Value       |
| ----------- | ----------- |
| `Eq`        | eq          |
| `Neq`       | neq         |
| `Gt`        | gt          |
| `Gte`       | gte         |
| `Lt`        | lt          |
| `Lte`       | lte         |
| `Exists`    | exists      |
| `NotExists` | not_exists  |