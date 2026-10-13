# LivekitTokenRequestServiceTier

Specifies the processing tier for serving the request. 'auto' lets the system choose, 'default' uses standard processing, 'flex' allows flexible scheduling for lower priority, 'priority' provides faster processing. Defaults to 'auto'.

## Example Usage

```csharp
using MeetKai.MKA1.Types.Components;

var value = LivekitTokenRequestServiceTier.Auto;
```


## Values

| Name       | Value      |
| ---------- | ---------- |
| `Auto`     | auto       |
| `Default`  | default    |
| `Flex`     | flex       |
| `Priority` | priority   |