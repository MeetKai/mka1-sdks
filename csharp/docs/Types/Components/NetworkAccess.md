# NetworkAccess

How much of the internet a Coding Harness guest reaches through the proxy.

Ordered: each level includes the one before it. The model broker and the
``mka1-github`` push/PR tool reach the runner directly, and the
Environment's repositories are cloned on the host before boot, so all of
them work at every level, including ``none``.

## Example Usage

```csharp
using MeetKai.MKA1.Types.Components;

var value = NetworkAccess.None;
```


## Values

| Name              | Value             |
| ----------------- | ----------------- |
| `None`            | none              |
| `PackageManagers` | package_managers  |
| `Full`            | full              |