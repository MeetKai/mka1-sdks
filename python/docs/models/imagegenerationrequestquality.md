# ImageGenerationRequestQuality

The quality tier of the generated image. Higher tiers may incur higher latency or cost. 'auto' lets the gateway pick a sensible value per model. 'standard' and 'hd' are accepted as legacy aliases.

## Example Usage

```python
from meetkai_mka1.models import ImageGenerationRequestQuality
value: ImageGenerationRequestQuality = "low"
```


## Values

- `"low"`
- `"medium"`
- `"high"`
- `"auto"`
- `"standard"`
- `"hd"`
