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
* [ListPermissions](#listpermissions) - List skill permissions
* [CreatePermission](#createpermission) - Grant a skill permission
* [GetPermission](#getpermission) - Retrieve a skill permission
* [DeletePermission](#deletepermission) - Remove a skill permission

## Create

Create a new skill by uploading files. The uploaded files must include a SKILL.md manifest. Accepts multipart form data with individual files or a single zip archive.

### Example Usage

<!-- UsageSnippet language="go" operationID="createSkill" method="post" path="/api/v1/llm/skills" -->
```go
package main

import(
	"context"
	mka1 "github.com/MeetKai/mka1-sdks/go"
	"github.com/MeetKai/mka1-sdks/go/models/operations"
	"log"
)

func main() {
    ctx := context.Background()

    s := mka1.New(
        mka1.WithSecurity("<YOUR_BEARER_TOKEN_HERE>"),
    )

    res, err := s.Llm.Skills.Create(ctx, operations.CreateSkillRequestBody{}, nil)
    if err != nil {
        log.Fatal(err)
    }
    if res.Skill != nil {
        // handle response
    }
}
```

### Parameters

| Parameter                                                                              | Type                                                                                   | Required                                                                               | Description                                                                            |
| -------------------------------------------------------------------------------------- | -------------------------------------------------------------------------------------- | -------------------------------------------------------------------------------------- | -------------------------------------------------------------------------------------- |
| `ctx`                                                                                  | [context.Context](https://pkg.go.dev/context#Context)                                  | :heavy_check_mark:                                                                     | The context to use for the request.                                                    |
| `body`                                                                                 | [operations.CreateSkillRequestBody](../../models/operations/createskillrequestbody.md) | :heavy_check_mark:                                                                     | N/A                                                                                    |
| `xOnBehalfOf`                                                                          | `*string`                                                                              | :heavy_minus_sign:                                                                     | Optional external end-user identifier forwarded by the API gateway.                    |
| `opts`                                                                                 | [][operations.Option](../../models/operations/option.md)                               | :heavy_minus_sign:                                                                     | The options for this request.                                                          |

### Response

**[*operations.CreateSkillResponse](../../models/operations/createskillresponse.md), error**

### Errors

| Error Type         | Status Code        | Content Type       |
| ------------------ | ------------------ | ------------------ |
| apierrors.APIError | 4XX, 5XX           | \*/\*              |

## List

Returns a paginated list of skills.

### Example Usage

<!-- UsageSnippet language="go" operationID="listSkills" method="get" path="/api/v1/llm/skills" -->
```go
package main

import(
	"context"
	mka1 "github.com/MeetKai/mka1-sdks/go"
	"github.com/MeetKai/mka1-sdks/go/models/operations"
	"log"
)

func main() {
    ctx := context.Background()

    s := mka1.New(
        mka1.WithSecurity("<YOUR_BEARER_TOKEN_HERE>"),
    )

    res, err := s.Llm.Skills.List(ctx, nil, mka1.Pointer[int64](20), operations.ListSkillsOrderDesc.ToPointer(), nil)
    if err != nil {
        log.Fatal(err)
    }
    if res.SkillList != nil {
        // handle response
    }
}
```

### Parameters

| Parameter                                                                 | Type                                                                      | Required                                                                  | Description                                                               | Example                                                                   |
| ------------------------------------------------------------------------- | ------------------------------------------------------------------------- | ------------------------------------------------------------------------- | ------------------------------------------------------------------------- | ------------------------------------------------------------------------- |
| `ctx`                                                                     | [context.Context](https://pkg.go.dev/context#Context)                     | :heavy_check_mark:                                                        | The context to use for the request.                                       |                                                                           |
| `after`                                                                   | `*string`                                                                 | :heavy_minus_sign:                                                        | N/A                                                                       |                                                                           |
| `limit`                                                                   | `*int64`                                                                  | :heavy_minus_sign:                                                        | N/A                                                                       | 20                                                                        |
| `order`                                                                   | [*operations.ListSkillsOrder](../../models/operations/listskillsorder.md) | :heavy_minus_sign:                                                        | N/A                                                                       | desc                                                                      |
| `xOnBehalfOf`                                                             | `*string`                                                                 | :heavy_minus_sign:                                                        | Optional external end-user identifier forwarded by the API gateway.       |                                                                           |
| `opts`                                                                    | [][operations.Option](../../models/operations/option.md)                  | :heavy_minus_sign:                                                        | The options for this request.                                             |                                                                           |

### Response

**[*operations.ListSkillsResponse](../../models/operations/listskillsresponse.md), error**

### Errors

| Error Type         | Status Code        | Content Type       |
| ------------------ | ------------------ | ------------------ |
| apierrors.APIError | 4XX, 5XX           | \*/\*              |

## Get

Returns information about a specific skill.

### Example Usage

<!-- UsageSnippet language="go" operationID="getSkill" method="get" path="/api/v1/llm/skills/{skill_id}" -->
```go
package main

import(
	"context"
	mka1 "github.com/MeetKai/mka1-sdks/go"
	"log"
)

func main() {
    ctx := context.Background()

    s := mka1.New(
        mka1.WithSecurity("<YOUR_BEARER_TOKEN_HERE>"),
    )

    res, err := s.Llm.Skills.Get(ctx, "skill_1710000000000_abc123", nil)
    if err != nil {
        log.Fatal(err)
    }
    if res.Skill != nil {
        // handle response
    }
}
```

### Parameters

| Parameter                                                           | Type                                                                | Required                                                            | Description                                                         | Example                                                             |
| ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- |
| `ctx`                                                               | [context.Context](https://pkg.go.dev/context#Context)               | :heavy_check_mark:                                                  | The context to use for the request.                                 |                                                                     |
| `skillID`                                                           | `string`                                                            | :heavy_check_mark:                                                  | N/A                                                                 | skill_1710000000000_abc123                                          |
| `xOnBehalfOf`                                                       | `*string`                                                           | :heavy_minus_sign:                                                  | Optional external end-user identifier forwarded by the API gateway. |                                                                     |
| `opts`                                                              | [][operations.Option](../../models/operations/option.md)            | :heavy_minus_sign:                                                  | The options for this request.                                       |                                                                     |

### Response

**[*operations.GetSkillResponse](../../models/operations/getskillresponse.md), error**

### Errors

| Error Type         | Status Code        | Content Type       |
| ------------------ | ------------------ | ------------------ |
| apierrors.APIError | 4XX, 5XX           | \*/\*              |

## Update

Update the default version pointer for a skill.

### Example Usage

<!-- UsageSnippet language="go" operationID="updateSkill" method="post" path="/api/v1/llm/skills/{skill_id}" -->
```go
package main

import(
	"context"
	mka1 "github.com/MeetKai/mka1-sdks/go"
	"github.com/MeetKai/mka1-sdks/go/models/components"
	"log"
)

func main() {
    ctx := context.Background()

    s := mka1.New(
        mka1.WithSecurity("<YOUR_BEARER_TOKEN_HERE>"),
    )

    res, err := s.Llm.Skills.Update(ctx, "skill_1710000000000_abc123", components.SkillUpdateRequest{
        DefaultVersion: "2",
    }, nil)
    if err != nil {
        log.Fatal(err)
    }
    if res.Skill != nil {
        // handle response
    }
}
```

### Parameters

| Parameter                                                                      | Type                                                                           | Required                                                                       | Description                                                                    | Example                                                                        |
| ------------------------------------------------------------------------------ | ------------------------------------------------------------------------------ | ------------------------------------------------------------------------------ | ------------------------------------------------------------------------------ | ------------------------------------------------------------------------------ |
| `ctx`                                                                          | [context.Context](https://pkg.go.dev/context#Context)                          | :heavy_check_mark:                                                             | The context to use for the request.                                            |                                                                                |
| `skillID`                                                                      | `string`                                                                       | :heavy_check_mark:                                                             | N/A                                                                            | skill_1710000000000_abc123                                                     |
| `body`                                                                         | [components.SkillUpdateRequest](../../models/components/skillupdaterequest.md) | :heavy_check_mark:                                                             | N/A                                                                            |                                                                                |
| `xOnBehalfOf`                                                                  | `*string`                                                                      | :heavy_minus_sign:                                                             | Optional external end-user identifier forwarded by the API gateway.            |                                                                                |
| `opts`                                                                         | [][operations.Option](../../models/operations/option.md)                       | :heavy_minus_sign:                                                             | The options for this request.                                                  |                                                                                |

### Response

**[*operations.UpdateSkillResponse](../../models/operations/updateskillresponse.md), error**

### Errors

| Error Type         | Status Code        | Content Type       |
| ------------------ | ------------------ | ------------------ |
| apierrors.APIError | 4XX, 5XX           | \*/\*              |

## Delete

Delete a skill and all its versions.

### Example Usage

<!-- UsageSnippet language="go" operationID="deleteSkill" method="delete" path="/api/v1/llm/skills/{skill_id}" -->
```go
package main

import(
	"context"
	mka1 "github.com/MeetKai/mka1-sdks/go"
	"log"
)

func main() {
    ctx := context.Background()

    s := mka1.New(
        mka1.WithSecurity("<YOUR_BEARER_TOKEN_HERE>"),
    )

    res, err := s.Llm.Skills.Delete(ctx, "skill_1710000000000_abc123", nil)
    if err != nil {
        log.Fatal(err)
    }
    if res.DeletedSkill != nil {
        // handle response
    }
}
```

### Parameters

| Parameter                                                           | Type                                                                | Required                                                            | Description                                                         | Example                                                             |
| ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- |
| `ctx`                                                               | [context.Context](https://pkg.go.dev/context#Context)               | :heavy_check_mark:                                                  | The context to use for the request.                                 |                                                                     |
| `skillID`                                                           | `string`                                                            | :heavy_check_mark:                                                  | N/A                                                                 | skill_1710000000000_abc123                                          |
| `xOnBehalfOf`                                                       | `*string`                                                           | :heavy_minus_sign:                                                  | Optional external end-user identifier forwarded by the API gateway. |                                                                     |
| `opts`                                                              | [][operations.Option](../../models/operations/option.md)            | :heavy_minus_sign:                                                  | The options for this request.                                       |                                                                     |

### Response

**[*operations.DeleteSkillResponse](../../models/operations/deleteskillresponse.md), error**

### Errors

| Error Type         | Status Code        | Content Type       |
| ------------------ | ------------------ | ------------------ |
| apierrors.APIError | 4XX, 5XX           | \*/\*              |

## Content

Download the zip bundle for a skill's default version.

### Example Usage

<!-- UsageSnippet language="go" operationID="getSkillContent" method="get" path="/api/v1/llm/skills/{skill_id}/content" -->
```go
package main

import(
	"context"
	mka1 "github.com/MeetKai/mka1-sdks/go"
	"log"
)

func main() {
    ctx := context.Background()

    s := mka1.New(
        mka1.WithSecurity("<YOUR_BEARER_TOKEN_HERE>"),
    )

    res, err := s.Llm.Skills.Content(ctx, "skill_1710000000000_abc123", nil)
    if err != nil {
        log.Fatal(err)
    }
    if res.ResponseStream != nil {
        // handle response
    }
}
```

### Parameters

| Parameter                                                           | Type                                                                | Required                                                            | Description                                                         | Example                                                             |
| ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- |
| `ctx`                                                               | [context.Context](https://pkg.go.dev/context#Context)               | :heavy_check_mark:                                                  | The context to use for the request.                                 |                                                                     |
| `skillID`                                                           | `string`                                                            | :heavy_check_mark:                                                  | N/A                                                                 | skill_1710000000000_abc123                                          |
| `xOnBehalfOf`                                                       | `*string`                                                           | :heavy_minus_sign:                                                  | Optional external end-user identifier forwarded by the API gateway. |                                                                     |
| `opts`                                                              | [][operations.Option](../../models/operations/option.md)            | :heavy_minus_sign:                                                  | The options for this request.                                       |                                                                     |

### Response

**[*operations.GetSkillContentResponse](../../models/operations/getskillcontentresponse.md), error**

### Errors

| Error Type         | Status Code        | Content Type       |
| ------------------ | ------------------ | ------------------ |
| apierrors.APIError | 4XX, 5XX           | \*/\*              |

## CreateVersion

Create a new immutable version of a skill by uploading files. The uploaded files must include a SKILL.md manifest.

### Example Usage

<!-- UsageSnippet language="go" operationID="createSkillVersion" method="post" path="/api/v1/llm/skills/{skill_id}/versions" -->
```go
package main

import(
	"context"
	mka1 "github.com/MeetKai/mka1-sdks/go"
	"github.com/MeetKai/mka1-sdks/go/models/operations"
	"log"
)

func main() {
    ctx := context.Background()

    s := mka1.New(
        mka1.WithSecurity("<YOUR_BEARER_TOKEN_HERE>"),
    )

    res, err := s.Llm.Skills.CreateVersion(ctx, "skill_1710000000000_abc123", operations.CreateSkillVersionRequestBody{}, nil)
    if err != nil {
        log.Fatal(err)
    }
    if res.SkillVersion != nil {
        // handle response
    }
}
```

### Parameters

| Parameter                                                                                            | Type                                                                                                 | Required                                                                                             | Description                                                                                          | Example                                                                                              |
| ---------------------------------------------------------------------------------------------------- | ---------------------------------------------------------------------------------------------------- | ---------------------------------------------------------------------------------------------------- | ---------------------------------------------------------------------------------------------------- | ---------------------------------------------------------------------------------------------------- |
| `ctx`                                                                                                | [context.Context](https://pkg.go.dev/context#Context)                                                | :heavy_check_mark:                                                                                   | The context to use for the request.                                                                  |                                                                                                      |
| `skillID`                                                                                            | `string`                                                                                             | :heavy_check_mark:                                                                                   | N/A                                                                                                  | skill_1710000000000_abc123                                                                           |
| `body`                                                                                               | [operations.CreateSkillVersionRequestBody](../../models/operations/createskillversionrequestbody.md) | :heavy_check_mark:                                                                                   | N/A                                                                                                  |                                                                                                      |
| `xOnBehalfOf`                                                                                        | `*string`                                                                                            | :heavy_minus_sign:                                                                                   | Optional external end-user identifier forwarded by the API gateway.                                  |                                                                                                      |
| `opts`                                                                                               | [][operations.Option](../../models/operations/option.md)                                             | :heavy_minus_sign:                                                                                   | The options for this request.                                                                        |                                                                                                      |

### Response

**[*operations.CreateSkillVersionResponse](../../models/operations/createskillversionresponse.md), error**

### Errors

| Error Type         | Status Code        | Content Type       |
| ------------------ | ------------------ | ------------------ |
| apierrors.APIError | 4XX, 5XX           | \*/\*              |

## ListVersions

Returns a paginated list of versions for a skill.

### Example Usage

<!-- UsageSnippet language="go" operationID="listSkillVersions" method="get" path="/api/v1/llm/skills/{skill_id}/versions" -->
```go
package main

import(
	"context"
	mka1 "github.com/MeetKai/mka1-sdks/go"
	"github.com/MeetKai/mka1-sdks/go/models/operations"
	"log"
)

func main() {
    ctx := context.Background()

    s := mka1.New(
        mka1.WithSecurity("<YOUR_BEARER_TOKEN_HERE>"),
    )

    res, err := s.Llm.Skills.ListVersions(ctx, operations.ListSkillVersionsRequest{
        SkillID: "skill_1710000000000_abc123",
    })
    if err != nil {
        log.Fatal(err)
    }
    if res.SkillVersionList != nil {
        // handle response
    }
}
```

### Parameters

| Parameter                                                                                  | Type                                                                                       | Required                                                                                   | Description                                                                                |
| ------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------ |
| `ctx`                                                                                      | [context.Context](https://pkg.go.dev/context#Context)                                      | :heavy_check_mark:                                                                         | The context to use for the request.                                                        |
| `request`                                                                                  | [operations.ListSkillVersionsRequest](../../models/operations/listskillversionsrequest.md) | :heavy_check_mark:                                                                         | The request object to use for the request.                                                 |
| `opts`                                                                                     | [][operations.Option](../../models/operations/option.md)                                   | :heavy_minus_sign:                                                                         | The options for this request.                                                              |

### Response

**[*operations.ListSkillVersionsResponse](../../models/operations/listskillversionsresponse.md), error**

### Errors

| Error Type         | Status Code        | Content Type       |
| ------------------ | ------------------ | ------------------ |
| apierrors.APIError | 4XX, 5XX           | \*/\*              |

## GetVersion

Returns information about a specific skill version.

### Example Usage

<!-- UsageSnippet language="go" operationID="getSkillVersion" method="get" path="/api/v1/llm/skills/{skill_id}/versions/{version}" -->
```go
package main

import(
	"context"
	mka1 "github.com/MeetKai/mka1-sdks/go"
	"log"
)

func main() {
    ctx := context.Background()

    s := mka1.New(
        mka1.WithSecurity("<YOUR_BEARER_TOKEN_HERE>"),
    )

    res, err := s.Llm.Skills.GetVersion(ctx, "skill_1710000000000_abc123", "1", nil)
    if err != nil {
        log.Fatal(err)
    }
    if res.SkillVersion != nil {
        // handle response
    }
}
```

### Parameters

| Parameter                                                           | Type                                                                | Required                                                            | Description                                                         | Example                                                             |
| ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- |
| `ctx`                                                               | [context.Context](https://pkg.go.dev/context#Context)               | :heavy_check_mark:                                                  | The context to use for the request.                                 |                                                                     |
| `skillID`                                                           | `string`                                                            | :heavy_check_mark:                                                  | N/A                                                                 | skill_1710000000000_abc123                                          |
| `version`                                                           | `string`                                                            | :heavy_check_mark:                                                  | N/A                                                                 | 1                                                                   |
| `xOnBehalfOf`                                                       | `*string`                                                           | :heavy_minus_sign:                                                  | Optional external end-user identifier forwarded by the API gateway. |                                                                     |
| `opts`                                                              | [][operations.Option](../../models/operations/option.md)            | :heavy_minus_sign:                                                  | The options for this request.                                       |                                                                     |

### Response

**[*operations.GetSkillVersionResponse](../../models/operations/getskillversionresponse.md), error**

### Errors

| Error Type         | Status Code        | Content Type       |
| ------------------ | ------------------ | ------------------ |
| apierrors.APIError | 4XX, 5XX           | \*/\*              |

## DeleteVersion

Delete a specific version of a skill.

### Example Usage

<!-- UsageSnippet language="go" operationID="deleteSkillVersion" method="delete" path="/api/v1/llm/skills/{skill_id}/versions/{version}" -->
```go
package main

import(
	"context"
	mka1 "github.com/MeetKai/mka1-sdks/go"
	"log"
)

func main() {
    ctx := context.Background()

    s := mka1.New(
        mka1.WithSecurity("<YOUR_BEARER_TOKEN_HERE>"),
    )

    res, err := s.Llm.Skills.DeleteVersion(ctx, "skill_1710000000000_abc123", "1", nil)
    if err != nil {
        log.Fatal(err)
    }
    if res.DeletedSkillVersion != nil {
        // handle response
    }
}
```

### Parameters

| Parameter                                                           | Type                                                                | Required                                                            | Description                                                         | Example                                                             |
| ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- |
| `ctx`                                                               | [context.Context](https://pkg.go.dev/context#Context)               | :heavy_check_mark:                                                  | The context to use for the request.                                 |                                                                     |
| `skillID`                                                           | `string`                                                            | :heavy_check_mark:                                                  | N/A                                                                 | skill_1710000000000_abc123                                          |
| `version`                                                           | `string`                                                            | :heavy_check_mark:                                                  | N/A                                                                 | 1                                                                   |
| `xOnBehalfOf`                                                       | `*string`                                                           | :heavy_minus_sign:                                                  | Optional external end-user identifier forwarded by the API gateway. |                                                                     |
| `opts`                                                              | [][operations.Option](../../models/operations/option.md)            | :heavy_minus_sign:                                                  | The options for this request.                                       |                                                                     |

### Response

**[*operations.DeleteSkillVersionResponse](../../models/operations/deleteskillversionresponse.md), error**

### Errors

| Error Type         | Status Code        | Content Type       |
| ------------------ | ------------------ | ------------------ |
| apierrors.APIError | 4XX, 5XX           | \*/\*              |

## VersionContent

Download the zip bundle for a specific skill version.

### Example Usage

<!-- UsageSnippet language="go" operationID="getSkillVersionContent" method="get" path="/api/v1/llm/skills/{skill_id}/versions/{version}/content" -->
```go
package main

import(
	"context"
	mka1 "github.com/MeetKai/mka1-sdks/go"
	"log"
)

func main() {
    ctx := context.Background()

    s := mka1.New(
        mka1.WithSecurity("<YOUR_BEARER_TOKEN_HERE>"),
    )

    res, err := s.Llm.Skills.VersionContent(ctx, "skill_1710000000000_abc123", "1", nil)
    if err != nil {
        log.Fatal(err)
    }
    if res.ResponseStream != nil {
        // handle response
    }
}
```

### Parameters

| Parameter                                                           | Type                                                                | Required                                                            | Description                                                         | Example                                                             |
| ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- |
| `ctx`                                                               | [context.Context](https://pkg.go.dev/context#Context)               | :heavy_check_mark:                                                  | The context to use for the request.                                 |                                                                     |
| `skillID`                                                           | `string`                                                            | :heavy_check_mark:                                                  | N/A                                                                 | skill_1710000000000_abc123                                          |
| `version`                                                           | `string`                                                            | :heavy_check_mark:                                                  | N/A                                                                 | 1                                                                   |
| `xOnBehalfOf`                                                       | `*string`                                                           | :heavy_minus_sign:                                                  | Optional external end-user identifier forwarded by the API gateway. |                                                                     |
| `opts`                                                              | [][operations.Option](../../models/operations/option.md)            | :heavy_minus_sign:                                                  | The options for this request.                                       |                                                                     |

### Response

**[*operations.GetSkillVersionContentResponse](../../models/operations/getskillversioncontentresponse.md), error**

### Errors

| Error Type         | Status Code        | Content Type       |
| ------------------ | ------------------ | ------------------ |
| apierrors.APIError | 4XX, 5XX           | \*/\*              |

## ListPreconfigured

Returns the list of preconfigured skills that ship with the gateway. These can be referenced in shell tool definitions as { type: 'preconfigured', name: '...' }.

### Example Usage

<!-- UsageSnippet language="go" operationID="listPreconfiguredSkills" method="get" path="/api/v1/llm/skills/preconfigured" -->
```go
package main

import(
	"context"
	mka1 "github.com/MeetKai/mka1-sdks/go"
	"log"
)

func main() {
    ctx := context.Background()

    s := mka1.New(
        mka1.WithSecurity("<YOUR_BEARER_TOKEN_HERE>"),
    )

    res, err := s.Llm.Skills.ListPreconfigured(ctx, nil)
    if err != nil {
        log.Fatal(err)
    }
    if res.PreconfiguredSkillList != nil {
        // handle response
    }
}
```

### Parameters

| Parameter                                                           | Type                                                                | Required                                                            | Description                                                         |
| ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- |
| `ctx`                                                               | [context.Context](https://pkg.go.dev/context#Context)               | :heavy_check_mark:                                                  | The context to use for the request.                                 |
| `xOnBehalfOf`                                                       | `*string`                                                           | :heavy_minus_sign:                                                  | Optional external end-user identifier forwarded by the API gateway. |
| `opts`                                                              | [][operations.Option](../../models/operations/option.md)            | :heavy_minus_sign:                                                  | The options for this request.                                       |

### Response

**[*operations.ListPreconfiguredSkillsResponse](../../models/operations/listpreconfiguredskillsresponse.md), error**

### Errors

| Error Type         | Status Code        | Content Type       |
| ------------------ | ------------------ | ------------------ |
| apierrors.APIError | 4XX, 5XX           | \*/\*              |

## ListPermissions

Lists who holds a role on the skill: its owner, then its team when that permission is set, then individual principals. Only the skill's owner or an organization admin of its team can list them (403 otherwise). Organization admins of the skill's team can always read it and are not listed.

### Example Usage

<!-- UsageSnippet language="go" operationID="listSkillPermissions" method="get" path="/api/v1/llm/skills/{skill_id}/permissions" -->
```go
package main

import(
	"context"
	mka1 "github.com/MeetKai/mka1-sdks/go"
	"log"
)

func main() {
    ctx := context.Background()

    s := mka1.New(
        mka1.WithSecurity("<YOUR_BEARER_TOKEN_HERE>"),
    )

    res, err := s.Llm.Skills.ListPermissions(ctx, "skill_1710000000000_abc123", nil)
    if err != nil {
        log.Fatal(err)
    }
    if res.SkillPermissionList != nil {
        // handle response
    }
}
```

### Parameters

| Parameter                                                           | Type                                                                | Required                                                            | Description                                                         | Example                                                             |
| ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- |
| `ctx`                                                               | [context.Context](https://pkg.go.dev/context#Context)               | :heavy_check_mark:                                                  | The context to use for the request.                                 |                                                                     |
| `skillID`                                                           | `string`                                                            | :heavy_check_mark:                                                  | N/A                                                                 | skill_1710000000000_abc123                                          |
| `xOnBehalfOf`                                                       | `*string`                                                           | :heavy_minus_sign:                                                  | Optional external end-user identifier forwarded by the API gateway. |                                                                     |
| `opts`                                                              | [][operations.Option](../../models/operations/option.md)            | :heavy_minus_sign:                                                  | The options for this request.                                       |                                                                     |

### Response

**[*operations.ListSkillPermissionsResponse](../../models/operations/listskillpermissionsresponse.md), error**

### Errors

| Error Type         | Status Code        | Content Type       |
| ------------------ | ------------------ | ------------------ |
| apierrors.APIError | 4XX, 5XX           | \*/\*              |

## CreatePermission

Grants `reader` or `writer` on the skill to one principal, or to every member of the skill's team (`grantee_type: team`), replacing any role that principal already held. Only the skill's owner or an organization admin of its team can grant (403 otherwise). The owner's role is fixed at creation and cannot be granted or changed. The `user_id` is not checked against a directory: an id that names no member of the organization is stored as an end-user id, so a mistyped id is accepted and listed until it is removed.

### Example Usage

<!-- UsageSnippet language="go" operationID="createSkillPermission" method="post" path="/api/v1/llm/skills/{skill_id}/permissions" -->
```go
package main

import(
	"context"
	mka1 "github.com/MeetKai/mka1-sdks/go"
	"github.com/MeetKai/mka1-sdks/go/models/components"
	"log"
)

func main() {
    ctx := context.Background()

    s := mka1.New(
        mka1.WithSecurity("<YOUR_BEARER_TOKEN_HERE>"),
    )

    res, err := s.Llm.Skills.CreatePermission(ctx, "skill_1710000000000_abc123", components.CreateCreateResourcePermissionRequestUnionUser(
        components.CreateResourcePermissionRequest1{
            UserID: "<id>",
            Role: components.GrantableResourcePermissionRoleWriter,
        },
    ), nil)
    if err != nil {
        log.Fatal(err)
    }
    if res.SkillPermission != nil {
        // handle response
    }
}
```

### Parameters

| Parameter                                                                                                          | Type                                                                                                               | Required                                                                                                           | Description                                                                                                        | Example                                                                                                            |
| ------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------ |
| `ctx`                                                                                                              | [context.Context](https://pkg.go.dev/context#Context)                                                              | :heavy_check_mark:                                                                                                 | The context to use for the request.                                                                                |                                                                                                                    |
| `skillID`                                                                                                          | `string`                                                                                                           | :heavy_check_mark:                                                                                                 | N/A                                                                                                                | skill_1710000000000_abc123                                                                                         |
| `body`                                                                                                             | [components.CreateResourcePermissionRequestUnion](../../models/components/createresourcepermissionrequestunion.md) | :heavy_check_mark:                                                                                                 | N/A                                                                                                                |                                                                                                                    |
| `xOnBehalfOf`                                                                                                      | `*string`                                                                                                          | :heavy_minus_sign:                                                                                                 | Optional external end-user identifier forwarded by the API gateway.                                                |                                                                                                                    |
| `opts`                                                                                                             | [][operations.Option](../../models/operations/option.md)                                                           | :heavy_minus_sign:                                                                                                 | The options for this request.                                                                                      |                                                                                                                    |

### Response

**[*operations.CreateSkillPermissionResponse](../../models/operations/createskillpermissionresponse.md), error**

### Errors

| Error Type         | Status Code        | Content Type       |
| ------------------ | ------------------ | ------------------ |
| apierrors.APIError | 4XX, 5XX           | \*/\*              |

## GetPermission

Returns the role a principal effectively holds on the skill and where it comes from: `owner`, a permission granted to it (`grant`), the skill's `team` permission, or `none`. A principal with `none` can still reach the skill as an organization admin of its team; that is decided per request from the caller's role. Only the skill's owner or an organization admin of its team can call this (403 otherwise).

### Example Usage

<!-- UsageSnippet language="go" operationID="getSkillPermission" method="get" path="/api/v1/llm/skills/{skill_id}/permissions/{user_id}" -->
```go
package main

import(
	"context"
	mka1 "github.com/MeetKai/mka1-sdks/go"
	"log"
)

func main() {
    ctx := context.Background()

    s := mka1.New(
        mka1.WithSecurity("<YOUR_BEARER_TOKEN_HERE>"),
    )

    res, err := s.Llm.Skills.GetPermission(ctx, "skill_1710000000000_abc123", "user_8f2c1", nil)
    if err != nil {
        log.Fatal(err)
    }
    if res.SkillEffectivePermission != nil {
        // handle response
    }
}
```

### Parameters

| Parameter                                                           | Type                                                                | Required                                                            | Description                                                         | Example                                                             |
| ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- |
| `ctx`                                                               | [context.Context](https://pkg.go.dev/context#Context)               | :heavy_check_mark:                                                  | The context to use for the request.                                 |                                                                     |
| `skillID`                                                           | `string`                                                            | :heavy_check_mark:                                                  | N/A                                                                 | skill_1710000000000_abc123                                          |
| `userID`                                                            | `string`                                                            | :heavy_check_mark:                                                  | N/A                                                                 | user_8f2c1                                                          |
| `xOnBehalfOf`                                                       | `*string`                                                           | :heavy_minus_sign:                                                  | Optional external end-user identifier forwarded by the API gateway. |                                                                     |
| `opts`                                                              | [][operations.Option](../../models/operations/option.md)            | :heavy_minus_sign:                                                  | The options for this request.                                       |                                                                     |

### Response

**[*operations.GetSkillPermissionResponse](../../models/operations/getskillpermissionresponse.md), error**

### Errors

| Error Type         | Status Code        | Content Type       |
| ------------------ | ------------------ | ------------------ |
| apierrors.APIError | 4XX, 5XX           | \*/\*              |

## DeletePermission

Removes every role the principal holds on the skill, or the `team` permission. Only the skill's owner or an organization admin of its team can remove permissions (403 otherwise); the owner's own permission cannot be removed. 404 when the principal holds no permission.

### Example Usage

<!-- UsageSnippet language="go" operationID="deleteSkillPermission" method="delete" path="/api/v1/llm/skills/{skill_id}/permissions/{user_id}" -->
```go
package main

import(
	"context"
	mka1 "github.com/MeetKai/mka1-sdks/go"
	"log"
)

func main() {
    ctx := context.Background()

    s := mka1.New(
        mka1.WithSecurity("<YOUR_BEARER_TOKEN_HERE>"),
    )

    res, err := s.Llm.Skills.DeletePermission(ctx, "skill_1710000000000_abc123", "user_8f2c1", nil)
    if err != nil {
        log.Fatal(err)
    }
    if res.SkillPermissionDeleted != nil {
        // handle response
    }
}
```

### Parameters

| Parameter                                                           | Type                                                                | Required                                                            | Description                                                         | Example                                                             |
| ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- |
| `ctx`                                                               | [context.Context](https://pkg.go.dev/context#Context)               | :heavy_check_mark:                                                  | The context to use for the request.                                 |                                                                     |
| `skillID`                                                           | `string`                                                            | :heavy_check_mark:                                                  | N/A                                                                 | skill_1710000000000_abc123                                          |
| `userID`                                                            | `string`                                                            | :heavy_check_mark:                                                  | N/A                                                                 | user_8f2c1                                                          |
| `xOnBehalfOf`                                                       | `*string`                                                           | :heavy_minus_sign:                                                  | Optional external end-user identifier forwarded by the API gateway. |                                                                     |
| `opts`                                                              | [][operations.Option](../../models/operations/option.md)            | :heavy_minus_sign:                                                  | The options for this request.                                       |                                                                     |

### Response

**[*operations.DeleteSkillPermissionResponse](../../models/operations/deleteskillpermissionresponse.md), error**

### Errors

| Error Type         | Status Code        | Content Type       |
| ------------------ | ------------------ | ------------------ |
| apierrors.APIError | 4XX, 5XX           | \*/\*              |