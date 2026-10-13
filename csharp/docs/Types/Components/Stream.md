# Stream

The stream the line was written to. Native services report one combined stream as stdout: Kubernetes merges a container's two streams.

## Example Usage

```csharp
using MeetKai.MKA1.Types.Components;

var value = Stream.Stdout;
```


## Values

| Name     | Value    |
| -------- | -------- |
| `Stdout` | stdout   |
| `Stderr` | stderr   |