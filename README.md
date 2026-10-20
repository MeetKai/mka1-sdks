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

## About this repository

This is a read-only release mirror. The SDKs are generated from the MKA1
OpenAPI specification with [Speakeasy](https://www.speakeasy.com), and every
commit here corresponds to a published package version. Tags follow
`<language>/v<version>`.

Pull requests are not accepted in this repository because changes are
overwritten on the next release. For questions and bug reports, see
[docs.mka1.com](https://docs.mka1.com).

Copyright MeetKai. All rights reserved.
