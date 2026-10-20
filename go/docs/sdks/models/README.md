# Llm.Models

## Overview

### Available Operations

* [List](#list) - List available models
* [Get](#get) - Retrieve a model
* [GetQuota](#getquota) - Read a model's token quota
* [ListCatalog](#listcatalog) - List the organization's model catalog
* [AddCatalogEntry](#addcatalogentry) - Define a BYO catalog model
* [UpdateCatalogEntry](#updatecatalogentry) - Update a BYO catalog model
* [DeleteCatalogEntry](#deletecatalogentry) - Remove a BYO catalog model
* [CheckCatalogHealth](#checkcataloghealth) - Check a BYO catalog model's health
* [ListCatalogOrgAccess](#listcatalogorgaccess) - List an organization's cluster model access
* [AddCatalogOrgAccess](#addcatalogorgaccess) - Add cluster model access for an organization
* [ReplaceCatalogOrgAccess](#replacecatalogorgaccess) - Replace an organization's cluster model access
* [ListCatalogModelAccess](#listcatalogmodelaccess) - List organizations with access to a cluster model
* [ListRegistry](#listregistry) - List the organization's active model registry
* [ActivateRegistryEntry](#activateregistryentry) - Activate a catalog entry
* [DeactivateRegistryEntry](#deactivateregistryentry) - Deactivate a model registry name
* [ListOrgAutoModels](#listorgautomodels) - List this org's auto-model overrides
* [PutOrgAutoModel](#putorgautomodel) - Set this org's auto policy for an endpoint
* [DeleteOrgAutoModel](#deleteorgautomodel) - Clear this org's auto-model override for an endpoint
* [GetClusterCurrency](#getclustercurrency) - Get the cluster currency
* [SetClusterCurrency](#setclustercurrency) - Set the cluster currency
* [ListClusterPrices](#listclusterprices) - List cluster-default model prices
* [SetClusterPrice](#setclusterprice) - Set a cluster-default model price
* [ClearClusterPrice](#clearclusterprice) - Clear a cluster-default model price
* [ListOrgPrices](#listorgprices) - List an org's price overrides
* [SetOrgPrice](#setorgprice) - Set an org price override
* [ClearOrgPrice](#clearorgprice) - Clear an org price override
* [ListEffectivePrices](#listeffectiveprices) - List effective prices for the caller's models

## List

Lists the currently available models. Provides basic information about each model including its ID and owner.

### Example Usage

<!-- UsageSnippet language="go" operationID="listModels" method="get" path="/api/v1/llm/models" -->
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

    res, err := s.Llm.Models.List(ctx, nil)
    if err != nil {
        log.Fatal(err)
    }
    if res.Object != nil {
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

**[*operations.ListModelsResponse](../../models/operations/listmodelsresponse.md), error**

### Errors

| Error Type         | Status Code        | Content Type       |
| ------------------ | ------------------ | ------------------ |
| apierrors.APIError | 4XX, 5XX           | \*/\*              |

## Get

Retrieves a model instance, providing basic information about the model such as the owner and supported capabilities.

### Example Usage

<!-- UsageSnippet language="go" operationID="getModel" method="get" path="/api/v1/llm/models/{model_id}" -->
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

    res, err := s.Llm.Models.Get(ctx, "meetkai:functionary-urdu-mini-pak", nil)
    if err != nil {
        log.Fatal(err)
    }
    if res.Object != nil {
        // handle response
    }
}
```

### Parameters

| Parameter                                                           | Type                                                                | Required                                                            | Description                                                         | Example                                                             |
| ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- |
| `ctx`                                                               | [context.Context](https://pkg.go.dev/context#Context)               | :heavy_check_mark:                                                  | The context to use for the request.                                 |                                                                     |
| `modelID`                                                           | `string`                                                            | :heavy_check_mark:                                                  | N/A                                                                 | meetkai:functionary-urdu-mini-pak                                   |
| `xOnBehalfOf`                                                       | `*string`                                                           | :heavy_minus_sign:                                                  | Optional external end-user identifier forwarded by the API gateway. |                                                                     |
| `opts`                                                              | [][operations.Option](../../models/operations/option.md)            | :heavy_minus_sign:                                                  | The options for this request.                                       |                                                                     |

### Response

**[*operations.GetModelResponse](../../models/operations/getmodelresponse.md), error**

### Errors

| Error Type         | Status Code        | Content Type       |
| ------------------ | ------------------ | ------------------ |
| apierrors.APIError | 4XX, 5XX           | \*/\*              |

## GetQuota

Read current tokens-per-minute limits without consuming tokens or starting a window. Use a concrete active model, not auto. Omit selectors for the authenticated caller's context, including its delegated external user. Human sessions may select an authorized api_key_id, plus service_account_id for a service-account key; selected keys use their ordinary, non-delegated context. Scopes with missing subject identities are omitted to avoid exposing shared fallback usage; their enforcement is unchanged. An empty limits array means no reportable token rules for this context. Untouched windows have reset_at: null; unavailable counters return 503.

### Example Usage

<!-- UsageSnippet language="go" operationID="getModelQuota" method="get" path="/api/v1/llm/models/{model_id}/quota" -->
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

    res, err := s.Llm.Models.GetQuota(ctx, "meetkai:functionary-urdu-mini-pak", nil, nil, nil)
    if err != nil {
        log.Fatal(err)
    }
    if res.Object != nil {
        // handle response
    }
}
```

### Parameters

| Parameter                                                           | Type                                                                | Required                                                            | Description                                                         | Example                                                             |
| ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- |
| `ctx`                                                               | [context.Context](https://pkg.go.dev/context#Context)               | :heavy_check_mark:                                                  | The context to use for the request.                                 |                                                                     |
| `modelID`                                                           | `string`                                                            | :heavy_check_mark:                                                  | N/A                                                                 | meetkai:functionary-urdu-mini-pak                                   |
| `apiKeyID`                                                          | `*string`                                                           | :heavy_minus_sign:                                                  | N/A                                                                 |                                                                     |
| `serviceAccountID`                                                  | `*string`                                                           | :heavy_minus_sign:                                                  | N/A                                                                 |                                                                     |
| `xOnBehalfOf`                                                       | `*string`                                                           | :heavy_minus_sign:                                                  | Optional external end-user identifier forwarded by the API gateway. |                                                                     |
| `opts`                                                              | [][operations.Option](../../models/operations/option.md)            | :heavy_minus_sign:                                                  | The options for this request.                                       |                                                                     |

### Response

**[*operations.GetModelQuotaResponse](../../models/operations/getmodelquotaresponse.md), error**

### Errors

| Error Type         | Status Code        | Content Type       |
| ------------------ | ------------------ | ------------------ |
| apierrors.APIError | 4XX, 5XX           | \*/\*              |

## ListCatalog

Lists all BYO, serving, and cluster-access definitions with activation state, blocker, health, and price preview.

### Example Usage

<!-- UsageSnippet language="go" operationID="listModelCatalog" method="get" path="/api/v1/llm/models/catalog" -->
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

    res, err := s.Llm.Models.ListCatalog(ctx)
    if err != nil {
        log.Fatal(err)
    }
    if res.CatalogListResponse != nil {
        // handle response
    }
}
```

### Parameters

| Parameter                                                | Type                                                     | Required                                                 | Description                                              |
| -------------------------------------------------------- | -------------------------------------------------------- | -------------------------------------------------------- | -------------------------------------------------------- |
| `ctx`                                                    | [context.Context](https://pkg.go.dev/context#Context)    | :heavy_check_mark:                                       | The context to use for the request.                      |
| `opts`                                                   | [][operations.Option](../../models/operations/option.md) | :heavy_minus_sign:                                       | The options for this request.                            |

### Response

**[*operations.ListModelCatalogResponse](../../models/operations/listmodelcatalogresponse.md), error**

### Errors

| Error Type         | Status Code        | Content Type       |
| ------------------ | ------------------ | ------------------ |
| apierrors.APIError | 4XX, 5XX           | \*/\*              |

## AddCatalogEntry

Creates an API-owned BYO definition without activating its name.

### Example Usage

<!-- UsageSnippet language="go" operationID="addModelCatalogEntry" method="post" path="/api/v1/llm/models/catalog" -->
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

    res, err := s.Llm.Models.AddCatalogEntry(ctx, components.AddCatalogModelRequest{
        ID: "meetkai:custom-chat-v1",
        Provider: "openai-compatible",
        ModelID: "custom-chat-v1",
        DisplayName: mka1.Pointer("Custom Chat v1"),
        BaseURL: mka1.Pointer("https://models.example.com/v1"),
        APIFormat: components.AutoEndpointResponses,
        APIProviderType: components.AddCatalogModelRequestAPIProviderTypeOpenai,
        Created: 1704067200,
        Auth: components.CreateAddCatalogModelRequestAuthUnionAPIKey(
            components.AddCatalogModelRequestAuth1{
                Value: mka1.Pointer("sk-provider-key"),
            },
        ),
        Capabilities: components.AddCatalogModelRequestCapabilities{
            Modalities: components.AddCatalogModelRequestModalities{
                Input: []components.AddCatalogModelRequestInput{
                    components.AddCatalogModelRequestInputText,
                },
                Output: []components.AddCatalogModelRequestOutput{
                    components.AddCatalogModelRequestOutputText,
                },
            },
            Reasoning: true,
        },
    })
    if err != nil {
        log.Fatal(err)
    }
    if res.CatalogEntry != nil {
        // handle response
    }
}
```

### Parameters

| Parameter                                                                              | Type                                                                                   | Required                                                                               | Description                                                                            |
| -------------------------------------------------------------------------------------- | -------------------------------------------------------------------------------------- | -------------------------------------------------------------------------------------- | -------------------------------------------------------------------------------------- |
| `ctx`                                                                                  | [context.Context](https://pkg.go.dev/context#Context)                                  | :heavy_check_mark:                                                                     | The context to use for the request.                                                    |
| `request`                                                                              | [components.AddCatalogModelRequest](../../models/components/addcatalogmodelrequest.md) | :heavy_check_mark:                                                                     | The request object to use for the request.                                             |
| `opts`                                                                                 | [][operations.Option](../../models/operations/option.md)                               | :heavy_minus_sign:                                                                     | The options for this request.                                                          |

### Response

**[*operations.AddModelCatalogEntryResponse](../../models/operations/addmodelcatalogentryresponse.md), error**

### Errors

| Error Type         | Status Code        | Content Type       |
| ------------------ | ------------------ | ------------------ |
| apierrors.APIError | 4XX, 5XX           | \*/\*              |

## UpdateCatalogEntry

Updates an API-owned BYO definition; yaml-origin entries are file-managed and immutable through this API.

### Example Usage

<!-- UsageSnippet language="go" operationID="updateModelCatalogEntry" method="patch" path="/api/v1/llm/models/catalog" -->
```go
package main

import(
	"context"
	mka1 "github.com/MeetKai/mka1-sdks/go"
	"github.com/MeetKai/mka1-sdks/go/optionalnullable"
	"github.com/MeetKai/mka1-sdks/go/models/components"
	"log"
)

func main() {
    ctx := context.Background()

    s := mka1.New(
        mka1.WithSecurity("<YOUR_BEARER_TOKEN_HERE>"),
    )

    res, err := s.Llm.Models.UpdateCatalogEntry(ctx, components.UpdateCatalogModelRequest{
        DisplayName: optionalnullable.From(mka1.Pointer("Custom Chat v2")),
        Rpm: optionalnullable.From(mka1.Pointer[int64](240)),
        ID: "meetkai:custom-chat-v1",
    })
    if err != nil {
        log.Fatal(err)
    }
    if res.CatalogEntry != nil {
        // handle response
    }
}
```

### Parameters

| Parameter                                                                                    | Type                                                                                         | Required                                                                                     | Description                                                                                  |
| -------------------------------------------------------------------------------------------- | -------------------------------------------------------------------------------------------- | -------------------------------------------------------------------------------------------- | -------------------------------------------------------------------------------------------- |
| `ctx`                                                                                        | [context.Context](https://pkg.go.dev/context#Context)                                        | :heavy_check_mark:                                                                           | The context to use for the request.                                                          |
| `request`                                                                                    | [components.UpdateCatalogModelRequest](../../models/components/updatecatalogmodelrequest.md) | :heavy_check_mark:                                                                           | The request object to use for the request.                                                   |
| `opts`                                                                                       | [][operations.Option](../../models/operations/option.md)                                     | :heavy_minus_sign:                                                                           | The options for this request.                                                                |

### Response

**[*operations.UpdateModelCatalogEntryResponse](../../models/operations/updatemodelcatalogentryresponse.md), error**

### Errors

| Error Type         | Status Code        | Content Type       |
| ------------------ | ------------------ | ------------------ |
| apierrors.APIError | 4XX, 5XX           | \*/\*              |

## DeleteCatalogEntry

Withdraws a BYO definition and deactivates it only when the active name is sourced from that BYO lineage.

### Example Usage

<!-- UsageSnippet language="go" operationID="deleteModelCatalogEntry" method="delete" path="/api/v1/llm/models/catalog" -->
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

    res, err := s.Llm.Models.DeleteCatalogEntry(ctx, "meetkai:custom-chat-v1")
    if err != nil {
        log.Fatal(err)
    }
    if res.DeleteCatalogModelResponse != nil {
        // handle response
    }
}
```

### Parameters

| Parameter                                                | Type                                                     | Required                                                 | Description                                              | Example                                                  |
| -------------------------------------------------------- | -------------------------------------------------------- | -------------------------------------------------------- | -------------------------------------------------------- | -------------------------------------------------------- |
| `ctx`                                                    | [context.Context](https://pkg.go.dev/context#Context)    | :heavy_check_mark:                                       | The context to use for the request.                      |                                                          |
| `id`                                                     | `string`                                                 | :heavy_check_mark:                                       | N/A                                                      | meetkai:custom-chat-v1                                   |
| `opts`                                                   | [][operations.Option](../../models/operations/option.md) | :heavy_minus_sign:                                       | The options for this request.                            |                                                          |

### Response

**[*operations.DeleteModelCatalogEntryResponse](../../models/operations/deletemodelcatalogentryresponse.md), error**

### Errors

| Error Type         | Status Code        | Content Type       |
| ------------------ | ------------------ | ------------------ |
| apierrors.APIError | 4XX, 5XX           | \*/\*              |

## CheckCatalogHealth

Probes an available BYO definition whether or not it is active.

### Example Usage

<!-- UsageSnippet language="go" operationID="checkModelCatalogHealth" method="post" path="/api/v1/llm/models/catalog/health" -->
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

    res, err := s.Llm.Models.CheckCatalogHealth(ctx, "meetkai:custom-chat-v1")
    if err != nil {
        log.Fatal(err)
    }
    if res.CatalogHealthResponse != nil {
        // handle response
    }
}
```

### Parameters

| Parameter                                                | Type                                                     | Required                                                 | Description                                              | Example                                                  |
| -------------------------------------------------------- | -------------------------------------------------------- | -------------------------------------------------------- | -------------------------------------------------------- | -------------------------------------------------------- |
| `ctx`                                                    | [context.Context](https://pkg.go.dev/context#Context)    | :heavy_check_mark:                                       | The context to use for the request.                      |                                                          |
| `id`                                                     | `string`                                                 | :heavy_check_mark:                                       | N/A                                                      | meetkai:custom-chat-v1                                   |
| `opts`                                                   | [][operations.Option](../../models/operations/option.md) | :heavy_minus_sign:                                       | The options for this request.                            |                                                          |

### Response

**[*operations.CheckModelCatalogHealthResponse](../../models/operations/checkmodelcataloghealthresponse.md), error**

### Errors

| Error Type         | Status Code        | Content Type       |
| ------------------ | ------------------ | ------------------ |
| apierrors.APIError | 4XX, 5XX           | \*/\*              |

## ListCatalogOrgAccess

Cluster operator view of an org's available cluster catalog entries and their activation state.

### Example Usage

<!-- UsageSnippet language="go" operationID="listModelCatalogOrgAccess" method="get" path="/api/v1/llm/models/catalog/orgs/{org_id}/access" -->
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

    res, err := s.Llm.Models.ListCatalogOrgAccess(ctx, "org-acme")
    if err != nil {
        log.Fatal(err)
    }
    if res.AccessListResponse != nil {
        // handle response
    }
}
```

### Parameters

| Parameter                                                | Type                                                     | Required                                                 | Description                                              | Example                                                  |
| -------------------------------------------------------- | -------------------------------------------------------- | -------------------------------------------------------- | -------------------------------------------------------- | -------------------------------------------------------- |
| `ctx`                                                    | [context.Context](https://pkg.go.dev/context#Context)    | :heavy_check_mark:                                       | The context to use for the request.                      |                                                          |
| `orgID`                                                  | `string`                                                 | :heavy_check_mark:                                       | N/A                                                      | org-acme                                                 |
| `opts`                                                   | [][operations.Option](../../models/operations/option.md) | :heavy_minus_sign:                                       | The options for this request.                            |                                                          |

### Response

**[*operations.ListModelCatalogOrgAccessResponse](../../models/operations/listmodelcatalogorgaccessresponse.md), error**

### Errors

| Error Type         | Status Code        | Content Type       |
| ------------------ | ------------------ | ------------------ |
| apierrors.APIError | 4XX, 5XX           | \*/\*              |

## AddCatalogOrgAccess

Idempotently adds availability without revoking any model names. Set activate to true to also activate every requested model from the cluster source in the target organization. Grants and activations are atomic per request; a name active from another source returns 409 without changing access or activation. Existing activation audit details are preserved on retries.

### Example Usage

<!-- UsageSnippet language="go" operationID="addModelCatalogOrgAccess" method="post" path="/api/v1/llm/models/catalog/orgs/{org_id}/access" -->
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

    res, err := s.Llm.Models.AddCatalogOrgAccess(ctx, "org-acme", components.AddAccessMutationRequest{
        ModelIds: []string{
            "functionary",
        },
        Activate: mka1.Pointer(false),
    })
    if err != nil {
        log.Fatal(err)
    }
    if res.AccessMutationResponse != nil {
        // handle response
    }
}
```

### Parameters

| Parameter                                                                                  | Type                                                                                       | Required                                                                                   | Description                                                                                | Example                                                                                    |
| ------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------ |
| `ctx`                                                                                      | [context.Context](https://pkg.go.dev/context#Context)                                      | :heavy_check_mark:                                                                         | The context to use for the request.                                                        |                                                                                            |
| `orgID`                                                                                    | `string`                                                                                   | :heavy_check_mark:                                                                         | N/A                                                                                        | org-acme                                                                                   |
| `body`                                                                                     | [components.AddAccessMutationRequest](../../models/components/addaccessmutationrequest.md) | :heavy_check_mark:                                                                         | N/A                                                                                        |                                                                                            |
| `opts`                                                                                     | [][operations.Option](../../models/operations/option.md)                                   | :heavy_minus_sign:                                                                         | The options for this request.                                                              |                                                                                            |

### Response

**[*operations.AddModelCatalogOrgAccessResponse](../../models/operations/addmodelcatalogorgaccessresponse.md), error**

### Errors

| Error Type         | Status Code        | Content Type       |
| ------------------ | ------------------ | ------------------ |
| apierrors.APIError | 4XX, 5XX           | \*/\*              |

## ReplaceCatalogOrgAccess

Serializable full replacement; revoked active cluster names are deactivated and their org price rows are closed.

### Example Usage

<!-- UsageSnippet language="go" operationID="replaceModelCatalogOrgAccess" method="put" path="/api/v1/llm/models/catalog/orgs/{org_id}/access" -->
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

    res, err := s.Llm.Models.ReplaceCatalogOrgAccess(ctx, "org-acme", components.AccessMutationRequest{
        ModelIds: []string{
            "functionary",
        },
    })
    if err != nil {
        log.Fatal(err)
    }
    if res.AccessMutationResponse != nil {
        // handle response
    }
}
```

### Parameters

| Parameter                                                                            | Type                                                                                 | Required                                                                             | Description                                                                          | Example                                                                              |
| ------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------ |
| `ctx`                                                                                | [context.Context](https://pkg.go.dev/context#Context)                                | :heavy_check_mark:                                                                   | The context to use for the request.                                                  |                                                                                      |
| `orgID`                                                                              | `string`                                                                             | :heavy_check_mark:                                                                   | N/A                                                                                  | org-acme                                                                             |
| `body`                                                                               | [components.AccessMutationRequest](../../models/components/accessmutationrequest.md) | :heavy_check_mark:                                                                   | N/A                                                                                  |                                                                                      |
| `opts`                                                                               | [][operations.Option](../../models/operations/option.md)                             | :heavy_minus_sign:                                                                   | The options for this request.                                                        |                                                                                      |

### Response

**[*operations.ReplaceModelCatalogOrgAccessResponse](../../models/operations/replacemodelcatalogorgaccessresponse.md), error**

### Errors

| Error Type         | Status Code        | Content Type       |
| ------------------ | ------------------ | ------------------ |
| apierrors.APIError | 4XX, 5XX           | \*/\*              |

## ListCatalogModelAccess

Cluster operator reverse lookup showing availability and activation for one cluster catalog id.

### Example Usage

<!-- UsageSnippet language="go" operationID="listModelCatalogAccess" method="get" path="/api/v1/llm/models/catalog/access" -->
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

    res, err := s.Llm.Models.ListCatalogModelAccess(ctx, "functionary")
    if err != nil {
        log.Fatal(err)
    }
    if res.ReverseAccessListResponse != nil {
        // handle response
    }
}
```

### Parameters

| Parameter                                                | Type                                                     | Required                                                 | Description                                              | Example                                                  |
| -------------------------------------------------------- | -------------------------------------------------------- | -------------------------------------------------------- | -------------------------------------------------------- | -------------------------------------------------------- |
| `ctx`                                                    | [context.Context](https://pkg.go.dev/context#Context)    | :heavy_check_mark:                                       | The context to use for the request.                      |                                                          |
| `modelID`                                                | `string`                                                 | :heavy_check_mark:                                       | N/A                                                      | functionary                                              |
| `opts`                                                   | [][operations.Option](../../models/operations/option.md) | :heavy_minus_sign:                                       | The options for this request.                            |                                                          |

### Response

**[*operations.ListModelCatalogAccessResponse](../../models/operations/listmodelcatalogaccessresponse.md), error**

### Errors

| Error Type         | Status Code        | Content Type       |
| ------------------ | ------------------ | ------------------ |
| apierrors.APIError | 4XX, 5XX           | \*/\*              |

## ListRegistry

Single management view of every active name with source-qualified definition, health, price, and activation audit details.

### Example Usage

<!-- UsageSnippet language="go" operationID="listModelRegistry" method="get" path="/api/v1/llm/models/registry" -->
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

    res, err := s.Llm.Models.ListRegistry(ctx)
    if err != nil {
        log.Fatal(err)
    }
    if res.RegistryManagementListResponse != nil {
        // handle response
    }
}
```

### Parameters

| Parameter                                                | Type                                                     | Required                                                 | Description                                              |
| -------------------------------------------------------- | -------------------------------------------------------- | -------------------------------------------------------- | -------------------------------------------------------- |
| `ctx`                                                    | [context.Context](https://pkg.go.dev/context#Context)    | :heavy_check_mark:                                       | The context to use for the request.                      |
| `opts`                                                   | [][operations.Option](../../models/operations/option.md) | :heavy_minus_sign:                                       | The options for this request.                            |

### Response

**[*operations.ListModelRegistryResponse](../../models/operations/listmodelregistryresponse.md), error**

### Errors

| Error Type         | Status Code        | Content Type       |
| ------------------ | ------------------ | ------------------ |
| apierrors.APIError | 4XX, 5XX           | \*/\*              |

## ActivateRegistryEntry

Claims a model name from one catalog source. Re-activation from the same source is idempotent; a different holder returns 409.

### Example Usage

<!-- UsageSnippet language="go" operationID="activateModelRegistryEntry" method="post" path="/api/v1/llm/models/registry" -->
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

    res, err := s.Llm.Models.ActivateRegistryEntry(ctx, components.ActivateRegistryEntryRequest{
        Source: components.RegistrySourceCluster,
        ModelID: "functionary",
    })
    if err != nil {
        log.Fatal(err)
    }
    if res.RegistryEntryResponse != nil {
        // handle response
    }
}
```

### Parameters

| Parameter                                                                                          | Type                                                                                               | Required                                                                                           | Description                                                                                        |
| -------------------------------------------------------------------------------------------------- | -------------------------------------------------------------------------------------------------- | -------------------------------------------------------------------------------------------------- | -------------------------------------------------------------------------------------------------- |
| `ctx`                                                                                              | [context.Context](https://pkg.go.dev/context#Context)                                              | :heavy_check_mark:                                                                                 | The context to use for the request.                                                                |
| `request`                                                                                          | [components.ActivateRegistryEntryRequest](../../models/components/activateregistryentryrequest.md) | :heavy_check_mark:                                                                                 | The request object to use for the request.                                                         |
| `opts`                                                                                             | [][operations.Option](../../models/operations/option.md)                                           | :heavy_minus_sign:                                                                                 | The options for this request.                                                                      |

### Response

**[*operations.ActivateModelRegistryEntryResponse](../../models/operations/activatemodelregistryentryresponse.md), error**

### Errors

| Error Type         | Status Code        | Content Type       |
| ------------------ | ------------------ | ------------------ |
| apierrors.APIError | 4XX, 5XX           | \*/\*              |

## DeactivateRegistryEntry

Idempotently removes the active name and closes its org-scope price rows without touching the catalog definition.

### Example Usage

<!-- UsageSnippet language="go" operationID="deactivateModelRegistryEntry" method="delete" path="/api/v1/llm/models/registry" -->
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

    res, err := s.Llm.Models.DeactivateRegistryEntry(ctx, "functionary")
    if err != nil {
        log.Fatal(err)
    }
    if res.DeactivateRegistryEntryResponse != nil {
        // handle response
    }
}
```

### Parameters

| Parameter                                                | Type                                                     | Required                                                 | Description                                              | Example                                                  |
| -------------------------------------------------------- | -------------------------------------------------------- | -------------------------------------------------------- | -------------------------------------------------------- | -------------------------------------------------------- |
| `ctx`                                                    | [context.Context](https://pkg.go.dev/context#Context)    | :heavy_check_mark:                                       | The context to use for the request.                      |                                                          |
| `id`                                                     | `string`                                                 | :heavy_check_mark:                                       | N/A                                                      | functionary                                              |
| `opts`                                                   | [][operations.Option](../../models/operations/option.md) | :heavy_minus_sign:                                       | The options for this request.                            |                                                          |

### Response

**[*operations.DeactivateModelRegistryEntryResponse](../../models/operations/deactivatemodelregistryentryresponse.md), error**

### Errors

| Error Type         | Status Code        | Content Type       |
| ------------------ | ------------------ | ------------------ |
| apierrors.APIError | 4XX, 5XX           | \*/\*              |

## ListOrgAutoModels

Returns every endpoint for which this org has set its own `"auto"` target. Endpoints not listed fall through to the operator's YAML defaults.

### Example Usage

<!-- UsageSnippet language="go" operationID="listOrgAutoModels" method="get" path="/api/v1/llm/models/auto" -->
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

    res, err := s.Llm.Models.ListOrgAutoModels(ctx)
    if err != nil {
        log.Fatal(err)
    }
    if res.ListOrgAutoModelsResponse != nil {
        // handle response
    }
}
```

### Parameters

| Parameter                                                | Type                                                     | Required                                                 | Description                                              |
| -------------------------------------------------------- | -------------------------------------------------------- | -------------------------------------------------------- | -------------------------------------------------------- |
| `ctx`                                                    | [context.Context](https://pkg.go.dev/context#Context)    | :heavy_check_mark:                                       | The context to use for the request.                      |
| `opts`                                                   | [][operations.Option](../../models/operations/option.md) | :heavy_minus_sign:                                       | The options for this request.                            |

### Response

**[*operations.ListOrgAutoModelsResponse](../../models/operations/listorgautomodelsresponse.md), error**

### Errors

| Error Type         | Status Code        | Content Type       |
| ------------------ | ------------------ | ------------------ |
| apierrors.APIError | 4XX, 5XX           | \*/\*              |

## PutOrgAutoModel

Stores either the existing direct `{ endpoint → model_id }` alias or a judge policy with candidate models. Judge routing is supported for responses, completions, transcriptions, and TTS. The judge must be a non-reasoning text LLM. All configured models must be active when written; revoked candidates are filtered at request time, while an unavailable judge is an explicit error. The `tts` policy may also carry `fallback_language`, the language `language: "auto"` text-to-speech uses when detection cannot name one; a PUT replaces the whole policy, so omitting it clears it.

### Example Usage

<!-- UsageSnippet language="go" operationID="putOrgAutoModel" method="put" path="/api/v1/llm/models/auto/{endpoint}" -->
```go
package main

import(
	"context"
	mka1 "github.com/MeetKai/mka1-sdks/go"
	"github.com/MeetKai/mka1-sdks/go/models/components"
	"log"
	"github.com/MeetKai/mka1-sdks/go/models/operations"
)

func main() {
    ctx := context.Background()

    s := mka1.New(
        mka1.WithSecurity("<YOUR_BEARER_TOKEN_HERE>"),
    )

    res, err := s.Llm.Models.PutOrgAutoModel(ctx, components.AutoEndpointResponses, components.CreatePutOrgAutoModelRequestUnionPutOrgAutoModelRequest2(
        components.PutOrgAutoModelRequest2{
            Policy: components.PolicyPrice.ToPointer(),
            JudgeModelID: "meetkai:functionary-es-mini",
            CandidateModelIds: []string{
                "meetkai:functionary-pt",
                "meetkai:functionary-es",
            },
        },
    ))
    if err != nil {
        log.Fatal(err)
    }
    if res.OneOf != nil {
        switch res.OneOf.Type {
            case operations.PutOrgAutoModelResponseBodyTypeDirect:
                // res.OneOf.DirectOrgAutoModel is populated
            case operations.PutOrgAutoModelResponseBodyTypeBalanced:
                // res.OneOf.BalancedOrgAutoModel is populated
            case operations.PutOrgAutoModelResponseBodyTypePrice:
                // res.OneOf.PriceOrgAutoModel is populated
            case operations.PutOrgAutoModelResponseBodyTypeQuality:
                // res.OneOf.QualityOrgAutoModel is populated
            case operations.PutOrgAutoModelResponseBodyTypeSpeed:
                // res.OneOf.SpeedOrgAutoModel is populated
            default:
                // Unknown type - use res.OneOf.GetUnknownRaw() for raw JSON
        }

    }
}
```

### Parameters

| Parameter                                                                                        | Type                                                                                             | Required                                                                                         | Description                                                                                      | Example                                                                                          |
| ------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------ |
| `ctx`                                                                                            | [context.Context](https://pkg.go.dev/context#Context)                                            | :heavy_check_mark:                                                                               | The context to use for the request.                                                              |                                                                                                  |
| `endpoint`                                                                                       | [components.AutoEndpoint](../../models/components/autoendpoint.md)                               | :heavy_check_mark:                                                                               | N/A                                                                                              | responses                                                                                        |
| `body`                                                                                           | [components.PutOrgAutoModelRequestUnion](../../models/components/putorgautomodelrequestunion.md) | :heavy_check_mark:                                                                               | N/A                                                                                              |                                                                                                  |
| `opts`                                                                                           | [][operations.Option](../../models/operations/option.md)                                         | :heavy_minus_sign:                                                                               | The options for this request.                                                                    |                                                                                                  |

### Response

**[*operations.PutOrgAutoModelResponse](../../models/operations/putorgautomodelresponse.md), error**

### Errors

| Error Type         | Status Code        | Content Type       |
| ------------------ | ------------------ | ------------------ |
| apierrors.APIError | 4XX, 5XX           | \*/\*              |

## DeleteOrgAutoModel

Removes the per-org override for the endpoint. Subsequent `model: "auto"` requests fall through to the operator's YAML default again.

### Example Usage

<!-- UsageSnippet language="go" operationID="deleteOrgAutoModel" method="delete" path="/api/v1/llm/models/auto/{endpoint}" -->
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

    res, err := s.Llm.Models.DeleteOrgAutoModel(ctx, components.AutoEndpointResponses)
    if err != nil {
        log.Fatal(err)
    }
    if res.DeleteOrgAutoModelResponse != nil {
        // handle response
    }
}
```

### Parameters

| Parameter                                                          | Type                                                               | Required                                                           | Description                                                        | Example                                                            |
| ------------------------------------------------------------------ | ------------------------------------------------------------------ | ------------------------------------------------------------------ | ------------------------------------------------------------------ | ------------------------------------------------------------------ |
| `ctx`                                                              | [context.Context](https://pkg.go.dev/context#Context)              | :heavy_check_mark:                                                 | The context to use for the request.                                |                                                                    |
| `endpoint`                                                         | [components.AutoEndpoint](../../models/components/autoendpoint.md) | :heavy_check_mark:                                                 | N/A                                                                | responses                                                          |
| `opts`                                                             | [][operations.Option](../../models/operations/option.md)           | :heavy_minus_sign:                                                 | The options for this request.                                      |                                                                    |

### Response

**[*operations.DeleteOrgAutoModelResponse](../../models/operations/deleteorgautomodelresponse.md), error**

### Errors

| Error Type         | Status Code        | Content Type       |
| ------------------ | ------------------ | ------------------ |
| apierrors.APIError | 4XX, 5XX           | \*/\*              |

## GetClusterCurrency

Returns the single cluster-wide ISO-4217 currency code (null if not set).

### Example Usage

<!-- UsageSnippet language="go" operationID="getClusterCurrency" method="get" path="/api/v1/llm/models/pricing/currency" -->
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

    res, err := s.Llm.Models.GetClusterCurrency(ctx)
    if err != nil {
        log.Fatal(err)
    }
    if res.ClusterCurrencyResponse != nil {
        // handle response
    }
}
```

### Parameters

| Parameter                                                | Type                                                     | Required                                                 | Description                                              |
| -------------------------------------------------------- | -------------------------------------------------------- | -------------------------------------------------------- | -------------------------------------------------------- |
| `ctx`                                                    | [context.Context](https://pkg.go.dev/context#Context)    | :heavy_check_mark:                                       | The context to use for the request.                      |
| `opts`                                                   | [][operations.Option](../../models/operations/option.md) | :heavy_minus_sign:                                       | The options for this request.                            |

### Response

**[*operations.GetClusterCurrencyResponse](../../models/operations/getclustercurrencyresponse.md), error**

### Errors

| Error Type         | Status Code        | Content Type       |
| ------------------ | ------------------ | ------------------ |
| apierrors.APIError | 4XX, 5XX           | \*/\*              |

## SetClusterCurrency

Sets the cluster-wide currency. Changing it does not auto-convert existing prices.

### Example Usage

<!-- UsageSnippet language="go" operationID="setClusterCurrency" method="put" path="/api/v1/llm/models/pricing/currency" -->
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

    res, err := s.Llm.Models.SetClusterCurrency(ctx, components.PutClusterCurrencyBody{
        Currency: "Nakfa",
    })
    if err != nil {
        log.Fatal(err)
    }
    if res.ClusterCurrencyResponse != nil {
        // handle response
    }
}
```

### Parameters

| Parameter                                                                              | Type                                                                                   | Required                                                                               | Description                                                                            |
| -------------------------------------------------------------------------------------- | -------------------------------------------------------------------------------------- | -------------------------------------------------------------------------------------- | -------------------------------------------------------------------------------------- |
| `ctx`                                                                                  | [context.Context](https://pkg.go.dev/context#Context)                                  | :heavy_check_mark:                                                                     | The context to use for the request.                                                    |
| `request`                                                                              | [components.PutClusterCurrencyBody](../../models/components/putclustercurrencybody.md) | :heavy_check_mark:                                                                     | The request object to use for the request.                                             |
| `opts`                                                                                 | [][operations.Option](../../models/operations/option.md)                               | :heavy_minus_sign:                                                                     | The options for this request.                                                          |

### Response

**[*operations.SetClusterCurrencyResponse](../../models/operations/setclustercurrencyresponse.md), error**

### Errors

| Error Type         | Status Code        | Content Type       |
| ------------------ | ------------------ | ------------------ |
| apierrors.APIError | 4XX, 5XX           | \*/\*              |

## ListClusterPrices

Without `model`, lists every model's current cluster-default price. With `model`, returns that model's full dated history.

### Example Usage

<!-- UsageSnippet language="go" operationID="listClusterPrices" method="get" path="/api/v1/llm/models/pricing" -->
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

    res, err := s.Llm.Models.ListClusterPrices(ctx, nil)
    if err != nil {
        log.Fatal(err)
    }
    if res.ListModelPricesResponse != nil {
        // handle response
    }
}
```

### Parameters

| Parameter                                                | Type                                                     | Required                                                 | Description                                              |
| -------------------------------------------------------- | -------------------------------------------------------- | -------------------------------------------------------- | -------------------------------------------------------- |
| `ctx`                                                    | [context.Context](https://pkg.go.dev/context#Context)    | :heavy_check_mark:                                       | The context to use for the request.                      |
| `model`                                                  | `*string`                                                | :heavy_minus_sign:                                       | N/A                                                      |
| `opts`                                                   | [][operations.Option](../../models/operations/option.md) | :heavy_minus_sign:                                       | The options for this request.                            |

### Response

**[*operations.ListClusterPricesResponse](../../models/operations/listclusterpricesresponse.md), error**

### Errors

| Error Type         | Status Code        | Content Type       |
| ------------------ | ------------------ | ------------------ |
| apierrors.APIError | 4XX, 5XX           | \*/\*              |

## SetClusterPrice

Upserts the cluster-default price for a model as a new dated version. `rates` is a flexible metric→rate map; omitted metrics are not charged.

### Example Usage

<!-- UsageSnippet language="go" operationID="setClusterPrice" method="put" path="/api/v1/llm/models/pricing" -->
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

    res, err := s.Llm.Models.SetClusterPrice(ctx, components.PutModelPriceBody{
        Model: "Cruze",
        Rates: components.PutModelPriceBodyRates{},
    })
    if err != nil {
        log.Fatal(err)
    }
    if res.ModelPriceRow != nil {
        // handle response
    }
}
```

### Parameters

| Parameter                                                                    | Type                                                                         | Required                                                                     | Description                                                                  |
| ---------------------------------------------------------------------------- | ---------------------------------------------------------------------------- | ---------------------------------------------------------------------------- | ---------------------------------------------------------------------------- |
| `ctx`                                                                        | [context.Context](https://pkg.go.dev/context#Context)                        | :heavy_check_mark:                                                           | The context to use for the request.                                          |
| `request`                                                                    | [components.PutModelPriceBody](../../models/components/putmodelpricebody.md) | :heavy_check_mark:                                                           | The request object to use for the request.                                   |
| `opts`                                                                       | [][operations.Option](../../models/operations/option.md)                     | :heavy_minus_sign:                                                           | The options for this request.                                                |

### Response

**[*operations.SetClusterPriceResponse](../../models/operations/setclusterpriceresponse.md), error**

### Errors

| Error Type         | Status Code        | Content Type       |
| ------------------ | ------------------ | ------------------ |
| apierrors.APIError | 4XX, 5XX           | \*/\*              |

## ClearClusterPrice

Closes the cluster-default price. Active cluster lineage then uses an org override or becomes unpriced ($0).

### Example Usage

<!-- UsageSnippet language="go" operationID="clearClusterPrice" method="delete" path="/api/v1/llm/models/pricing" -->
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

    res, err := s.Llm.Models.ClearClusterPrice(ctx, "Alpine")
    if err != nil {
        log.Fatal(err)
    }
    if res.DeleteModelPriceResponse != nil {
        // handle response
    }
}
```

### Parameters

| Parameter                                                | Type                                                     | Required                                                 | Description                                              |
| -------------------------------------------------------- | -------------------------------------------------------- | -------------------------------------------------------- | -------------------------------------------------------- |
| `ctx`                                                    | [context.Context](https://pkg.go.dev/context#Context)    | :heavy_check_mark:                                       | The context to use for the request.                      |
| `model`                                                  | `string`                                                 | :heavy_check_mark:                                       | N/A                                                      |
| `opts`                                                   | [][operations.Option](../../models/operations/option.md) | :heavy_minus_sign:                                       | The options for this request.                            |

### Response

**[*operations.ClearClusterPriceResponse](../../models/operations/clearclusterpriceresponse.md), error**

### Errors

| Error Type         | Status Code        | Content Type       |
| ------------------ | ------------------ | ------------------ |
| apierrors.APIError | 4XX, 5XX           | \*/\*              |

## ListOrgPrices

Without `model`, lists the org's current overrides. With `model`, returns that override's dated history.

### Example Usage

<!-- UsageSnippet language="go" operationID="listOrgPrices" method="get" path="/api/v1/llm/models/pricing/org/{org_id}" -->
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

    res, err := s.Llm.Models.ListOrgPrices(ctx, "<id>", nil)
    if err != nil {
        log.Fatal(err)
    }
    if res.ListModelPricesResponse != nil {
        // handle response
    }
}
```

### Parameters

| Parameter                                                | Type                                                     | Required                                                 | Description                                              |
| -------------------------------------------------------- | -------------------------------------------------------- | -------------------------------------------------------- | -------------------------------------------------------- |
| `ctx`                                                    | [context.Context](https://pkg.go.dev/context#Context)    | :heavy_check_mark:                                       | The context to use for the request.                      |
| `orgID`                                                  | `string`                                                 | :heavy_check_mark:                                       | N/A                                                      |
| `model`                                                  | `*string`                                                | :heavy_minus_sign:                                       | N/A                                                      |
| `opts`                                                   | [][operations.Option](../../models/operations/option.md) | :heavy_minus_sign:                                       | The options for this request.                            |

### Response

**[*operations.ListOrgPricesResponse](../../models/operations/listorgpricesresponse.md), error**

### Errors

| Error Type         | Status Code        | Content Type       |
| ------------------ | ------------------ | ------------------ |
| apierrors.APIError | 4XX, 5XX           | \*/\*              |

## SetOrgPrice

Upserts a dated per-org price. Cluster lineage falls back to the cluster default; BYO and serving lineage become unpriced when no org row exists.

### Example Usage

<!-- UsageSnippet language="go" operationID="setOrgPrice" method="put" path="/api/v1/llm/models/pricing/org/{org_id}" -->
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

    res, err := s.Llm.Models.SetOrgPrice(ctx, "<id>", components.PutModelPriceBody{
        Model: "Roadster",
        Rates: components.PutModelPriceBodyRates{},
    })
    if err != nil {
        log.Fatal(err)
    }
    if res.ModelPriceRow != nil {
        // handle response
    }
}
```

### Parameters

| Parameter                                                                    | Type                                                                         | Required                                                                     | Description                                                                  |
| ---------------------------------------------------------------------------- | ---------------------------------------------------------------------------- | ---------------------------------------------------------------------------- | ---------------------------------------------------------------------------- |
| `ctx`                                                                        | [context.Context](https://pkg.go.dev/context#Context)                        | :heavy_check_mark:                                                           | The context to use for the request.                                          |
| `orgID`                                                                      | `string`                                                                     | :heavy_check_mark:                                                           | N/A                                                                          |
| `body`                                                                       | [components.PutModelPriceBody](../../models/components/putmodelpricebody.md) | :heavy_check_mark:                                                           | N/A                                                                          |
| `opts`                                                                       | [][operations.Option](../../models/operations/option.md)                     | :heavy_minus_sign:                                                           | The options for this request.                                                |

### Response

**[*operations.SetOrgPriceResponse](../../models/operations/setorgpriceresponse.md), error**

### Errors

| Error Type         | Status Code        | Content Type       |
| ------------------ | ------------------ | ------------------ |
| apierrors.APIError | 4XX, 5XX           | \*/\*              |

## ClearOrgPrice

Closes a per-org price. Only active cluster lineage can then fall back to the cluster default.

### Example Usage

<!-- UsageSnippet language="go" operationID="clearOrgPrice" method="delete" path="/api/v1/llm/models/pricing/org/{org_id}" -->
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

    res, err := s.Llm.Models.ClearOrgPrice(ctx, "<id>", "XTS")
    if err != nil {
        log.Fatal(err)
    }
    if res.DeleteModelPriceResponse != nil {
        // handle response
    }
}
```

### Parameters

| Parameter                                                | Type                                                     | Required                                                 | Description                                              |
| -------------------------------------------------------- | -------------------------------------------------------- | -------------------------------------------------------- | -------------------------------------------------------- |
| `ctx`                                                    | [context.Context](https://pkg.go.dev/context#Context)    | :heavy_check_mark:                                       | The context to use for the request.                      |
| `orgID`                                                  | `string`                                                 | :heavy_check_mark:                                       | N/A                                                      |
| `model`                                                  | `string`                                                 | :heavy_check_mark:                                       | N/A                                                      |
| `opts`                                                   | [][operations.Option](../../models/operations/option.md) | :heavy_minus_sign:                                       | The options for this request.                            |

### Response

**[*operations.ClearOrgPriceResponse](../../models/operations/clearorgpriceresponse.md), error**

### Errors

| Error Type         | Status Code        | Content Type       |
| ------------------ | ------------------ | ------------------ |
| apierrors.APIError | 4XX, 5XX           | \*/\*              |

## ListEffectivePrices

For every active model, returns its registry-aware price: an org row, a cluster default for cluster lineage, or unpriced ($0). Also lists the `auto` routing alias, priced at the per-metric maximum across every model it can be billed as (`resolves_to`): a judge policy's active candidates, or the direct/YAML target plus any reroute target it can fall through to.

### Example Usage

<!-- UsageSnippet language="go" operationID="listEffectivePrices" method="get" path="/api/v1/llm/models/pricing/effective" -->
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

    res, err := s.Llm.Models.ListEffectivePrices(ctx, nil)
    if err != nil {
        log.Fatal(err)
    }
    if res.EffectivePricesResponse != nil {
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

**[*operations.ListEffectivePricesResponse](../../models/operations/listeffectivepricesresponse.md), error**

### Errors

| Error Type         | Status Code        | Content Type       |
| ------------------ | ------------------ | ------------------ |
| apierrors.APIError | 4XX, 5XX           | \*/\*              |