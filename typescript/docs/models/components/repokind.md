# RepoKind

What a repository holds — a property of the content, not of the
client that made it. `repo` is a plain git repository (git, `gh`);
`model` and `dataset` are git repositories in the Hugging Face
layouts, served under `/api/models` and `/api/datasets` respectively;
`image` holds container images served by the OCI registry. Every kind
is reachable over git; the HF and OCI planes answer only for their
own kinds.


## Example Usage

```typescript
import { RepoKind } from "@meetkai/mka1/models/components";

let value: RepoKind = "dataset";
```

## Values

```typescript
"repo" | "model" | "dataset" | "image"
```