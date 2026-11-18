# MKA1 SDKs

Official client SDKs for the [MKA1 API](https://docs.mka1.com).

| Language   | Package | Install |
| ---------- | ------- | ------- |
| TypeScript | [`@meetkai/mka1`](https://www.npmjs.com/package/@meetkai/mka1) | `npm install @meetkai/mka1` |
| Python     | [`meetkai-mka1`](https://pypi.org/project/meetkai-mka1/) | `pip install meetkai-mka1` |
| C#         | [`MeetKai.MKA1`](https://www.nuget.org/packages/MeetKai.MKA1) | `dotnet add package MeetKai.MKA1` |
| Go         | [`github.com/MeetKai/mka1-sdks/go`](https://pkg.go.dev/github.com/MeetKai/mka1-sdks/go) | `go get github.com/MeetKai/mka1-sdks/go` |

Each directory has its own README with usage, authentication, and the full
list of operations:

- [`typescript/`](./typescript)
- [`python/`](./python)
- [`csharp/`](./csharp)
- [`go/`](./go)

## OAuth authentication

For interactive applications, use an OAuth API access token through a dynamic
bearer callback. See [OAuth integration](./oauth/README.md) for all four
languages, refresh ownership, and optional CLI credentials. Static API keys
remain supported for automation.

## Breaking changes

### `permissions.llm` removed

Removed in TypeScript 0.55.89, Python 0.12.188, C# 0.11.209 and Go 0.1.73.
The `permissions` namespace is gone. Sharing is now managed on the resource
itself, for conversations, files, responses, skills and vector stores:

| Removed | Use instead |
| ------- | ----------- |
| `permissions.llm.check` | `llm.<resource>.getPermission`. Pass your own user id to read your own role. |
| `permissions.llm.grant` | `llm.<resource>.createPermission` |
| `permissions.llm.revoke` | `llm.<resource>.deletePermission` |
| A grant to `*` | No exact equivalent. The nearest is `createPermission` with `granteeType: "team"`, which reaches only the members of the resource's team. |

`llm.<resource>.listPermissions` lists the grants on a resource. Names are
shown as in TypeScript, for example `llm.conversations.createPermission`; the
other SDKs use the same names in their own casing.

## About this repository

This is a read-only release mirror. The SDKs are generated from the MKA1
OpenAPI specification with [Speakeasy](https://www.speakeasy.com), and every
commit here corresponds to a published package version. Tags follow
`<language>/v<version>`.

Pull requests are not accepted in this repository because changes are
overwritten on the next release. For questions and bug reports, see
[docs.mka1.com](https://docs.mka1.com).

Copyright MeetKai. All rights reserved.
