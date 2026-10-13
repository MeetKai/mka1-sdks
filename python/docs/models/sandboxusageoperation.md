# SandboxUsageOperation

## Example Usage

```python
from meetkai_mka1.models import SandboxUsageOperation

# Open enum: unrecognized values are captured as UnrecognizedStr
value: SandboxUsageOperation = "session_start"
```


## Values

This is an open enum. Unrecognized values will not fail type checks.

- `"session_start"`
- `"session_stop"`
- `"session_terminate"`
- `"turn"`
- `"repo_task"`
- `"command"`
- `"code"`
- `"workspace_manifest"`
- `"workspace_download"`
- `"workspace_archive_download"`
- `"workspace_upload"`
- `"workspace_archive_upload"`
