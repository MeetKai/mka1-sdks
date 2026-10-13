# ResponsesCreateRequestTruncation

The truncation strategy for handling inputs that exceed the model's context window. 'auto' automatically truncates old messages to fit, 'disabled' returns an error if context is too long. Defaults to 'auto'.

## Example Usage

```csharp
using MeetKai.MKA1.Types.Components;

var value = ResponsesCreateRequestTruncation.Auto;
```


## Values

| Name       | Value      |
| ---------- | ---------- |
| `Auto`     | auto       |
| `Disabled` | disabled   |