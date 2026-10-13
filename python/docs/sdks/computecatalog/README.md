# ComputeCatalog

## Overview

### Available Operations

* [list_accelerators](#list_accelerators) - List accelerators
* [get_accelerator](#get_accelerator) - Get an accelerator
* [list_compute_offers](#list_compute_offers) - List provider offers
* [list_compute_providers](#list_compute_providers) - List provider health
* [create_compute_quote](#create_compute_quote) - Create a quote

## list_accelerators

List accelerators

### Example Usage

<!-- UsageSnippet language="python" operationID="listAccelerators" method="get" path="/api/v1/compute/catalog/accelerators" -->
```python
from meetkai_mka1 import SDK


with SDK(
    bearer_auth="<YOUR_BEARER_TOKEN_HERE>",
) as sdk:

    res = sdk.compute_catalog.list_accelerators(limit=50)

    # Handle response
    print(res)

```

### Parameters

| Parameter                                                                         | Type                                                                              | Required                                                                          | Description                                                                       |
| --------------------------------------------------------------------------------- | --------------------------------------------------------------------------------- | --------------------------------------------------------------------------------- | --------------------------------------------------------------------------------- |
| `vendor`                                                                          | [Optional[models.ListAcceleratorsVendor]](../../models/listacceleratorsvendor.md) | :heavy_minus_sign:                                                                | N/A                                                                               |
| `cursor`                                                                          | *Optional[str]*                                                                   | :heavy_minus_sign:                                                                | N/A                                                                               |
| `limit`                                                                           | *Optional[int]*                                                                   | :heavy_minus_sign:                                                                | N/A                                                                               |
| `x_on_behalf_of`                                                                  | *Optional[str]*                                                                   | :heavy_minus_sign:                                                                | Optional external end-user identifier forwarded by the API gateway.               |
| `retries`                                                                         | [Optional[utils.RetryConfig]](../../models/utils/retryconfig.md)                  | :heavy_minus_sign:                                                                | Configuration to override the default retry behavior of the client.               |

### Response

**[models.ListAcceleratorsResponse](../../models/listacceleratorsresponse.md)**

### Errors

| Error Type             | Status Code            | Content Type           |
| ---------------------- | ---------------------- | ---------------------- |
| errors.SDKDefaultError | 4XX, 5XX               | \*/\*                  |

## get_accelerator

Get an accelerator

### Example Usage

<!-- UsageSnippet language="python" operationID="getAccelerator" method="get" path="/api/v1/compute/catalog/accelerators/{name}" -->
```python
from meetkai_mka1 import SDK


with SDK(
    bearer_auth="<YOUR_BEARER_TOKEN_HERE>",
) as sdk:

    res = sdk.compute_catalog.get_accelerator(name="<value>")

    # Handle response
    print(res)

```

### Parameters

| Parameter                                                           | Type                                                                | Required                                                            | Description                                                         |
| ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- |
| `name`                                                              | *str*                                                               | :heavy_check_mark:                                                  | N/A                                                                 |
| `x_on_behalf_of`                                                    | *Optional[str]*                                                     | :heavy_minus_sign:                                                  | Optional external end-user identifier forwarded by the API gateway. |
| `retries`                                                           | [Optional[utils.RetryConfig]](../../models/utils/retryconfig.md)    | :heavy_minus_sign:                                                  | Configuration to override the default retry behavior of the client. |

### Response

**[models.GetAcceleratorResponse](../../models/getacceleratorresponse.md)**

### Errors

| Error Type             | Status Code            | Content Type           |
| ---------------------- | ---------------------- | ---------------------- |
| errors.SDKDefaultError | 4XX, 5XX               | \*/\*                  |

## list_compute_offers

Cluster administrators may always read this route. Organization administrators may read it only when provider anonymity is disabled.

### Example Usage

<!-- UsageSnippet language="python" operationID="listComputeOffers" method="get" path="/api/v1/compute/catalog/offers" -->
```python
from meetkai_mka1 import SDK


with SDK(
    bearer_auth="<YOUR_BEARER_TOKEN_HERE>",
) as sdk:

    res = sdk.compute_catalog.list_compute_offers(limit=50)

    # Handle response
    print(res)

```

### Parameters

| Parameter                                                           | Type                                                                | Required                                                            | Description                                                         |
| ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- |
| `accelerator`                                                       | *Optional[str]*                                                     | :heavy_minus_sign:                                                  | N/A                                                                 |
| `gpu_count`                                                         | *Optional[int]*                                                     | :heavy_minus_sign:                                                  | N/A                                                                 |
| `interconnect`                                                      | [Optional[models.Interconnect]](../../models/interconnect.md)       | :heavy_minus_sign:                                                  | N/A                                                                 |
| `provider`                                                          | *Optional[str]*                                                     | :heavy_minus_sign:                                                  | N/A                                                                 |
| `region`                                                            | *Optional[str]*                                                     | :heavy_minus_sign:                                                  | N/A                                                                 |
| `available`                                                         | *Optional[bool]*                                                    | :heavy_minus_sign:                                                  | N/A                                                                 |
| `cursor`                                                            | *Optional[str]*                                                     | :heavy_minus_sign:                                                  | N/A                                                                 |
| `limit`                                                             | *Optional[int]*                                                     | :heavy_minus_sign:                                                  | N/A                                                                 |
| `x_on_behalf_of`                                                    | *Optional[str]*                                                     | :heavy_minus_sign:                                                  | Optional external end-user identifier forwarded by the API gateway. |
| `retries`                                                           | [Optional[utils.RetryConfig]](../../models/utils/retryconfig.md)    | :heavy_minus_sign:                                                  | Configuration to override the default retry behavior of the client. |

### Response

**[models.ListComputeOffersResponse](../../models/listcomputeoffersresponse.md)**

### Errors

| Error Type             | Status Code            | Content Type           |
| ---------------------- | ---------------------- | ---------------------- |
| errors.SDKDefaultError | 4XX, 5XX               | \*/\*                  |

## list_compute_providers

Cluster administrators may always read this route. Organization administrators may read it only when provider anonymity is disabled.

### Example Usage

<!-- UsageSnippet language="python" operationID="listComputeProviders" method="get" path="/api/v1/compute/catalog/providers" -->
```python
from meetkai_mka1 import SDK


with SDK(
    bearer_auth="<YOUR_BEARER_TOKEN_HERE>",
) as sdk:

    res = sdk.compute_catalog.list_compute_providers(limit=50)

    # Handle response
    print(res)

```

### Parameters

| Parameter                                                           | Type                                                                | Required                                                            | Description                                                         |
| ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- |
| `cursor`                                                            | *Optional[str]*                                                     | :heavy_minus_sign:                                                  | N/A                                                                 |
| `limit`                                                             | *Optional[int]*                                                     | :heavy_minus_sign:                                                  | N/A                                                                 |
| `x_on_behalf_of`                                                    | *Optional[str]*                                                     | :heavy_minus_sign:                                                  | Optional external end-user identifier forwarded by the API gateway. |
| `retries`                                                           | [Optional[utils.RetryConfig]](../../models/utils/retryconfig.md)    | :heavy_minus_sign:                                                  | Configuration to override the default retry behavior of the client. |

### Response

**[models.ListComputeProvidersResponse](../../models/listcomputeprovidersresponse.md)**

### Errors

| Error Type             | Status Code            | Content Type           |
| ---------------------- | ---------------------- | ---------------------- |
| errors.SDKDefaultError | 4XX, 5XX               | \*/\*                  |

## create_compute_quote

Create a quote

### Example Usage

<!-- UsageSnippet language="python" operationID="createComputeQuote" method="post" path="/api/v1/compute/catalog/quotes" -->
```python
from meetkai_mka1 import SDK


with SDK(
    bearer_auth="<YOUR_BEARER_TOKEN_HERE>",
) as sdk:

    res = sdk.compute_catalog.create_compute_quote(compute={
        "accelerator": "<value>",
        "ephemeral_disk_gb": 986693,
        "gpu_count": 546670,
    }, container={
        "image": "https://loremflickr.com/3170/1872?lock=3147859139793822",
    }, resource_type="job")

    # Handle response
    print(res)

```

### Parameters

| Parameter                                                                                 | Type                                                                                      | Required                                                                                  | Description                                                                               |
| ----------------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------------- |
| `compute`                                                                                 | [models.ComputeRequest](../../models/computerequest.md)                                   | :heavy_check_mark:                                                                        | N/A                                                                                       |
| `container`                                                                               | [models.ComputeQuoteRequestContainer](../../models/computequoterequestcontainer.md)       | :heavy_check_mark:                                                                        | N/A                                                                                       |
| `resource_type`                                                                           | [models.ComputeResourceType](../../models/computeresourcetype.md)                         | :heavy_check_mark:                                                                        | N/A                                                                                       |
| `x_on_behalf_of`                                                                          | *Optional[str]*                                                                           | :heavy_minus_sign:                                                                        | Optional external end-user identifier forwarded by the API gateway.                       |
| `access`                                                                                  | [Optional[models.ComputeQuoteRequestAccess]](../../models/computequoterequestaccess.md)   | :heavy_minus_sign:                                                                        | N/A                                                                                       |
| `placement`                                                                               | [Optional[models.ComputePlacement]](../../models/computeplacement.md)                     | :heavy_minus_sign:                                                                        | N/A                                                                                       |
| `service`                                                                                 | [Optional[models.Service]](../../models/service.md)                                       | :heavy_minus_sign:                                                                        | N/A                                                                                       |
| `volumes`                                                                                 | List[[models.ComputeStandaloneVolumeMount](../../models/computestandalonevolumemount.md)] | :heavy_minus_sign:                                                                        | N/A                                                                                       |
| `retries`                                                                                 | [Optional[utils.RetryConfig]](../../models/utils/retryconfig.md)                          | :heavy_minus_sign:                                                                        | Configuration to override the default retry behavior of the client.                       |

### Response

**[models.CreateComputeQuoteResponse](../../models/createcomputequoteresponse.md)**

### Errors

| Error Type             | Status Code            | Content Type           |
| ---------------------- | ---------------------- | ---------------------- |
| errors.SDKDefaultError | 4XX, 5XX               | \*/\*                  |