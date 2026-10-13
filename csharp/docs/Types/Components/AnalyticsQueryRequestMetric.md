# AnalyticsQueryRequestMetric

count counts events. unique_visitors counts distinct values of distinct_id. Both deduplicate event IDs first.

## Example Usage

```csharp
using MeetKai.MKA1.Types.Components;

var value = AnalyticsQueryRequestMetric.Count;
```


## Values

| Name             | Value            |
| ---------------- | ---------------- |
| `Count`          | count            |
| `UniqueVisitors` | unique_visitors  |