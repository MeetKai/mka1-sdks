# RepoKind

What a repository holds — a property of the content, not of the
client that made it. `repo` is a plain git repository (git, `gh`);
`model` and `dataset` are git repositories in the Hugging Face
layouts, served under `/api/models` and `/api/datasets` respectively;
`image` holds container images served by the OCI registry. Every kind
is reachable over git; the HF and OCI planes answer only for their
own kinds.


## Example Usage

```python
from meetkai_mka1.models import RepoKind

# Open enum: unrecognized values are captured as UnrecognizedStr
value: RepoKind = "repo"
```


## Values

This is an open enum. Unrecognized values will not fail type checks.

- `"repo"`
- `"model"`
- `"dataset"`
- `"image"`
