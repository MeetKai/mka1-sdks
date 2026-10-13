# Repos.Tags

## Overview

### Available Operations

* [list](#list) - List an image repository's tags
* [delete](#delete) - Delete an image tag

## list

Lists the container-image tags a repository holds, newest-moved first,
each with the manifest it points at, the manifest's media type, the
image's declared size and when the tag last moved. The same access
check as reading the repository (org owner/admin; `read:repos` for a
key).

It is a fact about what the repository HOLDS, not about its `kind`:
a `model` lists `[]`, and a legacy `kind: null` repository that still
holds images lists them — those are the tags a `409 kind_has_content`
on PATCH is about, and deleting them through this API is what makes
that PATCH go through.

One page, of at most 1000 tags; `truncated` says whether the
repository holds more. The registry's own `GET /v2/{org}/{name}/tags/list`
is the paginated, names-only listing every OCI client speaks.


### Example Usage

<!-- UsageSnippet language="typescript" operationID="listRepoTags" method="get" path="/api/v1/repos/{org}/{name}/tags" -->
```typescript
import { SDK } from "@meetkai/mka1";

const sdk = new SDK({
  bearerAuth: "<YOUR_BEARER_TOKEN_HERE>",
});

async function run() {
  const result = await sdk.repos.tags.list({
    org: "<value>",
    name: "<value>",
  });

  console.log(result);
}

run();
```

### Standalone function

The standalone function version of this method:

```typescript
import { SDKCore } from "@meetkai/mka1/core.js";
import { reposTagsList } from "@meetkai/mka1/funcs/reposTagsList.js";

// Use `SDKCore` for best tree-shaking performance.
// You can create one instance of it to use across an application.
const sdk = new SDKCore({
  bearerAuth: "<YOUR_BEARER_TOKEN_HERE>",
});

async function run() {
  const res = await reposTagsList(sdk, {
    org: "<value>",
    name: "<value>",
  });
  if (res.ok) {
    const { value: result } = res;
    console.log(result);
  } else {
    console.log("reposTagsList failed:", res.error);
  }
}

run();
```

### React hooks and utilities

This method can be used in React components through the following hooks and
associated utilities.

> Check out [this guide][hook-guide] for information about each of the utilities
> below and how to get started using React hooks.

[hook-guide]: ../../../REACT_QUERY.md

```tsx
import {
  // Query hooks for fetching data.
  useReposTagsList,
  useReposTagsListSuspense,

  // Utility for prefetching data during server-side rendering and in React
  // Server Components that will be immediately available to client components
  // using the hooks.
  prefetchReposTagsList,
  
  // Utilities to invalidate the query cache for this query in response to
  // mutations and other user actions.
  invalidateReposTagsList,
  invalidateAllReposTagsList,
} from "@meetkai/mka1/react-query/reposTagsList.js";
```

### Parameters

| Parameter                                                                                                                                                                      | Type                                                                                                                                                                           | Required                                                                                                                                                                       | Description                                                                                                                                                                    |
| ------------------------------------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------------------------------------ |
| `request`                                                                                                                                                                      | [operations.ListRepoTagsRequest](../../models/operations/listrepotagsrequest.md)                                                                                               | :heavy_check_mark:                                                                                                                                                             | The request object to use for the request.                                                                                                                                     |
| `options`                                                                                                                                                                      | RequestOptions                                                                                                                                                                 | :heavy_minus_sign:                                                                                                                                                             | Used to set various options for making HTTP requests.                                                                                                                          |
| `options.fetchOptions`                                                                                                                                                         | [RequestInit](https://developer.mozilla.org/en-US/docs/Web/API/Request/Request#options)                                                                                        | :heavy_minus_sign:                                                                                                                                                             | Options that are passed to the underlying HTTP request. This can be used to inject extra headers for examples. All `Request` options, except `method` and `body`, are allowed. |
| `options.retries`                                                                                                                                                              | [RetryConfig](../../lib/utils/retryconfig.md)                                                                                                                                  | :heavy_minus_sign:                                                                                                                                                             | Enables retrying HTTP requests under certain failure conditions.                                                                                                               |

### Response

**Promise\<[components.RepoTagList](../../models/components/repotaglist.md)\>**

### Errors

| Error Type       | Status Code      | Content Type     |
| ---------------- | ---------------- | ---------------- |
| errors.RepoError | 401, 403, 404    | application/json |
| errors.RepoError | 500              | application/json |
| errors.APIError  | 4XX, 5XX         | \*/\*            |

## delete

Removes one tag; org owner/admin only (`write:repos` for a key). The
same untag as the registry's `DELETE /v2/{org}/{name}/manifests/{tag}`:
the name goes and the image stays, reachable by digest and by any
other tag that names it.

What makes a repository convertible afterwards is the kind switch
itself: `PATCH` to another `kind` first collects every image no tag
reaches (a multi-arch index's per-platform images included) and is
refused with `409 kind_has_content` only for images a tag still
names. So delete the tags the listing shows, then switch.


### Example Usage

<!-- UsageSnippet language="typescript" operationID="deleteRepoTag" method="delete" path="/api/v1/repos/{org}/{name}/tags/{tag}" -->
```typescript
import { SDK } from "@meetkai/mka1";

const sdk = new SDK({
  bearerAuth: "<YOUR_BEARER_TOKEN_HERE>",
});

async function run() {
  await sdk.repos.tags.delete({
    org: "<value>",
    name: "<value>",
    tag: "<value>",
  });


}

run();
```

### Standalone function

The standalone function version of this method:

```typescript
import { SDKCore } from "@meetkai/mka1/core.js";
import { reposTagsDelete } from "@meetkai/mka1/funcs/reposTagsDelete.js";

// Use `SDKCore` for best tree-shaking performance.
// You can create one instance of it to use across an application.
const sdk = new SDKCore({
  bearerAuth: "<YOUR_BEARER_TOKEN_HERE>",
});

async function run() {
  const res = await reposTagsDelete(sdk, {
    org: "<value>",
    name: "<value>",
    tag: "<value>",
  });
  if (res.ok) {
    const { value: result } = res;
    
  } else {
    console.log("reposTagsDelete failed:", res.error);
  }
}

run();
```

### React hooks and utilities

This method can be used in React components through the following hooks and
associated utilities.

> Check out [this guide][hook-guide] for information about each of the utilities
> below and how to get started using React hooks.

[hook-guide]: ../../../REACT_QUERY.md

```tsx
import {
  // Mutation hook for triggering the API call.
  useReposTagsDeleteMutation
} from "@meetkai/mka1/react-query/reposTagsDelete.js";
```

### Parameters

| Parameter                                                                                                                                                                      | Type                                                                                                                                                                           | Required                                                                                                                                                                       | Description                                                                                                                                                                    |
| ------------------------------------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------------------------------------ |
| `request`                                                                                                                                                                      | [operations.DeleteRepoTagRequest](../../models/operations/deleterepotagrequest.md)                                                                                             | :heavy_check_mark:                                                                                                                                                             | The request object to use for the request.                                                                                                                                     |
| `options`                                                                                                                                                                      | RequestOptions                                                                                                                                                                 | :heavy_minus_sign:                                                                                                                                                             | Used to set various options for making HTTP requests.                                                                                                                          |
| `options.fetchOptions`                                                                                                                                                         | [RequestInit](https://developer.mozilla.org/en-US/docs/Web/API/Request/Request#options)                                                                                        | :heavy_minus_sign:                                                                                                                                                             | Options that are passed to the underlying HTTP request. This can be used to inject extra headers for examples. All `Request` options, except `method` and `body`, are allowed. |
| `options.retries`                                                                                                                                                              | [RetryConfig](../../lib/utils/retryconfig.md)                                                                                                                                  | :heavy_minus_sign:                                                                                                                                                             | Enables retrying HTTP requests under certain failure conditions.                                                                                                               |

### Response

**Promise\<void\>**

### Errors

| Error Type       | Status Code      | Content Type     |
| ---------------- | ---------------- | ---------------- |
| errors.RepoError | 401, 403, 404    | application/json |
| errors.RepoError | 500              | application/json |
| errors.APIError  | 4XX, 5XX         | \*/\*            |