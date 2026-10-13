# Stream

The stream the line was written to. Native services report one combined stream as stdout: Kubernetes merges a container's two streams.

## Example Usage

```python
from meetkai_mka1.models import Stream

# Open enum: unrecognized values are captured as UnrecognizedStr
value: Stream = "stdout"
```


## Values

This is an open enum. Unrecognized values will not fail type checks.

- `"stdout"`
- `"stderr"`
