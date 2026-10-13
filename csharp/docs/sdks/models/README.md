# Llm.Models

## Overview

### Available Operations

* [List](#list) - List available models
* [Get](#get) - Retrieve a model
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

<!-- UsageSnippet language="csharp" operationID="listModels" method="get" path="/api/v1/llm/models" -->
```csharp
using MeetKai.MKA1;
using MeetKai.MKA1.Types.Components;

var sdk = new SDK(bearerAuth: "<YOUR_BEARER_TOKEN_HERE>");

var res = await sdk.Llm.Models.ListAsync();

// handle response
```

### Parameters

| Parameter                                                           | Type                                                                | Required                                                            | Description                                                         |
| ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- |
| `XOnBehalfOf`                                                       | *string*                                                            | :heavy_minus_sign:                                                  | Optional external end-user identifier forwarded by the API gateway. |

### Response

**[ListModelsResponse](../../Types/Requests/ListModelsResponse.md)**

### Errors

| Error Type                             | Status Code                            | Content Type                           |
| -------------------------------------- | -------------------------------------- | -------------------------------------- |
| MeetKai.MKA1.Types.Errors.APIException | 4XX, 5XX                               | \*/\*                                  |

## Get

Retrieves a model instance, providing basic information about the model such as the owner and supported capabilities.

### Example Usage

<!-- UsageSnippet language="csharp" operationID="getModel" method="get" path="/api/v1/llm/models/{model_id}" -->
```csharp
using MeetKai.MKA1;
using MeetKai.MKA1.Types.Components;

var sdk = new SDK(bearerAuth: "<YOUR_BEARER_TOKEN_HERE>");

var res = await sdk.Llm.Models.GetAsync(modelId: "meetkai:functionary-urdu-mini-pak");

// handle response
```

### Parameters

| Parameter                                                           | Type                                                                | Required                                                            | Description                                                         | Example                                                             |
| ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- |
| `ModelId`                                                           | *string*                                                            | :heavy_check_mark:                                                  | N/A                                                                 | meetkai:functionary-urdu-mini-pak                                   |
| `XOnBehalfOf`                                                       | *string*                                                            | :heavy_minus_sign:                                                  | Optional external end-user identifier forwarded by the API gateway. |                                                                     |

### Response

**[GetModelResponse](../../Types/Requests/GetModelResponse.md)**

### Errors

| Error Type                             | Status Code                            | Content Type                           |
| -------------------------------------- | -------------------------------------- | -------------------------------------- |
| MeetKai.MKA1.Types.Errors.APIException | 4XX, 5XX                               | \*/\*                                  |

## ListCatalog

Lists all BYO, serving, and cluster-access definitions with activation state, blocker, health, and price preview.

### Example Usage

<!-- UsageSnippet language="csharp" operationID="listModelCatalog" method="get" path="/api/v1/llm/models/catalog" -->
```csharp
using MeetKai.MKA1;
using MeetKai.MKA1.Types.Components;

var sdk = new SDK(bearerAuth: "<YOUR_BEARER_TOKEN_HERE>");

var res = await sdk.Llm.Models.ListCatalogAsync();

// handle response
```

### Response

**[ListModelCatalogResponse](../../Types/Requests/ListModelCatalogResponse.md)**

### Errors

| Error Type                             | Status Code                            | Content Type                           |
| -------------------------------------- | -------------------------------------- | -------------------------------------- |
| MeetKai.MKA1.Types.Errors.APIException | 4XX, 5XX                               | \*/\*                                  |

## AddCatalogEntry

Creates an API-owned BYO definition without activating its name.

### Example Usage

<!-- UsageSnippet language="csharp" operationID="addModelCatalogEntry" method="post" path="/api/v1/llm/models/catalog" -->
```csharp
using MeetKai.MKA1;
using MeetKai.MKA1.Types.Components;
using System.Collections.Generic;

var sdk = new SDK(bearerAuth: "<YOUR_BEARER_TOKEN_HERE>");

AddCatalogModelRequest req = new AddCatalogModelRequest() {
    Id = "meetkai:custom-chat-v1",
    Provider = "openai-compatible",
    ModelId = "custom-chat-v1",
    DisplayName = "Custom Chat v1",
    BaseUrl = "https://models.example.com/v1",
    ApiFormat = AutoEndpoint.Responses,
    ApiProviderType = AddCatalogModelRequestApiProviderType.Openai,
    Created = 1704067200,
    Auth = AddCatalogModelRequestAuthUnion.CreateApiKey(
        new AddCatalogModelRequestAuth1() {
            Value = "sk-provider-key",
        }
    ),
    Capabilities = new AddCatalogModelRequestCapabilities() {
        Modalities = new AddCatalogModelRequestModalities() {
            Input = new List<AddCatalogModelRequestInput>() {
                AddCatalogModelRequestInput.Text,
            },
            Output = new List<AddCatalogModelRequestOutput>() {
                AddCatalogModelRequestOutput.Text,
            },
        },
        Reasoning = true,
    },
};

var res = await sdk.Llm.Models.AddCatalogEntryAsync(req);

// handle response
```

### Parameters

| Parameter                                                                  | Type                                                                       | Required                                                                   | Description                                                                |
| -------------------------------------------------------------------------- | -------------------------------------------------------------------------- | -------------------------------------------------------------------------- | -------------------------------------------------------------------------- |
| `request`                                                                  | [AddCatalogModelRequest](../../Types/Components/AddCatalogModelRequest.md) | :heavy_check_mark:                                                         | The request object to use for the request.                                 |

### Response

**[AddModelCatalogEntryResponse](../../Types/Requests/AddModelCatalogEntryResponse.md)**

### Errors

| Error Type                             | Status Code                            | Content Type                           |
| -------------------------------------- | -------------------------------------- | -------------------------------------- |
| MeetKai.MKA1.Types.Errors.APIException | 4XX, 5XX                               | \*/\*                                  |

## UpdateCatalogEntry

Updates an API-owned BYO definition; yaml-origin entries are file-managed and immutable through this API.

### Example Usage

<!-- UsageSnippet language="csharp" operationID="updateModelCatalogEntry" method="patch" path="/api/v1/llm/models/catalog" -->
```csharp
using MeetKai.MKA1;
using MeetKai.MKA1.Types.Components;

var sdk = new SDK(bearerAuth: "<YOUR_BEARER_TOKEN_HERE>");

UpdateCatalogModelRequest req = new UpdateCatalogModelRequest() {
    DisplayName = "Custom Chat v2",
    Rpm = 240,
    Id = "meetkai:custom-chat-v1",
};

var res = await sdk.Llm.Models.UpdateCatalogEntryAsync(req);

// handle response
```

### Parameters

| Parameter                                                                        | Type                                                                             | Required                                                                         | Description                                                                      |
| -------------------------------------------------------------------------------- | -------------------------------------------------------------------------------- | -------------------------------------------------------------------------------- | -------------------------------------------------------------------------------- |
| `request`                                                                        | [UpdateCatalogModelRequest](../../Types/Components/UpdateCatalogModelRequest.md) | :heavy_check_mark:                                                               | The request object to use for the request.                                       |

### Response

**[UpdateModelCatalogEntryResponse](../../Types/Requests/UpdateModelCatalogEntryResponse.md)**

### Errors

| Error Type                             | Status Code                            | Content Type                           |
| -------------------------------------- | -------------------------------------- | -------------------------------------- |
| MeetKai.MKA1.Types.Errors.APIException | 4XX, 5XX                               | \*/\*                                  |

## DeleteCatalogEntry

Withdraws a BYO definition and deactivates it only when the active name is sourced from that BYO lineage.

### Example Usage

<!-- UsageSnippet language="csharp" operationID="deleteModelCatalogEntry" method="delete" path="/api/v1/llm/models/catalog" -->
```csharp
using MeetKai.MKA1;
using MeetKai.MKA1.Types.Components;

var sdk = new SDK(bearerAuth: "<YOUR_BEARER_TOKEN_HERE>");

var res = await sdk.Llm.Models.DeleteCatalogEntryAsync(id: "meetkai:custom-chat-v1");

// handle response
```

### Parameters

| Parameter              | Type                   | Required               | Description            | Example                |
| ---------------------- | ---------------------- | ---------------------- | ---------------------- | ---------------------- |
| `Id`                   | *string*               | :heavy_check_mark:     | N/A                    | meetkai:custom-chat-v1 |

### Response

**[DeleteModelCatalogEntryResponse](../../Types/Requests/DeleteModelCatalogEntryResponse.md)**

### Errors

| Error Type                             | Status Code                            | Content Type                           |
| -------------------------------------- | -------------------------------------- | -------------------------------------- |
| MeetKai.MKA1.Types.Errors.APIException | 4XX, 5XX                               | \*/\*                                  |

## CheckCatalogHealth

Probes an available BYO definition whether or not it is active.

### Example Usage

<!-- UsageSnippet language="csharp" operationID="checkModelCatalogHealth" method="post" path="/api/v1/llm/models/catalog/health" -->
```csharp
using MeetKai.MKA1;
using MeetKai.MKA1.Types.Components;

var sdk = new SDK(bearerAuth: "<YOUR_BEARER_TOKEN_HERE>");

var res = await sdk.Llm.Models.CheckCatalogHealthAsync(id: "meetkai:custom-chat-v1");

// handle response
```

### Parameters

| Parameter              | Type                   | Required               | Description            | Example                |
| ---------------------- | ---------------------- | ---------------------- | ---------------------- | ---------------------- |
| `Id`                   | *string*               | :heavy_check_mark:     | N/A                    | meetkai:custom-chat-v1 |

### Response

**[CheckModelCatalogHealthResponse](../../Types/Requests/CheckModelCatalogHealthResponse.md)**

### Errors

| Error Type                             | Status Code                            | Content Type                           |
| -------------------------------------- | -------------------------------------- | -------------------------------------- |
| MeetKai.MKA1.Types.Errors.APIException | 4XX, 5XX                               | \*/\*                                  |

## ListCatalogOrgAccess

Cluster operator view of an org's available cluster catalog entries and their activation state.

### Example Usage

<!-- UsageSnippet language="csharp" operationID="listModelCatalogOrgAccess" method="get" path="/api/v1/llm/models/catalog/orgs/{org_id}/access" -->
```csharp
using MeetKai.MKA1;
using MeetKai.MKA1.Types.Components;

var sdk = new SDK(bearerAuth: "<YOUR_BEARER_TOKEN_HERE>");

var res = await sdk.Llm.Models.ListCatalogOrgAccessAsync(orgId: "org-acme");

// handle response
```

### Parameters

| Parameter          | Type               | Required           | Description        | Example            |
| ------------------ | ------------------ | ------------------ | ------------------ | ------------------ |
| `OrgId`            | *string*           | :heavy_check_mark: | N/A                | org-acme           |

### Response

**[ListModelCatalogOrgAccessResponse](../../Types/Requests/ListModelCatalogOrgAccessResponse.md)**

### Errors

| Error Type                             | Status Code                            | Content Type                           |
| -------------------------------------- | -------------------------------------- | -------------------------------------- |
| MeetKai.MKA1.Types.Errors.APIException | 4XX, 5XX                               | \*/\*                                  |

## AddCatalogOrgAccess

Idempotently adds availability without revoking any model names. Set activate to true to also activate every requested model from the cluster source in the target organization. Grants and activations are atomic per request; a name active from another source returns 409 without changing access or activation. Existing activation audit details are preserved on retries.

### Example Usage

<!-- UsageSnippet language="csharp" operationID="addModelCatalogOrgAccess" method="post" path="/api/v1/llm/models/catalog/orgs/{org_id}/access" -->
```csharp
using MeetKai.MKA1;
using MeetKai.MKA1.Types.Components;
using System.Collections.Generic;

var sdk = new SDK(bearerAuth: "<YOUR_BEARER_TOKEN_HERE>");

var res = await sdk.Llm.Models.AddCatalogOrgAccessAsync(
    orgId: "org-acme",
    body: new AddAccessMutationRequest() {
        ModelIds = new List<string>() {
            "functionary",
        },
        Activate = false,
    }
);

// handle response
```

### Parameters

| Parameter                                                                      | Type                                                                           | Required                                                                       | Description                                                                    | Example                                                                        |
| ------------------------------------------------------------------------------ | ------------------------------------------------------------------------------ | ------------------------------------------------------------------------------ | ------------------------------------------------------------------------------ | ------------------------------------------------------------------------------ |
| `OrgId`                                                                        | *string*                                                                       | :heavy_check_mark:                                                             | N/A                                                                            | org-acme                                                                       |
| `Body`                                                                         | [AddAccessMutationRequest](../../Types/Components/AddAccessMutationRequest.md) | :heavy_check_mark:                                                             | N/A                                                                            |                                                                                |

### Response

**[AddModelCatalogOrgAccessResponse](../../Types/Requests/AddModelCatalogOrgAccessResponse.md)**

### Errors

| Error Type                             | Status Code                            | Content Type                           |
| -------------------------------------- | -------------------------------------- | -------------------------------------- |
| MeetKai.MKA1.Types.Errors.APIException | 4XX, 5XX                               | \*/\*                                  |

## ReplaceCatalogOrgAccess

Serializable full replacement; revoked active cluster names are deactivated and their org price rows are closed.

### Example Usage

<!-- UsageSnippet language="csharp" operationID="replaceModelCatalogOrgAccess" method="put" path="/api/v1/llm/models/catalog/orgs/{org_id}/access" -->
```csharp
using MeetKai.MKA1;
using MeetKai.MKA1.Types.Components;
using System.Collections.Generic;

var sdk = new SDK(bearerAuth: "<YOUR_BEARER_TOKEN_HERE>");

var res = await sdk.Llm.Models.ReplaceCatalogOrgAccessAsync(
    orgId: "org-acme",
    body: new AccessMutationRequest() {
        ModelIds = new List<string>() {
            "functionary",
        },
    }
);

// handle response
```

### Parameters

| Parameter                                                                | Type                                                                     | Required                                                                 | Description                                                              | Example                                                                  |
| ------------------------------------------------------------------------ | ------------------------------------------------------------------------ | ------------------------------------------------------------------------ | ------------------------------------------------------------------------ | ------------------------------------------------------------------------ |
| `OrgId`                                                                  | *string*                                                                 | :heavy_check_mark:                                                       | N/A                                                                      | org-acme                                                                 |
| `Body`                                                                   | [AccessMutationRequest](../../Types/Components/AccessMutationRequest.md) | :heavy_check_mark:                                                       | N/A                                                                      |                                                                          |

### Response

**[ReplaceModelCatalogOrgAccessResponse](../../Types/Requests/ReplaceModelCatalogOrgAccessResponse.md)**

### Errors

| Error Type                             | Status Code                            | Content Type                           |
| -------------------------------------- | -------------------------------------- | -------------------------------------- |
| MeetKai.MKA1.Types.Errors.APIException | 4XX, 5XX                               | \*/\*                                  |

## ListCatalogModelAccess

Cluster operator reverse lookup showing availability and activation for one cluster catalog id.

### Example Usage

<!-- UsageSnippet language="csharp" operationID="listModelCatalogAccess" method="get" path="/api/v1/llm/models/catalog/access" -->
```csharp
using MeetKai.MKA1;
using MeetKai.MKA1.Types.Components;

var sdk = new SDK(bearerAuth: "<YOUR_BEARER_TOKEN_HERE>");

var res = await sdk.Llm.Models.ListCatalogModelAccessAsync(modelId: "functionary");

// handle response
```

### Parameters

| Parameter          | Type               | Required           | Description        | Example            |
| ------------------ | ------------------ | ------------------ | ------------------ | ------------------ |
| `ModelId`          | *string*           | :heavy_check_mark: | N/A                | functionary        |

### Response

**[ListModelCatalogAccessResponse](../../Types/Requests/ListModelCatalogAccessResponse.md)**

### Errors

| Error Type                             | Status Code                            | Content Type                           |
| -------------------------------------- | -------------------------------------- | -------------------------------------- |
| MeetKai.MKA1.Types.Errors.APIException | 4XX, 5XX                               | \*/\*                                  |

## ListRegistry

Single management view of every active name with source-qualified definition, health, price, and activation audit details.

### Example Usage

<!-- UsageSnippet language="csharp" operationID="listModelRegistry" method="get" path="/api/v1/llm/models/registry" -->
```csharp
using MeetKai.MKA1;
using MeetKai.MKA1.Types.Components;

var sdk = new SDK(bearerAuth: "<YOUR_BEARER_TOKEN_HERE>");

var res = await sdk.Llm.Models.ListRegistryAsync();

// handle response
```

### Response

**[ListModelRegistryResponse](../../Types/Requests/ListModelRegistryResponse.md)**

### Errors

| Error Type                             | Status Code                            | Content Type                           |
| -------------------------------------- | -------------------------------------- | -------------------------------------- |
| MeetKai.MKA1.Types.Errors.APIException | 4XX, 5XX                               | \*/\*                                  |

## ActivateRegistryEntry

Claims a model name from one catalog source. Re-activation from the same source is idempotent; a different holder returns 409.

### Example Usage

<!-- UsageSnippet language="csharp" operationID="activateModelRegistryEntry" method="post" path="/api/v1/llm/models/registry" -->
```csharp
using MeetKai.MKA1;
using MeetKai.MKA1.Types.Components;

var sdk = new SDK(bearerAuth: "<YOUR_BEARER_TOKEN_HERE>");

ActivateRegistryEntryRequest req = new ActivateRegistryEntryRequest() {
    Source = RegistrySource.Cluster,
    ModelId = "functionary",
};

var res = await sdk.Llm.Models.ActivateRegistryEntryAsync(req);

// handle response
```

### Parameters

| Parameter                                                                              | Type                                                                                   | Required                                                                               | Description                                                                            |
| -------------------------------------------------------------------------------------- | -------------------------------------------------------------------------------------- | -------------------------------------------------------------------------------------- | -------------------------------------------------------------------------------------- |
| `request`                                                                              | [ActivateRegistryEntryRequest](../../Types/Components/ActivateRegistryEntryRequest.md) | :heavy_check_mark:                                                                     | The request object to use for the request.                                             |

### Response

**[ActivateModelRegistryEntryResponse](../../Types/Requests/ActivateModelRegistryEntryResponse.md)**

### Errors

| Error Type                             | Status Code                            | Content Type                           |
| -------------------------------------- | -------------------------------------- | -------------------------------------- |
| MeetKai.MKA1.Types.Errors.APIException | 4XX, 5XX                               | \*/\*                                  |

## DeactivateRegistryEntry

Idempotently removes the active name and closes its org-scope price rows without touching the catalog definition.

### Example Usage

<!-- UsageSnippet language="csharp" operationID="deactivateModelRegistryEntry" method="delete" path="/api/v1/llm/models/registry" -->
```csharp
using MeetKai.MKA1;
using MeetKai.MKA1.Types.Components;

var sdk = new SDK(bearerAuth: "<YOUR_BEARER_TOKEN_HERE>");

var res = await sdk.Llm.Models.DeactivateRegistryEntryAsync(id: "functionary");

// handle response
```

### Parameters

| Parameter          | Type               | Required           | Description        | Example            |
| ------------------ | ------------------ | ------------------ | ------------------ | ------------------ |
| `Id`               | *string*           | :heavy_check_mark: | N/A                | functionary        |

### Response

**[DeactivateModelRegistryEntryResponse](../../Types/Requests/DeactivateModelRegistryEntryResponse.md)**

### Errors

| Error Type                             | Status Code                            | Content Type                           |
| -------------------------------------- | -------------------------------------- | -------------------------------------- |
| MeetKai.MKA1.Types.Errors.APIException | 4XX, 5XX                               | \*/\*                                  |

## ListOrgAutoModels

Returns every endpoint for which this org has set its own `"auto"` target. Endpoints not listed fall through to the operator's YAML defaults.

### Example Usage

<!-- UsageSnippet language="csharp" operationID="listOrgAutoModels" method="get" path="/api/v1/llm/models/auto" -->
```csharp
using MeetKai.MKA1;
using MeetKai.MKA1.Types.Components;

var sdk = new SDK(bearerAuth: "<YOUR_BEARER_TOKEN_HERE>");

var res = await sdk.Llm.Models.ListOrgAutoModelsAsync();

// handle response
```

### Response

**[Types.Requests.ListOrgAutoModelsResponse](../../Types/Requests/ListOrgAutoModelsResponse.md)**

### Errors

| Error Type                             | Status Code                            | Content Type                           |
| -------------------------------------- | -------------------------------------- | -------------------------------------- |
| MeetKai.MKA1.Types.Errors.APIException | 4XX, 5XX                               | \*/\*                                  |

## PutOrgAutoModel

Stores either the existing direct `{ endpoint → model_id }` alias or a judge policy with candidate models. Judge routing is supported for responses, completions, transcriptions, and TTS. The judge must be a non-reasoning text LLM. All configured models must be active when written; revoked candidates are filtered at request time, while an unavailable judge is an explicit error.

### Example Usage

<!-- UsageSnippet language="csharp" operationID="putOrgAutoModel" method="put" path="/api/v1/llm/models/auto/{endpoint}" -->
```csharp
using MeetKai.MKA1;
using MeetKai.MKA1.Types.Components;
using System.Collections.Generic;

var sdk = new SDK(bearerAuth: "<YOUR_BEARER_TOKEN_HERE>");

var res = await sdk.Llm.Models.PutOrgAutoModelAsync(
    endpoint: AutoEndpoint.Responses,
    body: PutOrgAutoModelRequestUnion.CreatePutOrgAutoModelRequest2(
        new PutOrgAutoModelRequest2() {
            Policy = Policy.Price,
            JudgeModelId = "meetkai:functionary-es-mini",
            CandidateModelIds = new List<string>() {
                "meetkai:functionary-pt",
                "meetkai:functionary-es",
            },
        }
    )
);

// handle response
```

### Parameters

| Parameter                                                                            | Type                                                                                 | Required                                                                             | Description                                                                          | Example                                                                              |
| ------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------ |
| `Endpoint`                                                                           | [AutoEndpoint](../../Types/Components/AutoEndpoint.md)                               | :heavy_check_mark:                                                                   | N/A                                                                                  | responses                                                                            |
| `Body`                                                                               | [PutOrgAutoModelRequestUnion](../../Types/Components/PutOrgAutoModelRequestUnion.md) | :heavy_check_mark:                                                                   | N/A                                                                                  |                                                                                      |

### Response

**[PutOrgAutoModelResponse](../../Types/Requests/PutOrgAutoModelResponse.md)**

### Errors

| Error Type                             | Status Code                            | Content Type                           |
| -------------------------------------- | -------------------------------------- | -------------------------------------- |
| MeetKai.MKA1.Types.Errors.APIException | 4XX, 5XX                               | \*/\*                                  |

## DeleteOrgAutoModel

Removes the per-org override for the endpoint. Subsequent `model: "auto"` requests fall through to the operator's YAML default again.

### Example Usage

<!-- UsageSnippet language="csharp" operationID="deleteOrgAutoModel" method="delete" path="/api/v1/llm/models/auto/{endpoint}" -->
```csharp
using MeetKai.MKA1;
using MeetKai.MKA1.Types.Components;

var sdk = new SDK(bearerAuth: "<YOUR_BEARER_TOKEN_HERE>");

var res = await sdk.Llm.Models.DeleteOrgAutoModelAsync(endpoint: AutoEndpoint.Responses);

// handle response
```

### Parameters

| Parameter                                              | Type                                                   | Required                                               | Description                                            | Example                                                |
| ------------------------------------------------------ | ------------------------------------------------------ | ------------------------------------------------------ | ------------------------------------------------------ | ------------------------------------------------------ |
| `Endpoint`                                             | [AutoEndpoint](../../Types/Components/AutoEndpoint.md) | :heavy_check_mark:                                     | N/A                                                    | responses                                              |

### Response

**[Types.Requests.DeleteOrgAutoModelResponse](../../Types/Requests/DeleteOrgAutoModelResponse.md)**

### Errors

| Error Type                             | Status Code                            | Content Type                           |
| -------------------------------------- | -------------------------------------- | -------------------------------------- |
| MeetKai.MKA1.Types.Errors.APIException | 4XX, 5XX                               | \*/\*                                  |

## GetClusterCurrency

Returns the single cluster-wide ISO-4217 currency code (null if not set).

### Example Usage

<!-- UsageSnippet language="csharp" operationID="getClusterCurrency" method="get" path="/api/v1/llm/models/pricing/currency" -->
```csharp
using MeetKai.MKA1;
using MeetKai.MKA1.Types.Components;

var sdk = new SDK(bearerAuth: "<YOUR_BEARER_TOKEN_HERE>");

var res = await sdk.Llm.Models.GetClusterCurrencyAsync();

// handle response
```

### Response

**[GetClusterCurrencyResponse](../../Types/Requests/GetClusterCurrencyResponse.md)**

### Errors

| Error Type                             | Status Code                            | Content Type                           |
| -------------------------------------- | -------------------------------------- | -------------------------------------- |
| MeetKai.MKA1.Types.Errors.APIException | 4XX, 5XX                               | \*/\*                                  |

## SetClusterCurrency

Sets the cluster-wide currency. Changing it does not auto-convert existing prices.

### Example Usage

<!-- UsageSnippet language="csharp" operationID="setClusterCurrency" method="put" path="/api/v1/llm/models/pricing/currency" -->
```csharp
using MeetKai.MKA1;
using MeetKai.MKA1.Types.Components;

var sdk = new SDK(bearerAuth: "<YOUR_BEARER_TOKEN_HERE>");

PutClusterCurrencyBody req = new PutClusterCurrencyBody() {
    Currency = "Nakfa",
};

var res = await sdk.Llm.Models.SetClusterCurrencyAsync(req);

// handle response
```

### Parameters

| Parameter                                                                  | Type                                                                       | Required                                                                   | Description                                                                |
| -------------------------------------------------------------------------- | -------------------------------------------------------------------------- | -------------------------------------------------------------------------- | -------------------------------------------------------------------------- |
| `request`                                                                  | [PutClusterCurrencyBody](../../Types/Components/PutClusterCurrencyBody.md) | :heavy_check_mark:                                                         | The request object to use for the request.                                 |

### Response

**[SetClusterCurrencyResponse](../../Types/Requests/SetClusterCurrencyResponse.md)**

### Errors

| Error Type                             | Status Code                            | Content Type                           |
| -------------------------------------- | -------------------------------------- | -------------------------------------- |
| MeetKai.MKA1.Types.Errors.APIException | 4XX, 5XX                               | \*/\*                                  |

## ListClusterPrices

Without `model`, lists every model's current cluster-default price. With `model`, returns that model's full dated history.

### Example Usage

<!-- UsageSnippet language="csharp" operationID="listClusterPrices" method="get" path="/api/v1/llm/models/pricing" -->
```csharp
using MeetKai.MKA1;
using MeetKai.MKA1.Types.Components;

var sdk = new SDK(bearerAuth: "<YOUR_BEARER_TOKEN_HERE>");

var res = await sdk.Llm.Models.ListClusterPricesAsync();

// handle response
```

### Parameters

| Parameter          | Type               | Required           | Description        |
| ------------------ | ------------------ | ------------------ | ------------------ |
| `Model`            | *string*           | :heavy_minus_sign: | N/A                |

### Response

**[ListClusterPricesResponse](../../Types/Requests/ListClusterPricesResponse.md)**

### Errors

| Error Type                             | Status Code                            | Content Type                           |
| -------------------------------------- | -------------------------------------- | -------------------------------------- |
| MeetKai.MKA1.Types.Errors.APIException | 4XX, 5XX                               | \*/\*                                  |

## SetClusterPrice

Upserts the cluster-default price for a model as a new dated version. `rates` is a flexible metric→rate map; omitted metrics are not charged.

### Example Usage

<!-- UsageSnippet language="csharp" operationID="setClusterPrice" method="put" path="/api/v1/llm/models/pricing" -->
```csharp
using MeetKai.MKA1;
using MeetKai.MKA1.Types.Components;

var sdk = new SDK(bearerAuth: "<YOUR_BEARER_TOKEN_HERE>");

PutModelPriceBody req = new PutModelPriceBody() {
    Model = "Cruze",
    Rates = new PutModelPriceBodyRates() {},
};

var res = await sdk.Llm.Models.SetClusterPriceAsync(req);

// handle response
```

### Parameters

| Parameter                                                        | Type                                                             | Required                                                         | Description                                                      |
| ---------------------------------------------------------------- | ---------------------------------------------------------------- | ---------------------------------------------------------------- | ---------------------------------------------------------------- |
| `request`                                                        | [PutModelPriceBody](../../Types/Components/PutModelPriceBody.md) | :heavy_check_mark:                                               | The request object to use for the request.                       |

### Response

**[SetClusterPriceResponse](../../Types/Requests/SetClusterPriceResponse.md)**

### Errors

| Error Type                             | Status Code                            | Content Type                           |
| -------------------------------------- | -------------------------------------- | -------------------------------------- |
| MeetKai.MKA1.Types.Errors.APIException | 4XX, 5XX                               | \*/\*                                  |

## ClearClusterPrice

Closes the cluster-default price. Active cluster lineage then uses an org override or becomes unpriced ($0).

### Example Usage

<!-- UsageSnippet language="csharp" operationID="clearClusterPrice" method="delete" path="/api/v1/llm/models/pricing" -->
```csharp
using MeetKai.MKA1;
using MeetKai.MKA1.Types.Components;

var sdk = new SDK(bearerAuth: "<YOUR_BEARER_TOKEN_HERE>");

var res = await sdk.Llm.Models.ClearClusterPriceAsync(model: "Alpine");

// handle response
```

### Parameters

| Parameter          | Type               | Required           | Description        |
| ------------------ | ------------------ | ------------------ | ------------------ |
| `Model`            | *string*           | :heavy_check_mark: | N/A                |

### Response

**[ClearClusterPriceResponse](../../Types/Requests/ClearClusterPriceResponse.md)**

### Errors

| Error Type                             | Status Code                            | Content Type                           |
| -------------------------------------- | -------------------------------------- | -------------------------------------- |
| MeetKai.MKA1.Types.Errors.APIException | 4XX, 5XX                               | \*/\*                                  |

## ListOrgPrices

Without `model`, lists the org's current overrides. With `model`, returns that override's dated history.

### Example Usage

<!-- UsageSnippet language="csharp" operationID="listOrgPrices" method="get" path="/api/v1/llm/models/pricing/org/{org_id}" -->
```csharp
using MeetKai.MKA1;
using MeetKai.MKA1.Types.Components;

var sdk = new SDK(bearerAuth: "<YOUR_BEARER_TOKEN_HERE>");

var res = await sdk.Llm.Models.ListOrgPricesAsync(orgId: "<id>");

// handle response
```

### Parameters

| Parameter          | Type               | Required           | Description        |
| ------------------ | ------------------ | ------------------ | ------------------ |
| `OrgId`            | *string*           | :heavy_check_mark: | N/A                |
| `Model`            | *string*           | :heavy_minus_sign: | N/A                |

### Response

**[ListOrgPricesResponse](../../Types/Requests/ListOrgPricesResponse.md)**

### Errors

| Error Type                             | Status Code                            | Content Type                           |
| -------------------------------------- | -------------------------------------- | -------------------------------------- |
| MeetKai.MKA1.Types.Errors.APIException | 4XX, 5XX                               | \*/\*                                  |

## SetOrgPrice

Upserts a dated per-org price. Cluster lineage falls back to the cluster default; BYO and serving lineage become unpriced when no org row exists.

### Example Usage

<!-- UsageSnippet language="csharp" operationID="setOrgPrice" method="put" path="/api/v1/llm/models/pricing/org/{org_id}" -->
```csharp
using MeetKai.MKA1;
using MeetKai.MKA1.Types.Components;

var sdk = new SDK(bearerAuth: "<YOUR_BEARER_TOKEN_HERE>");

var res = await sdk.Llm.Models.SetOrgPriceAsync(
    orgId: "<id>",
    body: new PutModelPriceBody() {
        Model = "Roadster",
        Rates = new PutModelPriceBodyRates() {},
    }
);

// handle response
```

### Parameters

| Parameter                                                        | Type                                                             | Required                                                         | Description                                                      |
| ---------------------------------------------------------------- | ---------------------------------------------------------------- | ---------------------------------------------------------------- | ---------------------------------------------------------------- |
| `OrgId`                                                          | *string*                                                         | :heavy_check_mark:                                               | N/A                                                              |
| `Body`                                                           | [PutModelPriceBody](../../Types/Components/PutModelPriceBody.md) | :heavy_check_mark:                                               | N/A                                                              |

### Response

**[SetOrgPriceResponse](../../Types/Requests/SetOrgPriceResponse.md)**

### Errors

| Error Type                             | Status Code                            | Content Type                           |
| -------------------------------------- | -------------------------------------- | -------------------------------------- |
| MeetKai.MKA1.Types.Errors.APIException | 4XX, 5XX                               | \*/\*                                  |

## ClearOrgPrice

Closes a per-org price. Only active cluster lineage can then fall back to the cluster default.

### Example Usage

<!-- UsageSnippet language="csharp" operationID="clearOrgPrice" method="delete" path="/api/v1/llm/models/pricing/org/{org_id}" -->
```csharp
using MeetKai.MKA1;
using MeetKai.MKA1.Types.Components;

var sdk = new SDK(bearerAuth: "<YOUR_BEARER_TOKEN_HERE>");

var res = await sdk.Llm.Models.ClearOrgPriceAsync(
    orgId: "<id>",
    model: "XTS"
);

// handle response
```

### Parameters

| Parameter          | Type               | Required           | Description        |
| ------------------ | ------------------ | ------------------ | ------------------ |
| `OrgId`            | *string*           | :heavy_check_mark: | N/A                |
| `Model`            | *string*           | :heavy_check_mark: | N/A                |

### Response

**[ClearOrgPriceResponse](../../Types/Requests/ClearOrgPriceResponse.md)**

### Errors

| Error Type                             | Status Code                            | Content Type                           |
| -------------------------------------- | -------------------------------------- | -------------------------------------- |
| MeetKai.MKA1.Types.Errors.APIException | 4XX, 5XX                               | \*/\*                                  |

## ListEffectivePrices

For every active model, returns its registry-aware price: an org row, a cluster default for cluster lineage, or unpriced ($0). Also lists the `auto` routing alias, priced at the per-metric maximum across every model it can be billed as (`resolves_to`): a judge policy's active candidates, or the direct/YAML target plus any reroute target it can fall through to.

### Example Usage

<!-- UsageSnippet language="csharp" operationID="listEffectivePrices" method="get" path="/api/v1/llm/models/pricing/effective" -->
```csharp
using MeetKai.MKA1;
using MeetKai.MKA1.Types.Components;

var sdk = new SDK(bearerAuth: "<YOUR_BEARER_TOKEN_HERE>");

var res = await sdk.Llm.Models.ListEffectivePricesAsync();

// handle response
```

### Parameters

| Parameter                                                           | Type                                                                | Required                                                            | Description                                                         |
| ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- |
| `XOnBehalfOf`                                                       | *string*                                                            | :heavy_minus_sign:                                                  | Optional external end-user identifier forwarded by the API gateway. |

### Response

**[ListEffectivePricesResponse](../../Types/Requests/ListEffectivePricesResponse.md)**

### Errors

| Error Type                             | Status Code                            | Content Type                           |
| -------------------------------------- | -------------------------------------- | -------------------------------------- |
| MeetKai.MKA1.Types.Errors.APIException | 4XX, 5XX                               | \*/\*                                  |