# ResponsesCreateRequestServiceTier

Specifies the processing tier for serving the request. 'auto' lets the system choose, 'default' uses standard processing, 'flex' allows flexible scheduling for lower priority, 'priority' provides faster processing. Defaults to 'auto'.

## Example Usage

```python
from meetkai_mka1.models import ResponsesCreateRequestServiceTier
value: ResponsesCreateRequestServiceTier = "auto"
```


## Values

- `"auto"`
- `"default"`
- `"flex"`
- `"priority"`
