# ComputePricing

## Overview

### Available Operations

* [get_pricing](#get_pricing) - Get the latest committed storage price
* [put_pricing](#put_pricing) - Create an immutable storage-price version

## get_pricing

The latest version may be scheduled for the next UTC hour. Before the first version is written this route returns pricing_not_configured.

### Example Usage

<!-- UsageSnippet language="python" operationID="getPricing" method="get" path="/api/v1/compute/pricing" -->
```python
from meetkai_mka1 import SDK


with SDK(
    bearer_auth="<YOUR_BEARER_TOKEN_HERE>",
) as sdk:

    res = sdk.compute_pricing.get_pricing()

    # Handle response
    print(res)

```

### Parameters

| Parameter                                                           | Type                                                                | Required                                                            | Description                                                         |
| ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- |
| `x_on_behalf_of`                                                    | *Optional[str]*                                                     | :heavy_minus_sign:                                                  | Optional external end-user identifier forwarded by the API gateway. |
| `retries`                                                           | [Optional[utils.RetryConfig]](../../models/utils/retryconfig.md)    | :heavy_minus_sign:                                                  | Configuration to override the default retry behavior of the client. |

### Response

**[models.GetPricingResponse](../../models/getpricingresponse.md)**

### Errors

| Error Type             | Status Code            | Content Type           |
| ---------------------- | ---------------------- | ---------------------- |
| errors.SDKDefaultError | 4XX, 5XX               | \*/\*                  |

## put_pricing

Cluster administrators only. If-Match: 0 performs the explicit bootstrap. Every version activates at the next UTC-hour boundary; equivalent idempotent replay precedes version comparison.

### Example Usage

<!-- UsageSnippet language="python" operationID="putPricing" method="put" path="/api/v1/compute/pricing" -->
```python
from meetkai_mka1 import SDK


with SDK(
    bearer_auth="<YOUR_BEARER_TOKEN_HERE>",
) as sdk:

    res = sdk.compute_pricing.put_pricing(idempotency_key="<value>", if_match="<value>", volume_storage_usd_per_gib_hour=6479.35)

    # Handle response
    print(res)

```

### Parameters

| Parameter                                                                                                                                                                                                                                                                                                                             | Type                                                                                                                                                                                                                                                                                                                                  | Required                                                                                                                                                                                                                                                                                                                              | Description                                                                                                                                                                                                                                                                                                                           |
| ------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------- |
| `idempotency_key`                                                                                                                                                                                                                                                                                                                     | *str*                                                                                                                                                                                                                                                                                                                                 | :heavy_check_mark:                                                                                                                                                                                                                                                                                                                    | N/A                                                                                                                                                                                                                                                                                                                                   |
| `if_match`                                                                                                                                                                                                                                                                                                                            | *str*                                                                                                                                                                                                                                                                                                                                 | :heavy_check_mark:                                                                                                                                                                                                                                                                                                                    | Current pricing version. Use 0 for the first write.                                                                                                                                                                                                                                                                                   |
| `volume_storage_usd_per_gib_hour`                                                                                                                                                                                                                                                                                                     | *float*                                                                                                                                                                                                                                                                                                                               | :heavy_check_mark:                                                                                                                                                                                                                                                                                                                    | Exact USD-per-GiB-hour decimal from 0.000000000000000001 through 10000000000 inclusive, in increments of 0.000000000000000001, with at most 38 mantissa digits, 64 JSON-number characters, and exponent magnitude 128. This range is representable by the numeric(38,18) hourly ledger across the supported int64 stored-byte domain. |
| `x_on_behalf_of`                                                                                                                                                                                                                                                                                                                      | *Optional[str]*                                                                                                                                                                                                                                                                                                                       | :heavy_minus_sign:                                                                                                                                                                                                                                                                                                                    | Optional external end-user identifier forwarded by the API gateway.                                                                                                                                                                                                                                                                   |
| `retries`                                                                                                                                                                                                                                                                                                                             | [Optional[utils.RetryConfig]](../../models/utils/retryconfig.md)                                                                                                                                                                                                                                                                      | :heavy_minus_sign:                                                                                                                                                                                                                                                                                                                    | Configuration to override the default retry behavior of the client.                                                                                                                                                                                                                                                                   |

### Response

**[models.PutPricingResponse](../../models/putpricingresponse.md)**

### Errors

| Error Type             | Status Code            | Content Type           |
| ---------------------- | ---------------------- | ---------------------- |
| errors.SDKDefaultError | 4XX, 5XX               | \*/\*                  |