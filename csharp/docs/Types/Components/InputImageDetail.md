# InputImageDetail

The detail level for image processing. 'high' for detailed analysis (higher cost), 'low' for basic analysis (lower cost), 'auto' lets the model choose based on image size, 'original' asks for the image at its native resolution (treated as 'high' by upstreams without that level). Defaults to 'auto'.

## Example Usage

```csharp
using MeetKai.MKA1.Types.Components;

var value = InputImageDetail.High;
```


## Values

| Name       | Value      |
| ---------- | ---------- |
| `High`     | high       |
| `Low`      | low        |
| `Auto`     | auto       |
| `Original` | original   |