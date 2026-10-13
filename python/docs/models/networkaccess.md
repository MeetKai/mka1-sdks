# NetworkAccess

How much of the internet a Coding Harness guest reaches through the proxy.

Ordered: each level includes the one before it. The model broker and the
``mka1-github`` push/PR tool reach the runner directly, and the
Environment's repositories are cloned on the host before boot, so all of
them work at every level, including ``none``.

## Example Usage

```python
from meetkai_mka1.models import NetworkAccess

# Open enum: unrecognized values are captured as UnrecognizedStr
value: NetworkAccess = "none"
```


## Values

This is an open enum. Unrecognized values will not fail type checks.

- `"none"`
- `"package_managers"`
- `"full"`
