# ComputePricing

## Overview

### Available Operations

* [GetPricing](#getpricing) - Get the latest committed storage price
* [PutPricing](#putpricing) - Create an immutable storage-price version

## GetPricing

The latest version may be scheduled for the next UTC hour. Before the first version is written this route returns pricing_not_configured.

### Example Usage

<!-- UsageSnippet language="csharp" operationID="getPricing" method="get" path="/api/v1/compute/pricing" -->
```csharp
using MeetKai.MKA1;
using MeetKai.MKA1.Types.Components;

var sdk = new SDK(bearerAuth: "<YOUR_BEARER_TOKEN_HERE>");

var res = await sdk.ComputePricing.GetPricingAsync();

// handle response
```

### Parameters

| Parameter                                                           | Type                                                                | Required                                                            | Description                                                         |
| ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- |
| `XOnBehalfOf`                                                       | *string*                                                            | :heavy_minus_sign:                                                  | Optional external end-user identifier forwarded by the API gateway. |

### Response

**[GetPricingResponse](../../Types/Requests/GetPricingResponse.md)**

### Errors

| Error Type                             | Status Code                            | Content Type                           |
| -------------------------------------- | -------------------------------------- | -------------------------------------- |
| MeetKai.MKA1.Types.Errors.APIException | 4XX, 5XX                               | \*/\*                                  |

## PutPricing

Cluster administrators only. If-Match: 0 performs the explicit bootstrap. Every version activates at the next UTC-hour boundary; equivalent idempotent replay precedes version comparison.

### Example Usage

<!-- UsageSnippet language="csharp" operationID="putPricing" method="put" path="/api/v1/compute/pricing" -->
```csharp
using MeetKai.MKA1;
using MeetKai.MKA1.Types.Components;

var sdk = new SDK(bearerAuth: "<YOUR_BEARER_TOKEN_HERE>");

var res = await sdk.ComputePricing.PutPricingAsync(
    idempotencyKey: "<value>",
    ifMatch: "<value>",
    body: new ComputePricingUpdate() {
        VolumeStorageUsdPerGibHour = 6479.35D,
    }
);

// handle response
```

### Parameters

| Parameter                                                              | Type                                                                   | Required                                                               | Description                                                            |
| ---------------------------------------------------------------------- | ---------------------------------------------------------------------- | ---------------------------------------------------------------------- | ---------------------------------------------------------------------- |
| `IdempotencyKey`                                                       | *string*                                                               | :heavy_check_mark:                                                     | N/A                                                                    |
| `IfMatch`                                                              | *string*                                                               | :heavy_check_mark:                                                     | Current pricing version. Use 0 for the first write.                    |
| `Body`                                                                 | [ComputePricingUpdate](../../Types/Components/ComputePricingUpdate.md) | :heavy_check_mark:                                                     | N/A                                                                    |
| `XOnBehalfOf`                                                          | *string*                                                               | :heavy_minus_sign:                                                     | Optional external end-user identifier forwarded by the API gateway.    |

### Response

**[PutPricingResponse](../../Types/Requests/PutPricingResponse.md)**

### Errors

| Error Type                             | Status Code                            | Content Type                           |
| -------------------------------------- | -------------------------------------- | -------------------------------------- |
| MeetKai.MKA1.Types.Errors.APIException | 4XX, 5XX                               | \*/\*                                  |