# Auth.Teams

## Overview

### Available Operations

* [create](#create) - Create a team
* [list](#list) - List teams in an org
* [get](#get) - Get a team
* [update](#update) - Rename a team
* [delete](#delete) - Delete a team
* [addMember](#addmember) - Add a team member
* [listMembers](#listmembers) - List team members
* [removeMember](#removemember) - Remove a team member

## create

Create a team

### Example Usage

<!-- UsageSnippet language="typescript" operationID="createTeam" method="post" path="/api/v1/authentication/orgs/{orgId}/teams" -->
```typescript
import { SDK } from "@meetkai/mka1";

const sdk = new SDK({
  bearerAuth: "<YOUR_BEARER_TOKEN_HERE>",
});

async function run() {
  const result = await sdk.auth.teams.create({
    orgId: "<id>",
  });

  console.log(result);
}

run();
```

### Standalone function

The standalone function version of this method:

```typescript
import { SDKCore } from "@meetkai/mka1/core.js";
import { authTeamsCreate } from "@meetkai/mka1/funcs/authTeamsCreate.js";

// Use `SDKCore` for best tree-shaking performance.
// You can create one instance of it to use across an application.
const sdk = new SDKCore({
  bearerAuth: "<YOUR_BEARER_TOKEN_HERE>",
});

async function run() {
  const res = await authTeamsCreate(sdk, {
    orgId: "<id>",
  });
  if (res.ok) {
    const { value: result } = res;
    console.log(result);
  } else {
    console.log("authTeamsCreate failed:", res.error);
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
  useAuthTeamsCreateMutation
} from "@meetkai/mka1/react-query/authTeamsCreate.js";
```

### Parameters

| Parameter                                                                                                                                                                      | Type                                                                                                                                                                           | Required                                                                                                                                                                       | Description                                                                                                                                                                    |
| ------------------------------------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------------------------------------ |
| `request`                                                                                                                                                                      | [operations.CreateTeamRequest](../../models/operations/createteamrequest.md)                                                                                                   | :heavy_check_mark:                                                                                                                                                             | The request object to use for the request.                                                                                                                                     |
| `options`                                                                                                                                                                      | RequestOptions                                                                                                                                                                 | :heavy_minus_sign:                                                                                                                                                             | Used to set various options for making HTTP requests.                                                                                                                          |
| `options.fetchOptions`                                                                                                                                                         | [RequestInit](https://developer.mozilla.org/en-US/docs/Web/API/Request/Request#options)                                                                                        | :heavy_minus_sign:                                                                                                                                                             | Options that are passed to the underlying HTTP request. This can be used to inject extra headers for examples. All `Request` options, except `method` and `body`, are allowed. |
| `options.retries`                                                                                                                                                              | [RetryConfig](../../lib/utils/retryconfig.md)                                                                                                                                  | :heavy_minus_sign:                                                                                                                                                             | Enables retrying HTTP requests under certain failure conditions.                                                                                                               |

### Response

**Promise\<[operations.CreateTeamResponseBody](../../models/operations/createteamresponsebody.md)\>**

### Errors

| Error Type                                        | Status Code                                       | Content Type                                      |
| ------------------------------------------------- | ------------------------------------------------- | ------------------------------------------------- |
| errors.CreateTeamResponseBody                     | 400                                               | application/json                                  |
| errors.CreateTeamAuthTeamsResponseBody            | 401                                               | application/json                                  |
| errors.CreateTeamAuthTeamsResponseResponseBody    | 403                                               | application/json                                  |
| errors.CreateTeamAuthTeamsResponse404ResponseBody | 404                                               | application/json                                  |
| errors.CreateTeamAuthTeamsResponse409ResponseBody | 409                                               | application/json                                  |
| errors.CreateTeamAuthTeamsResponse410ResponseBody | 410                                               | application/json                                  |
| errors.CreateTeamAuthTeamsResponse429ResponseBody | 429                                               | application/json                                  |
| errors.APIError                                   | 4XX, 5XX                                          | \*/\*                                             |

## list

List teams in an org

### Example Usage

<!-- UsageSnippet language="typescript" operationID="listTeams" method="get" path="/api/v1/authentication/orgs/{orgId}/teams" -->
```typescript
import { SDK } from "@meetkai/mka1";

const sdk = new SDK({
  bearerAuth: "<YOUR_BEARER_TOKEN_HERE>",
});

async function run() {
  const result = await sdk.auth.teams.list({
    orgId: "<id>",
  });

  console.log(result);
}

run();
```

### Standalone function

The standalone function version of this method:

```typescript
import { SDKCore } from "@meetkai/mka1/core.js";
import { authTeamsList } from "@meetkai/mka1/funcs/authTeamsList.js";

// Use `SDKCore` for best tree-shaking performance.
// You can create one instance of it to use across an application.
const sdk = new SDKCore({
  bearerAuth: "<YOUR_BEARER_TOKEN_HERE>",
});

async function run() {
  const res = await authTeamsList(sdk, {
    orgId: "<id>",
  });
  if (res.ok) {
    const { value: result } = res;
    console.log(result);
  } else {
    console.log("authTeamsList failed:", res.error);
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
  useAuthTeamsList,
  useAuthTeamsListSuspense,

  // Utility for prefetching data during server-side rendering and in React
  // Server Components that will be immediately available to client components
  // using the hooks.
  prefetchAuthTeamsList,
  
  // Utilities to invalidate the query cache for this query in response to
  // mutations and other user actions.
  invalidateAuthTeamsList,
  invalidateAllAuthTeamsList,
} from "@meetkai/mka1/react-query/authTeamsList.js";
```

### Parameters

| Parameter                                                                                                                                                                      | Type                                                                                                                                                                           | Required                                                                                                                                                                       | Description                                                                                                                                                                    |
| ------------------------------------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------------------------------------ |
| `request`                                                                                                                                                                      | [operations.ListTeamsRequest](../../models/operations/listteamsrequest.md)                                                                                                     | :heavy_check_mark:                                                                                                                                                             | The request object to use for the request.                                                                                                                                     |
| `options`                                                                                                                                                                      | RequestOptions                                                                                                                                                                 | :heavy_minus_sign:                                                                                                                                                             | Used to set various options for making HTTP requests.                                                                                                                          |
| `options.fetchOptions`                                                                                                                                                         | [RequestInit](https://developer.mozilla.org/en-US/docs/Web/API/Request/Request#options)                                                                                        | :heavy_minus_sign:                                                                                                                                                             | Options that are passed to the underlying HTTP request. This can be used to inject extra headers for examples. All `Request` options, except `method` and `body`, are allowed. |
| `options.retries`                                                                                                                                                              | [RetryConfig](../../lib/utils/retryconfig.md)                                                                                                                                  | :heavy_minus_sign:                                                                                                                                                             | Enables retrying HTTP requests under certain failure conditions.                                                                                                               |

### Response

**Promise\<[operations.ListTeamsResponseBody](../../models/operations/listteamsresponsebody.md)\>**

### Errors

| Error Type                                       | Status Code                                      | Content Type                                     |
| ------------------------------------------------ | ------------------------------------------------ | ------------------------------------------------ |
| errors.ListTeamsResponseBody                     | 400                                              | application/json                                 |
| errors.ListTeamsAuthTeamsResponseBody            | 401                                              | application/json                                 |
| errors.ListTeamsAuthTeamsResponseResponseBody    | 403                                              | application/json                                 |
| errors.ListTeamsAuthTeamsResponse404ResponseBody | 404                                              | application/json                                 |
| errors.ListTeamsAuthTeamsResponse409ResponseBody | 409                                              | application/json                                 |
| errors.ListTeamsAuthTeamsResponse410ResponseBody | 410                                              | application/json                                 |
| errors.ListTeamsAuthTeamsResponse429ResponseBody | 429                                              | application/json                                 |
| errors.APIError                                  | 4XX, 5XX                                         | \*/\*                                            |

## get

Get a team

### Example Usage

<!-- UsageSnippet language="typescript" operationID="getTeam" method="get" path="/api/v1/authentication/orgs/{orgId}/teams/{teamId}" -->
```typescript
import { SDK } from "@meetkai/mka1";

const sdk = new SDK({
  bearerAuth: "<YOUR_BEARER_TOKEN_HERE>",
});

async function run() {
  const result = await sdk.auth.teams.get({
    orgId: "<id>",
    teamId: "<id>",
  });

  console.log(result);
}

run();
```

### Standalone function

The standalone function version of this method:

```typescript
import { SDKCore } from "@meetkai/mka1/core.js";
import { authTeamsGet } from "@meetkai/mka1/funcs/authTeamsGet.js";

// Use `SDKCore` for best tree-shaking performance.
// You can create one instance of it to use across an application.
const sdk = new SDKCore({
  bearerAuth: "<YOUR_BEARER_TOKEN_HERE>",
});

async function run() {
  const res = await authTeamsGet(sdk, {
    orgId: "<id>",
    teamId: "<id>",
  });
  if (res.ok) {
    const { value: result } = res;
    console.log(result);
  } else {
    console.log("authTeamsGet failed:", res.error);
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
  useAuthTeamsGet,
  useAuthTeamsGetSuspense,

  // Utility for prefetching data during server-side rendering and in React
  // Server Components that will be immediately available to client components
  // using the hooks.
  prefetchAuthTeamsGet,
  
  // Utilities to invalidate the query cache for this query in response to
  // mutations and other user actions.
  invalidateAuthTeamsGet,
  invalidateAllAuthTeamsGet,
} from "@meetkai/mka1/react-query/authTeamsGet.js";
```

### Parameters

| Parameter                                                                                                                                                                      | Type                                                                                                                                                                           | Required                                                                                                                                                                       | Description                                                                                                                                                                    |
| ------------------------------------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------------------------------------ |
| `request`                                                                                                                                                                      | [operations.GetTeamRequest](../../models/operations/getteamrequest.md)                                                                                                         | :heavy_check_mark:                                                                                                                                                             | The request object to use for the request.                                                                                                                                     |
| `options`                                                                                                                                                                      | RequestOptions                                                                                                                                                                 | :heavy_minus_sign:                                                                                                                                                             | Used to set various options for making HTTP requests.                                                                                                                          |
| `options.fetchOptions`                                                                                                                                                         | [RequestInit](https://developer.mozilla.org/en-US/docs/Web/API/Request/Request#options)                                                                                        | :heavy_minus_sign:                                                                                                                                                             | Options that are passed to the underlying HTTP request. This can be used to inject extra headers for examples. All `Request` options, except `method` and `body`, are allowed. |
| `options.retries`                                                                                                                                                              | [RetryConfig](../../lib/utils/retryconfig.md)                                                                                                                                  | :heavy_minus_sign:                                                                                                                                                             | Enables retrying HTTP requests under certain failure conditions.                                                                                                               |

### Response

**Promise\<[operations.GetTeamResponseBody](../../models/operations/getteamresponsebody.md)\>**

### Errors

| Error Type                                     | Status Code                                    | Content Type                                   |
| ---------------------------------------------- | ---------------------------------------------- | ---------------------------------------------- |
| errors.GetTeamResponseBody                     | 400                                            | application/json                               |
| errors.GetTeamAuthTeamsResponseBody            | 401                                            | application/json                               |
| errors.GetTeamAuthTeamsResponseResponseBody    | 403                                            | application/json                               |
| errors.GetTeamAuthTeamsResponse404ResponseBody | 404                                            | application/json                               |
| errors.GetTeamAuthTeamsResponse409ResponseBody | 409                                            | application/json                               |
| errors.GetTeamAuthTeamsResponse410ResponseBody | 410                                            | application/json                               |
| errors.GetTeamAuthTeamsResponse429ResponseBody | 429                                            | application/json                               |
| errors.APIError                                | 4XX, 5XX                                       | \*/\*                                          |

## update

Rename a team

### Example Usage

<!-- UsageSnippet language="typescript" operationID="updateTeam" method="patch" path="/api/v1/authentication/orgs/{orgId}/teams/{teamId}" -->
```typescript
import { SDK } from "@meetkai/mka1";

const sdk = new SDK({
  bearerAuth: "<YOUR_BEARER_TOKEN_HERE>",
});

async function run() {
  const result = await sdk.auth.teams.update({
    orgId: "<id>",
    teamId: "<id>",
  });

  console.log(result);
}

run();
```

### Standalone function

The standalone function version of this method:

```typescript
import { SDKCore } from "@meetkai/mka1/core.js";
import { authTeamsUpdate } from "@meetkai/mka1/funcs/authTeamsUpdate.js";

// Use `SDKCore` for best tree-shaking performance.
// You can create one instance of it to use across an application.
const sdk = new SDKCore({
  bearerAuth: "<YOUR_BEARER_TOKEN_HERE>",
});

async function run() {
  const res = await authTeamsUpdate(sdk, {
    orgId: "<id>",
    teamId: "<id>",
  });
  if (res.ok) {
    const { value: result } = res;
    console.log(result);
  } else {
    console.log("authTeamsUpdate failed:", res.error);
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
  useAuthTeamsUpdateMutation
} from "@meetkai/mka1/react-query/authTeamsUpdate.js";
```

### Parameters

| Parameter                                                                                                                                                                      | Type                                                                                                                                                                           | Required                                                                                                                                                                       | Description                                                                                                                                                                    |
| ------------------------------------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------------------------------------ |
| `request`                                                                                                                                                                      | [operations.UpdateTeamRequest](../../models/operations/updateteamrequest.md)                                                                                                   | :heavy_check_mark:                                                                                                                                                             | The request object to use for the request.                                                                                                                                     |
| `options`                                                                                                                                                                      | RequestOptions                                                                                                                                                                 | :heavy_minus_sign:                                                                                                                                                             | Used to set various options for making HTTP requests.                                                                                                                          |
| `options.fetchOptions`                                                                                                                                                         | [RequestInit](https://developer.mozilla.org/en-US/docs/Web/API/Request/Request#options)                                                                                        | :heavy_minus_sign:                                                                                                                                                             | Options that are passed to the underlying HTTP request. This can be used to inject extra headers for examples. All `Request` options, except `method` and `body`, are allowed. |
| `options.retries`                                                                                                                                                              | [RetryConfig](../../lib/utils/retryconfig.md)                                                                                                                                  | :heavy_minus_sign:                                                                                                                                                             | Enables retrying HTTP requests under certain failure conditions.                                                                                                               |

### Response

**Promise\<[operations.UpdateTeamResponseBody](../../models/operations/updateteamresponsebody.md)\>**

### Errors

| Error Type                                        | Status Code                                       | Content Type                                      |
| ------------------------------------------------- | ------------------------------------------------- | ------------------------------------------------- |
| errors.UpdateTeamResponseBody                     | 400                                               | application/json                                  |
| errors.UpdateTeamAuthTeamsResponseBody            | 401                                               | application/json                                  |
| errors.UpdateTeamAuthTeamsResponseResponseBody    | 403                                               | application/json                                  |
| errors.UpdateTeamAuthTeamsResponse404ResponseBody | 404                                               | application/json                                  |
| errors.UpdateTeamAuthTeamsResponse409ResponseBody | 409                                               | application/json                                  |
| errors.UpdateTeamAuthTeamsResponse410ResponseBody | 410                                               | application/json                                  |
| errors.UpdateTeamAuthTeamsResponse429ResponseBody | 429                                               | application/json                                  |
| errors.APIError                                   | 4XX, 5XX                                          | \*/\*                                             |

## delete

Delete a team

### Example Usage

<!-- UsageSnippet language="typescript" operationID="deleteTeam" method="delete" path="/api/v1/authentication/orgs/{orgId}/teams/{teamId}" -->
```typescript
import { SDK } from "@meetkai/mka1";

const sdk = new SDK({
  bearerAuth: "<YOUR_BEARER_TOKEN_HERE>",
});

async function run() {
  const result = await sdk.auth.teams.delete({
    orgId: "<id>",
    teamId: "<id>",
  });

  console.log(result);
}

run();
```

### Standalone function

The standalone function version of this method:

```typescript
import { SDKCore } from "@meetkai/mka1/core.js";
import { authTeamsDelete } from "@meetkai/mka1/funcs/authTeamsDelete.js";

// Use `SDKCore` for best tree-shaking performance.
// You can create one instance of it to use across an application.
const sdk = new SDKCore({
  bearerAuth: "<YOUR_BEARER_TOKEN_HERE>",
});

async function run() {
  const res = await authTeamsDelete(sdk, {
    orgId: "<id>",
    teamId: "<id>",
  });
  if (res.ok) {
    const { value: result } = res;
    console.log(result);
  } else {
    console.log("authTeamsDelete failed:", res.error);
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
  useAuthTeamsDeleteMutation
} from "@meetkai/mka1/react-query/authTeamsDelete.js";
```

### Parameters

| Parameter                                                                                                                                                                      | Type                                                                                                                                                                           | Required                                                                                                                                                                       | Description                                                                                                                                                                    |
| ------------------------------------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------------------------------------ |
| `request`                                                                                                                                                                      | [operations.DeleteTeamRequest](../../models/operations/deleteteamrequest.md)                                                                                                   | :heavy_check_mark:                                                                                                                                                             | The request object to use for the request.                                                                                                                                     |
| `options`                                                                                                                                                                      | RequestOptions                                                                                                                                                                 | :heavy_minus_sign:                                                                                                                                                             | Used to set various options for making HTTP requests.                                                                                                                          |
| `options.fetchOptions`                                                                                                                                                         | [RequestInit](https://developer.mozilla.org/en-US/docs/Web/API/Request/Request#options)                                                                                        | :heavy_minus_sign:                                                                                                                                                             | Options that are passed to the underlying HTTP request. This can be used to inject extra headers for examples. All `Request` options, except `method` and `body`, are allowed. |
| `options.retries`                                                                                                                                                              | [RetryConfig](../../lib/utils/retryconfig.md)                                                                                                                                  | :heavy_minus_sign:                                                                                                                                                             | Enables retrying HTTP requests under certain failure conditions.                                                                                                               |

### Response

**Promise\<[operations.DeleteTeamResponseBody](../../models/operations/deleteteamresponsebody.md)\>**

### Errors

| Error Type                                        | Status Code                                       | Content Type                                      |
| ------------------------------------------------- | ------------------------------------------------- | ------------------------------------------------- |
| errors.DeleteTeamResponseBody                     | 400                                               | application/json                                  |
| errors.DeleteTeamAuthTeamsResponseBody            | 401                                               | application/json                                  |
| errors.DeleteTeamAuthTeamsResponseResponseBody    | 403                                               | application/json                                  |
| errors.DeleteTeamAuthTeamsResponse404ResponseBody | 404                                               | application/json                                  |
| errors.DeleteTeamAuthTeamsResponse409ResponseBody | 409                                               | application/json                                  |
| errors.DeleteTeamAuthTeamsResponse410ResponseBody | 410                                               | application/json                                  |
| errors.DeleteTeamAuthTeamsResponse429ResponseBody | 429                                               | application/json                                  |
| errors.APIError                                   | 4XX, 5XX                                          | \*/\*                                             |

## addMember

Attach a principal (user or service account) to the team by its userId.

### Example Usage

<!-- UsageSnippet language="typescript" operationID="addTeamMember" method="post" path="/api/v1/authentication/orgs/{orgId}/teams/{teamId}/members" -->
```typescript
import { SDK } from "@meetkai/mka1";

const sdk = new SDK({
  bearerAuth: "<YOUR_BEARER_TOKEN_HERE>",
});

async function run() {
  const result = await sdk.auth.teams.addMember({
    orgId: "<id>",
    teamId: "<id>",
  });

  console.log(result);
}

run();
```

### Standalone function

The standalone function version of this method:

```typescript
import { SDKCore } from "@meetkai/mka1/core.js";
import { authTeamsAddMember } from "@meetkai/mka1/funcs/authTeamsAddMember.js";

// Use `SDKCore` for best tree-shaking performance.
// You can create one instance of it to use across an application.
const sdk = new SDKCore({
  bearerAuth: "<YOUR_BEARER_TOKEN_HERE>",
});

async function run() {
  const res = await authTeamsAddMember(sdk, {
    orgId: "<id>",
    teamId: "<id>",
  });
  if (res.ok) {
    const { value: result } = res;
    console.log(result);
  } else {
    console.log("authTeamsAddMember failed:", res.error);
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
  useAuthTeamsAddMemberMutation
} from "@meetkai/mka1/react-query/authTeamsAddMember.js";
```

### Parameters

| Parameter                                                                                                                                                                      | Type                                                                                                                                                                           | Required                                                                                                                                                                       | Description                                                                                                                                                                    |
| ------------------------------------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------------------------------------ |
| `request`                                                                                                                                                                      | [operations.AddTeamMemberRequest](../../models/operations/addteammemberrequest.md)                                                                                             | :heavy_check_mark:                                                                                                                                                             | The request object to use for the request.                                                                                                                                     |
| `options`                                                                                                                                                                      | RequestOptions                                                                                                                                                                 | :heavy_minus_sign:                                                                                                                                                             | Used to set various options for making HTTP requests.                                                                                                                          |
| `options.fetchOptions`                                                                                                                                                         | [RequestInit](https://developer.mozilla.org/en-US/docs/Web/API/Request/Request#options)                                                                                        | :heavy_minus_sign:                                                                                                                                                             | Options that are passed to the underlying HTTP request. This can be used to inject extra headers for examples. All `Request` options, except `method` and `body`, are allowed. |
| `options.retries`                                                                                                                                                              | [RetryConfig](../../lib/utils/retryconfig.md)                                                                                                                                  | :heavy_minus_sign:                                                                                                                                                             | Enables retrying HTTP requests under certain failure conditions.                                                                                                               |

### Response

**Promise\<[operations.AddTeamMemberResponseBody](../../models/operations/addteammemberresponsebody.md)\>**

### Errors

| Error Type                                           | Status Code                                          | Content Type                                         |
| ---------------------------------------------------- | ---------------------------------------------------- | ---------------------------------------------------- |
| errors.AddTeamMemberResponseBody                     | 400                                                  | application/json                                     |
| errors.AddTeamMemberAuthTeamsResponseBody            | 401                                                  | application/json                                     |
| errors.AddTeamMemberAuthTeamsResponseResponseBody    | 403                                                  | application/json                                     |
| errors.AddTeamMemberAuthTeamsResponse404ResponseBody | 404                                                  | application/json                                     |
| errors.AddTeamMemberAuthTeamsResponse409ResponseBody | 409                                                  | application/json                                     |
| errors.AddTeamMemberAuthTeamsResponse410ResponseBody | 410                                                  | application/json                                     |
| errors.AddTeamMemberAuthTeamsResponse429ResponseBody | 429                                                  | application/json                                     |
| errors.APIError                                      | 4XX, 5XX                                             | \*/\*                                                |

## listMembers

List team members

### Example Usage

<!-- UsageSnippet language="typescript" operationID="listTeamMembers" method="get" path="/api/v1/authentication/orgs/{orgId}/teams/{teamId}/members" -->
```typescript
import { SDK } from "@meetkai/mka1";

const sdk = new SDK({
  bearerAuth: "<YOUR_BEARER_TOKEN_HERE>",
});

async function run() {
  const result = await sdk.auth.teams.listMembers({
    orgId: "<id>",
    teamId: "<id>",
  });

  console.log(result);
}

run();
```

### Standalone function

The standalone function version of this method:

```typescript
import { SDKCore } from "@meetkai/mka1/core.js";
import { authTeamsListMembers } from "@meetkai/mka1/funcs/authTeamsListMembers.js";

// Use `SDKCore` for best tree-shaking performance.
// You can create one instance of it to use across an application.
const sdk = new SDKCore({
  bearerAuth: "<YOUR_BEARER_TOKEN_HERE>",
});

async function run() {
  const res = await authTeamsListMembers(sdk, {
    orgId: "<id>",
    teamId: "<id>",
  });
  if (res.ok) {
    const { value: result } = res;
    console.log(result);
  } else {
    console.log("authTeamsListMembers failed:", res.error);
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
  useAuthTeamsListMembers,
  useAuthTeamsListMembersSuspense,

  // Utility for prefetching data during server-side rendering and in React
  // Server Components that will be immediately available to client components
  // using the hooks.
  prefetchAuthTeamsListMembers,
  
  // Utilities to invalidate the query cache for this query in response to
  // mutations and other user actions.
  invalidateAuthTeamsListMembers,
  invalidateAllAuthTeamsListMembers,
} from "@meetkai/mka1/react-query/authTeamsListMembers.js";
```

### Parameters

| Parameter                                                                                                                                                                      | Type                                                                                                                                                                           | Required                                                                                                                                                                       | Description                                                                                                                                                                    |
| ------------------------------------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------------------------------------ |
| `request`                                                                                                                                                                      | [operations.ListTeamMembersRequest](../../models/operations/listteammembersrequest.md)                                                                                         | :heavy_check_mark:                                                                                                                                                             | The request object to use for the request.                                                                                                                                     |
| `options`                                                                                                                                                                      | RequestOptions                                                                                                                                                                 | :heavy_minus_sign:                                                                                                                                                             | Used to set various options for making HTTP requests.                                                                                                                          |
| `options.fetchOptions`                                                                                                                                                         | [RequestInit](https://developer.mozilla.org/en-US/docs/Web/API/Request/Request#options)                                                                                        | :heavy_minus_sign:                                                                                                                                                             | Options that are passed to the underlying HTTP request. This can be used to inject extra headers for examples. All `Request` options, except `method` and `body`, are allowed. |
| `options.retries`                                                                                                                                                              | [RetryConfig](../../lib/utils/retryconfig.md)                                                                                                                                  | :heavy_minus_sign:                                                                                                                                                             | Enables retrying HTTP requests under certain failure conditions.                                                                                                               |

### Response

**Promise\<[operations.ListTeamMembersResponseBody](../../models/operations/listteammembersresponsebody.md)\>**

### Errors

| Error Type                                             | Status Code                                            | Content Type                                           |
| ------------------------------------------------------ | ------------------------------------------------------ | ------------------------------------------------------ |
| errors.ListTeamMembersResponseBody                     | 400                                                    | application/json                                       |
| errors.ListTeamMembersAuthTeamsResponseBody            | 401                                                    | application/json                                       |
| errors.ListTeamMembersAuthTeamsResponseResponseBody    | 403                                                    | application/json                                       |
| errors.ListTeamMembersAuthTeamsResponse404ResponseBody | 404                                                    | application/json                                       |
| errors.ListTeamMembersAuthTeamsResponse409ResponseBody | 409                                                    | application/json                                       |
| errors.ListTeamMembersAuthTeamsResponse410ResponseBody | 410                                                    | application/json                                       |
| errors.ListTeamMembersAuthTeamsResponse429ResponseBody | 429                                                    | application/json                                       |
| errors.APIError                                        | 4XX, 5XX                                               | \*/\*                                                  |

## removeMember

Remove a team member

### Example Usage

<!-- UsageSnippet language="typescript" operationID="removeTeamMember" method="delete" path="/api/v1/authentication/orgs/{orgId}/teams/{teamId}/members/{memberId}" -->
```typescript
import { SDK } from "@meetkai/mka1";

const sdk = new SDK({
  bearerAuth: "<YOUR_BEARER_TOKEN_HERE>",
});

async function run() {
  const result = await sdk.auth.teams.removeMember({
    orgId: "<id>",
    teamId: "<id>",
    memberId: "<id>",
  });

  console.log(result);
}

run();
```

### Standalone function

The standalone function version of this method:

```typescript
import { SDKCore } from "@meetkai/mka1/core.js";
import { authTeamsRemoveMember } from "@meetkai/mka1/funcs/authTeamsRemoveMember.js";

// Use `SDKCore` for best tree-shaking performance.
// You can create one instance of it to use across an application.
const sdk = new SDKCore({
  bearerAuth: "<YOUR_BEARER_TOKEN_HERE>",
});

async function run() {
  const res = await authTeamsRemoveMember(sdk, {
    orgId: "<id>",
    teamId: "<id>",
    memberId: "<id>",
  });
  if (res.ok) {
    const { value: result } = res;
    console.log(result);
  } else {
    console.log("authTeamsRemoveMember failed:", res.error);
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
  useAuthTeamsRemoveMemberMutation
} from "@meetkai/mka1/react-query/authTeamsRemoveMember.js";
```

### Parameters

| Parameter                                                                                                                                                                      | Type                                                                                                                                                                           | Required                                                                                                                                                                       | Description                                                                                                                                                                    |
| ------------------------------------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------------------------------------ |
| `request`                                                                                                                                                                      | [operations.RemoveTeamMemberRequest](../../models/operations/removeteammemberrequest.md)                                                                                       | :heavy_check_mark:                                                                                                                                                             | The request object to use for the request.                                                                                                                                     |
| `options`                                                                                                                                                                      | RequestOptions                                                                                                                                                                 | :heavy_minus_sign:                                                                                                                                                             | Used to set various options for making HTTP requests.                                                                                                                          |
| `options.fetchOptions`                                                                                                                                                         | [RequestInit](https://developer.mozilla.org/en-US/docs/Web/API/Request/Request#options)                                                                                        | :heavy_minus_sign:                                                                                                                                                             | Options that are passed to the underlying HTTP request. This can be used to inject extra headers for examples. All `Request` options, except `method` and `body`, are allowed. |
| `options.retries`                                                                                                                                                              | [RetryConfig](../../lib/utils/retryconfig.md)                                                                                                                                  | :heavy_minus_sign:                                                                                                                                                             | Enables retrying HTTP requests under certain failure conditions.                                                                                                               |

### Response

**Promise\<[operations.RemoveTeamMemberResponseBody](../../models/operations/removeteammemberresponsebody.md)\>**

### Errors

| Error Type                                              | Status Code                                             | Content Type                                            |
| ------------------------------------------------------- | ------------------------------------------------------- | ------------------------------------------------------- |
| errors.RemoveTeamMemberResponseBody                     | 400                                                     | application/json                                        |
| errors.RemoveTeamMemberAuthTeamsResponseBody            | 401                                                     | application/json                                        |
| errors.RemoveTeamMemberAuthTeamsResponseResponseBody    | 403                                                     | application/json                                        |
| errors.RemoveTeamMemberAuthTeamsResponse404ResponseBody | 404                                                     | application/json                                        |
| errors.RemoveTeamMemberAuthTeamsResponse409ResponseBody | 409                                                     | application/json                                        |
| errors.RemoveTeamMemberAuthTeamsResponse410ResponseBody | 410                                                     | application/json                                        |
| errors.RemoveTeamMemberAuthTeamsResponse429ResponseBody | 429                                                     | application/json                                        |
| errors.APIError                                         | 4XX, 5XX                                                | \*/\*                                                   |