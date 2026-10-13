# Llm.Skills

## Overview

### Available Operations

* [Create](#create) - Create skill
* [List](#list) - List skills
* [Get](#get) - Retrieve skill
* [Update](#update) - Update skill
* [Delete](#delete) - Delete skill
* [Content](#content) - Download skill content
* [CreateVersion](#createversion) - Create skill version
* [ListVersions](#listversions) - List skill versions
* [GetVersion](#getversion) - Retrieve skill version
* [DeleteVersion](#deleteversion) - Delete skill version
* [VersionContent](#versioncontent) - Download skill version content
* [ListPreconfigured](#listpreconfigured) - List preconfigured skills

## Create

Create a new skill by uploading files. The uploaded files must include a SKILL.md manifest. Accepts multipart form data with individual files or a single zip archive.

### Example Usage

<!-- UsageSnippet language="csharp" operationID="createSkill" method="post" path="/api/v1/llm/skills" -->
```csharp
using MeetKai.MKA1;
using MeetKai.MKA1.Types.Components;
using MeetKai.MKA1.Types.Requests;

var sdk = new SDK(bearerAuth: "<YOUR_BEARER_TOKEN_HERE>");

var res = await sdk.Llm.Skills.CreateAsync(body: new CreateSkillRequestBody() {});

// handle response
```

### Parameters

| Parameter                                                                | Type                                                                     | Required                                                                 | Description                                                              |
| ------------------------------------------------------------------------ | ------------------------------------------------------------------------ | ------------------------------------------------------------------------ | ------------------------------------------------------------------------ |
| `Body`                                                                   | [CreateSkillRequestBody](../../Types/Requests/CreateSkillRequestBody.md) | :heavy_check_mark:                                                       | N/A                                                                      |
| `XOnBehalfOf`                                                            | *string*                                                                 | :heavy_minus_sign:                                                       | Optional external end-user identifier forwarded by the API gateway.      |

### Response

**[CreateSkillResponse](../../Types/Requests/CreateSkillResponse.md)**

### Errors

| Error Type                             | Status Code                            | Content Type                           |
| -------------------------------------- | -------------------------------------- | -------------------------------------- |
| MeetKai.MKA1.Types.Errors.APIException | 4XX, 5XX                               | \*/\*                                  |

## List

Returns a paginated list of skills.

### Example Usage

<!-- UsageSnippet language="csharp" operationID="listSkills" method="get" path="/api/v1/llm/skills" -->
```csharp
using MeetKai.MKA1;
using MeetKai.MKA1.Types.Components;
using MeetKai.MKA1.Types.Requests;

var sdk = new SDK(bearerAuth: "<YOUR_BEARER_TOKEN_HERE>");

var res = await sdk.Llm.Skills.ListAsync(
    limit: 20,
    order: ListSkillsOrder.Desc
);

// handle response
```

### Parameters

| Parameter                                                           | Type                                                                | Required                                                            | Description                                                         | Example                                                             |
| ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- |
| `After`                                                             | *string*                                                            | :heavy_minus_sign:                                                  | N/A                                                                 |                                                                     |
| `Limit`                                                             | *long*                                                              | :heavy_minus_sign:                                                  | N/A                                                                 | 20                                                                  |
| `Order`                                                             | [ListSkillsOrder](../../Types/Requests/ListSkillsOrder.md)          | :heavy_minus_sign:                                                  | N/A                                                                 | desc                                                                |
| `XOnBehalfOf`                                                       | *string*                                                            | :heavy_minus_sign:                                                  | Optional external end-user identifier forwarded by the API gateway. |                                                                     |

### Response

**[ListSkillsResponse](../../Types/Requests/ListSkillsResponse.md)**

### Errors

| Error Type                             | Status Code                            | Content Type                           |
| -------------------------------------- | -------------------------------------- | -------------------------------------- |
| MeetKai.MKA1.Types.Errors.APIException | 4XX, 5XX                               | \*/\*                                  |

## Get

Returns information about a specific skill.

### Example Usage

<!-- UsageSnippet language="csharp" operationID="getSkill" method="get" path="/api/v1/llm/skills/{skill_id}" -->
```csharp
using MeetKai.MKA1;
using MeetKai.MKA1.Types.Components;

var sdk = new SDK(bearerAuth: "<YOUR_BEARER_TOKEN_HERE>");

var res = await sdk.Llm.Skills.GetAsync(skillId: "skill_1710000000000_abc123");

// handle response
```

### Parameters

| Parameter                                                           | Type                                                                | Required                                                            | Description                                                         | Example                                                             |
| ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- |
| `SkillId`                                                           | *string*                                                            | :heavy_check_mark:                                                  | N/A                                                                 | skill_1710000000000_abc123                                          |
| `XOnBehalfOf`                                                       | *string*                                                            | :heavy_minus_sign:                                                  | Optional external end-user identifier forwarded by the API gateway. |                                                                     |

### Response

**[GetSkillResponse](../../Types/Requests/GetSkillResponse.md)**

### Errors

| Error Type                             | Status Code                            | Content Type                           |
| -------------------------------------- | -------------------------------------- | -------------------------------------- |
| MeetKai.MKA1.Types.Errors.APIException | 4XX, 5XX                               | \*/\*                                  |

## Update

Update the default version pointer for a skill.

### Example Usage

<!-- UsageSnippet language="csharp" operationID="updateSkill" method="post" path="/api/v1/llm/skills/{skill_id}" -->
```csharp
using MeetKai.MKA1;
using MeetKai.MKA1.Types.Components;

var sdk = new SDK(bearerAuth: "<YOUR_BEARER_TOKEN_HERE>");

var res = await sdk.Llm.Skills.UpdateAsync(
    skillId: "skill_1710000000000_abc123",
    body: new SkillUpdateRequest() {
        DefaultVersion = "2",
    }
);

// handle response
```

### Parameters

| Parameter                                                           | Type                                                                | Required                                                            | Description                                                         | Example                                                             |
| ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- |
| `SkillId`                                                           | *string*                                                            | :heavy_check_mark:                                                  | N/A                                                                 | skill_1710000000000_abc123                                          |
| `Body`                                                              | [SkillUpdateRequest](../../Types/Components/SkillUpdateRequest.md)  | :heavy_check_mark:                                                  | N/A                                                                 |                                                                     |
| `XOnBehalfOf`                                                       | *string*                                                            | :heavy_minus_sign:                                                  | Optional external end-user identifier forwarded by the API gateway. |                                                                     |

### Response

**[UpdateSkillResponse](../../Types/Requests/UpdateSkillResponse.md)**

### Errors

| Error Type                             | Status Code                            | Content Type                           |
| -------------------------------------- | -------------------------------------- | -------------------------------------- |
| MeetKai.MKA1.Types.Errors.APIException | 4XX, 5XX                               | \*/\*                                  |

## Delete

Delete a skill and all its versions.

### Example Usage

<!-- UsageSnippet language="csharp" operationID="deleteSkill" method="delete" path="/api/v1/llm/skills/{skill_id}" -->
```csharp
using MeetKai.MKA1;
using MeetKai.MKA1.Types.Components;

var sdk = new SDK(bearerAuth: "<YOUR_BEARER_TOKEN_HERE>");

var res = await sdk.Llm.Skills.DeleteAsync(skillId: "skill_1710000000000_abc123");

// handle response
```

### Parameters

| Parameter                                                           | Type                                                                | Required                                                            | Description                                                         | Example                                                             |
| ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- |
| `SkillId`                                                           | *string*                                                            | :heavy_check_mark:                                                  | N/A                                                                 | skill_1710000000000_abc123                                          |
| `XOnBehalfOf`                                                       | *string*                                                            | :heavy_minus_sign:                                                  | Optional external end-user identifier forwarded by the API gateway. |                                                                     |

### Response

**[DeleteSkillResponse](../../Types/Requests/DeleteSkillResponse.md)**

### Errors

| Error Type                             | Status Code                            | Content Type                           |
| -------------------------------------- | -------------------------------------- | -------------------------------------- |
| MeetKai.MKA1.Types.Errors.APIException | 4XX, 5XX                               | \*/\*                                  |

## Content

Download the zip bundle for a skill's default version.

### Example Usage

<!-- UsageSnippet language="csharp" operationID="getSkillContent" method="get" path="/api/v1/llm/skills/{skill_id}/content" -->
```csharp
using MeetKai.MKA1;
using MeetKai.MKA1.Types.Components;

var sdk = new SDK(bearerAuth: "<YOUR_BEARER_TOKEN_HERE>");

var res = await sdk.Llm.Skills.ContentAsync(skillId: "skill_1710000000000_abc123");

// handle response
```

### Parameters

| Parameter                                                           | Type                                                                | Required                                                            | Description                                                         | Example                                                             |
| ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- |
| `SkillId`                                                           | *string*                                                            | :heavy_check_mark:                                                  | N/A                                                                 | skill_1710000000000_abc123                                          |
| `XOnBehalfOf`                                                       | *string*                                                            | :heavy_minus_sign:                                                  | Optional external end-user identifier forwarded by the API gateway. |                                                                     |

### Response

**[GetSkillContentResponse](../../Types/Requests/GetSkillContentResponse.md)**

### Errors

| Error Type                             | Status Code                            | Content Type                           |
| -------------------------------------- | -------------------------------------- | -------------------------------------- |
| MeetKai.MKA1.Types.Errors.APIException | 4XX, 5XX                               | \*/\*                                  |

## CreateVersion

Create a new immutable version of a skill by uploading files. The uploaded files must include a SKILL.md manifest.

### Example Usage

<!-- UsageSnippet language="csharp" operationID="createSkillVersion" method="post" path="/api/v1/llm/skills/{skill_id}/versions" -->
```csharp
using MeetKai.MKA1;
using MeetKai.MKA1.Types.Components;
using MeetKai.MKA1.Types.Requests;

var sdk = new SDK(bearerAuth: "<YOUR_BEARER_TOKEN_HERE>");

var res = await sdk.Llm.Skills.CreateVersionAsync(
    skillId: "skill_1710000000000_abc123",
    body: new CreateSkillVersionRequestBody() {}
);

// handle response
```

### Parameters

| Parameter                                                                              | Type                                                                                   | Required                                                                               | Description                                                                            | Example                                                                                |
| -------------------------------------------------------------------------------------- | -------------------------------------------------------------------------------------- | -------------------------------------------------------------------------------------- | -------------------------------------------------------------------------------------- | -------------------------------------------------------------------------------------- |
| `SkillId`                                                                              | *string*                                                                               | :heavy_check_mark:                                                                     | N/A                                                                                    | skill_1710000000000_abc123                                                             |
| `Body`                                                                                 | [CreateSkillVersionRequestBody](../../Types/Requests/CreateSkillVersionRequestBody.md) | :heavy_check_mark:                                                                     | N/A                                                                                    |                                                                                        |
| `XOnBehalfOf`                                                                          | *string*                                                                               | :heavy_minus_sign:                                                                     | Optional external end-user identifier forwarded by the API gateway.                    |                                                                                        |

### Response

**[CreateSkillVersionResponse](../../Types/Requests/CreateSkillVersionResponse.md)**

### Errors

| Error Type                             | Status Code                            | Content Type                           |
| -------------------------------------- | -------------------------------------- | -------------------------------------- |
| MeetKai.MKA1.Types.Errors.APIException | 4XX, 5XX                               | \*/\*                                  |

## ListVersions

Returns a paginated list of versions for a skill.

### Example Usage

<!-- UsageSnippet language="csharp" operationID="listSkillVersions" method="get" path="/api/v1/llm/skills/{skill_id}/versions" -->
```csharp
using MeetKai.MKA1;
using MeetKai.MKA1.Types.Components;
using MeetKai.MKA1.Types.Requests;

var sdk = new SDK(bearerAuth: "<YOUR_BEARER_TOKEN_HERE>");

ListSkillVersionsRequest req = new ListSkillVersionsRequest() {
    SkillId = "skill_1710000000000_abc123",
};

var res = await sdk.Llm.Skills.ListVersionsAsync(req);

// handle response
```

### Parameters

| Parameter                                                                    | Type                                                                         | Required                                                                     | Description                                                                  |
| ---------------------------------------------------------------------------- | ---------------------------------------------------------------------------- | ---------------------------------------------------------------------------- | ---------------------------------------------------------------------------- |
| `request`                                                                    | [ListSkillVersionsRequest](../../Types/Requests/ListSkillVersionsRequest.md) | :heavy_check_mark:                                                           | The request object to use for the request.                                   |

### Response

**[ListSkillVersionsResponse](../../Types/Requests/ListSkillVersionsResponse.md)**

### Errors

| Error Type                             | Status Code                            | Content Type                           |
| -------------------------------------- | -------------------------------------- | -------------------------------------- |
| MeetKai.MKA1.Types.Errors.APIException | 4XX, 5XX                               | \*/\*                                  |

## GetVersion

Returns information about a specific skill version.

### Example Usage

<!-- UsageSnippet language="csharp" operationID="getSkillVersion" method="get" path="/api/v1/llm/skills/{skill_id}/versions/{version}" -->
```csharp
using MeetKai.MKA1;
using MeetKai.MKA1.Types.Components;

var sdk = new SDK(bearerAuth: "<YOUR_BEARER_TOKEN_HERE>");

var res = await sdk.Llm.Skills.GetVersionAsync(
    skillId: "skill_1710000000000_abc123",
    version: "1"
);

// handle response
```

### Parameters

| Parameter                                                           | Type                                                                | Required                                                            | Description                                                         | Example                                                             |
| ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- |
| `SkillId`                                                           | *string*                                                            | :heavy_check_mark:                                                  | N/A                                                                 | skill_1710000000000_abc123                                          |
| `Version`                                                           | *string*                                                            | :heavy_check_mark:                                                  | N/A                                                                 | 1                                                                   |
| `XOnBehalfOf`                                                       | *string*                                                            | :heavy_minus_sign:                                                  | Optional external end-user identifier forwarded by the API gateway. |                                                                     |

### Response

**[GetSkillVersionResponse](../../Types/Requests/GetSkillVersionResponse.md)**

### Errors

| Error Type                             | Status Code                            | Content Type                           |
| -------------------------------------- | -------------------------------------- | -------------------------------------- |
| MeetKai.MKA1.Types.Errors.APIException | 4XX, 5XX                               | \*/\*                                  |

## DeleteVersion

Delete a specific version of a skill.

### Example Usage

<!-- UsageSnippet language="csharp" operationID="deleteSkillVersion" method="delete" path="/api/v1/llm/skills/{skill_id}/versions/{version}" -->
```csharp
using MeetKai.MKA1;
using MeetKai.MKA1.Types.Components;

var sdk = new SDK(bearerAuth: "<YOUR_BEARER_TOKEN_HERE>");

var res = await sdk.Llm.Skills.DeleteVersionAsync(
    skillId: "skill_1710000000000_abc123",
    version: "1"
);

// handle response
```

### Parameters

| Parameter                                                           | Type                                                                | Required                                                            | Description                                                         | Example                                                             |
| ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- |
| `SkillId`                                                           | *string*                                                            | :heavy_check_mark:                                                  | N/A                                                                 | skill_1710000000000_abc123                                          |
| `Version`                                                           | *string*                                                            | :heavy_check_mark:                                                  | N/A                                                                 | 1                                                                   |
| `XOnBehalfOf`                                                       | *string*                                                            | :heavy_minus_sign:                                                  | Optional external end-user identifier forwarded by the API gateway. |                                                                     |

### Response

**[DeleteSkillVersionResponse](../../Types/Requests/DeleteSkillVersionResponse.md)**

### Errors

| Error Type                             | Status Code                            | Content Type                           |
| -------------------------------------- | -------------------------------------- | -------------------------------------- |
| MeetKai.MKA1.Types.Errors.APIException | 4XX, 5XX                               | \*/\*                                  |

## VersionContent

Download the zip bundle for a specific skill version.

### Example Usage

<!-- UsageSnippet language="csharp" operationID="getSkillVersionContent" method="get" path="/api/v1/llm/skills/{skill_id}/versions/{version}/content" -->
```csharp
using MeetKai.MKA1;
using MeetKai.MKA1.Types.Components;

var sdk = new SDK(bearerAuth: "<YOUR_BEARER_TOKEN_HERE>");

var res = await sdk.Llm.Skills.VersionContentAsync(
    skillId: "skill_1710000000000_abc123",
    version: "1"
);

// handle response
```

### Parameters

| Parameter                                                           | Type                                                                | Required                                                            | Description                                                         | Example                                                             |
| ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- |
| `SkillId`                                                           | *string*                                                            | :heavy_check_mark:                                                  | N/A                                                                 | skill_1710000000000_abc123                                          |
| `Version`                                                           | *string*                                                            | :heavy_check_mark:                                                  | N/A                                                                 | 1                                                                   |
| `XOnBehalfOf`                                                       | *string*                                                            | :heavy_minus_sign:                                                  | Optional external end-user identifier forwarded by the API gateway. |                                                                     |

### Response

**[GetSkillVersionContentResponse](../../Types/Requests/GetSkillVersionContentResponse.md)**

### Errors

| Error Type                             | Status Code                            | Content Type                           |
| -------------------------------------- | -------------------------------------- | -------------------------------------- |
| MeetKai.MKA1.Types.Errors.APIException | 4XX, 5XX                               | \*/\*                                  |

## ListPreconfigured

Returns the list of preconfigured skills that ship with the gateway. These can be referenced in shell tool definitions as { type: 'preconfigured', name: '...' }.

### Example Usage

<!-- UsageSnippet language="csharp" operationID="listPreconfiguredSkills" method="get" path="/api/v1/llm/skills/preconfigured" -->
```csharp
using MeetKai.MKA1;
using MeetKai.MKA1.Types.Components;

var sdk = new SDK(bearerAuth: "<YOUR_BEARER_TOKEN_HERE>");

var res = await sdk.Llm.Skills.ListPreconfiguredAsync();

// handle response
```

### Parameters

| Parameter                                                           | Type                                                                | Required                                                            | Description                                                         |
| ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- |
| `XOnBehalfOf`                                                       | *string*                                                            | :heavy_minus_sign:                                                  | Optional external end-user identifier forwarded by the API gateway. |

### Response

**[ListPreconfiguredSkillsResponse](../../Types/Requests/ListPreconfiguredSkillsResponse.md)**

### Errors

| Error Type                             | Status Code                            | Content Type                           |
| -------------------------------------- | -------------------------------------- | -------------------------------------- |
| MeetKai.MKA1.Types.Errors.APIException | 4XX, 5XX                               | \*/\*                                  |