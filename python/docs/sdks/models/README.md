# Llm.Models

## Overview

### Available Operations

* [list](#list) - List available models
* [get](#get) - Retrieve a model
* [list_catalog](#list_catalog) - List the organization's model catalog
* [add_catalog_entry](#add_catalog_entry) - Define a BYO catalog model
* [update_catalog_entry](#update_catalog_entry) - Update a BYO catalog model
* [delete_catalog_entry](#delete_catalog_entry) - Remove a BYO catalog model
* [check_catalog_health](#check_catalog_health) - Check a BYO catalog model's health
* [list_catalog_org_access](#list_catalog_org_access) - List an organization's cluster model access
* [add_catalog_org_access](#add_catalog_org_access) - Add cluster model access for an organization
* [replace_catalog_org_access](#replace_catalog_org_access) - Replace an organization's cluster model access
* [list_catalog_model_access](#list_catalog_model_access) - List organizations with access to a cluster model
* [list_registry](#list_registry) - List the organization's active model registry
* [activate_registry_entry](#activate_registry_entry) - Activate a catalog entry
* [deactivate_registry_entry](#deactivate_registry_entry) - Deactivate a model registry name
* [list_org_auto_models](#list_org_auto_models) - List this org's auto-model overrides
* [put_org_auto_model](#put_org_auto_model) - Set this org's auto policy for an endpoint
* [delete_org_auto_model](#delete_org_auto_model) - Clear this org's auto-model override for an endpoint
* [get_cluster_currency](#get_cluster_currency) - Get the cluster currency
* [set_cluster_currency](#set_cluster_currency) - Set the cluster currency
* [list_cluster_prices](#list_cluster_prices) - List cluster-default model prices
* [set_cluster_price](#set_cluster_price) - Set a cluster-default model price
* [clear_cluster_price](#clear_cluster_price) - Clear a cluster-default model price
* [list_org_prices](#list_org_prices) - List an org's price overrides
* [set_org_price](#set_org_price) - Set an org price override
* [clear_org_price](#clear_org_price) - Clear an org price override
* [list_effective_prices](#list_effective_prices) - List effective prices for the caller's models

## list

Lists the currently available models. Provides basic information about each model including its ID and owner.

### Example Usage

<!-- UsageSnippet language="python" operationID="listModels" method="get" path="/api/v1/llm/models" -->
```python
from meetkai_mka1 import SDK


with SDK(
    bearer_auth="<YOUR_BEARER_TOKEN_HERE>",
) as sdk:

    res = sdk.llm.models.list()

    # Handle response
    print(res)

```

### Parameters

| Parameter                                                           | Type                                                                | Required                                                            | Description                                                         |
| ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- |
| `x_on_behalf_of`                                                    | *Optional[str]*                                                     | :heavy_minus_sign:                                                  | Optional external end-user identifier forwarded by the API gateway. |
| `retries`                                                           | [Optional[utils.RetryConfig]](../../models/utils/retryconfig.md)    | :heavy_minus_sign:                                                  | Configuration to override the default retry behavior of the client. |

### Response

**[models.ListModelsResponse](../../models/listmodelsresponse.md)**

### Errors

| Error Type             | Status Code            | Content Type           |
| ---------------------- | ---------------------- | ---------------------- |
| errors.SDKDefaultError | 4XX, 5XX               | \*/\*                  |

## get

Retrieves a model instance, providing basic information about the model such as the owner and supported capabilities.

### Example Usage

<!-- UsageSnippet language="python" operationID="getModel" method="get" path="/api/v1/llm/models/{model_id}" -->
```python
from meetkai_mka1 import SDK


with SDK(
    bearer_auth="<YOUR_BEARER_TOKEN_HERE>",
) as sdk:

    res = sdk.llm.models.get(model_id="meetkai:functionary-urdu-mini-pak")

    # Handle response
    print(res)

```

### Parameters

| Parameter                                                           | Type                                                                | Required                                                            | Description                                                         | Example                                                             |
| ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- |
| `model_id`                                                          | *str*                                                               | :heavy_check_mark:                                                  | N/A                                                                 | meetkai:functionary-urdu-mini-pak                                   |
| `x_on_behalf_of`                                                    | *Optional[str]*                                                     | :heavy_minus_sign:                                                  | Optional external end-user identifier forwarded by the API gateway. |                                                                     |
| `retries`                                                           | [Optional[utils.RetryConfig]](../../models/utils/retryconfig.md)    | :heavy_minus_sign:                                                  | Configuration to override the default retry behavior of the client. |                                                                     |

### Response

**[models.GetModelResponse](../../models/getmodelresponse.md)**

### Errors

| Error Type             | Status Code            | Content Type           |
| ---------------------- | ---------------------- | ---------------------- |
| errors.SDKDefaultError | 4XX, 5XX               | \*/\*                  |

## list_catalog

Lists all BYO, serving, and cluster-access definitions with activation state, blocker, health, and price preview.

### Example Usage

<!-- UsageSnippet language="python" operationID="listModelCatalog" method="get" path="/api/v1/llm/models/catalog" -->
```python
from meetkai_mka1 import SDK


with SDK(
    bearer_auth="<YOUR_BEARER_TOKEN_HERE>",
) as sdk:

    res = sdk.llm.models.list_catalog()

    # Handle response
    print(res)

```

### Parameters

| Parameter                                                           | Type                                                                | Required                                                            | Description                                                         |
| ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- |
| `retries`                                                           | [Optional[utils.RetryConfig]](../../models/utils/retryconfig.md)    | :heavy_minus_sign:                                                  | Configuration to override the default retry behavior of the client. |

### Response

**[models.CatalogListResponse](../../models/cataloglistresponse.md)**

### Errors

| Error Type             | Status Code            | Content Type           |
| ---------------------- | ---------------------- | ---------------------- |
| errors.SDKDefaultError | 4XX, 5XX               | \*/\*                  |

## add_catalog_entry

Creates an API-owned BYO definition without activating its name.

### Example Usage

<!-- UsageSnippet language="python" operationID="addModelCatalogEntry" method="post" path="/api/v1/llm/models/catalog" -->
```python
from meetkai_mka1 import SDK


with SDK(
    bearer_auth="<YOUR_BEARER_TOKEN_HERE>",
) as sdk:

    res = sdk.llm.models.add_catalog_entry(id="meetkai:custom-chat-v1", provider="openai-compatible", model_id="custom-chat-v1", api_format="responses", api_provider_type="openai", created=1704067200, auth={
        "type": "api-key",
        "value": "sk-provider-key",
    }, capabilities={
        "modalities": {
            "input": [
                "text",
            ],
            "output": [
                "text",
            ],
        },
        "reasoning": True,
    }, display_name="Custom Chat v1", base_url="https://models.example.com/v1")

    # Handle response
    print(res)

```

### Parameters

| Parameter                                                                                                         | Type                                                                                                              | Required                                                                                                          | Description                                                                                                       | Example                                                                                                           |
| ----------------------------------------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------------------------------------- |
| `id`                                                                                                              | *str*                                                                                                             | :heavy_check_mark:                                                                                                | N/A                                                                                                               |                                                                                                                   |
| `provider`                                                                                                        | *str*                                                                                                             | :heavy_check_mark:                                                                                                | N/A                                                                                                               |                                                                                                                   |
| `model_id`                                                                                                        | *str*                                                                                                             | :heavy_check_mark:                                                                                                | N/A                                                                                                               |                                                                                                                   |
| `api_format`                                                                                                      | [models.AutoEndpoint](../../models/autoendpoint.md)                                                               | :heavy_check_mark:                                                                                                | N/A                                                                                                               | responses                                                                                                         |
| `api_provider_type`                                                                                               | [models.AddCatalogModelRequestAPIProviderType](../../models/addcatalogmodelrequestapiprovidertype.md)             | :heavy_check_mark:                                                                                                | N/A                                                                                                               |                                                                                                                   |
| `created`                                                                                                         | *int*                                                                                                             | :heavy_check_mark:                                                                                                | N/A                                                                                                               |                                                                                                                   |
| `auth`                                                                                                            | [models.AddCatalogModelRequestAuthUnion](../../models/addcatalogmodelrequestauthunion.md)                         | :heavy_check_mark:                                                                                                | N/A                                                                                                               |                                                                                                                   |
| `capabilities`                                                                                                    | [models.AddCatalogModelRequestCapabilities](../../models/addcatalogmodelrequestcapabilities.md)                   | :heavy_check_mark:                                                                                                | N/A                                                                                                               |                                                                                                                   |
| `display_name`                                                                                                    | *Optional[str]*                                                                                                   | :heavy_minus_sign:                                                                                                | N/A                                                                                                               |                                                                                                                   |
| `base_url`                                                                                                        | *Optional[str]*                                                                                                   | :heavy_minus_sign:                                                                                                | N/A                                                                                                               |                                                                                                                   |
| `context_window`                                                                                                  | *Optional[int]*                                                                                                   | :heavy_minus_sign:                                                                                                | N/A                                                                                                               |                                                                                                                   |
| `rpm`                                                                                                             | *Optional[int]*                                                                                                   | :heavy_minus_sign:                                                                                                | N/A                                                                                                               |                                                                                                                   |
| `rate_limits`                                                                                                     | List[[models.RateLimit](../../models/ratelimit.md)]                                                               | :heavy_minus_sign:                                                                                                | N/A                                                                                                               |                                                                                                                   |
| `concurrency`                                                                                                     | [Optional[models.AddCatalogModelRequestConcurrency]](../../models/addcatalogmodelrequestconcurrency.md)           | :heavy_minus_sign:                                                                                                | N/A                                                                                                               |                                                                                                                   |
| `request_timeout_ms`                                                                                              | *Optional[int]*                                                                                                   | :heavy_minus_sign:                                                                                                | N/A                                                                                                               |                                                                                                                   |
| `max_retries`                                                                                                     | *Optional[int]*                                                                                                   | :heavy_minus_sign:                                                                                                | N/A                                                                                                               |                                                                                                                   |
| `default_params`                                                                                                  | [Optional[models.AddCatalogModelRequestDefaultParams]](../../models/addcatalogmodelrequestdefaultparams.md)       | :heavy_minus_sign:                                                                                                | N/A                                                                                                               |                                                                                                                   |
| `reroute_rules`                                                                                                   | List[[models.RerouteRule](../../models/rerouterule.md)]                                                           | :heavy_minus_sign:                                                                                                | N/A                                                                                                               |                                                                                                                   |
| `hidden`                                                                                                          | *Optional[bool]*                                                                                                  | :heavy_minus_sign:                                                                                                | N/A                                                                                                               |                                                                                                                   |
| `embedding_limits`                                                                                                | [Optional[models.AddCatalogModelRequestEmbeddingLimits]](../../models/addcatalogmodelrequestembeddinglimits.md)   | :heavy_minus_sign:                                                                                                | N/A                                                                                                               |                                                                                                                   |
| `health_check`                                                                                                    | [Optional[models.AddCatalogModelRequestHealthCheckUnion]](../../models/addcatalogmodelrequesthealthcheckunion.md) | :heavy_minus_sign:                                                                                                | N/A                                                                                                               |                                                                                                                   |
| `model_card`                                                                                                      | [Optional[models.AddCatalogModelRequestModelCard]](../../models/addcatalogmodelrequestmodelcard.md)               | :heavy_minus_sign:                                                                                                | N/A                                                                                                               |                                                                                                                   |
| `retries`                                                                                                         | [Optional[utils.RetryConfig]](../../models/utils/retryconfig.md)                                                  | :heavy_minus_sign:                                                                                                | Configuration to override the default retry behavior of the client.                                               |                                                                                                                   |

### Response

**[models.CatalogEntry](../../models/catalogentry.md)**

### Errors

| Error Type             | Status Code            | Content Type           |
| ---------------------- | ---------------------- | ---------------------- |
| errors.SDKDefaultError | 4XX, 5XX               | \*/\*                  |

## update_catalog_entry

Updates an API-owned BYO definition; yaml-origin entries are file-managed and immutable through this API.

### Example Usage

<!-- UsageSnippet language="python" operationID="updateModelCatalogEntry" method="patch" path="/api/v1/llm/models/catalog" -->
```python
from meetkai_mka1 import SDK


with SDK(
    bearer_auth="<YOUR_BEARER_TOKEN_HERE>",
) as sdk:

    res = sdk.llm.models.update_catalog_entry(id="meetkai:custom-chat-v1", display_name="Custom Chat v2", api_format="responses", rpm=240)

    # Handle response
    print(res)

```

### Parameters

| Parameter                                                                                                                       | Type                                                                                                                            | Required                                                                                                                        | Description                                                                                                                     | Example                                                                                                                         |
| ------------------------------------------------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------------------------------------------------- |
| `id`                                                                                                                            | *str*                                                                                                                           | :heavy_check_mark:                                                                                                              | N/A                                                                                                                             |                                                                                                                                 |
| `provider`                                                                                                                      | *Optional[str]*                                                                                                                 | :heavy_minus_sign:                                                                                                              | N/A                                                                                                                             |                                                                                                                                 |
| `model_id`                                                                                                                      | *Optional[str]*                                                                                                                 | :heavy_minus_sign:                                                                                                              | N/A                                                                                                                             |                                                                                                                                 |
| `display_name`                                                                                                                  | *OptionalNullable[str]*                                                                                                         | :heavy_minus_sign:                                                                                                              | N/A                                                                                                                             |                                                                                                                                 |
| `base_url`                                                                                                                      | *OptionalNullable[str]*                                                                                                         | :heavy_minus_sign:                                                                                                              | N/A                                                                                                                             |                                                                                                                                 |
| `api_format`                                                                                                                    | [Optional[models.AutoEndpoint]](../../models/autoendpoint.md)                                                                   | :heavy_minus_sign:                                                                                                              | N/A                                                                                                                             | responses                                                                                                                       |
| `api_provider_type`                                                                                                             | [Optional[models.UpdateCatalogModelRequestAPIProviderType]](../../models/updatecatalogmodelrequestapiprovidertype.md)           | :heavy_minus_sign:                                                                                                              | N/A                                                                                                                             |                                                                                                                                 |
| `created`                                                                                                                       | *Optional[int]*                                                                                                                 | :heavy_minus_sign:                                                                                                              | N/A                                                                                                                             |                                                                                                                                 |
| `auth`                                                                                                                          | [Optional[models.UpdateCatalogModelRequestAuthUnion]](../../models/updatecatalogmodelrequestauthunion.md)                       | :heavy_minus_sign:                                                                                                              | N/A                                                                                                                             |                                                                                                                                 |
| `capabilities`                                                                                                                  | [Optional[models.UpdateCatalogModelRequestCapabilities]](../../models/updatecatalogmodelrequestcapabilities.md)                 | :heavy_minus_sign:                                                                                                              | N/A                                                                                                                             |                                                                                                                                 |
| `context_window`                                                                                                                | *OptionalNullable[int]*                                                                                                         | :heavy_minus_sign:                                                                                                              | N/A                                                                                                                             |                                                                                                                                 |
| `rpm`                                                                                                                           | *OptionalNullable[int]*                                                                                                         | :heavy_minus_sign:                                                                                                              | N/A                                                                                                                             |                                                                                                                                 |
| `rate_limits`                                                                                                                   | List[[models.RateLimits](../../models/ratelimits.md)]                                                                           | :heavy_minus_sign:                                                                                                              | N/A                                                                                                                             |                                                                                                                                 |
| `concurrency`                                                                                                                   | [OptionalNullable[models.UpdateCatalogModelRequestConcurrency]](../../models/updatecatalogmodelrequestconcurrency.md)           | :heavy_minus_sign:                                                                                                              | N/A                                                                                                                             |                                                                                                                                 |
| `request_timeout_ms`                                                                                                            | *OptionalNullable[int]*                                                                                                         | :heavy_minus_sign:                                                                                                              | N/A                                                                                                                             |                                                                                                                                 |
| `max_retries`                                                                                                                   | *OptionalNullable[int]*                                                                                                         | :heavy_minus_sign:                                                                                                              | N/A                                                                                                                             |                                                                                                                                 |
| `default_params`                                                                                                                | [OptionalNullable[models.UpdateCatalogModelRequestDefaultParams]](../../models/updatecatalogmodelrequestdefaultparams.md)       | :heavy_minus_sign:                                                                                                              | N/A                                                                                                                             |                                                                                                                                 |
| `reroute_rules`                                                                                                                 | List[[models.RerouteRules](../../models/rerouterules.md)]                                                                       | :heavy_minus_sign:                                                                                                              | N/A                                                                                                                             |                                                                                                                                 |
| `hidden`                                                                                                                        | *OptionalNullable[bool]*                                                                                                        | :heavy_minus_sign:                                                                                                              | N/A                                                                                                                             |                                                                                                                                 |
| `embedding_limits`                                                                                                              | [OptionalNullable[models.UpdateCatalogModelRequestEmbeddingLimits]](../../models/updatecatalogmodelrequestembeddinglimits.md)   | :heavy_minus_sign:                                                                                                              | N/A                                                                                                                             |                                                                                                                                 |
| `health_check`                                                                                                                  | [OptionalNullable[models.UpdateCatalogModelRequestHealthCheckUnion]](../../models/updatecatalogmodelrequesthealthcheckunion.md) | :heavy_minus_sign:                                                                                                              | N/A                                                                                                                             |                                                                                                                                 |
| `model_card`                                                                                                                    | [OptionalNullable[models.UpdateCatalogModelRequestModelCard]](../../models/updatecatalogmodelrequestmodelcard.md)               | :heavy_minus_sign:                                                                                                              | N/A                                                                                                                             |                                                                                                                                 |
| `retries`                                                                                                                       | [Optional[utils.RetryConfig]](../../models/utils/retryconfig.md)                                                                | :heavy_minus_sign:                                                                                                              | Configuration to override the default retry behavior of the client.                                                             |                                                                                                                                 |

### Response

**[models.CatalogEntry](../../models/catalogentry.md)**

### Errors

| Error Type             | Status Code            | Content Type           |
| ---------------------- | ---------------------- | ---------------------- |
| errors.SDKDefaultError | 4XX, 5XX               | \*/\*                  |

## delete_catalog_entry

Withdraws a BYO definition and deactivates it only when the active name is sourced from that BYO lineage.

### Example Usage

<!-- UsageSnippet language="python" operationID="deleteModelCatalogEntry" method="delete" path="/api/v1/llm/models/catalog" -->
```python
from meetkai_mka1 import SDK


with SDK(
    bearer_auth="<YOUR_BEARER_TOKEN_HERE>",
) as sdk:

    res = sdk.llm.models.delete_catalog_entry(id="meetkai:custom-chat-v1")

    # Handle response
    print(res)

```

### Parameters

| Parameter                                                           | Type                                                                | Required                                                            | Description                                                         | Example                                                             |
| ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- |
| `id`                                                                | *str*                                                               | :heavy_check_mark:                                                  | N/A                                                                 | meetkai:custom-chat-v1                                              |
| `retries`                                                           | [Optional[utils.RetryConfig]](../../models/utils/retryconfig.md)    | :heavy_minus_sign:                                                  | Configuration to override the default retry behavior of the client. |                                                                     |

### Response

**[models.DeleteCatalogModelResponse](../../models/deletecatalogmodelresponse.md)**

### Errors

| Error Type             | Status Code            | Content Type           |
| ---------------------- | ---------------------- | ---------------------- |
| errors.SDKDefaultError | 4XX, 5XX               | \*/\*                  |

## check_catalog_health

Probes an available BYO definition whether or not it is active.

### Example Usage

<!-- UsageSnippet language="python" operationID="checkModelCatalogHealth" method="post" path="/api/v1/llm/models/catalog/health" -->
```python
from meetkai_mka1 import SDK


with SDK(
    bearer_auth="<YOUR_BEARER_TOKEN_HERE>",
) as sdk:

    res = sdk.llm.models.check_catalog_health(id="meetkai:custom-chat-v1")

    # Handle response
    print(res)

```

### Parameters

| Parameter                                                           | Type                                                                | Required                                                            | Description                                                         | Example                                                             |
| ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- |
| `id`                                                                | *str*                                                               | :heavy_check_mark:                                                  | N/A                                                                 | meetkai:custom-chat-v1                                              |
| `retries`                                                           | [Optional[utils.RetryConfig]](../../models/utils/retryconfig.md)    | :heavy_minus_sign:                                                  | Configuration to override the default retry behavior of the client. |                                                                     |

### Response

**[models.CatalogHealthResponse](../../models/cataloghealthresponse.md)**

### Errors

| Error Type             | Status Code            | Content Type           |
| ---------------------- | ---------------------- | ---------------------- |
| errors.SDKDefaultError | 4XX, 5XX               | \*/\*                  |

## list_catalog_org_access

Cluster operator view of an org's available cluster catalog entries and their activation state.

### Example Usage

<!-- UsageSnippet language="python" operationID="listModelCatalogOrgAccess" method="get" path="/api/v1/llm/models/catalog/orgs/{org_id}/access" -->
```python
from meetkai_mka1 import SDK


with SDK(
    bearer_auth="<YOUR_BEARER_TOKEN_HERE>",
) as sdk:

    res = sdk.llm.models.list_catalog_org_access(org_id="org-acme")

    # Handle response
    print(res)

```

### Parameters

| Parameter                                                           | Type                                                                | Required                                                            | Description                                                         | Example                                                             |
| ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- |
| `org_id`                                                            | *str*                                                               | :heavy_check_mark:                                                  | N/A                                                                 | org-acme                                                            |
| `retries`                                                           | [Optional[utils.RetryConfig]](../../models/utils/retryconfig.md)    | :heavy_minus_sign:                                                  | Configuration to override the default retry behavior of the client. |                                                                     |

### Response

**[models.AccessListResponse](../../models/accesslistresponse.md)**

### Errors

| Error Type             | Status Code            | Content Type           |
| ---------------------- | ---------------------- | ---------------------- |
| errors.SDKDefaultError | 4XX, 5XX               | \*/\*                  |

## add_catalog_org_access

Idempotently adds availability without revoking any model names. Set activate to true to also activate every requested model from the cluster source in the target organization. Grants and activations are atomic per request; a name active from another source returns 409 without changing access or activation. Existing activation audit details are preserved on retries.

### Example Usage

<!-- UsageSnippet language="python" operationID="addModelCatalogOrgAccess" method="post" path="/api/v1/llm/models/catalog/orgs/{org_id}/access" -->
```python
from meetkai_mka1 import SDK


with SDK(
    bearer_auth="<YOUR_BEARER_TOKEN_HERE>",
) as sdk:

    res = sdk.llm.models.add_catalog_org_access(org_id="org-acme", model_ids=[
        "functionary",
    ], activate=False)

    # Handle response
    print(res)

```

### Parameters

| Parameter                                                                                       | Type                                                                                            | Required                                                                                        | Description                                                                                     | Example                                                                                         |
| ----------------------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------------------- |
| `org_id`                                                                                        | *str*                                                                                           | :heavy_check_mark:                                                                              | N/A                                                                                             | org-acme                                                                                        |
| `model_ids`                                                                                     | List[*str*]                                                                                     | :heavy_check_mark:                                                                              | N/A                                                                                             |                                                                                                 |
| `activate`                                                                                      | *Optional[bool]*                                                                                | :heavy_minus_sign:                                                                              | Explicitly activate the requested cluster models in the target organization. Defaults to false. |                                                                                                 |
| `retries`                                                                                       | [Optional[utils.RetryConfig]](../../models/utils/retryconfig.md)                                | :heavy_minus_sign:                                                                              | Configuration to override the default retry behavior of the client.                             |                                                                                                 |

### Response

**[models.AccessMutationResponse](../../models/accessmutationresponse.md)**

### Errors

| Error Type             | Status Code            | Content Type           |
| ---------------------- | ---------------------- | ---------------------- |
| errors.SDKDefaultError | 4XX, 5XX               | \*/\*                  |

## replace_catalog_org_access

Serializable full replacement; revoked active cluster names are deactivated and their org price rows are closed.

### Example Usage

<!-- UsageSnippet language="python" operationID="replaceModelCatalogOrgAccess" method="put" path="/api/v1/llm/models/catalog/orgs/{org_id}/access" -->
```python
from meetkai_mka1 import SDK


with SDK(
    bearer_auth="<YOUR_BEARER_TOKEN_HERE>",
) as sdk:

    res = sdk.llm.models.replace_catalog_org_access(org_id="org-acme", model_ids=[
        "functionary",
    ])

    # Handle response
    print(res)

```

### Parameters

| Parameter                                                           | Type                                                                | Required                                                            | Description                                                         | Example                                                             |
| ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- |
| `org_id`                                                            | *str*                                                               | :heavy_check_mark:                                                  | N/A                                                                 | org-acme                                                            |
| `model_ids`                                                         | List[*str*]                                                         | :heavy_check_mark:                                                  | N/A                                                                 |                                                                     |
| `retries`                                                           | [Optional[utils.RetryConfig]](../../models/utils/retryconfig.md)    | :heavy_minus_sign:                                                  | Configuration to override the default retry behavior of the client. |                                                                     |

### Response

**[models.AccessMutationResponse](../../models/accessmutationresponse.md)**

### Errors

| Error Type             | Status Code            | Content Type           |
| ---------------------- | ---------------------- | ---------------------- |
| errors.SDKDefaultError | 4XX, 5XX               | \*/\*                  |

## list_catalog_model_access

Cluster operator reverse lookup showing availability and activation for one cluster catalog id.

### Example Usage

<!-- UsageSnippet language="python" operationID="listModelCatalogAccess" method="get" path="/api/v1/llm/models/catalog/access" -->
```python
from meetkai_mka1 import SDK


with SDK(
    bearer_auth="<YOUR_BEARER_TOKEN_HERE>",
) as sdk:

    res = sdk.llm.models.list_catalog_model_access(model_id="functionary")

    # Handle response
    print(res)

```

### Parameters

| Parameter                                                           | Type                                                                | Required                                                            | Description                                                         | Example                                                             |
| ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- |
| `model_id`                                                          | *str*                                                               | :heavy_check_mark:                                                  | N/A                                                                 | functionary                                                         |
| `retries`                                                           | [Optional[utils.RetryConfig]](../../models/utils/retryconfig.md)    | :heavy_minus_sign:                                                  | Configuration to override the default retry behavior of the client. |                                                                     |

### Response

**[models.ReverseAccessListResponse](../../models/reverseaccesslistresponse.md)**

### Errors

| Error Type             | Status Code            | Content Type           |
| ---------------------- | ---------------------- | ---------------------- |
| errors.SDKDefaultError | 4XX, 5XX               | \*/\*                  |

## list_registry

Single management view of every active name with source-qualified definition, health, price, and activation audit details.

### Example Usage

<!-- UsageSnippet language="python" operationID="listModelRegistry" method="get" path="/api/v1/llm/models/registry" -->
```python
from meetkai_mka1 import SDK


with SDK(
    bearer_auth="<YOUR_BEARER_TOKEN_HERE>",
) as sdk:

    res = sdk.llm.models.list_registry()

    # Handle response
    print(res)

```

### Parameters

| Parameter                                                           | Type                                                                | Required                                                            | Description                                                         |
| ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- |
| `retries`                                                           | [Optional[utils.RetryConfig]](../../models/utils/retryconfig.md)    | :heavy_minus_sign:                                                  | Configuration to override the default retry behavior of the client. |

### Response

**[models.RegistryManagementListResponse](../../models/registrymanagementlistresponse.md)**

### Errors

| Error Type             | Status Code            | Content Type           |
| ---------------------- | ---------------------- | ---------------------- |
| errors.SDKDefaultError | 4XX, 5XX               | \*/\*                  |

## activate_registry_entry

Claims a model name from one catalog source. Re-activation from the same source is idempotent; a different holder returns 409.

### Example Usage

<!-- UsageSnippet language="python" operationID="activateModelRegistryEntry" method="post" path="/api/v1/llm/models/registry" -->
```python
from meetkai_mka1 import SDK


with SDK(
    bearer_auth="<YOUR_BEARER_TOKEN_HERE>",
) as sdk:

    res = sdk.llm.models.activate_registry_entry(source="cluster", model_id="functionary")

    # Handle response
    print(res)

```

### Parameters

| Parameter                                                           | Type                                                                | Required                                                            | Description                                                         |
| ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- |
| `source`                                                            | [models.RegistrySource](../../models/registrysource.md)             | :heavy_check_mark:                                                  | N/A                                                                 |
| `model_id`                                                          | *str*                                                               | :heavy_check_mark:                                                  | N/A                                                                 |
| `retries`                                                           | [Optional[utils.RetryConfig]](../../models/utils/retryconfig.md)    | :heavy_minus_sign:                                                  | Configuration to override the default retry behavior of the client. |

### Response

**[models.RegistryEntryResponse](../../models/registryentryresponse.md)**

### Errors

| Error Type             | Status Code            | Content Type           |
| ---------------------- | ---------------------- | ---------------------- |
| errors.SDKDefaultError | 4XX, 5XX               | \*/\*                  |

## deactivate_registry_entry

Idempotently removes the active name and closes its org-scope price rows without touching the catalog definition.

### Example Usage

<!-- UsageSnippet language="python" operationID="deactivateModelRegistryEntry" method="delete" path="/api/v1/llm/models/registry" -->
```python
from meetkai_mka1 import SDK


with SDK(
    bearer_auth="<YOUR_BEARER_TOKEN_HERE>",
) as sdk:

    res = sdk.llm.models.deactivate_registry_entry(id="functionary")

    # Handle response
    print(res)

```

### Parameters

| Parameter                                                           | Type                                                                | Required                                                            | Description                                                         | Example                                                             |
| ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- |
| `id`                                                                | *str*                                                               | :heavy_check_mark:                                                  | N/A                                                                 | functionary                                                         |
| `retries`                                                           | [Optional[utils.RetryConfig]](../../models/utils/retryconfig.md)    | :heavy_minus_sign:                                                  | Configuration to override the default retry behavior of the client. |                                                                     |

### Response

**[models.DeactivateRegistryEntryResponse](../../models/deactivateregistryentryresponse.md)**

### Errors

| Error Type             | Status Code            | Content Type           |
| ---------------------- | ---------------------- | ---------------------- |
| errors.SDKDefaultError | 4XX, 5XX               | \*/\*                  |

## list_org_auto_models

Returns every endpoint for which this org has set its own `"auto"` target. Endpoints not listed fall through to the operator's YAML defaults.

### Example Usage

<!-- UsageSnippet language="python" operationID="listOrgAutoModels" method="get" path="/api/v1/llm/models/auto" -->
```python
from meetkai_mka1 import SDK


with SDK(
    bearer_auth="<YOUR_BEARER_TOKEN_HERE>",
) as sdk:

    res = sdk.llm.models.list_org_auto_models()

    # Handle response
    print(res)

```

### Parameters

| Parameter                                                           | Type                                                                | Required                                                            | Description                                                         |
| ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- |
| `retries`                                                           | [Optional[utils.RetryConfig]](../../models/utils/retryconfig.md)    | :heavy_minus_sign:                                                  | Configuration to override the default retry behavior of the client. |

### Response

**[models.ListOrgAutoModelsResponse](../../models/listorgautomodelsresponse.md)**

### Errors

| Error Type             | Status Code            | Content Type           |
| ---------------------- | ---------------------- | ---------------------- |
| errors.SDKDefaultError | 4XX, 5XX               | \*/\*                  |

## put_org_auto_model

Stores either the existing direct `{ endpoint → model_id }` alias or a judge policy with candidate models. Judge routing is supported for responses, completions, transcriptions, and TTS. The judge must be a non-reasoning text LLM. All configured models must be active when written; revoked candidates are filtered at request time, while an unavailable judge is an explicit error.

### Example Usage

<!-- UsageSnippet language="python" operationID="putOrgAutoModel" method="put" path="/api/v1/llm/models/auto/{endpoint}" -->
```python
from meetkai_mka1 import SDK


with SDK(
    bearer_auth="<YOUR_BEARER_TOKEN_HERE>",
) as sdk:

    res = sdk.llm.models.put_org_auto_model(endpoint="responses", body={
        "policy": "price",
        "judge_model_id": "meetkai:functionary-es-mini",
        "candidate_model_ids": [
            "meetkai:functionary-pt",
            "meetkai:functionary-es",
        ],
    })

    # Handle response
    print(res)

```

### Parameters

| Parameter                                                               | Type                                                                    | Required                                                                | Description                                                             | Example                                                                 |
| ----------------------------------------------------------------------- | ----------------------------------------------------------------------- | ----------------------------------------------------------------------- | ----------------------------------------------------------------------- | ----------------------------------------------------------------------- |
| `endpoint`                                                              | [models.AutoEndpoint](../../models/autoendpoint.md)                     | :heavy_check_mark:                                                      | N/A                                                                     | responses                                                               |
| `body`                                                                  | [models.PutOrgAutoModelRequest](../../models/putorgautomodelrequest.md) | :heavy_check_mark:                                                      | N/A                                                                     |                                                                         |
| `retries`                                                               | [Optional[utils.RetryConfig]](../../models/utils/retryconfig.md)        | :heavy_minus_sign:                                                      | Configuration to override the default retry behavior of the client.     |                                                                         |

### Response

**[models.PutOrgAutoModelResponse](../../models/putorgautomodelresponse.md)**

### Errors

| Error Type             | Status Code            | Content Type           |
| ---------------------- | ---------------------- | ---------------------- |
| errors.SDKDefaultError | 4XX, 5XX               | \*/\*                  |

## delete_org_auto_model

Removes the per-org override for the endpoint. Subsequent `model: "auto"` requests fall through to the operator's YAML default again.

### Example Usage

<!-- UsageSnippet language="python" operationID="deleteOrgAutoModel" method="delete" path="/api/v1/llm/models/auto/{endpoint}" -->
```python
from meetkai_mka1 import SDK


with SDK(
    bearer_auth="<YOUR_BEARER_TOKEN_HERE>",
) as sdk:

    res = sdk.llm.models.delete_org_auto_model(endpoint="responses")

    # Handle response
    print(res)

```

### Parameters

| Parameter                                                           | Type                                                                | Required                                                            | Description                                                         | Example                                                             |
| ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- |
| `endpoint`                                                          | [models.AutoEndpoint](../../models/autoendpoint.md)                 | :heavy_check_mark:                                                  | N/A                                                                 | responses                                                           |
| `retries`                                                           | [Optional[utils.RetryConfig]](../../models/utils/retryconfig.md)    | :heavy_minus_sign:                                                  | Configuration to override the default retry behavior of the client. |                                                                     |

### Response

**[models.DeleteOrgAutoModelResponse](../../models/deleteorgautomodelresponse.md)**

### Errors

| Error Type             | Status Code            | Content Type           |
| ---------------------- | ---------------------- | ---------------------- |
| errors.SDKDefaultError | 4XX, 5XX               | \*/\*                  |

## get_cluster_currency

Returns the single cluster-wide ISO-4217 currency code (null if not set).

### Example Usage

<!-- UsageSnippet language="python" operationID="getClusterCurrency" method="get" path="/api/v1/llm/models/pricing/currency" -->
```python
from meetkai_mka1 import SDK


with SDK(
    bearer_auth="<YOUR_BEARER_TOKEN_HERE>",
) as sdk:

    res = sdk.llm.models.get_cluster_currency()

    # Handle response
    print(res)

```

### Parameters

| Parameter                                                           | Type                                                                | Required                                                            | Description                                                         |
| ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- |
| `retries`                                                           | [Optional[utils.RetryConfig]](../../models/utils/retryconfig.md)    | :heavy_minus_sign:                                                  | Configuration to override the default retry behavior of the client. |

### Response

**[models.ClusterCurrencyResponse](../../models/clustercurrencyresponse.md)**

### Errors

| Error Type             | Status Code            | Content Type           |
| ---------------------- | ---------------------- | ---------------------- |
| errors.SDKDefaultError | 4XX, 5XX               | \*/\*                  |

## set_cluster_currency

Sets the cluster-wide currency. Changing it does not auto-convert existing prices.

### Example Usage

<!-- UsageSnippet language="python" operationID="setClusterCurrency" method="put" path="/api/v1/llm/models/pricing/currency" -->
```python
from meetkai_mka1 import SDK


with SDK(
    bearer_auth="<YOUR_BEARER_TOKEN_HERE>",
) as sdk:

    res = sdk.llm.models.set_cluster_currency(currency="Nakfa")

    # Handle response
    print(res)

```

### Parameters

| Parameter                                                           | Type                                                                | Required                                                            | Description                                                         |
| ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- |
| `currency`                                                          | *str*                                                               | :heavy_check_mark:                                                  | N/A                                                                 |
| `retries`                                                           | [Optional[utils.RetryConfig]](../../models/utils/retryconfig.md)    | :heavy_minus_sign:                                                  | Configuration to override the default retry behavior of the client. |

### Response

**[models.ClusterCurrencyResponse](../../models/clustercurrencyresponse.md)**

### Errors

| Error Type             | Status Code            | Content Type           |
| ---------------------- | ---------------------- | ---------------------- |
| errors.SDKDefaultError | 4XX, 5XX               | \*/\*                  |

## list_cluster_prices

Without `model`, lists every model's current cluster-default price. With `model`, returns that model's full dated history.

### Example Usage

<!-- UsageSnippet language="python" operationID="listClusterPrices" method="get" path="/api/v1/llm/models/pricing" -->
```python
from meetkai_mka1 import SDK


with SDK(
    bearer_auth="<YOUR_BEARER_TOKEN_HERE>",
) as sdk:

    res = sdk.llm.models.list_cluster_prices()

    # Handle response
    print(res)

```

### Parameters

| Parameter                                                           | Type                                                                | Required                                                            | Description                                                         |
| ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- |
| `model`                                                             | *Optional[str]*                                                     | :heavy_minus_sign:                                                  | N/A                                                                 |
| `retries`                                                           | [Optional[utils.RetryConfig]](../../models/utils/retryconfig.md)    | :heavy_minus_sign:                                                  | Configuration to override the default retry behavior of the client. |

### Response

**[models.ListModelPricesResponse](../../models/listmodelpricesresponse.md)**

### Errors

| Error Type             | Status Code            | Content Type           |
| ---------------------- | ---------------------- | ---------------------- |
| errors.SDKDefaultError | 4XX, 5XX               | \*/\*                  |

## set_cluster_price

Upserts the cluster-default price for a model as a new dated version. `rates` is a flexible metric→rate map; omitted metrics are not charged.

### Example Usage

<!-- UsageSnippet language="python" operationID="setClusterPrice" method="put" path="/api/v1/llm/models/pricing" -->
```python
from meetkai_mka1 import SDK


with SDK(
    bearer_auth="<YOUR_BEARER_TOKEN_HERE>",
) as sdk:

    res = sdk.llm.models.set_cluster_price(model="Cruze", rates={})

    # Handle response
    print(res)

```

### Parameters

| Parameter                                                               | Type                                                                    | Required                                                                | Description                                                             |
| ----------------------------------------------------------------------- | ----------------------------------------------------------------------- | ----------------------------------------------------------------------- | ----------------------------------------------------------------------- |
| `model`                                                                 | *str*                                                                   | :heavy_check_mark:                                                      | N/A                                                                     |
| `rates`                                                                 | [models.PutModelPriceBodyRates](../../models/putmodelpricebodyrates.md) | :heavy_check_mark:                                                      | N/A                                                                     |
| `retries`                                                               | [Optional[utils.RetryConfig]](../../models/utils/retryconfig.md)        | :heavy_minus_sign:                                                      | Configuration to override the default retry behavior of the client.     |

### Response

**[models.ModelPriceRow](../../models/modelpricerow.md)**

### Errors

| Error Type             | Status Code            | Content Type           |
| ---------------------- | ---------------------- | ---------------------- |
| errors.SDKDefaultError | 4XX, 5XX               | \*/\*                  |

## clear_cluster_price

Closes the cluster-default price. Active cluster lineage then uses an org override or becomes unpriced ($0).

### Example Usage

<!-- UsageSnippet language="python" operationID="clearClusterPrice" method="delete" path="/api/v1/llm/models/pricing" -->
```python
from meetkai_mka1 import SDK


with SDK(
    bearer_auth="<YOUR_BEARER_TOKEN_HERE>",
) as sdk:

    res = sdk.llm.models.clear_cluster_price(model="Alpine")

    # Handle response
    print(res)

```

### Parameters

| Parameter                                                           | Type                                                                | Required                                                            | Description                                                         |
| ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- |
| `model`                                                             | *str*                                                               | :heavy_check_mark:                                                  | N/A                                                                 |
| `retries`                                                           | [Optional[utils.RetryConfig]](../../models/utils/retryconfig.md)    | :heavy_minus_sign:                                                  | Configuration to override the default retry behavior of the client. |

### Response

**[models.DeleteModelPriceResponse](../../models/deletemodelpriceresponse.md)**

### Errors

| Error Type             | Status Code            | Content Type           |
| ---------------------- | ---------------------- | ---------------------- |
| errors.SDKDefaultError | 4XX, 5XX               | \*/\*                  |

## list_org_prices

Without `model`, lists the org's current overrides. With `model`, returns that override's dated history.

### Example Usage

<!-- UsageSnippet language="python" operationID="listOrgPrices" method="get" path="/api/v1/llm/models/pricing/org/{org_id}" -->
```python
from meetkai_mka1 import SDK


with SDK(
    bearer_auth="<YOUR_BEARER_TOKEN_HERE>",
) as sdk:

    res = sdk.llm.models.list_org_prices(org_id="<id>")

    # Handle response
    print(res)

```

### Parameters

| Parameter                                                           | Type                                                                | Required                                                            | Description                                                         |
| ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- |
| `org_id`                                                            | *str*                                                               | :heavy_check_mark:                                                  | N/A                                                                 |
| `model`                                                             | *Optional[str]*                                                     | :heavy_minus_sign:                                                  | N/A                                                                 |
| `retries`                                                           | [Optional[utils.RetryConfig]](../../models/utils/retryconfig.md)    | :heavy_minus_sign:                                                  | Configuration to override the default retry behavior of the client. |

### Response

**[models.ListModelPricesResponse](../../models/listmodelpricesresponse.md)**

### Errors

| Error Type             | Status Code            | Content Type           |
| ---------------------- | ---------------------- | ---------------------- |
| errors.SDKDefaultError | 4XX, 5XX               | \*/\*                  |

## set_org_price

Upserts a dated per-org price. Cluster lineage falls back to the cluster default; BYO and serving lineage become unpriced when no org row exists.

### Example Usage

<!-- UsageSnippet language="python" operationID="setOrgPrice" method="put" path="/api/v1/llm/models/pricing/org/{org_id}" -->
```python
from meetkai_mka1 import SDK


with SDK(
    bearer_auth="<YOUR_BEARER_TOKEN_HERE>",
) as sdk:

    res = sdk.llm.models.set_org_price(org_id="<id>", model="Roadster", rates={})

    # Handle response
    print(res)

```

### Parameters

| Parameter                                                               | Type                                                                    | Required                                                                | Description                                                             |
| ----------------------------------------------------------------------- | ----------------------------------------------------------------------- | ----------------------------------------------------------------------- | ----------------------------------------------------------------------- |
| `org_id`                                                                | *str*                                                                   | :heavy_check_mark:                                                      | N/A                                                                     |
| `model`                                                                 | *str*                                                                   | :heavy_check_mark:                                                      | N/A                                                                     |
| `rates`                                                                 | [models.PutModelPriceBodyRates](../../models/putmodelpricebodyrates.md) | :heavy_check_mark:                                                      | N/A                                                                     |
| `retries`                                                               | [Optional[utils.RetryConfig]](../../models/utils/retryconfig.md)        | :heavy_minus_sign:                                                      | Configuration to override the default retry behavior of the client.     |

### Response

**[models.ModelPriceRow](../../models/modelpricerow.md)**

### Errors

| Error Type             | Status Code            | Content Type           |
| ---------------------- | ---------------------- | ---------------------- |
| errors.SDKDefaultError | 4XX, 5XX               | \*/\*                  |

## clear_org_price

Closes a per-org price. Only active cluster lineage can then fall back to the cluster default.

### Example Usage

<!-- UsageSnippet language="python" operationID="clearOrgPrice" method="delete" path="/api/v1/llm/models/pricing/org/{org_id}" -->
```python
from meetkai_mka1 import SDK


with SDK(
    bearer_auth="<YOUR_BEARER_TOKEN_HERE>",
) as sdk:

    res = sdk.llm.models.clear_org_price(org_id="<id>", model="XTS")

    # Handle response
    print(res)

```

### Parameters

| Parameter                                                           | Type                                                                | Required                                                            | Description                                                         |
| ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- |
| `org_id`                                                            | *str*                                                               | :heavy_check_mark:                                                  | N/A                                                                 |
| `model`                                                             | *str*                                                               | :heavy_check_mark:                                                  | N/A                                                                 |
| `retries`                                                           | [Optional[utils.RetryConfig]](../../models/utils/retryconfig.md)    | :heavy_minus_sign:                                                  | Configuration to override the default retry behavior of the client. |

### Response

**[models.DeleteModelPriceResponse](../../models/deletemodelpriceresponse.md)**

### Errors

| Error Type             | Status Code            | Content Type           |
| ---------------------- | ---------------------- | ---------------------- |
| errors.SDKDefaultError | 4XX, 5XX               | \*/\*                  |

## list_effective_prices

For every active model, returns its registry-aware price: an org row, a cluster default for cluster lineage, or unpriced ($0). Also lists the `auto` routing alias, priced at the per-metric maximum across every model it can be billed as (`resolves_to`): a judge policy's active candidates, or the direct/YAML target plus any reroute target it can fall through to.

### Example Usage

<!-- UsageSnippet language="python" operationID="listEffectivePrices" method="get" path="/api/v1/llm/models/pricing/effective" -->
```python
from meetkai_mka1 import SDK


with SDK(
    bearer_auth="<YOUR_BEARER_TOKEN_HERE>",
) as sdk:

    res = sdk.llm.models.list_effective_prices()

    # Handle response
    print(res)

```

### Parameters

| Parameter                                                           | Type                                                                | Required                                                            | Description                                                         |
| ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- |
| `x_on_behalf_of`                                                    | *Optional[str]*                                                     | :heavy_minus_sign:                                                  | Optional external end-user identifier forwarded by the API gateway. |
| `retries`                                                           | [Optional[utils.RetryConfig]](../../models/utils/retryconfig.md)    | :heavy_minus_sign:                                                  | Configuration to override the default retry behavior of the client. |

### Response

**[models.EffectivePricesResponse](../../models/effectivepricesresponse.md)**

### Errors

| Error Type             | Status Code            | Content Type           |
| ---------------------- | ---------------------- | ---------------------- |
| errors.SDKDefaultError | 4XX, 5XX               | \*/\*                  |