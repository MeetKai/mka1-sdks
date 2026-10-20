# SandboxUsageOperation

## Example Usage

```go
import (
	"github.com/MeetKai/mka1-sdks/go/models/components"
)

value := components.SandboxUsageOperationSessionStart

// Open enum: custom values can be created with a direct type cast
custom := components.SandboxUsageOperation("custom_value")
```


## Values

| Name                                            | Value                                           |
| ----------------------------------------------- | ----------------------------------------------- |
| `SandboxUsageOperationSessionStart`             | session_start                                   |
| `SandboxUsageOperationSessionStop`              | session_stop                                    |
| `SandboxUsageOperationSessionTerminate`         | session_terminate                               |
| `SandboxUsageOperationTurn`                     | turn                                            |
| `SandboxUsageOperationRepoTask`                 | repo_task                                       |
| `SandboxUsageOperationCommand`                  | command                                         |
| `SandboxUsageOperationCode`                     | code                                            |
| `SandboxUsageOperationWorkspaceManifest`        | workspace_manifest                              |
| `SandboxUsageOperationWorkspaceDownload`        | workspace_download                              |
| `SandboxUsageOperationWorkspaceArchiveDownload` | workspace_archive_download                      |
| `SandboxUsageOperationWorkspaceUpload`          | workspace_upload                                |
| `SandboxUsageOperationWorkspaceArchiveUpload`   | workspace_archive_upload                        |