# RepoKind

What a repository holds — a property of the content, not of the
client that made it. `repo` is a plain git repository (git, `gh`);
`model` and `dataset` are git repositories in the Hugging Face
layouts, served under `/api/models` and `/api/datasets` respectively;
`image` holds container images served by the OCI registry. Every kind
is reachable over git; the HF and OCI planes answer only for their
own kinds.


## Example Usage

```go
import (
	"github.com/MeetKai/mka1-sdks/go/models/components"
)

value := components.RepoKindRepo

// Open enum: custom values can be created with a direct type cast
custom := components.RepoKind("custom_value")
```


## Values

| Name              | Value             |
| ----------------- | ----------------- |
| `RepoKindRepo`    | repo              |
| `RepoKindModel`   | model             |
| `RepoKindDataset` | dataset           |
| `RepoKindImage`   | image             |