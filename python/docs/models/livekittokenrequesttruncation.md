# LivekitTokenRequestTruncation

The truncation strategy for handling inputs that exceed the model's context window. 'auto' automatically truncates old messages to fit, 'disabled' returns an error if context is too long. Defaults to 'auto'.

## Example Usage

```python
from meetkai_mka1.models import LivekitTokenRequestTruncation
value: LivekitTokenRequestTruncation = "auto"
```


## Values

- `"auto"`
- `"disabled"`
