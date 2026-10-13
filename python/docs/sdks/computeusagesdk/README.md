# ComputeUsage

## Overview

### Available Operations

* [get_compute_usage](#get_compute_usage) - Get usage

## get_compute_usage

Get usage

### Example Usage

<!-- UsageSnippet language="python" operationID="getComputeUsage" method="get" path="/api/v1/compute/usage" -->
```python
from meetkai_mka1 import SDK


with SDK(
    bearer_auth="<YOUR_BEARER_TOKEN_HERE>",
) as sdk:

    res = sdk.compute_usage.get_compute_usage(limit=50)

    # Handle response
    print(res)

```

### Parameters

| Parameter                                                                                                                                      | Type                                                                                                                                           | Required                                                                                                                                       | Description                                                                                                                                    |
| ---------------------------------------------------------------------------------------------------------------------------------------------- | ---------------------------------------------------------------------------------------------------------------------------------------------- | ---------------------------------------------------------------------------------------------------------------------------------------------- | ---------------------------------------------------------------------------------------------------------------------------------------------- |
| `from_`                                                                                                                                        | [date](https://docs.python.org/3/library/datetime.html#date-objects)                                                                           | :heavy_minus_sign:                                                                                                                             | Inclusive RFC 3339 timestamp on an exact UTC minute boundary; never rounded.                                                                   |
| `to`                                                                                                                                           | [date](https://docs.python.org/3/library/datetime.html#date-objects)                                                                           | :heavy_minus_sign:                                                                                                                             | Exclusive RFC 3339 timestamp on an exact UTC minute boundary; never rounded and cannot be later than the server's current UTC minute boundary. |
| `resource_type`                                                                                                                                | [Optional[models.ComputeUsageResourceType]](../../models/computeusageresourcetype.md)                                                          | :heavy_minus_sign:                                                                                                                             | N/A                                                                                                                                            |
| `cursor`                                                                                                                                       | *Optional[str]*                                                                                                                                | :heavy_minus_sign:                                                                                                                             | N/A                                                                                                                                            |
| `limit`                                                                                                                                        | *Optional[int]*                                                                                                                                | :heavy_minus_sign:                                                                                                                             | N/A                                                                                                                                            |
| `x_on_behalf_of`                                                                                                                               | *Optional[str]*                                                                                                                                | :heavy_minus_sign:                                                                                                                             | Optional external end-user identifier forwarded by the API gateway.                                                                            |
| `retries`                                                                                                                                      | [Optional[utils.RetryConfig]](../../models/utils/retryconfig.md)                                                                               | :heavy_minus_sign:                                                                                                                             | Configuration to override the default retry behavior of the client.                                                                            |

### Response

**[models.GetComputeUsageResponse](../../models/getcomputeusageresponse.md)**

### Errors

| Error Type             | Status Code            | Content Type           |
| ---------------------- | ---------------------- | ---------------------- |
| errors.SDKDefaultError | 4XX, 5XX               | \*/\*                  |