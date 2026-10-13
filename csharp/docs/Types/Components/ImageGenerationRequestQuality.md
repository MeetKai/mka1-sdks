# ImageGenerationRequestQuality

The quality tier of the generated image. Higher tiers may incur higher latency or cost. 'auto' lets the gateway pick a sensible value per model. 'standard' and 'hd' are accepted as legacy aliases.

## Example Usage

```csharp
using MeetKai.MKA1.Types.Components;

var value = ImageGenerationRequestQuality.Low;
```


## Values

| Name       | Value      |
| ---------- | ---------- |
| `Low`      | low        |
| `Medium`   | medium     |
| `High`     | high       |
| `Auto`     | auto       |
| `Standard` | standard   |
| `Hd`       | hd         |