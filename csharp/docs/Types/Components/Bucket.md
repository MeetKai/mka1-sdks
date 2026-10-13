# Bucket

Split results into time buckets. Hours, days, and Monday-start weeks begin on the clock of timezone, which defaults to UTC. Empty buckets are omitted.

## Example Usage

```csharp
using MeetKai.MKA1.Types.Components;

var value = Bucket.Hour;
```


## Values

| Name   | Value  |
| ------ | ------ |
| `Hour` | hour   |
| `Day`  | day    |
| `Week` | week   |