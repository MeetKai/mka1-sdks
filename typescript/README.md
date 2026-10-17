# MKA1 TypeScript SDK

Official TypeScript SDK for the MKA1 API.

Use `@meetkai/mka1` to call MKA1 from Node.js, browsers, React apps, and agent tooling. The SDK includes typed clients for responses, agents, files, vector stores, evals, usage, model registry operations, guardrails, sandbox APIs, and more.

Full product and API documentation lives at [docs.mka1.com](https://docs.mka1.com).

## Install

```bash
npm add @meetkai/mka1
```

```bash
pnpm add @meetkai/mka1
```

```bash
bun add @meetkai/mka1
```

```bash
yarn add @meetkai/mka1
```

The package ships both ESM and CommonJS builds. For supported runtimes, see [RUNTIMES.md](RUNTIMES.md).

## Quick Start

```typescript
import { SDK } from "@meetkai/mka1";

const mka1 = new SDK({
  bearerAuth: process.env.MKA1_API_KEY,
});

const models = await mka1.llm.models.list({});

console.log(models.data.map((model) => model.id));
```

Most write APIs use the same client:

```typescript
import { SDK } from "@meetkai/mka1";

const mka1 = new SDK({
  bearerAuth: process.env.MKA1_API_KEY,
});

const response = await mka1.llm.responses.create({
  responsesCreateRequest: {
    model: "<MODEL_ID>",
    input: "Summarize the latest MKA1 eval run.",
  },
});

console.log(response);
```

## Authentication

Pass an MKA1 API key or bearer token when constructing the client:

```typescript
const mka1 = new SDK({
  bearerAuth: process.env.MKA1_API_KEY,
});
```

You can also provide an async token resolver:

```typescript
const mka1 = new SDK({
  bearerAuth: async () => refreshMka1Token(),
});
```

For account setup, API keys, and endpoint-specific examples, see [docs.mka1.com](https://docs.mka1.com).

## Common Entry Points

```typescript
mka1.llm.responses
mka1.llm.conversations
mka1.llm.files
mka1.llm.vectorStores
mka1.llm.evals
mka1.llm.models
mka1.llm.usage
mka1.agents
mka1.agentRuns
mka1.sandbox
mka1.permissions
```

The generated method reference below lists every resource and operation included in this SDK.

## React Query

React hooks are available from `@meetkai/mka1/react-query`. Install the optional peer dependencies only if you plan to use those hooks:

```bash
npm add @tanstack/react-query react react-dom
```

See [REACT_QUERY.md](REACT_QUERY.md) for provider setup, suspense hooks, invalidation helpers, and mutation examples.

## MCP Server

This package also exposes the MKA1 API as an installable Model Context Protocol server.

Node.js v20 or newer is required for the MCP server.

```json
{
  "mcpServers": {
    "mka1": {
      "command": "npx",
      "args": [
        "-y",
        "--package",
        "@meetkai/mka1",
        "--",
        "mcp",
        "start",
        "--bearer-auth",
        "..."
      ]
    }
  }
}
```

For available server flags:

```bash
npx -y --package @meetkai/mka1 -- mcp start --help
```

<!-- Start Summary [summary] -->
## Summary

MKA1 API: The MKA1 API is a RESTful API that provides access to the MKA1 platform. Learn how to get started with the API and the TypeScript SDK [here](https://mka1.apidocumentation.com/guides/getting-started).
<!-- End Summary [summary] -->

<!-- Start Table of Contents [toc] -->
## Table of Contents
<!-- $toc-max-depth=2 -->
* [MKA1 TypeScript SDK](#mka1-typescript-sdk)
  * [Install](#install)
  * [Quick Start](#quick-start)
  * [Authentication](#authentication)
  * [Common Entry Points](#common-entry-points)
  * [React Query](#react-query)
  * [MCP Server](#mcp-server)
  * [SDK Installation](#sdk-installation)
  * [Requirements](#requirements)
  * [SDK Example Usage](#sdk-example-usage)
  * [Authentication](#authentication-1)
  * [Available Resources and Operations](#available-resources-and-operations)
  * [Standalone functions](#standalone-functions)
  * [React hooks with TanStack Query](#react-hooks-with-tanstack-query)
  * [Server-sent event streaming](#server-sent-event-streaming)
  * [File uploads](#file-uploads)
  * [Retries](#retries)
  * [Error Handling](#error-handling)
  * [Server Selection](#server-selection)
  * [Custom HTTP Client](#custom-http-client)
  * [Debugging](#debugging)
  * [Versioning](#versioning)
  * [Generated Code](#generated-code)

<!-- End Table of Contents [toc] -->

<!-- Start SDK Installation [installation] -->
## SDK Installation

> [!TIP]
> To finish publishing your SDK to npm and others you must [run your first generation action](https://www.speakeasy.com/docs/github-setup#step-by-step-guide).


The SDK can be installed with either [npm](https://www.npmjs.com/), [pnpm](https://pnpm.io/), [bun](https://bun.sh/) or [yarn](https://classic.yarnpkg.com/en/) package managers.

### NPM

```bash
npm add git+https://github.com/MeetKai/mka1-sdks.git?subdir=typescript
# Install optional peer dependencies if you plan to use React hooks
npm add @tanstack/react-query react react-dom
```

### PNPM

```bash
pnpm add https://github.com/MeetKai/mka1-sdks#path:typescript
# Install optional peer dependencies if you plan to use React hooks
pnpm add @tanstack/react-query react react-dom
```

### Bun

```bash
bun add https://github.com/MeetKai/mka1-sdks
# Install optional peer dependencies if you plan to use React hooks
bun add @tanstack/react-query react react-dom
```

### Yarn

```bash
yarn add https://github.com/MeetKai/mka1-sdks
# Install optional peer dependencies if you plan to use React hooks
yarn add @tanstack/react-query react react-dom
```

> [!NOTE]
> This package is published with CommonJS and ES Modules (ESM) support.


### Model Context Protocol (MCP) Server

This SDK is also an installable MCP server where the various SDK methods are
exposed as tools that can be invoked by AI applications.

> Node.js v20 or greater is required to run the MCP server from npm.

<details>
<summary>Claude installation steps</summary>

Add the following server definition to your `claude_desktop_config.json` file:

```json
{
  "mcpServers": {
    "SDK": {
      "command": "npx",
      "args": [
        "-y", "--package", "@meetkai/mka1",
        "--",
        "mcp", "start",
        "--bearer-auth", "..."
      ]
    }
  }
}
```

</details>

<details>
<summary>Cursor installation steps</summary>

Create a `.cursor/mcp.json` file in your project root with the following content:

```json
{
  "mcpServers": {
    "SDK": {
      "command": "npx",
      "args": [
        "-y", "--package", "@meetkai/mka1",
        "--",
        "mcp", "start",
        "--bearer-auth", "..."
      ]
    }
  }
}
```

</details>

You can also run MCP servers as a standalone binary with no additional dependencies. You must pull these binaries from available Github releases:

```bash
curl -L -o mcp-server \
    https://github.com/{org}/{repo}/releases/download/{tag}/mcp-server-bun-darwin-arm64 && \
chmod +x mcp-server
```

If the repo is a private repo you must add your Github PAT to download a release `-H "Authorization: Bearer {GITHUB_PAT}"`.


```json
{
  "mcpServers": {
    "Todos": {
      "command": "./DOWNLOAD/PATH/mcp-server",
      "args": [
        "start"
      ]
    }
  }
}
```

For a full list of server arguments, run:

```sh
npx -y --package @meetkai/mka1 -- mcp start --help
```
<!-- End SDK Installation [installation] -->

<!-- Start Requirements [requirements] -->
## Requirements

For supported JavaScript runtimes, please consult [RUNTIMES.md](RUNTIMES.md).
<!-- End Requirements [requirements] -->

<!-- Start SDK Example Usage [usage] -->
## SDK Example Usage

### Example

```typescript
import { SDK } from "@meetkai/mka1";

const sdk = new SDK({
  bearerAuth: "<YOUR_BEARER_TOKEN_HERE>",
});

async function run() {
  await sdk.permissions.llm.grant({
    grantPermissionRequest: {
      resourceType: "completion",
      resourceId: "my-completion-123",
      userId: "user-abc456",
      role: "writer",
    },
  });
}

run();

```
<!-- End SDK Example Usage [usage] -->

<!-- Start Authentication [security] -->
## Authentication

### Per-Client Security Schemes

This SDK supports the following security scheme globally:

| Name         | Type | Scheme      |
| ------------ | ---- | ----------- |
| `bearerAuth` | http | HTTP Bearer |

To authenticate with the API the `bearerAuth` parameter must be set when initializing the SDK client instance. For example:
```typescript
import { SDK } from "@meetkai/mka1";

const sdk = new SDK({
  bearerAuth: "<YOUR_BEARER_TOKEN_HERE>",
});

async function run() {
  await sdk.permissions.llm.grant({
    grantPermissionRequest: {
      resourceType: "completion",
      resourceId: "my-completion-123",
      userId: "user-abc456",
      role: "writer",
    },
  });
}

run();

```

### Per-Operation Security Schemes

Some operations in this SDK require the security scheme to be specified at the request level. For example:
```typescript
import { SDK } from "@meetkai/mka1";

const sdk = new SDK();

async function run() {
  const result = await sdk.auth.orgs.listMembers({}, {
    orgId: "<id>",
  });

  console.log(result);
}

run();

```
<!-- End Authentication [security] -->

## Available Resources and Operations

The per-operation reference, with request and response shapes and examples for every SDK, is at [docs.mka1.com/api-reference](https://docs.mka1.com/api-reference).

<!-- No Available Resources and Operations [operations] -->

## Standalone functions

Every SDK method is also available as a standalone function under `@meetkai/mka1/funcs`. These are ideal for browsers, serverless runtimes, and other bundle-size-sensitive environments: unused functions are tree-shaken away. See [FUNCTIONS.md](./FUNCTIONS.md) for the pattern, and the [API reference](https://docs.mka1.com/api-reference) for the per-operation signatures.

<!-- No Standalone functions [standalone-funcs] -->

## React hooks with TanStack Query

Every SDK method has a matching React hook built on [TanStack Query](https://tanstack.com/query/latest) under `@meetkai/mka1/react-query`. See [REACT_QUERY.md](./REACT_QUERY.md) for setup, caching, and invalidation, and the [API reference](https://docs.mka1.com/api-reference) for the per-operation hooks.

<!-- No React hooks with TanStack Query [react-query] -->

<!-- Start Server-sent event streaming [eventstream] -->
## Server-sent event streaming

[Server-sent events][mdn-sse] are used to stream content from certain
operations. These operations will expose the stream as an async iterable that
can be consumed using a [`for await...of`][mdn-for-await-of] loop. The loop will
terminate when the server no longer has any events to send and closes the
underlying connection.

```typescript
import { SDK } from "@meetkai/mka1";

const sdk = new SDK({
  bearerAuth: "<YOUR_BEARER_TOKEN_HERE>",
});

async function run() {
  const result = await sdk.llm.responses.create({
    responsesCreateRequest: {
      model: "meetkai:functionary-urdu-mini-pak",
      input: "What is the capital of France?",
    },
  });

  console.log(result);
}

run();

```

[mdn-sse]: https://developer.mozilla.org/en-US/docs/Web/API/Server-sent_events/Using_server-sent_events
[mdn-for-await-of]: https://developer.mozilla.org/en-US/docs/Web/JavaScript/Reference/Statements/for-await...of
<!-- End Server-sent event streaming [eventstream] -->

<!-- Start File uploads [file-upload] -->
## File uploads

Certain SDK methods accept files as part of a multi-part request. It is possible and typically recommended to upload files as a stream rather than reading the entire contents into memory. This avoids excessive memory consumption and potentially crashing with out-of-memory errors when working with very large files. The following example demonstrates how to attach a file stream to a request.

> [!TIP]
>
> Depending on your JavaScript runtime, there are convenient utilities that return a handle to a file without reading the entire contents into memory:
>
> - **Node.js v20+:** Since v20, Node.js comes with a native `openAsBlob` function in [`node:fs`](https://nodejs.org/docs/latest-v20.x/api/fs.html#fsopenasblobpath-options).
> - **Bun:** The native [`Bun.file`](https://bun.sh/docs/api/file-io#reading-files-bun-file) function produces a file handle that can be used for streaming file uploads.
> - **Browsers:** All supported browsers return an instance to a [`File`](https://developer.mozilla.org/en-US/docs/Web/API/File) when reading the value from an `<input type="file">` element.
> - **Node.js v18:** A file stream can be created using the `fileFrom` helper from [`fetch-blob/from.js`](https://www.npmjs.com/package/fetch-blob).

```typescript
import { SDK } from "@meetkai/mka1";
import { openAsBlob } from "node:fs";

const sdk = new SDK({
  bearerAuth: "<YOUR_BEARER_TOKEN_HERE>",
});

async function run() {
  const result = await sdk.llm.files.upload({
    requestBody: {
      file: await openAsBlob("example.file"),
      purpose: "assistants",
    },
  });

  console.log(result);
}

run();

```
<!-- End File uploads [file-upload] -->

<!-- Start Retries [retries] -->
## Retries

Some of the endpoints in this SDK support retries.  If you use the SDK without any configuration, it will fall back to the default retry strategy provided by the API.  However, the default retry strategy can be overridden on a per-operation basis, or across the entire SDK.

To change the default retry strategy for a single API call, simply provide a retryConfig object to the call:
```typescript
import { SDK } from "@meetkai/mka1";

const sdk = new SDK({
  bearerAuth: "<YOUR_BEARER_TOKEN_HERE>",
});

async function run() {
  await sdk.permissions.llm.grant({
    grantPermissionRequest: {
      resourceType: "completion",
      resourceId: "my-completion-123",
      userId: "user-abc456",
      role: "writer",
    },
  }, {
    retries: {
      strategy: "backoff",
      backoff: {
        initialInterval: 1,
        maxInterval: 50,
        exponent: 1.1,
        maxElapsedTime: 100,
      },
      retryConnectionErrors: false,
    },
  });
}

run();

```

If you'd like to override the default retry strategy for all operations that support retries, you can provide a retryConfig at SDK initialization:
```typescript
import { SDK } from "@meetkai/mka1";

const sdk = new SDK({
  retryConfig: {
    strategy: "backoff",
    backoff: {
      initialInterval: 1,
      maxInterval: 50,
      exponent: 1.1,
      maxElapsedTime: 100,
    },
    retryConnectionErrors: false,
  },
  bearerAuth: "<YOUR_BEARER_TOKEN_HERE>",
});

async function run() {
  await sdk.permissions.llm.grant({
    grantPermissionRequest: {
      resourceType: "completion",
      resourceId: "my-completion-123",
      userId: "user-abc456",
      role: "writer",
    },
  });
}

run();

```
<!-- End Retries [retries] -->

<!-- Start Error Handling [errors] -->
## Error Handling

[`SDKError`](./src/models/errors/sdkerror.ts) is the base class for all HTTP error responses. It has the following properties:

| Property            | Type       | Description                                                                             |
| ------------------- | ---------- | --------------------------------------------------------------------------------------- |
| `error.message`     | `string`   | Error message                                                                           |
| `error.statusCode`  | `number`   | HTTP response status code eg `404`                                                      |
| `error.headers`     | `Headers`  | HTTP response headers                                                                   |
| `error.body`        | `string`   | HTTP body. Can be empty string if no body is returned.                                  |
| `error.rawResponse` | `Response` | Raw HTTP response                                                                       |
| `error.data$`       |            | Optional. Some errors may contain structured data. [See Error Classes](#error-classes). |

### Example
```typescript
import { SDK } from "@meetkai/mka1";
import * as errors from "@meetkai/mka1/models/errors";

const sdk = new SDK({
  bearerAuth: "<YOUR_BEARER_TOKEN_HERE>",
});

async function run() {
  try {
    const result = await sdk.llm.files.content({
      fileId: "file-abc123",
    });

    console.log(result);
  } catch (error) {
    // The base class for HTTP error responses
    if (error instanceof errors.SDKError) {
      console.log(error.message);
      console.log(error.statusCode);
      console.log(error.body);
      console.log(error.headers);

      // Depending on the method different errors may be thrown
      if (error instanceof errors.GetFileContentResponseBody) {
        console.log(error.data$.error); // errors.GetFileContentLlmFilesResponse400Error
      }
    }
  }
}

run();

```

### Error Classes
**Primary error:**
* [`SDKError`](./src/models/errors/sdkerror.ts): The base class for HTTP error responses.

<details><summary>Less common errors (366)</summary>

<br />

**Network errors:**
* [`ConnectionError`](./src/models/errors/httpclienterrors.ts): HTTP client was unable to make a request to a server.
* [`RequestTimeoutError`](./src/models/errors/httpclienterrors.ts): HTTP request timed out due to an AbortSignal signal.
* [`RequestAbortedError`](./src/models/errors/httpclienterrors.ts): HTTP request was aborted by the client.
* [`InvalidRequestError`](./src/models/errors/httpclienterrors.ts): Any input used to create a request is invalid.
* [`UnexpectedClientError`](./src/models/errors/httpclienterrors.ts): Unrecognised or unexpected error.


**Inherit from [`SDKError`](./src/models/errors/sdkerror.ts)**:
* [`HTTPValidationError`](./src/models/errors/httpvalidationerror.ts): Validation Error. Status code `422`. Applicable to 47 of 486 methods.*
* [`ErrorEnvelope`](./src/models/errors/errorenvelope.ts): Error response. Applicable to 28 of 486 methods.*
* [`FeatureFlagError`](./src/models/errors/featureflagerror.ts): The request is malformed or fails validation. Applicable to 22 of 486 methods.*
* [`AnalyticsError`](./src/models/errors/analyticserror.ts): Request failed. Applicable to 12 of 486 methods.*
* [`RepoError`](./src/models/errors/repoerror.ts): The uniform error envelope. `error` is a stable machine-readable code (never an internal reason); `correlation_id` echoes the request's `X-Correlation-ID` for log correlation. Applicable to 7 of 486 methods.*
* [`ExchangeSessionTokenResponseBody`](./src/models/errors/exchangesessiontokenresponsebody.ts): Invalid request. Status code `400`. Applicable to 1 of 486 methods.*
* [`GetFileContentResponseBody`](./src/models/errors/getfilecontentresponsebody.ts): Invalid request - File ID is required. Status code `400`. Applicable to 1 of 486 methods.*
* [`ListOrgMembersResponseBody`](./src/models/errors/listorgmembersresponsebody.ts): Bad request. Status code `400`. Applicable to 1 of 486 methods.*
* [`InviteOrgMemberResponseBody`](./src/models/errors/inviteorgmemberresponsebody.ts): Bad request. Status code `400`. Applicable to 1 of 486 methods.*
* [`UpdateOrgMemberResponseBody`](./src/models/errors/updateorgmemberresponsebody.ts): Bad request. Status code `400`. Applicable to 1 of 486 methods.*
* [`RemoveOrgMemberResponseBody`](./src/models/errors/removeorgmemberresponsebody.ts): Bad request. Status code `400`. Applicable to 1 of 486 methods.*
* [`GetSsoPolicyResponseBody`](./src/models/errors/getssopolicyresponsebody.ts): Bad request. Status code `400`. Applicable to 1 of 486 methods.*
* [`UpdateSsoPolicyResponseBody`](./src/models/errors/updatessopolicyresponsebody.ts): Bad request. Status code `400`. Applicable to 1 of 486 methods.*
* [`GetOrgByIdResponseBody`](./src/models/errors/getorgbyidresponsebody.ts): Bad request. Status code `400`. Applicable to 1 of 486 methods.*
* [`UpdateOrganizationResponseBody`](./src/models/errors/updateorganizationresponsebody.ts): Invalid JSON or metadata patch. Status code `400`. Applicable to 1 of 486 methods.*
* [`GetOrgQuotaResponseBody`](./src/models/errors/getorgquotaresponsebody.ts): Bad request. Status code `400`. Applicable to 1 of 486 methods.*
* [`UpdateOrgQuotaResponseBody`](./src/models/errors/updateorgquotaresponsebody.ts): Bad request. Status code `400`. Applicable to 1 of 486 methods.*
* [`GetOrgRateLimitResponseBody`](./src/models/errors/getorgratelimitresponsebody.ts): Bad request. Status code `400`. Applicable to 1 of 486 methods.*
* [`UpdateOrgRateLimitResponseBody`](./src/models/errors/updateorgratelimitresponsebody.ts): Bad request. Status code `400`. Applicable to 1 of 486 methods.*
* [`GetNetworkPolicyAccessResponseBody`](./src/models/errors/getnetworkpolicyaccessresponsebody.ts): Bad request. Status code `400`. Applicable to 1 of 486 methods.*
* [`CreateTeamResponseBody`](./src/models/errors/createteamresponsebody.ts): Bad request. Status code `400`. Applicable to 1 of 486 methods.*
* [`ListTeamsResponseBody`](./src/models/errors/listteamsresponsebody.ts): Bad request. Status code `400`. Applicable to 1 of 486 methods.*
* [`GetTeamResponseBody`](./src/models/errors/getteamresponsebody.ts): Bad request. Status code `400`. Applicable to 1 of 486 methods.*
* [`UpdateTeamResponseBody`](./src/models/errors/updateteamresponsebody.ts): Bad request. Status code `400`. Applicable to 1 of 486 methods.*
* [`DeleteTeamResponseBody`](./src/models/errors/deleteteamresponsebody.ts): Bad request. Status code `400`. Applicable to 1 of 486 methods.*
* [`AddTeamMemberResponseBody`](./src/models/errors/addteammemberresponsebody.ts): Bad request. Status code `400`. Applicable to 1 of 486 methods.*
* [`ListTeamMembersResponseBody`](./src/models/errors/listteammembersresponsebody.ts): Bad request. Status code `400`. Applicable to 1 of 486 methods.*
* [`UpdateTeamMemberResponseBody`](./src/models/errors/updateteammemberresponsebody.ts): Bad request. Status code `400`. Applicable to 1 of 486 methods.*
* [`RemoveTeamMemberResponseBody`](./src/models/errors/removeteammemberresponsebody.ts): Bad request. Status code `400`. Applicable to 1 of 486 methods.*
* [`CreateScopedApiKeyResponseBody`](./src/models/errors/createscopedapikeyresponsebody.ts): Bad request. Status code `400`. Applicable to 1 of 486 methods.*
* [`ListScopedApiKeysResponseBody`](./src/models/errors/listscopedapikeysresponsebody.ts): Bad request. Status code `400`. Applicable to 1 of 486 methods.*
* [`UpdateScopedApiKeyResponseBody`](./src/models/errors/updatescopedapikeyresponsebody.ts): Bad request. Status code `400`. Applicable to 1 of 486 methods.*
* [`RegenerateScopedApiKeyResponseBody`](./src/models/errors/regeneratescopedapikeyresponsebody.ts): Bad request. Status code `400`. Applicable to 1 of 486 methods.*
* [`ExchangeApiKeyTokenResponseBody`](./src/models/errors/exchangeapikeytokenresponsebody.ts): Bad request. Status code `400`. Applicable to 1 of 486 methods.*
* [`CreateServiceAccountResponseBody`](./src/models/errors/createserviceaccountresponsebody.ts): Bad request. Status code `400`. Applicable to 1 of 486 methods.*
* [`ListServiceAccountsResponseBody`](./src/models/errors/listserviceaccountsresponsebody.ts): Bad request. Status code `400`. Applicable to 1 of 486 methods.*
* [`GetServiceAccountResponseBody`](./src/models/errors/getserviceaccountresponsebody.ts): Bad request. Status code `400`. Applicable to 1 of 486 methods.*
* [`DeleteServiceAccountResponseBody`](./src/models/errors/deleteserviceaccountresponsebody.ts): Bad request. Status code `400`. Applicable to 1 of 486 methods.*
* [`ListServiceAccountApiKeysResponseBody`](./src/models/errors/listserviceaccountapikeysresponsebody.ts): Bad request. Status code `400`. Applicable to 1 of 486 methods.*
* [`UpdateServiceAccountApiKeyResponseBody`](./src/models/errors/updateserviceaccountapikeyresponsebody.ts): Bad request. Status code `400`. Applicable to 1 of 486 methods.*
* [`DeleteServiceAccountApiKeyResponseBody`](./src/models/errors/deleteserviceaccountapikeyresponsebody.ts): Bad request. Status code `400`. Applicable to 1 of 486 methods.*
* [`RegenerateServiceAccountApiKeyResponseBody`](./src/models/errors/regenerateserviceaccountapikeyresponsebody.ts): Bad request. Status code `400`. Applicable to 1 of 486 methods.*
* [`CreateClusterInviteResponseBody`](./src/models/errors/createclusterinviteresponsebody.ts): Bad request. Status code `400`. Applicable to 1 of 486 methods.*
* [`ListClusterInvitesResponseBody`](./src/models/errors/listclusterinvitesresponsebody.ts): Bad request. Status code `400`. Applicable to 1 of 486 methods.*
* [`UpdateClusterInviteResponseBody`](./src/models/errors/updateclusterinviteresponsebody.ts): Bad request. Status code `400`. Applicable to 1 of 486 methods.*
* [`RevokeClusterInviteResponseBody`](./src/models/errors/revokeclusterinviteresponsebody.ts): Bad request. Status code `400`. Applicable to 1 of 486 methods.*
* [`ListClusterOrgsResponseBody`](./src/models/errors/listclusterorgsresponsebody.ts): Bad request. Status code `400`. Applicable to 1 of 486 methods.*
* [`GetClusterOrgResponseBody`](./src/models/errors/getclusterorgresponsebody.ts): Bad request. Status code `400`. Applicable to 1 of 486 methods.*
* [`DeleteClusterOrgResponseBody`](./src/models/errors/deleteclusterorgresponsebody.ts): Bad request. Status code `400`. Applicable to 1 of 486 methods.*
* [`InviteClusterOrgMembersResponseBody`](./src/models/errors/inviteclusterorgmembersresponsebody.ts): Invalid body or batch size. Status code `400`. Applicable to 1 of 486 methods.*
* [`SuspendClusterOrgResponseBody`](./src/models/errors/suspendclusterorgresponsebody.ts): Bad request. Status code `400`. Applicable to 1 of 486 methods.*
* [`UnsuspendClusterOrgResponseBody`](./src/models/errors/unsuspendclusterorgresponsebody.ts): Bad request. Status code `400`. Applicable to 1 of 486 methods.*
* [`ReissueOwnerKeyResponseBody`](./src/models/errors/reissueownerkeyresponsebody.ts): Bad request. Status code `400`. Applicable to 1 of 486 methods.*
* [`GetClusterInviteInfoResponseBody`](./src/models/errors/getclusterinviteinforesponsebody.ts): Bad request. Status code `400`. Applicable to 1 of 486 methods.*
* [`AcceptClusterInviteResponseBody`](./src/models/errors/acceptclusterinviteresponsebody.ts): Bad request. `code: "reserved_org_slug"` distinguishes a slug that nobody may hold from the 409 returned when another org already holds it. Status code `400`. Applicable to 1 of 486 methods.*
* [`GetJwtFromKeyResponseBody`](./src/models/errors/getjwtfromkeyresponsebody.ts): Invalid request body. Status code `400`. Applicable to 1 of 486 methods.*
* [`GetPendingInvitationResponseBody`](./src/models/errors/getpendinginvitationresponsebody.ts): Unauthorized. Status code `401`. Applicable to 1 of 486 methods.*
* [`ExchangeSessionTokenSessionResponseBody`](./src/models/errors/exchangesessiontokensessionresponsebody.ts): Missing, invalid, revoked or expiring session. Status code `401`. Applicable to 1 of 486 methods.*
* [`GetFileContentLlmFilesResponseBody`](./src/models/errors/getfilecontentllmfilesresponsebody.ts): Unauthorized - Invalid or missing authentication. Status code `401`. Applicable to 1 of 486 methods.*
* [`ListOrgMembersAuthOrgsResponseBody`](./src/models/errors/listorgmembersauthorgsresponsebody.ts): Unauthorized. Status code `401`. Applicable to 1 of 486 methods.*
* [`InviteOrgMemberAuthOrgsResponseBody`](./src/models/errors/inviteorgmemberauthorgsresponsebody.ts): Unauthorized. Status code `401`. Applicable to 1 of 486 methods.*
* [`UpdateOrgMemberAuthOrgsResponseBody`](./src/models/errors/updateorgmemberauthorgsresponsebody.ts): Unauthorized. Status code `401`. Applicable to 1 of 486 methods.*
* [`RemoveOrgMemberAuthOrgsResponseBody`](./src/models/errors/removeorgmemberauthorgsresponsebody.ts): Unauthorized. Status code `401`. Applicable to 1 of 486 methods.*
* [`GetSsoPolicyAuthOrgsResponseBody`](./src/models/errors/getssopolicyauthorgsresponsebody.ts): Unauthorized. Status code `401`. Applicable to 1 of 486 methods.*
* [`UpdateSsoPolicyAuthOrgsResponseBody`](./src/models/errors/updatessopolicyauthorgsresponsebody.ts): Unauthorized. Status code `401`. Applicable to 1 of 486 methods.*
* [`GetOrgByIdAuthOrgsResponseBody`](./src/models/errors/getorgbyidauthorgsresponsebody.ts): Unauthorized. Status code `401`. Applicable to 1 of 486 methods.*
* [`UpdateOrganizationAuthOrgsResponseBody`](./src/models/errors/updateorganizationauthorgsresponsebody.ts): Unauthorized. Status code `401`. Applicable to 1 of 486 methods.*
* [`GetOrgQuotaAuthOrgsResponseBody`](./src/models/errors/getorgquotaauthorgsresponsebody.ts): Unauthorized. Status code `401`. Applicable to 1 of 486 methods.*
* [`UpdateOrgQuotaAuthOrgsResponseBody`](./src/models/errors/updateorgquotaauthorgsresponsebody.ts): Unauthorized. Status code `401`. Applicable to 1 of 486 methods.*
* [`GetOrgRateLimitAuthOrgsResponseBody`](./src/models/errors/getorgratelimitauthorgsresponsebody.ts): Unauthorized. Status code `401`. Applicable to 1 of 486 methods.*
* [`UpdateOrgRateLimitAuthOrgsResponseBody`](./src/models/errors/updateorgratelimitauthorgsresponsebody.ts): Unauthorized. Status code `401`. Applicable to 1 of 486 methods.*
* [`GetNetworkPolicyAccessAuthTeamsResponseBody`](./src/models/errors/getnetworkpolicyaccessauthteamsresponsebody.ts): Unauthorized. Status code `401`. Applicable to 1 of 486 methods.*
* [`CreateTeamAuthTeamsResponseBody`](./src/models/errors/createteamauthteamsresponsebody.ts): Unauthorized. Status code `401`. Applicable to 1 of 486 methods.*
* [`ListTeamsAuthTeamsResponseBody`](./src/models/errors/listteamsauthteamsresponsebody.ts): Unauthorized. Status code `401`. Applicable to 1 of 486 methods.*
* [`GetTeamAuthTeamsResponseBody`](./src/models/errors/getteamauthteamsresponsebody.ts): Unauthorized. Status code `401`. Applicable to 1 of 486 methods.*
* [`UpdateTeamAuthTeamsResponseBody`](./src/models/errors/updateteamauthteamsresponsebody.ts): Unauthorized. Status code `401`. Applicable to 1 of 486 methods.*
* [`DeleteTeamAuthTeamsResponseBody`](./src/models/errors/deleteteamauthteamsresponsebody.ts): Unauthorized. Status code `401`. Applicable to 1 of 486 methods.*
* [`AddTeamMemberAuthTeamsResponseBody`](./src/models/errors/addteammemberauthteamsresponsebody.ts): Unauthorized. Status code `401`. Applicable to 1 of 486 methods.*
* [`ListTeamMembersAuthTeamsResponseBody`](./src/models/errors/listteammembersauthteamsresponsebody.ts): Unauthorized. Status code `401`. Applicable to 1 of 486 methods.*
* [`UpdateTeamMemberAuthTeamsResponseBody`](./src/models/errors/updateteammemberauthteamsresponsebody.ts): Unauthorized. Status code `401`. Applicable to 1 of 486 methods.*
* [`RemoveTeamMemberAuthTeamsResponseBody`](./src/models/errors/removeteammemberauthteamsresponsebody.ts): Unauthorized. Status code `401`. Applicable to 1 of 486 methods.*
* [`CreateScopedApiKeyAuthApiKeysResponseBody`](./src/models/errors/createscopedapikeyauthapikeysresponsebody.ts): Unauthorized. Status code `401`. Applicable to 1 of 486 methods.*
* [`ListScopedApiKeysAuthApiKeysResponseBody`](./src/models/errors/listscopedapikeysauthapikeysresponsebody.ts): Unauthorized. Status code `401`. Applicable to 1 of 486 methods.*
* [`UpdateScopedApiKeyAuthApiKeysResponseBody`](./src/models/errors/updatescopedapikeyauthapikeysresponsebody.ts): Unauthorized. Status code `401`. Applicable to 1 of 486 methods.*
* [`RegenerateScopedApiKeyAuthApiKeysResponseBody`](./src/models/errors/regeneratescopedapikeyauthapikeysresponsebody.ts): Unauthorized. Status code `401`. Applicable to 1 of 486 methods.*
* [`ExchangeApiKeyTokenAuthApiKeysResponseBody`](./src/models/errors/exchangeapikeytokenauthapikeysresponsebody.ts): Unauthorized. Status code `401`. Applicable to 1 of 486 methods.*
* [`CreateServiceAccountAuthServiceAccountsResponseBody`](./src/models/errors/createserviceaccountauthserviceaccountsresponsebody.ts): Unauthorized. Status code `401`. Applicable to 1 of 486 methods.*
* [`ListServiceAccountsAuthServiceAccountsResponseBody`](./src/models/errors/listserviceaccountsauthserviceaccountsresponsebody.ts): Unauthorized. Status code `401`. Applicable to 1 of 486 methods.*
* [`GetServiceAccountAuthServiceAccountsResponseBody`](./src/models/errors/getserviceaccountauthserviceaccountsresponsebody.ts): Unauthorized. Status code `401`. Applicable to 1 of 486 methods.*
* [`DeleteServiceAccountAuthServiceAccountsResponseBody`](./src/models/errors/deleteserviceaccountauthserviceaccountsresponsebody.ts): Unauthorized. Status code `401`. Applicable to 1 of 486 methods.*
* [`ListServiceAccountApiKeysAuthServiceAccountsResponseBody`](./src/models/errors/listserviceaccountapikeysauthserviceaccountsresponsebody.ts): Unauthorized. Status code `401`. Applicable to 1 of 486 methods.*
* [`UpdateServiceAccountApiKeyAuthServiceAccountsResponseBody`](./src/models/errors/updateserviceaccountapikeyauthserviceaccountsresponsebody.ts): Unauthorized. Status code `401`. Applicable to 1 of 486 methods.*
* [`DeleteServiceAccountApiKeyAuthServiceAccountsResponseBody`](./src/models/errors/deleteserviceaccountapikeyauthserviceaccountsresponsebody.ts): Unauthorized. Status code `401`. Applicable to 1 of 486 methods.*
* [`RegenerateServiceAccountApiKeyAuthServiceAccountsResponseBody`](./src/models/errors/regenerateserviceaccountapikeyauthserviceaccountsresponsebody.ts): Unauthorized. Status code `401`. Applicable to 1 of 486 methods.*
* [`CreateClusterInviteAuthClusterResponseBody`](./src/models/errors/createclusterinviteauthclusterresponsebody.ts): Unauthorized. Status code `401`. Applicable to 1 of 486 methods.*
* [`ListClusterInvitesAuthClusterResponseBody`](./src/models/errors/listclusterinvitesauthclusterresponsebody.ts): Unauthorized. Status code `401`. Applicable to 1 of 486 methods.*
* [`UpdateClusterInviteAuthClusterResponseBody`](./src/models/errors/updateclusterinviteauthclusterresponsebody.ts): Unauthorized. Status code `401`. Applicable to 1 of 486 methods.*
* [`RevokeClusterInviteAuthClusterResponseBody`](./src/models/errors/revokeclusterinviteauthclusterresponsebody.ts): Unauthorized. Status code `401`. Applicable to 1 of 486 methods.*
* [`ListClusterOrgsAuthClusterResponseBody`](./src/models/errors/listclusterorgsauthclusterresponsebody.ts): Unauthorized. Status code `401`. Applicable to 1 of 486 methods.*
* [`GetClusterOrgAuthClusterResponseBody`](./src/models/errors/getclusterorgauthclusterresponsebody.ts): Unauthorized. Status code `401`. Applicable to 1 of 486 methods.*
* [`DeleteClusterOrgAuthClusterResponseBody`](./src/models/errors/deleteclusterorgauthclusterresponsebody.ts): Unauthorized. Status code `401`. Applicable to 1 of 486 methods.*
* [`InviteClusterOrgMembersAuthClusterResponseBody`](./src/models/errors/inviteclusterorgmembersauthclusterresponsebody.ts): Unauthorized. Status code `401`. Applicable to 1 of 486 methods.*
* [`SuspendClusterOrgAuthClusterResponseBody`](./src/models/errors/suspendclusterorgauthclusterresponsebody.ts): Unauthorized. Status code `401`. Applicable to 1 of 486 methods.*
* [`UnsuspendClusterOrgAuthClusterResponseBody`](./src/models/errors/unsuspendclusterorgauthclusterresponsebody.ts): Unauthorized. Status code `401`. Applicable to 1 of 486 methods.*
* [`ReissueOwnerKeyAuthClusterResponseBody`](./src/models/errors/reissueownerkeyauthclusterresponsebody.ts): Unauthorized. Status code `401`. Applicable to 1 of 486 methods.*
* [`GetClusterInviteInfoAuthClusterResponseBody`](./src/models/errors/getclusterinviteinfoauthclusterresponsebody.ts): Unauthorized. Status code `401`. Applicable to 1 of 486 methods.*
* [`AcceptClusterInviteAuthClusterResponseBody`](./src/models/errors/acceptclusterinviteauthclusterresponsebody.ts): Unauthorized. Status code `401`. Applicable to 1 of 486 methods.*
* [`GetJwtFromKeyAuthApiKeyResponseBody`](./src/models/errors/getjwtfromkeyauthapikeyresponsebody.ts): Unauthorized. Status code `401`. Applicable to 1 of 486 methods.*
* [`GetPendingInvitationSessionResponseBody`](./src/models/errors/getpendinginvitationsessionresponsebody.ts): Forbidden. Status code `403`. Applicable to 1 of 486 methods.*
* [`ExchangeSessionTokenSessionResponseResponseBody`](./src/models/errors/exchangesessiontokensessionresponseresponsebody.ts): Active organization or team is missing or inaccessible. Status code `403`. Applicable to 1 of 486 methods.*
* [`ListOrgMembersAuthOrgsResponseResponseBody`](./src/models/errors/listorgmembersauthorgsresponseresponsebody.ts): Forbidden. Status code `403`. Applicable to 1 of 486 methods.*
* [`InviteOrgMemberAuthOrgsResponseResponseBody`](./src/models/errors/inviteorgmemberauthorgsresponseresponsebody.ts): Forbidden. Status code `403`. Applicable to 1 of 486 methods.*
* [`UpdateOrgMemberAuthOrgsResponseResponseBody`](./src/models/errors/updateorgmemberauthorgsresponseresponsebody.ts): Forbidden. Status code `403`. Applicable to 1 of 486 methods.*
* [`RemoveOrgMemberAuthOrgsResponseResponseBody`](./src/models/errors/removeorgmemberauthorgsresponseresponsebody.ts): Forbidden. Status code `403`. Applicable to 1 of 486 methods.*
* [`GetSsoPolicyAuthOrgsResponseResponseBody`](./src/models/errors/getssopolicyauthorgsresponseresponsebody.ts): Forbidden. Status code `403`. Applicable to 1 of 486 methods.*
* [`UpdateSsoPolicyAuthOrgsResponseResponseBody`](./src/models/errors/updatessopolicyauthorgsresponseresponsebody.ts): Forbidden. Status code `403`. Applicable to 1 of 486 methods.*
* [`GetOrgByIdAuthOrgsResponseResponseBody`](./src/models/errors/getorgbyidauthorgsresponseresponsebody.ts): Forbidden. Status code `403`. Applicable to 1 of 486 methods.*
* [`UpdateOrganizationAuthOrgsResponseResponseBody`](./src/models/errors/updateorganizationauthorgsresponseresponsebody.ts): Forbidden. Status code `403`. Applicable to 1 of 486 methods.*
* [`GetOrgQuotaAuthOrgsResponseResponseBody`](./src/models/errors/getorgquotaauthorgsresponseresponsebody.ts): Forbidden. Status code `403`. Applicable to 1 of 486 methods.*
* [`UpdateOrgQuotaAuthOrgsResponseResponseBody`](./src/models/errors/updateorgquotaauthorgsresponseresponsebody.ts): Forbidden. Status code `403`. Applicable to 1 of 486 methods.*
* [`GetOrgRateLimitAuthOrgsResponseResponseBody`](./src/models/errors/getorgratelimitauthorgsresponseresponsebody.ts): Forbidden. Status code `403`. Applicable to 1 of 486 methods.*
* [`UpdateOrgRateLimitAuthOrgsResponseResponseBody`](./src/models/errors/updateorgratelimitauthorgsresponseresponsebody.ts): Forbidden. Status code `403`. Applicable to 1 of 486 methods.*
* [`GetNetworkPolicyAccessAuthTeamsResponseResponseBody`](./src/models/errors/getnetworkpolicyaccessauthteamsresponseresponsebody.ts): Forbidden. Status code `403`. Applicable to 1 of 486 methods.*
* [`CreateTeamAuthTeamsResponseResponseBody`](./src/models/errors/createteamauthteamsresponseresponsebody.ts): Forbidden. Status code `403`. Applicable to 1 of 486 methods.*
* [`ListTeamsAuthTeamsResponseResponseBody`](./src/models/errors/listteamsauthteamsresponseresponsebody.ts): Forbidden. Status code `403`. Applicable to 1 of 486 methods.*
* [`GetTeamAuthTeamsResponseResponseBody`](./src/models/errors/getteamauthteamsresponseresponsebody.ts): Forbidden. Status code `403`. Applicable to 1 of 486 methods.*
* [`UpdateTeamAuthTeamsResponseResponseBody`](./src/models/errors/updateteamauthteamsresponseresponsebody.ts): Forbidden. Status code `403`. Applicable to 1 of 486 methods.*
* [`DeleteTeamAuthTeamsResponseResponseBody`](./src/models/errors/deleteteamauthteamsresponseresponsebody.ts): Forbidden. Status code `403`. Applicable to 1 of 486 methods.*
* [`AddTeamMemberAuthTeamsResponseResponseBody`](./src/models/errors/addteammemberauthteamsresponseresponsebody.ts): Forbidden. Status code `403`. Applicable to 1 of 486 methods.*
* [`ListTeamMembersAuthTeamsResponseResponseBody`](./src/models/errors/listteammembersauthteamsresponseresponsebody.ts): Forbidden. Status code `403`. Applicable to 1 of 486 methods.*
* [`UpdateTeamMemberAuthTeamsResponseResponseBody`](./src/models/errors/updateteammemberauthteamsresponseresponsebody.ts): Forbidden. Status code `403`. Applicable to 1 of 486 methods.*
* [`RemoveTeamMemberAuthTeamsResponseResponseBody`](./src/models/errors/removeteammemberauthteamsresponseresponsebody.ts): Forbidden. Status code `403`. Applicable to 1 of 486 methods.*
* [`CreateScopedApiKeyAuthApiKeysResponseResponseBody`](./src/models/errors/createscopedapikeyauthapikeysresponseresponsebody.ts): Forbidden. Status code `403`. Applicable to 1 of 486 methods.*
* [`ListScopedApiKeysAuthApiKeysResponseResponseBody`](./src/models/errors/listscopedapikeysauthapikeysresponseresponsebody.ts): Forbidden. Status code `403`. Applicable to 1 of 486 methods.*
* [`UpdateScopedApiKeyAuthApiKeysResponseResponseBody`](./src/models/errors/updatescopedapikeyauthapikeysresponseresponsebody.ts): Forbidden. Status code `403`. Applicable to 1 of 486 methods.*
* [`RegenerateScopedApiKeyAuthApiKeysResponseResponseBody`](./src/models/errors/regeneratescopedapikeyauthapikeysresponseresponsebody.ts): Forbidden. Status code `403`. Applicable to 1 of 486 methods.*
* [`ExchangeApiKeyTokenAuthApiKeysResponseResponseBody`](./src/models/errors/exchangeapikeytokenauthapikeysresponseresponsebody.ts): Forbidden. Status code `403`. Applicable to 1 of 486 methods.*
* [`CreateServiceAccountAuthServiceAccountsResponseResponseBody`](./src/models/errors/createserviceaccountauthserviceaccountsresponseresponsebody.ts): Forbidden. Status code `403`. Applicable to 1 of 486 methods.*
* [`ListServiceAccountsAuthServiceAccountsResponseResponseBody`](./src/models/errors/listserviceaccountsauthserviceaccountsresponseresponsebody.ts): Forbidden. Status code `403`. Applicable to 1 of 486 methods.*
* [`GetServiceAccountAuthServiceAccountsResponseResponseBody`](./src/models/errors/getserviceaccountauthserviceaccountsresponseresponsebody.ts): Forbidden. Status code `403`. Applicable to 1 of 486 methods.*
* [`DeleteServiceAccountAuthServiceAccountsResponseResponseBody`](./src/models/errors/deleteserviceaccountauthserviceaccountsresponseresponsebody.ts): Forbidden. Status code `403`. Applicable to 1 of 486 methods.*
* [`ListServiceAccountApiKeysAuthServiceAccountsResponseResponseBody`](./src/models/errors/listserviceaccountapikeysauthserviceaccountsresponseresponsebody.ts): Forbidden. Status code `403`. Applicable to 1 of 486 methods.*
* [`UpdateServiceAccountApiKeyAuthServiceAccountsResponseResponseBody`](./src/models/errors/updateserviceaccountapikeyauthserviceaccountsresponseresponsebody.ts): Forbidden. Status code `403`. Applicable to 1 of 486 methods.*
* [`DeleteServiceAccountApiKeyAuthServiceAccountsResponseResponseBody`](./src/models/errors/deleteserviceaccountapikeyauthserviceaccountsresponseresponsebody.ts): Forbidden. Status code `403`. Applicable to 1 of 486 methods.*
* [`RegenerateServiceAccountApiKeyAuthServiceAccountsResponseResponseBody`](./src/models/errors/regenerateserviceaccountapikeyauthserviceaccountsresponseresponsebody.ts): Forbidden. Status code `403`. Applicable to 1 of 486 methods.*
* [`CreateClusterInviteAuthClusterResponseResponseBody`](./src/models/errors/createclusterinviteauthclusterresponseresponsebody.ts): Forbidden. Status code `403`. Applicable to 1 of 486 methods.*
* [`ListClusterInvitesAuthClusterResponseResponseBody`](./src/models/errors/listclusterinvitesauthclusterresponseresponsebody.ts): Forbidden. Status code `403`. Applicable to 1 of 486 methods.*
* [`UpdateClusterInviteAuthClusterResponseResponseBody`](./src/models/errors/updateclusterinviteauthclusterresponseresponsebody.ts): Forbidden. Status code `403`. Applicable to 1 of 486 methods.*
* [`RevokeClusterInviteAuthClusterResponseResponseBody`](./src/models/errors/revokeclusterinviteauthclusterresponseresponsebody.ts): Forbidden. Status code `403`. Applicable to 1 of 486 methods.*
* [`ListClusterOrgsAuthClusterResponseResponseBody`](./src/models/errors/listclusterorgsauthclusterresponseresponsebody.ts): Forbidden. Status code `403`. Applicable to 1 of 486 methods.*
* [`GetClusterOrgAuthClusterResponseResponseBody`](./src/models/errors/getclusterorgauthclusterresponseresponsebody.ts): Forbidden. Status code `403`. Applicable to 1 of 486 methods.*
* [`DeleteClusterOrgAuthClusterResponseResponseBody`](./src/models/errors/deleteclusterorgauthclusterresponseresponsebody.ts): Forbidden. Status code `403`. Applicable to 1 of 486 methods.*
* [`InviteClusterOrgMembersAuthClusterResponseResponseBody`](./src/models/errors/inviteclusterorgmembersauthclusterresponseresponsebody.ts): Forbidden. Status code `403`. Applicable to 1 of 486 methods.*
* [`SuspendClusterOrgAuthClusterResponseResponseBody`](./src/models/errors/suspendclusterorgauthclusterresponseresponsebody.ts): Forbidden. Status code `403`. Applicable to 1 of 486 methods.*
* [`UnsuspendClusterOrgAuthClusterResponseResponseBody`](./src/models/errors/unsuspendclusterorgauthclusterresponseresponsebody.ts): Forbidden. Status code `403`. Applicable to 1 of 486 methods.*
* [`ReissueOwnerKeyAuthClusterResponseResponseBody`](./src/models/errors/reissueownerkeyauthclusterresponseresponsebody.ts): Forbidden. Status code `403`. Applicable to 1 of 486 methods.*
* [`GetClusterInviteInfoAuthClusterResponseResponseBody`](./src/models/errors/getclusterinviteinfoauthclusterresponseresponsebody.ts): Forbidden. Status code `403`. Applicable to 1 of 486 methods.*
* [`AcceptClusterInviteAuthClusterResponseResponseBody`](./src/models/errors/acceptclusterinviteauthclusterresponseresponsebody.ts): Forbidden. Status code `403`. Applicable to 1 of 486 methods.*
* [`GetFileContentLlmFilesResponseResponseBody`](./src/models/errors/getfilecontentllmfilesresponseresponsebody.ts): File not found. Status code `404`. Applicable to 1 of 486 methods.*
* [`ListOrgMembersAuthOrgsResponse404ResponseBody`](./src/models/errors/listorgmembersauthorgsresponse404responsebody.ts): Not found. Status code `404`. Applicable to 1 of 486 methods.*
* [`InviteOrgMemberAuthOrgsResponse404ResponseBody`](./src/models/errors/inviteorgmemberauthorgsresponse404responsebody.ts): Not found. Status code `404`. Applicable to 1 of 486 methods.*
* [`UpdateOrgMemberAuthOrgsResponse404ResponseBody`](./src/models/errors/updateorgmemberauthorgsresponse404responsebody.ts): Not found. Status code `404`. Applicable to 1 of 486 methods.*
* [`RemoveOrgMemberAuthOrgsResponse404ResponseBody`](./src/models/errors/removeorgmemberauthorgsresponse404responsebody.ts): Not found. Status code `404`. Applicable to 1 of 486 methods.*
* [`GetSsoPolicyAuthOrgsResponse404ResponseBody`](./src/models/errors/getssopolicyauthorgsresponse404responsebody.ts): Not found. Status code `404`. Applicable to 1 of 486 methods.*
* [`UpdateSsoPolicyAuthOrgsResponse404ResponseBody`](./src/models/errors/updatessopolicyauthorgsresponse404responsebody.ts): Not found. Status code `404`. Applicable to 1 of 486 methods.*
* [`GetOrgByIdAuthOrgsResponse404ResponseBody`](./src/models/errors/getorgbyidauthorgsresponse404responsebody.ts): Not found. Status code `404`. Applicable to 1 of 486 methods.*
* [`UpdateOrganizationAuthOrgsResponse404ResponseBody`](./src/models/errors/updateorganizationauthorgsresponse404responsebody.ts): Not found. Status code `404`. Applicable to 1 of 486 methods.*
* [`GetOrgQuotaAuthOrgsResponse404ResponseBody`](./src/models/errors/getorgquotaauthorgsresponse404responsebody.ts): Not found. Status code `404`. Applicable to 1 of 486 methods.*
* [`UpdateOrgQuotaAuthOrgsResponse404ResponseBody`](./src/models/errors/updateorgquotaauthorgsresponse404responsebody.ts): Not found. Status code `404`. Applicable to 1 of 486 methods.*
* [`GetOrgRateLimitAuthOrgsResponse404ResponseBody`](./src/models/errors/getorgratelimitauthorgsresponse404responsebody.ts): Not found. Status code `404`. Applicable to 1 of 486 methods.*
* [`UpdateOrgRateLimitAuthOrgsResponse404ResponseBody`](./src/models/errors/updateorgratelimitauthorgsresponse404responsebody.ts): Not found. Status code `404`. Applicable to 1 of 486 methods.*
* [`GetNetworkPolicyAccessAuthTeamsResponse404ResponseBody`](./src/models/errors/getnetworkpolicyaccessauthteamsresponse404responsebody.ts): Not found. Status code `404`. Applicable to 1 of 486 methods.*
* [`CreateTeamAuthTeamsResponse404ResponseBody`](./src/models/errors/createteamauthteamsresponse404responsebody.ts): Not found. Status code `404`. Applicable to 1 of 486 methods.*
* [`ListTeamsAuthTeamsResponse404ResponseBody`](./src/models/errors/listteamsauthteamsresponse404responsebody.ts): Not found. Status code `404`. Applicable to 1 of 486 methods.*
* [`GetTeamAuthTeamsResponse404ResponseBody`](./src/models/errors/getteamauthteamsresponse404responsebody.ts): Not found. Status code `404`. Applicable to 1 of 486 methods.*
* [`UpdateTeamAuthTeamsResponse404ResponseBody`](./src/models/errors/updateteamauthteamsresponse404responsebody.ts): Not found. Status code `404`. Applicable to 1 of 486 methods.*
* [`DeleteTeamAuthTeamsResponse404ResponseBody`](./src/models/errors/deleteteamauthteamsresponse404responsebody.ts): Not found. Status code `404`. Applicable to 1 of 486 methods.*
* [`AddTeamMemberAuthTeamsResponse404ResponseBody`](./src/models/errors/addteammemberauthteamsresponse404responsebody.ts): Not found. Status code `404`. Applicable to 1 of 486 methods.*
* [`ListTeamMembersAuthTeamsResponse404ResponseBody`](./src/models/errors/listteammembersauthteamsresponse404responsebody.ts): Not found. Status code `404`. Applicable to 1 of 486 methods.*
* [`UpdateTeamMemberAuthTeamsResponse404ResponseBody`](./src/models/errors/updateteammemberauthteamsresponse404responsebody.ts): Not found. Status code `404`. Applicable to 1 of 486 methods.*
* [`RemoveTeamMemberAuthTeamsResponse404ResponseBody`](./src/models/errors/removeteammemberauthteamsresponse404responsebody.ts): Not found. Status code `404`. Applicable to 1 of 486 methods.*
* [`CreateScopedApiKeyAuthApiKeysResponse404ResponseBody`](./src/models/errors/createscopedapikeyauthapikeysresponse404responsebody.ts): Not found. Status code `404`. Applicable to 1 of 486 methods.*
* [`ListScopedApiKeysAuthApiKeysResponse404ResponseBody`](./src/models/errors/listscopedapikeysauthapikeysresponse404responsebody.ts): Not found. Status code `404`. Applicable to 1 of 486 methods.*
* [`UpdateScopedApiKeyAuthApiKeysResponse404ResponseBody`](./src/models/errors/updatescopedapikeyauthapikeysresponse404responsebody.ts): Not found. Status code `404`. Applicable to 1 of 486 methods.*
* [`RegenerateScopedApiKeyAuthApiKeysResponse404ResponseBody`](./src/models/errors/regeneratescopedapikeyauthapikeysresponse404responsebody.ts): Not found. Status code `404`. Applicable to 1 of 486 methods.*
* [`ExchangeApiKeyTokenAuthApiKeysResponse404ResponseBody`](./src/models/errors/exchangeapikeytokenauthapikeysresponse404responsebody.ts): Not found. Status code `404`. Applicable to 1 of 486 methods.*
* [`CreateServiceAccountAuthServiceAccountsResponse404ResponseBody`](./src/models/errors/createserviceaccountauthserviceaccountsresponse404responsebody.ts): Not found. Status code `404`. Applicable to 1 of 486 methods.*
* [`ListServiceAccountsAuthServiceAccountsResponse404ResponseBody`](./src/models/errors/listserviceaccountsauthserviceaccountsresponse404responsebody.ts): Not found. Status code `404`. Applicable to 1 of 486 methods.*
* [`GetServiceAccountAuthServiceAccountsResponse404ResponseBody`](./src/models/errors/getserviceaccountauthserviceaccountsresponse404responsebody.ts): Not found. Status code `404`. Applicable to 1 of 486 methods.*
* [`DeleteServiceAccountAuthServiceAccountsResponse404ResponseBody`](./src/models/errors/deleteserviceaccountauthserviceaccountsresponse404responsebody.ts): Not found. Status code `404`. Applicable to 1 of 486 methods.*
* [`ListServiceAccountApiKeysAuthServiceAccountsResponse404ResponseBody`](./src/models/errors/listserviceaccountapikeysauthserviceaccountsresponse404responsebody.ts): Not found. Status code `404`. Applicable to 1 of 486 methods.*
* [`UpdateServiceAccountApiKeyAuthServiceAccountsResponse404ResponseBody`](./src/models/errors/updateserviceaccountapikeyauthserviceaccountsresponse404responsebody.ts): Not found. Status code `404`. Applicable to 1 of 486 methods.*
* [`DeleteServiceAccountApiKeyAuthServiceAccountsResponse404ResponseBody`](./src/models/errors/deleteserviceaccountapikeyauthserviceaccountsresponse404responsebody.ts): Not found. Status code `404`. Applicable to 1 of 486 methods.*
* [`RegenerateServiceAccountApiKeyAuthServiceAccountsResponse404ResponseBody`](./src/models/errors/regenerateserviceaccountapikeyauthserviceaccountsresponse404responsebody.ts): Not found. Status code `404`. Applicable to 1 of 486 methods.*
* [`CreateClusterInviteAuthClusterResponse404ResponseBody`](./src/models/errors/createclusterinviteauthclusterresponse404responsebody.ts): Not found. Status code `404`. Applicable to 1 of 486 methods.*
* [`ListClusterInvitesAuthClusterResponse404ResponseBody`](./src/models/errors/listclusterinvitesauthclusterresponse404responsebody.ts): Not found. Status code `404`. Applicable to 1 of 486 methods.*
* [`UpdateClusterInviteAuthClusterResponse404ResponseBody`](./src/models/errors/updateclusterinviteauthclusterresponse404responsebody.ts): Not found. Status code `404`. Applicable to 1 of 486 methods.*
* [`RevokeClusterInviteAuthClusterResponse404ResponseBody`](./src/models/errors/revokeclusterinviteauthclusterresponse404responsebody.ts): Not found. Status code `404`. Applicable to 1 of 486 methods.*
* [`ListClusterOrgsAuthClusterResponse404ResponseBody`](./src/models/errors/listclusterorgsauthclusterresponse404responsebody.ts): Not found. Status code `404`. Applicable to 1 of 486 methods.*
* [`GetClusterOrgAuthClusterResponse404ResponseBody`](./src/models/errors/getclusterorgauthclusterresponse404responsebody.ts): Not found. Status code `404`. Applicable to 1 of 486 methods.*
* [`DeleteClusterOrgAuthClusterResponse404ResponseBody`](./src/models/errors/deleteclusterorgauthclusterresponse404responsebody.ts): Not found. Status code `404`. Applicable to 1 of 486 methods.*
* [`InviteClusterOrgMembersAuthClusterResponse404ResponseBody`](./src/models/errors/inviteclusterorgmembersauthclusterresponse404responsebody.ts): Not found. Status code `404`. Applicable to 1 of 486 methods.*
* [`SuspendClusterOrgAuthClusterResponse404ResponseBody`](./src/models/errors/suspendclusterorgauthclusterresponse404responsebody.ts): Not found. Status code `404`. Applicable to 1 of 486 methods.*
* [`UnsuspendClusterOrgAuthClusterResponse404ResponseBody`](./src/models/errors/unsuspendclusterorgauthclusterresponse404responsebody.ts): Not found. Status code `404`. Applicable to 1 of 486 methods.*
* [`ReissueOwnerKeyAuthClusterResponse404ResponseBody`](./src/models/errors/reissueownerkeyauthclusterresponse404responsebody.ts): Not found. Status code `404`. Applicable to 1 of 486 methods.*
* [`GetClusterInviteInfoAuthClusterResponse404ResponseBody`](./src/models/errors/getclusterinviteinfoauthclusterresponse404responsebody.ts): Not found. Status code `404`. Applicable to 1 of 486 methods.*
* [`AcceptClusterInviteAuthClusterResponse404ResponseBody`](./src/models/errors/acceptclusterinviteauthclusterresponse404responsebody.ts): Not found. Status code `404`. Applicable to 1 of 486 methods.*
* [`ListOrgMembersAuthOrgsResponse409ResponseBody`](./src/models/errors/listorgmembersauthorgsresponse409responsebody.ts): Conflict. Status code `409`. Applicable to 1 of 486 methods.*
* [`InviteOrgMemberAuthOrgsResponse409ResponseBody`](./src/models/errors/inviteorgmemberauthorgsresponse409responsebody.ts): Conflict. Status code `409`. Applicable to 1 of 486 methods.*
* [`UpdateOrgMemberAuthOrgsResponse409ResponseBody`](./src/models/errors/updateorgmemberauthorgsresponse409responsebody.ts): Conflict. Status code `409`. Applicable to 1 of 486 methods.*
* [`RemoveOrgMemberAuthOrgsResponse409ResponseBody`](./src/models/errors/removeorgmemberauthorgsresponse409responsebody.ts): Conflict. Status code `409`. Applicable to 1 of 486 methods.*
* [`GetSsoPolicyAuthOrgsResponse409ResponseBody`](./src/models/errors/getssopolicyauthorgsresponse409responsebody.ts): Conflict. Status code `409`. Applicable to 1 of 486 methods.*
* [`UpdateSsoPolicyAuthOrgsResponse409ResponseBody`](./src/models/errors/updatessopolicyauthorgsresponse409responsebody.ts): Conflict. Status code `409`. Applicable to 1 of 486 methods.*
* [`GetOrgByIdAuthOrgsResponse409ResponseBody`](./src/models/errors/getorgbyidauthorgsresponse409responsebody.ts): Conflict. Status code `409`. Applicable to 1 of 486 methods.*
* [`UpdateOrganizationAuthOrgsResponse409ResponseBody`](./src/models/errors/updateorganizationauthorgsresponse409responsebody.ts): Conflict. Status code `409`. Applicable to 1 of 486 methods.*
* [`GetOrgQuotaAuthOrgsResponse409ResponseBody`](./src/models/errors/getorgquotaauthorgsresponse409responsebody.ts): Conflict. Status code `409`. Applicable to 1 of 486 methods.*
* [`UpdateOrgQuotaAuthOrgsResponse409ResponseBody`](./src/models/errors/updateorgquotaauthorgsresponse409responsebody.ts): Conflict. Status code `409`. Applicable to 1 of 486 methods.*
* [`GetOrgRateLimitAuthOrgsResponse409ResponseBody`](./src/models/errors/getorgratelimitauthorgsresponse409responsebody.ts): Conflict. Status code `409`. Applicable to 1 of 486 methods.*
* [`UpdateOrgRateLimitAuthOrgsResponse409ResponseBody`](./src/models/errors/updateorgratelimitauthorgsresponse409responsebody.ts): Conflict. Status code `409`. Applicable to 1 of 486 methods.*
* [`GetNetworkPolicyAccessAuthTeamsResponse409ResponseBody`](./src/models/errors/getnetworkpolicyaccessauthteamsresponse409responsebody.ts): Conflict. Status code `409`. Applicable to 1 of 486 methods.*
* [`CreateTeamAuthTeamsResponse409ResponseBody`](./src/models/errors/createteamauthteamsresponse409responsebody.ts): Conflict. Status code `409`. Applicable to 1 of 486 methods.*
* [`ListTeamsAuthTeamsResponse409ResponseBody`](./src/models/errors/listteamsauthteamsresponse409responsebody.ts): Conflict. Status code `409`. Applicable to 1 of 486 methods.*
* [`GetTeamAuthTeamsResponse409ResponseBody`](./src/models/errors/getteamauthteamsresponse409responsebody.ts): Conflict. Status code `409`. Applicable to 1 of 486 methods.*
* [`UpdateTeamAuthTeamsResponse409ResponseBody`](./src/models/errors/updateteamauthteamsresponse409responsebody.ts): Conflict. Status code `409`. Applicable to 1 of 486 methods.*
* [`DeleteTeamAuthTeamsResponse409ResponseBody`](./src/models/errors/deleteteamauthteamsresponse409responsebody.ts): Conflict. Status code `409`. Applicable to 1 of 486 methods.*
* [`AddTeamMemberAuthTeamsResponse409ResponseBody`](./src/models/errors/addteammemberauthteamsresponse409responsebody.ts): Conflict. Status code `409`. Applicable to 1 of 486 methods.*
* [`ListTeamMembersAuthTeamsResponse409ResponseBody`](./src/models/errors/listteammembersauthteamsresponse409responsebody.ts): Conflict. Status code `409`. Applicable to 1 of 486 methods.*
* [`UpdateTeamMemberAuthTeamsResponse409ResponseBody`](./src/models/errors/updateteammemberauthteamsresponse409responsebody.ts): Conflict. Status code `409`. Applicable to 1 of 486 methods.*
* [`RemoveTeamMemberAuthTeamsResponse409ResponseBody`](./src/models/errors/removeteammemberauthteamsresponse409responsebody.ts): Conflict. Status code `409`. Applicable to 1 of 486 methods.*
* [`CreateScopedApiKeyAuthApiKeysResponse409ResponseBody`](./src/models/errors/createscopedapikeyauthapikeysresponse409responsebody.ts): Conflict. Status code `409`. Applicable to 1 of 486 methods.*
* [`ListScopedApiKeysAuthApiKeysResponse409ResponseBody`](./src/models/errors/listscopedapikeysauthapikeysresponse409responsebody.ts): Conflict. Status code `409`. Applicable to 1 of 486 methods.*
* [`UpdateScopedApiKeyAuthApiKeysResponse409ResponseBody`](./src/models/errors/updatescopedapikeyauthapikeysresponse409responsebody.ts): Conflict. Status code `409`. Applicable to 1 of 486 methods.*
* [`RegenerateScopedApiKeyAuthApiKeysResponse409ResponseBody`](./src/models/errors/regeneratescopedapikeyauthapikeysresponse409responsebody.ts): Conflict. Status code `409`. Applicable to 1 of 486 methods.*
* [`ExchangeApiKeyTokenAuthApiKeysResponse409ResponseBody`](./src/models/errors/exchangeapikeytokenauthapikeysresponse409responsebody.ts): Conflict. Status code `409`. Applicable to 1 of 486 methods.*
* [`CreateServiceAccountAuthServiceAccountsResponse409ResponseBody`](./src/models/errors/createserviceaccountauthserviceaccountsresponse409responsebody.ts): Conflict. Status code `409`. Applicable to 1 of 486 methods.*
* [`ListServiceAccountsAuthServiceAccountsResponse409ResponseBody`](./src/models/errors/listserviceaccountsauthserviceaccountsresponse409responsebody.ts): Conflict. Status code `409`. Applicable to 1 of 486 methods.*
* [`GetServiceAccountAuthServiceAccountsResponse409ResponseBody`](./src/models/errors/getserviceaccountauthserviceaccountsresponse409responsebody.ts): Conflict. Status code `409`. Applicable to 1 of 486 methods.*
* [`DeleteServiceAccountAuthServiceAccountsResponse409ResponseBody`](./src/models/errors/deleteserviceaccountauthserviceaccountsresponse409responsebody.ts): Conflict. Status code `409`. Applicable to 1 of 486 methods.*
* [`ListServiceAccountApiKeysAuthServiceAccountsResponse409ResponseBody`](./src/models/errors/listserviceaccountapikeysauthserviceaccountsresponse409responsebody.ts): Conflict. Status code `409`. Applicable to 1 of 486 methods.*
* [`UpdateServiceAccountApiKeyAuthServiceAccountsResponse409ResponseBody`](./src/models/errors/updateserviceaccountapikeyauthserviceaccountsresponse409responsebody.ts): Conflict. Status code `409`. Applicable to 1 of 486 methods.*
* [`DeleteServiceAccountApiKeyAuthServiceAccountsResponse409ResponseBody`](./src/models/errors/deleteserviceaccountapikeyauthserviceaccountsresponse409responsebody.ts): Conflict. Status code `409`. Applicable to 1 of 486 methods.*
* [`RegenerateServiceAccountApiKeyAuthServiceAccountsResponse409ResponseBody`](./src/models/errors/regenerateserviceaccountapikeyauthserviceaccountsresponse409responsebody.ts): Conflict. Status code `409`. Applicable to 1 of 486 methods.*
* [`CreateClusterInviteAuthClusterResponse409ResponseBody`](./src/models/errors/createclusterinviteauthclusterresponse409responsebody.ts): Conflict. Status code `409`. Applicable to 1 of 486 methods.*
* [`ListClusterInvitesAuthClusterResponse409ResponseBody`](./src/models/errors/listclusterinvitesauthclusterresponse409responsebody.ts): Conflict. Status code `409`. Applicable to 1 of 486 methods.*
* [`UpdateClusterInviteAuthClusterResponse409ResponseBody`](./src/models/errors/updateclusterinviteauthclusterresponse409responsebody.ts): Conflict. Status code `409`. Applicable to 1 of 486 methods.*
* [`RevokeClusterInviteAuthClusterResponse409ResponseBody`](./src/models/errors/revokeclusterinviteauthclusterresponse409responsebody.ts): Conflict. Status code `409`. Applicable to 1 of 486 methods.*
* [`ListClusterOrgsAuthClusterResponse409ResponseBody`](./src/models/errors/listclusterorgsauthclusterresponse409responsebody.ts): Conflict. Status code `409`. Applicable to 1 of 486 methods.*
* [`GetClusterOrgAuthClusterResponse409ResponseBody`](./src/models/errors/getclusterorgauthclusterresponse409responsebody.ts): Conflict. Status code `409`. Applicable to 1 of 486 methods.*
* [`DeleteClusterOrgAuthClusterResponse409ResponseBody`](./src/models/errors/deleteclusterorgauthclusterresponse409responsebody.ts): Conflict. Status code `409`. Applicable to 1 of 486 methods.*
* [`InviteClusterOrgMembersAuthClusterResponse409ResponseBody`](./src/models/errors/inviteclusterorgmembersauthclusterresponse409responsebody.ts): Conflict. Status code `409`. Applicable to 1 of 486 methods.*
* [`SuspendClusterOrgAuthClusterResponse409ResponseBody`](./src/models/errors/suspendclusterorgauthclusterresponse409responsebody.ts): Conflict. Status code `409`. Applicable to 1 of 486 methods.*
* [`UnsuspendClusterOrgAuthClusterResponse409ResponseBody`](./src/models/errors/unsuspendclusterorgauthclusterresponse409responsebody.ts): Conflict. Status code `409`. Applicable to 1 of 486 methods.*
* [`ReissueOwnerKeyAuthClusterResponse409ResponseBody`](./src/models/errors/reissueownerkeyauthclusterresponse409responsebody.ts): Conflict. Status code `409`. Applicable to 1 of 486 methods.*
* [`GetClusterInviteInfoAuthClusterResponse409ResponseBody`](./src/models/errors/getclusterinviteinfoauthclusterresponse409responsebody.ts): Conflict. Status code `409`. Applicable to 1 of 486 methods.*
* [`AcceptClusterInviteAuthClusterResponse409ResponseBody`](./src/models/errors/acceptclusterinviteauthclusterresponse409responsebody.ts): Conflict. Status code `409`. Applicable to 1 of 486 methods.*
* [`ListOrgMembersAuthOrgsResponse410ResponseBody`](./src/models/errors/listorgmembersauthorgsresponse410responsebody.ts): Gone. Status code `410`. Applicable to 1 of 486 methods.*
* [`InviteOrgMemberAuthOrgsResponse410ResponseBody`](./src/models/errors/inviteorgmemberauthorgsresponse410responsebody.ts): Gone. Status code `410`. Applicable to 1 of 486 methods.*
* [`UpdateOrgMemberAuthOrgsResponse410ResponseBody`](./src/models/errors/updateorgmemberauthorgsresponse410responsebody.ts): Gone. Status code `410`. Applicable to 1 of 486 methods.*
* [`RemoveOrgMemberAuthOrgsResponse410ResponseBody`](./src/models/errors/removeorgmemberauthorgsresponse410responsebody.ts): Gone. Status code `410`. Applicable to 1 of 486 methods.*
* [`GetSsoPolicyAuthOrgsResponse410ResponseBody`](./src/models/errors/getssopolicyauthorgsresponse410responsebody.ts): Gone. Status code `410`. Applicable to 1 of 486 methods.*
* [`UpdateSsoPolicyAuthOrgsResponse410ResponseBody`](./src/models/errors/updatessopolicyauthorgsresponse410responsebody.ts): Gone. Status code `410`. Applicable to 1 of 486 methods.*
* [`GetOrgByIdAuthOrgsResponse410ResponseBody`](./src/models/errors/getorgbyidauthorgsresponse410responsebody.ts): Gone. Status code `410`. Applicable to 1 of 486 methods.*
* [`UpdateOrganizationAuthOrgsResponse410ResponseBody`](./src/models/errors/updateorganizationauthorgsresponse410responsebody.ts): Gone. Status code `410`. Applicable to 1 of 486 methods.*
* [`GetOrgQuotaAuthOrgsResponse410ResponseBody`](./src/models/errors/getorgquotaauthorgsresponse410responsebody.ts): Gone. Status code `410`. Applicable to 1 of 486 methods.*
* [`UpdateOrgQuotaAuthOrgsResponse410ResponseBody`](./src/models/errors/updateorgquotaauthorgsresponse410responsebody.ts): Gone. Status code `410`. Applicable to 1 of 486 methods.*
* [`GetOrgRateLimitAuthOrgsResponse410ResponseBody`](./src/models/errors/getorgratelimitauthorgsresponse410responsebody.ts): Gone. Status code `410`. Applicable to 1 of 486 methods.*
* [`UpdateOrgRateLimitAuthOrgsResponse410ResponseBody`](./src/models/errors/updateorgratelimitauthorgsresponse410responsebody.ts): Gone. Status code `410`. Applicable to 1 of 486 methods.*
* [`GetNetworkPolicyAccessAuthTeamsResponse410ResponseBody`](./src/models/errors/getnetworkpolicyaccessauthteamsresponse410responsebody.ts): Gone. Status code `410`. Applicable to 1 of 486 methods.*
* [`CreateTeamAuthTeamsResponse410ResponseBody`](./src/models/errors/createteamauthteamsresponse410responsebody.ts): Gone. Status code `410`. Applicable to 1 of 486 methods.*
* [`ListTeamsAuthTeamsResponse410ResponseBody`](./src/models/errors/listteamsauthteamsresponse410responsebody.ts): Gone. Status code `410`. Applicable to 1 of 486 methods.*
* [`GetTeamAuthTeamsResponse410ResponseBody`](./src/models/errors/getteamauthteamsresponse410responsebody.ts): Gone. Status code `410`. Applicable to 1 of 486 methods.*
* [`UpdateTeamAuthTeamsResponse410ResponseBody`](./src/models/errors/updateteamauthteamsresponse410responsebody.ts): Gone. Status code `410`. Applicable to 1 of 486 methods.*
* [`DeleteTeamAuthTeamsResponse410ResponseBody`](./src/models/errors/deleteteamauthteamsresponse410responsebody.ts): Gone. Status code `410`. Applicable to 1 of 486 methods.*
* [`AddTeamMemberAuthTeamsResponse410ResponseBody`](./src/models/errors/addteammemberauthteamsresponse410responsebody.ts): Gone. Status code `410`. Applicable to 1 of 486 methods.*
* [`ListTeamMembersAuthTeamsResponse410ResponseBody`](./src/models/errors/listteammembersauthteamsresponse410responsebody.ts): Gone. Status code `410`. Applicable to 1 of 486 methods.*
* [`UpdateTeamMemberAuthTeamsResponse410ResponseBody`](./src/models/errors/updateteammemberauthteamsresponse410responsebody.ts): Gone. Status code `410`. Applicable to 1 of 486 methods.*
* [`RemoveTeamMemberAuthTeamsResponse410ResponseBody`](./src/models/errors/removeteammemberauthteamsresponse410responsebody.ts): Gone. Status code `410`. Applicable to 1 of 486 methods.*
* [`CreateScopedApiKeyAuthApiKeysResponse410ResponseBody`](./src/models/errors/createscopedapikeyauthapikeysresponse410responsebody.ts): Gone. Status code `410`. Applicable to 1 of 486 methods.*
* [`ListScopedApiKeysAuthApiKeysResponse410ResponseBody`](./src/models/errors/listscopedapikeysauthapikeysresponse410responsebody.ts): Gone. Status code `410`. Applicable to 1 of 486 methods.*
* [`UpdateScopedApiKeyAuthApiKeysResponse410ResponseBody`](./src/models/errors/updatescopedapikeyauthapikeysresponse410responsebody.ts): Gone. Status code `410`. Applicable to 1 of 486 methods.*
* [`RegenerateScopedApiKeyAuthApiKeysResponse410ResponseBody`](./src/models/errors/regeneratescopedapikeyauthapikeysresponse410responsebody.ts): Gone. Status code `410`. Applicable to 1 of 486 methods.*
* [`ExchangeApiKeyTokenAuthApiKeysResponse410ResponseBody`](./src/models/errors/exchangeapikeytokenauthapikeysresponse410responsebody.ts): Gone. Status code `410`. Applicable to 1 of 486 methods.*
* [`CreateServiceAccountAuthServiceAccountsResponse410ResponseBody`](./src/models/errors/createserviceaccountauthserviceaccountsresponse410responsebody.ts): Gone. Status code `410`. Applicable to 1 of 486 methods.*
* [`ListServiceAccountsAuthServiceAccountsResponse410ResponseBody`](./src/models/errors/listserviceaccountsauthserviceaccountsresponse410responsebody.ts): Gone. Status code `410`. Applicable to 1 of 486 methods.*
* [`GetServiceAccountAuthServiceAccountsResponse410ResponseBody`](./src/models/errors/getserviceaccountauthserviceaccountsresponse410responsebody.ts): Gone. Status code `410`. Applicable to 1 of 486 methods.*
* [`DeleteServiceAccountAuthServiceAccountsResponse410ResponseBody`](./src/models/errors/deleteserviceaccountauthserviceaccountsresponse410responsebody.ts): Gone. Status code `410`. Applicable to 1 of 486 methods.*
* [`ListServiceAccountApiKeysAuthServiceAccountsResponse410ResponseBody`](./src/models/errors/listserviceaccountapikeysauthserviceaccountsresponse410responsebody.ts): Gone. Status code `410`. Applicable to 1 of 486 methods.*
* [`UpdateServiceAccountApiKeyAuthServiceAccountsResponse410ResponseBody`](./src/models/errors/updateserviceaccountapikeyauthserviceaccountsresponse410responsebody.ts): Gone. Status code `410`. Applicable to 1 of 486 methods.*
* [`DeleteServiceAccountApiKeyAuthServiceAccountsResponse410ResponseBody`](./src/models/errors/deleteserviceaccountapikeyauthserviceaccountsresponse410responsebody.ts): Gone. Status code `410`. Applicable to 1 of 486 methods.*
* [`RegenerateServiceAccountApiKeyAuthServiceAccountsResponse410ResponseBody`](./src/models/errors/regenerateserviceaccountapikeyauthserviceaccountsresponse410responsebody.ts): Gone. Status code `410`. Applicable to 1 of 486 methods.*
* [`CreateClusterInviteAuthClusterResponse410ResponseBody`](./src/models/errors/createclusterinviteauthclusterresponse410responsebody.ts): Gone. Status code `410`. Applicable to 1 of 486 methods.*
* [`ListClusterInvitesAuthClusterResponse410ResponseBody`](./src/models/errors/listclusterinvitesauthclusterresponse410responsebody.ts): Gone. Status code `410`. Applicable to 1 of 486 methods.*
* [`UpdateClusterInviteAuthClusterResponse410ResponseBody`](./src/models/errors/updateclusterinviteauthclusterresponse410responsebody.ts): Gone. Status code `410`. Applicable to 1 of 486 methods.*
* [`RevokeClusterInviteAuthClusterResponse410ResponseBody`](./src/models/errors/revokeclusterinviteauthclusterresponse410responsebody.ts): Gone. Status code `410`. Applicable to 1 of 486 methods.*
* [`ListClusterOrgsAuthClusterResponse410ResponseBody`](./src/models/errors/listclusterorgsauthclusterresponse410responsebody.ts): Gone. Status code `410`. Applicable to 1 of 486 methods.*
* [`GetClusterOrgAuthClusterResponse410ResponseBody`](./src/models/errors/getclusterorgauthclusterresponse410responsebody.ts): Gone. Status code `410`. Applicable to 1 of 486 methods.*
* [`DeleteClusterOrgAuthClusterResponse410ResponseBody`](./src/models/errors/deleteclusterorgauthclusterresponse410responsebody.ts): Gone. Status code `410`. Applicable to 1 of 486 methods.*
* [`InviteClusterOrgMembersAuthClusterResponse410ResponseBody`](./src/models/errors/inviteclusterorgmembersauthclusterresponse410responsebody.ts): Gone. Status code `410`. Applicable to 1 of 486 methods.*
* [`SuspendClusterOrgAuthClusterResponse410ResponseBody`](./src/models/errors/suspendclusterorgauthclusterresponse410responsebody.ts): Gone. Status code `410`. Applicable to 1 of 486 methods.*
* [`UnsuspendClusterOrgAuthClusterResponse410ResponseBody`](./src/models/errors/unsuspendclusterorgauthclusterresponse410responsebody.ts): Gone. Status code `410`. Applicable to 1 of 486 methods.*
* [`ReissueOwnerKeyAuthClusterResponse410ResponseBody`](./src/models/errors/reissueownerkeyauthclusterresponse410responsebody.ts): Gone. Status code `410`. Applicable to 1 of 486 methods.*
* [`GetClusterInviteInfoAuthClusterResponse410ResponseBody`](./src/models/errors/getclusterinviteinfoauthclusterresponse410responsebody.ts): Gone. Status code `410`. Applicable to 1 of 486 methods.*
* [`AcceptClusterInviteAuthClusterResponse410ResponseBody`](./src/models/errors/acceptclusterinviteauthclusterresponse410responsebody.ts): Gone. Status code `410`. Applicable to 1 of 486 methods.*
* [`ExchangeSessionTokenSessionResponse413ResponseBody`](./src/models/errors/exchangesessiontokensessionresponse413responsebody.ts): Request body exceeds the endpoint's 4 KiB limit. Status code `413`. Applicable to 1 of 486 methods.*
* [`UpdateOrganizationAuthOrgsResponse413ResponseBody`](./src/models/errors/updateorganizationauthorgsresponse413responsebody.ts): Request or merged metadata exceeds 64 KiB. Status code `413`. Applicable to 1 of 486 methods.*
* [`ExchangeSessionTokenSessionResponse429ResponseBody`](./src/models/errors/exchangesessiontokensessionresponse429responsebody.ts): Per-session or per-user mint rate exceeded. Status code `429`. Applicable to 1 of 486 methods.*
* [`ListOrgMembersAuthOrgsResponse429ResponseBody`](./src/models/errors/listorgmembersauthorgsresponse429responsebody.ts): Rate limited. Status code `429`. Applicable to 1 of 486 methods.*
* [`InviteOrgMemberAuthOrgsResponse429ResponseBody`](./src/models/errors/inviteorgmemberauthorgsresponse429responsebody.ts): Rate limited. Status code `429`. Applicable to 1 of 486 methods.*
* [`UpdateOrgMemberAuthOrgsResponse429ResponseBody`](./src/models/errors/updateorgmemberauthorgsresponse429responsebody.ts): Rate limited. Status code `429`. Applicable to 1 of 486 methods.*
* [`RemoveOrgMemberAuthOrgsResponse429ResponseBody`](./src/models/errors/removeorgmemberauthorgsresponse429responsebody.ts): Rate limited. Status code `429`. Applicable to 1 of 486 methods.*
* [`GetSsoPolicyAuthOrgsResponse429ResponseBody`](./src/models/errors/getssopolicyauthorgsresponse429responsebody.ts): Rate limited. Status code `429`. Applicable to 1 of 486 methods.*
* [`UpdateSsoPolicyAuthOrgsResponse429ResponseBody`](./src/models/errors/updatessopolicyauthorgsresponse429responsebody.ts): Rate limited. Status code `429`. Applicable to 1 of 486 methods.*
* [`GetOrgByIdAuthOrgsResponse429ResponseBody`](./src/models/errors/getorgbyidauthorgsresponse429responsebody.ts): Rate limited. Status code `429`. Applicable to 1 of 486 methods.*
* [`UpdateOrganizationAuthOrgsResponse429ResponseBody`](./src/models/errors/updateorganizationauthorgsresponse429responsebody.ts): Rate limited. Status code `429`. Applicable to 1 of 486 methods.*
* [`GetOrgQuotaAuthOrgsResponse429ResponseBody`](./src/models/errors/getorgquotaauthorgsresponse429responsebody.ts): Rate limited. Status code `429`. Applicable to 1 of 486 methods.*
* [`UpdateOrgQuotaAuthOrgsResponse429ResponseBody`](./src/models/errors/updateorgquotaauthorgsresponse429responsebody.ts): Rate limited. Status code `429`. Applicable to 1 of 486 methods.*
* [`GetOrgRateLimitAuthOrgsResponse429ResponseBody`](./src/models/errors/getorgratelimitauthorgsresponse429responsebody.ts): Rate limited. Status code `429`. Applicable to 1 of 486 methods.*
* [`UpdateOrgRateLimitAuthOrgsResponse429ResponseBody`](./src/models/errors/updateorgratelimitauthorgsresponse429responsebody.ts): Rate limited. Status code `429`. Applicable to 1 of 486 methods.*
* [`GetNetworkPolicyAccessAuthTeamsResponse429ResponseBody`](./src/models/errors/getnetworkpolicyaccessauthteamsresponse429responsebody.ts): Rate limited. Status code `429`. Applicable to 1 of 486 methods.*
* [`CreateTeamAuthTeamsResponse429ResponseBody`](./src/models/errors/createteamauthteamsresponse429responsebody.ts): Rate limited. Status code `429`. Applicable to 1 of 486 methods.*
* [`ListTeamsAuthTeamsResponse429ResponseBody`](./src/models/errors/listteamsauthteamsresponse429responsebody.ts): Rate limited. Status code `429`. Applicable to 1 of 486 methods.*
* [`GetTeamAuthTeamsResponse429ResponseBody`](./src/models/errors/getteamauthteamsresponse429responsebody.ts): Rate limited. Status code `429`. Applicable to 1 of 486 methods.*
* [`UpdateTeamAuthTeamsResponse429ResponseBody`](./src/models/errors/updateteamauthteamsresponse429responsebody.ts): Rate limited. Status code `429`. Applicable to 1 of 486 methods.*
* [`DeleteTeamAuthTeamsResponse429ResponseBody`](./src/models/errors/deleteteamauthteamsresponse429responsebody.ts): Rate limited. Status code `429`. Applicable to 1 of 486 methods.*
* [`AddTeamMemberAuthTeamsResponse429ResponseBody`](./src/models/errors/addteammemberauthteamsresponse429responsebody.ts): Rate limited. Status code `429`. Applicable to 1 of 486 methods.*
* [`ListTeamMembersAuthTeamsResponse429ResponseBody`](./src/models/errors/listteammembersauthteamsresponse429responsebody.ts): Rate limited. Status code `429`. Applicable to 1 of 486 methods.*
* [`UpdateTeamMemberAuthTeamsResponse429ResponseBody`](./src/models/errors/updateteammemberauthteamsresponse429responsebody.ts): Rate limited. Status code `429`. Applicable to 1 of 486 methods.*
* [`RemoveTeamMemberAuthTeamsResponse429ResponseBody`](./src/models/errors/removeteammemberauthteamsresponse429responsebody.ts): Rate limited. Status code `429`. Applicable to 1 of 486 methods.*
* [`CreateScopedApiKeyAuthApiKeysResponse429ResponseBody`](./src/models/errors/createscopedapikeyauthapikeysresponse429responsebody.ts): Rate limited. Status code `429`. Applicable to 1 of 486 methods.*
* [`ListScopedApiKeysAuthApiKeysResponse429ResponseBody`](./src/models/errors/listscopedapikeysauthapikeysresponse429responsebody.ts): Rate limited. Status code `429`. Applicable to 1 of 486 methods.*
* [`UpdateScopedApiKeyAuthApiKeysResponse429ResponseBody`](./src/models/errors/updatescopedapikeyauthapikeysresponse429responsebody.ts): Rate limited. Status code `429`. Applicable to 1 of 486 methods.*
* [`RegenerateScopedApiKeyAuthApiKeysResponse429ResponseBody`](./src/models/errors/regeneratescopedapikeyauthapikeysresponse429responsebody.ts): Rate limited. Status code `429`. Applicable to 1 of 486 methods.*
* [`ExchangeApiKeyTokenAuthApiKeysResponse429ResponseBody`](./src/models/errors/exchangeapikeytokenauthapikeysresponse429responsebody.ts): Rate limited. Status code `429`. Applicable to 1 of 486 methods.*
* [`CreateServiceAccountAuthServiceAccountsResponse429ResponseBody`](./src/models/errors/createserviceaccountauthserviceaccountsresponse429responsebody.ts): Rate limited. Status code `429`. Applicable to 1 of 486 methods.*
* [`ListServiceAccountsAuthServiceAccountsResponse429ResponseBody`](./src/models/errors/listserviceaccountsauthserviceaccountsresponse429responsebody.ts): Rate limited. Status code `429`. Applicable to 1 of 486 methods.*
* [`GetServiceAccountAuthServiceAccountsResponse429ResponseBody`](./src/models/errors/getserviceaccountauthserviceaccountsresponse429responsebody.ts): Rate limited. Status code `429`. Applicable to 1 of 486 methods.*
* [`DeleteServiceAccountAuthServiceAccountsResponse429ResponseBody`](./src/models/errors/deleteserviceaccountauthserviceaccountsresponse429responsebody.ts): Rate limited. Status code `429`. Applicable to 1 of 486 methods.*
* [`ListServiceAccountApiKeysAuthServiceAccountsResponse429ResponseBody`](./src/models/errors/listserviceaccountapikeysauthserviceaccountsresponse429responsebody.ts): Rate limited. Status code `429`. Applicable to 1 of 486 methods.*
* [`UpdateServiceAccountApiKeyAuthServiceAccountsResponse429ResponseBody`](./src/models/errors/updateserviceaccountapikeyauthserviceaccountsresponse429responsebody.ts): Rate limited. Status code `429`. Applicable to 1 of 486 methods.*
* [`DeleteServiceAccountApiKeyAuthServiceAccountsResponse429ResponseBody`](./src/models/errors/deleteserviceaccountapikeyauthserviceaccountsresponse429responsebody.ts): Rate limited. Status code `429`. Applicable to 1 of 486 methods.*
* [`RegenerateServiceAccountApiKeyAuthServiceAccountsResponse429ResponseBody`](./src/models/errors/regenerateserviceaccountapikeyauthserviceaccountsresponse429responsebody.ts): Rate limited. Status code `429`. Applicable to 1 of 486 methods.*
* [`CreateClusterInviteAuthClusterResponse429ResponseBody`](./src/models/errors/createclusterinviteauthclusterresponse429responsebody.ts): Rate limited. Status code `429`. Applicable to 1 of 486 methods.*
* [`ListClusterInvitesAuthClusterResponse429ResponseBody`](./src/models/errors/listclusterinvitesauthclusterresponse429responsebody.ts): Rate limited. Status code `429`. Applicable to 1 of 486 methods.*
* [`UpdateClusterInviteAuthClusterResponse429ResponseBody`](./src/models/errors/updateclusterinviteauthclusterresponse429responsebody.ts): Rate limited. Status code `429`. Applicable to 1 of 486 methods.*
* [`RevokeClusterInviteAuthClusterResponse429ResponseBody`](./src/models/errors/revokeclusterinviteauthclusterresponse429responsebody.ts): Rate limited. Status code `429`. Applicable to 1 of 486 methods.*
* [`ListClusterOrgsAuthClusterResponse429ResponseBody`](./src/models/errors/listclusterorgsauthclusterresponse429responsebody.ts): Rate limited. Status code `429`. Applicable to 1 of 486 methods.*
* [`GetClusterOrgAuthClusterResponse429ResponseBody`](./src/models/errors/getclusterorgauthclusterresponse429responsebody.ts): Rate limited. Status code `429`. Applicable to 1 of 486 methods.*
* [`DeleteClusterOrgAuthClusterResponse429ResponseBody`](./src/models/errors/deleteclusterorgauthclusterresponse429responsebody.ts): Rate limited. Status code `429`. Applicable to 1 of 486 methods.*
* [`InviteClusterOrgMembersAuthClusterResponse429ResponseBody`](./src/models/errors/inviteclusterorgmembersauthclusterresponse429responsebody.ts): Rate limited. Status code `429`. Applicable to 1 of 486 methods.*
* [`SuspendClusterOrgAuthClusterResponse429ResponseBody`](./src/models/errors/suspendclusterorgauthclusterresponse429responsebody.ts): Rate limited. Status code `429`. Applicable to 1 of 486 methods.*
* [`UnsuspendClusterOrgAuthClusterResponse429ResponseBody`](./src/models/errors/unsuspendclusterorgauthclusterresponse429responsebody.ts): Rate limited. Status code `429`. Applicable to 1 of 486 methods.*
* [`ReissueOwnerKeyAuthClusterResponse429ResponseBody`](./src/models/errors/reissueownerkeyauthclusterresponse429responsebody.ts): Rate limited. Status code `429`. Applicable to 1 of 486 methods.*
* [`GetClusterInviteInfoAuthClusterResponse429ResponseBody`](./src/models/errors/getclusterinviteinfoauthclusterresponse429responsebody.ts): Rate limited. Status code `429`. Applicable to 1 of 486 methods.*
* [`AcceptClusterInviteAuthClusterResponse429ResponseBody`](./src/models/errors/acceptclusterinviteauthclusterresponse429responsebody.ts): Rate limited. Status code `429`. Applicable to 1 of 486 methods.*
* [`ExchangeSessionTokenSessionResponse500ResponseBody`](./src/models/errors/exchangesessiontokensessionresponse500responsebody.ts): Internal server error. Status code `500`. Applicable to 1 of 486 methods.*
* [`GetFileContentLlmFilesResponse500ResponseBody`](./src/models/errors/getfilecontentllmfilesresponse500responsebody.ts): Internal server error. Status code `500`. Applicable to 1 of 486 methods.*
* [`GetOrgByIdAuthOrgsResponse500ResponseBody`](./src/models/errors/getorgbyidauthorgsresponse500responsebody.ts): Stored organization metadata is invalid. Status code `500`. Applicable to 1 of 486 methods.*
* [`UpdateOrganizationAuthOrgsResponse500ResponseBody`](./src/models/errors/updateorganizationauthorgsresponse500responsebody.ts): Stored organization metadata is invalid. Status code `500`. Applicable to 1 of 486 methods.*
* [`GetJwtFromKeyAuthApiKeyResponseResponseBody`](./src/models/errors/getjwtfromkeyauthapikeyresponseresponsebody.ts): Internal server error. Status code `500`. Applicable to 1 of 486 methods.*
* [`AcceptClusterInviteAuthClusterResponse503ResponseBody`](./src/models/errors/acceptclusterinviteauthclusterresponse503responsebody.ts): The invitation spend limit could not be confirmed. The organization and invitation claim were rolled back; retry acceptance. Status code `503`. Applicable to 1 of 486 methods.*
* [`ResponseValidationError`](./src/models/errors/responsevalidationerror.ts): Type mismatch between the data returned from the server and the structure expected by the SDK. See `error.rawValue` for the raw value and `error.pretty()` for a nicely formatted multi-line string.

</details>

\* Check [the method documentation](#available-resources-and-operations) to see if the error is applicable.
<!-- End Error Handling [errors] -->

<!-- Start Server Selection [server] -->
## Server Selection

### Select Server by Index

You can override the default server globally by passing a server index to the `serverIdx: number` optional parameter when initializing the SDK client instance. The selected server will then be used as the default on the operations that use it. This table lists the indexes associated with the available servers:

| #   | Server                   | Description                                            |
| --- | ------------------------ | ------------------------------------------------------ |
| 0   | `https://apigw.mka1.com` | MKA1 API Gateway                                       |
| 1   | `/`                      | Relative server URL (configurable via SDK constructor) |

#### Example

```typescript
import { SDK } from "@meetkai/mka1";

const sdk = new SDK({
  serverIdx: 0,
  bearerAuth: "<YOUR_BEARER_TOKEN_HERE>",
});

async function run() {
  await sdk.permissions.llm.grant({
    grantPermissionRequest: {
      resourceType: "completion",
      resourceId: "my-completion-123",
      userId: "user-abc456",
      role: "writer",
    },
  });
}

run();

```

### Override Server URL Per-Client

The default server can also be overridden globally by passing a URL to the `serverURL: string` optional parameter when initializing the SDK client instance. For example:
```typescript
import { SDK } from "@meetkai/mka1";

const sdk = new SDK({
  serverURL: "https://apigw.mka1.com",
  bearerAuth: "<YOUR_BEARER_TOKEN_HERE>",
});

async function run() {
  await sdk.permissions.llm.grant({
    grantPermissionRequest: {
      resourceType: "completion",
      resourceId: "my-completion-123",
      userId: "user-abc456",
      role: "writer",
    },
  });
}

run();

```
<!-- End Server Selection [server] -->

<!-- Start Custom HTTP Client [http-client] -->
## Custom HTTP Client

The TypeScript SDK makes API calls using an `HTTPClient` that wraps the native
[Fetch API](https://developer.mozilla.org/en-US/docs/Web/API/Fetch_API). This
client is a thin wrapper around `fetch` and provides the ability to attach hooks
around the request lifecycle that can be used to modify the request or handle
errors and response.

The `HTTPClient` constructor takes an optional `fetcher` argument that can be
used to integrate a third-party HTTP client or when writing tests to mock out
the HTTP client and feed in fixtures.

The following example shows how to:
- route requests through a proxy server using [undici](https://www.npmjs.com/package/undici)'s ProxyAgent
- use the `"beforeRequest"` hook to add a custom header and a timeout to requests
- use the `"requestError"` hook to log errors

```typescript
import { SDK } from "@meetkai/mka1";
import { ProxyAgent } from "undici";
import { HTTPClient } from "@meetkai/mka1/lib/http";

const dispatcher = new ProxyAgent("http://proxy.example.com:8080");

const httpClient = new HTTPClient({
  // 'fetcher' takes a function that has the same signature as native 'fetch'.
  fetcher: (input, init) =>
    // 'dispatcher' is specific to undici and not part of the standard Fetch API.
    fetch(input, { ...init, dispatcher } as RequestInit),
});

httpClient.addHook("beforeRequest", (request) => {
  const nextRequest = new Request(request, {
    signal: request.signal || AbortSignal.timeout(5000)
  });

  nextRequest.headers.set("x-custom-header", "custom value");

  return nextRequest;
});

httpClient.addHook("requestError", (error, request) => {
  console.group("Request Error");
  console.log("Reason:", `${error}`);
  console.log("Endpoint:", `${request.method} ${request.url}`);
  console.groupEnd();
});

const sdk = new SDK({ httpClient: httpClient });
```
<!-- End Custom HTTP Client [http-client] -->

<!-- Start Debugging [debug] -->
## Debugging

You can setup your SDK to emit debug logs for SDK requests and responses.

You can pass a logger that matches `console`'s interface as an SDK option.

> [!WARNING]
> Beware that debug logging will reveal secrets, like API tokens in headers, in log messages printed to a console or files. It's recommended to use this feature only during local development and not in production.

```typescript
import { SDK } from "@meetkai/mka1";

const sdk = new SDK({ debugLogger: console });
```
<!-- End Debugging [debug] -->

## Versioning

The SDK is generated from the MKA1 OpenAPI schema and may gain new endpoints frequently. Pin an exact package version when deploying production applications, then upgrade intentionally after reviewing the generated type changes.

## Generated Code

Most files under `src/`, `docs/`, and the generated reference sections in this README are produced from the API schema. Changes to generated implementation files are likely to be overwritten by the next SDK generation. For API behavior questions, integration support, or documentation issues, use the support channels listed at [docs.mka1.com](https://docs.mka1.com).

Generated with [Speakeasy](https://www.speakeasy.com/).

<!-- Placeholder for Future Speakeasy SDK Sections -->
