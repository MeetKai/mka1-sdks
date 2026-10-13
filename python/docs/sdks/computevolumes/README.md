# ComputeVolumes

## Overview

### Available Operations

* [list_standalone_volumes](#list_standalone_volumes) - List organization volumes
* [create_standalone_volume](#create_standalone_volume) - Create a standalone shared volume
* [delete_standalone_volume](#delete_standalone_volume) - Permanently delete a standalone volume
* [get_standalone_volume](#get_standalone_volume) - Get a standalone volume
* [list_standalone_volume_attachments](#list_standalone_volume_attachments) - List volume attachments

## list_standalone_volumes

List organization volumes

### Example Usage

<!-- UsageSnippet language="python" operationID="listStandaloneVolumes" method="get" path="/api/v1/compute/volumes" -->
```python
from meetkai_mka1 import SDK


with SDK(
    bearer_auth="<YOUR_BEARER_TOKEN_HERE>",
) as sdk:

    res = sdk.compute_volumes.list_standalone_volumes(limit=50)

    # Handle response
    print(res)

```

### Parameters

| Parameter                                                                                     | Type                                                                                          | Required                                                                                      | Description                                                                                   |
| --------------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------------- |
| `status`                                                                                      | [Optional[models.ComputeStandaloneVolumeState]](../../models/computestandalonevolumestate.md) | :heavy_minus_sign:                                                                            | N/A                                                                                           |
| `cursor`                                                                                      | *Optional[str]*                                                                               | :heavy_minus_sign:                                                                            | N/A                                                                                           |
| `limit`                                                                                       | *Optional[int]*                                                                               | :heavy_minus_sign:                                                                            | N/A                                                                                           |
| `x_on_behalf_of`                                                                              | *Optional[str]*                                                                               | :heavy_minus_sign:                                                                            | Optional external end-user identifier forwarded by the API gateway.                           |
| `retries`                                                                                     | [Optional[utils.RetryConfig]](../../models/utils/retryconfig.md)                              | :heavy_minus_sign:                                                                            | Configuration to override the default retry behavior of the client.                           |

### Response

**[models.ListStandaloneVolumesResponse](../../models/liststandalonevolumesresponse.md)**

### Errors

| Error Type             | Status Code            | Content Type           |
| ---------------------- | ---------------------- | ---------------------- |
| errors.SDKDefaultError | 4XX, 5XX               | \*/\*                  |

## create_standalone_volume

Create a standalone shared volume

### Example Usage

<!-- UsageSnippet language="python" operationID="createStandaloneVolume" method="post" path="/api/v1/compute/volumes" -->
```python
from meetkai_mka1 import SDK


with SDK(
    bearer_auth="<YOUR_BEARER_TOKEN_HERE>",
) as sdk:

    res = sdk.compute_volumes.create_standalone_volume(idempotency_key="<value>", name="<value>")

    # Handle response
    print(res)

```

### Parameters

| Parameter                                                                                                                                                                                                                                                                                                                                                               | Type                                                                                                                                                                                                                                                                                                                                                                    | Required                                                                                                                                                                                                                                                                                                                                                                | Description                                                                                                                                                                                                                                                                                                                                                             |
| ----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------- |
| `idempotency_key`                                                                                                                                                                                                                                                                                                                                                       | *str*                                                                                                                                                                                                                                                                                                                                                                   | :heavy_check_mark:                                                                                                                                                                                                                                                                                                                                                      | N/A                                                                                                                                                                                                                                                                                                                                                                     |
| `name`                                                                                                                                                                                                                                                                                                                                                                  | *str*                                                                                                                                                                                                                                                                                                                                                                   | :heavy_check_mark:                                                                                                                                                                                                                                                                                                                                                      | N/A                                                                                                                                                                                                                                                                                                                                                                     |
| `x_on_behalf_of`                                                                                                                                                                                                                                                                                                                                                        | *Optional[str]*                                                                                                                                                                                                                                                                                                                                                         | :heavy_minus_sign:                                                                                                                                                                                                                                                                                                                                                      | Optional external end-user identifier forwarded by the API gateway.                                                                                                                                                                                                                                                                                                     |
| `data`                                                                                                                                                                                                                                                                                                                                                                  | List[[models.ComputeVolumeDataInput](../../models/computevolumedatainput.md)]                                                                                                                                                                                                                                                                                           | :heavy_minus_sign:                                                                                                                                                                                                                                                                                                                                                      | Repositories downloaded into the volume once, before it becomes ready. Each entry needs its own path. Entries on the organization's repositories are read with a short-lived token for the creating credential, which must carry read:repos; other sources are fetched anonymously. A failed download fails the volume, naming the entry; create a new volume to retry. |
| `retries`                                                                                                                                                                                                                                                                                                                                                               | [Optional[utils.RetryConfig]](../../models/utils/retryconfig.md)                                                                                                                                                                                                                                                                                                        | :heavy_minus_sign:                                                                                                                                                                                                                                                                                                                                                      | Configuration to override the default retry behavior of the client.                                                                                                                                                                                                                                                                                                     |

### Response

**[models.CreateStandaloneVolumeResponse](../../models/createstandalonevolumeresponse.md)**

### Errors

| Error Type             | Status Code            | Content Type           |
| ---------------------- | ---------------------- | ---------------------- |
| errors.SDKDefaultError | 4XX, 5XX               | \*/\*                  |

## delete_standalone_volume

Deletion bypasses tenant enablement and budget gates, but is refused while non-terminal attachments exist.

### Example Usage

<!-- UsageSnippet language="python" operationID="deleteStandaloneVolume" method="delete" path="/api/v1/compute/volumes/{id}" -->
```python
from meetkai_mka1 import SDK


with SDK(
    bearer_auth="<YOUR_BEARER_TOKEN_HERE>",
) as sdk:

    res = sdk.compute_volumes.delete_standalone_volume(id="<id>")

    # Handle response
    print(res)

```

### Parameters

| Parameter                                                           | Type                                                                | Required                                                            | Description                                                         |
| ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- |
| `id`                                                                | *str*                                                               | :heavy_check_mark:                                                  | N/A                                                                 |
| `x_on_behalf_of`                                                    | *Optional[str]*                                                     | :heavy_minus_sign:                                                  | Optional external end-user identifier forwarded by the API gateway. |
| `retries`                                                           | [Optional[utils.RetryConfig]](../../models/utils/retryconfig.md)    | :heavy_minus_sign:                                                  | Configuration to override the default retry behavior of the client. |

### Response

**[models.DeleteStandaloneVolumeResponse](../../models/deletestandalonevolumeresponse.md)**

### Errors

| Error Type             | Status Code            | Content Type           |
| ---------------------- | ---------------------- | ---------------------- |
| errors.SDKDefaultError | 4XX, 5XX               | \*/\*                  |

## get_standalone_volume

Get a standalone volume

### Example Usage

<!-- UsageSnippet language="python" operationID="getStandaloneVolume" method="get" path="/api/v1/compute/volumes/{id}" -->
```python
from meetkai_mka1 import SDK


with SDK(
    bearer_auth="<YOUR_BEARER_TOKEN_HERE>",
) as sdk:

    res = sdk.compute_volumes.get_standalone_volume(id="<id>")

    # Handle response
    print(res)

```

### Parameters

| Parameter                                                           | Type                                                                | Required                                                            | Description                                                         |
| ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- |
| `id`                                                                | *str*                                                               | :heavy_check_mark:                                                  | N/A                                                                 |
| `x_on_behalf_of`                                                    | *Optional[str]*                                                     | :heavy_minus_sign:                                                  | Optional external end-user identifier forwarded by the API gateway. |
| `retries`                                                           | [Optional[utils.RetryConfig]](../../models/utils/retryconfig.md)    | :heavy_minus_sign:                                                  | Configuration to override the default retry behavior of the client. |

### Response

**[models.GetStandaloneVolumeResponse](../../models/getstandalonevolumeresponse.md)**

### Errors

| Error Type             | Status Code            | Content Type           |
| ---------------------- | ---------------------- | ---------------------- |
| errors.SDKDefaultError | 4XX, 5XX               | \*/\*                  |

## list_standalone_volume_attachments

List volume attachments

### Example Usage

<!-- UsageSnippet language="python" operationID="listStandaloneVolumeAttachments" method="get" path="/api/v1/compute/volumes/{id}/attachments" -->
```python
from meetkai_mka1 import SDK


with SDK(
    bearer_auth="<YOUR_BEARER_TOKEN_HERE>",
) as sdk:

    res = sdk.compute_volumes.list_standalone_volume_attachments(id="<id>", limit=50)

    # Handle response
    print(res)

```

### Parameters

| Parameter                                                                                                         | Type                                                                                                              | Required                                                                                                          | Description                                                                                                       |
| ----------------------------------------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------------------------------------- |
| `id`                                                                                                              | *str*                                                                                                             | :heavy_check_mark:                                                                                                | N/A                                                                                                               |
| `status`                                                                                                          | [Optional[models.ComputeStandaloneVolumeAttachmentState]](../../models/computestandalonevolumeattachmentstate.md) | :heavy_minus_sign:                                                                                                | N/A                                                                                                               |
| `cursor`                                                                                                          | *Optional[str]*                                                                                                   | :heavy_minus_sign:                                                                                                | N/A                                                                                                               |
| `limit`                                                                                                           | *Optional[int]*                                                                                                   | :heavy_minus_sign:                                                                                                | N/A                                                                                                               |
| `x_on_behalf_of`                                                                                                  | *Optional[str]*                                                                                                   | :heavy_minus_sign:                                                                                                | Optional external end-user identifier forwarded by the API gateway.                                               |
| `retries`                                                                                                         | [Optional[utils.RetryConfig]](../../models/utils/retryconfig.md)                                                  | :heavy_minus_sign:                                                                                                | Configuration to override the default retry behavior of the client.                                               |

### Response

**[models.ListStandaloneVolumeAttachmentsResponse](../../models/liststandalonevolumeattachmentsresponse.md)**

### Errors

| Error Type             | Status Code            | Content Type           |
| ---------------------- | ---------------------- | ---------------------- |
| errors.SDKDefaultError | 4XX, 5XX               | \*/\*                  |