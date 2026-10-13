# ComputeCatalog

## Overview

### Available Operations

* [ListAccelerators](#listaccelerators) - List accelerators
* [GetAccelerator](#getaccelerator) - Get an accelerator
* [ListComputeOffers](#listcomputeoffers) - List provider offers
* [ListComputeProviders](#listcomputeproviders) - List provider health
* [CreateComputeQuote](#createcomputequote) - Create a quote

## ListAccelerators

List accelerators

### Example Usage

<!-- UsageSnippet language="csharp" operationID="listAccelerators" method="get" path="/api/v1/compute/catalog/accelerators" -->
```csharp
using MeetKai.MKA1;
using MeetKai.MKA1.Types.Components;

var sdk = new SDK(bearerAuth: "<YOUR_BEARER_TOKEN_HERE>");

var res = await sdk.ComputeCatalog.ListAcceleratorsAsync(limit: 50);

// handle response
```

### Parameters

| Parameter                                                           | Type                                                                | Required                                                            | Description                                                         |
| ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- |
| `Vendor`                                                            | [Types.Requests.Vendor](../../Types/Requests/Vendor.md)             | :heavy_minus_sign:                                                  | N/A                                                                 |
| `Cursor`                                                            | *string*                                                            | :heavy_minus_sign:                                                  | N/A                                                                 |
| `Limit`                                                             | *long*                                                              | :heavy_minus_sign:                                                  | N/A                                                                 |
| `XOnBehalfOf`                                                       | *string*                                                            | :heavy_minus_sign:                                                  | Optional external end-user identifier forwarded by the API gateway. |

### Response

**[ListAcceleratorsResponse](../../Types/Requests/ListAcceleratorsResponse.md)**

### Errors

| Error Type                             | Status Code                            | Content Type                           |
| -------------------------------------- | -------------------------------------- | -------------------------------------- |
| MeetKai.MKA1.Types.Errors.APIException | 4XX, 5XX                               | \*/\*                                  |

## GetAccelerator

Get an accelerator

### Example Usage

<!-- UsageSnippet language="csharp" operationID="getAccelerator" method="get" path="/api/v1/compute/catalog/accelerators/{name}" -->
```csharp
using MeetKai.MKA1;
using MeetKai.MKA1.Types.Components;

var sdk = new SDK(bearerAuth: "<YOUR_BEARER_TOKEN_HERE>");

var res = await sdk.ComputeCatalog.GetAcceleratorAsync(name: "<value>");

// handle response
```

### Parameters

| Parameter                                                           | Type                                                                | Required                                                            | Description                                                         |
| ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- |
| `Name`                                                              | *string*                                                            | :heavy_check_mark:                                                  | N/A                                                                 |
| `XOnBehalfOf`                                                       | *string*                                                            | :heavy_minus_sign:                                                  | Optional external end-user identifier forwarded by the API gateway. |

### Response

**[GetAcceleratorResponse](../../Types/Requests/GetAcceleratorResponse.md)**

### Errors

| Error Type                             | Status Code                            | Content Type                           |
| -------------------------------------- | -------------------------------------- | -------------------------------------- |
| MeetKai.MKA1.Types.Errors.APIException | 4XX, 5XX                               | \*/\*                                  |

## ListComputeOffers

Cluster administrators may always read this route. Organization administrators may read it only when provider anonymity is disabled.

### Example Usage

<!-- UsageSnippet language="csharp" operationID="listComputeOffers" method="get" path="/api/v1/compute/catalog/offers" -->
```csharp
using MeetKai.MKA1;
using MeetKai.MKA1.Types.Components;
using MeetKai.MKA1.Types.Requests;

var sdk = new SDK(bearerAuth: "<YOUR_BEARER_TOKEN_HERE>");

ListComputeOffersRequest req = new ListComputeOffersRequest() {};

var res = await sdk.ComputeCatalog.ListComputeOffersAsync(req);

// handle response
```

### Parameters

| Parameter                                                                    | Type                                                                         | Required                                                                     | Description                                                                  |
| ---------------------------------------------------------------------------- | ---------------------------------------------------------------------------- | ---------------------------------------------------------------------------- | ---------------------------------------------------------------------------- |
| `request`                                                                    | [ListComputeOffersRequest](../../Types/Requests/ListComputeOffersRequest.md) | :heavy_check_mark:                                                           | The request object to use for the request.                                   |

### Response

**[ListComputeOffersResponse](../../Types/Requests/ListComputeOffersResponse.md)**

### Errors

| Error Type                             | Status Code                            | Content Type                           |
| -------------------------------------- | -------------------------------------- | -------------------------------------- |
| MeetKai.MKA1.Types.Errors.APIException | 4XX, 5XX                               | \*/\*                                  |

## ListComputeProviders

Cluster administrators may always read this route. Organization administrators may read it only when provider anonymity is disabled.

### Example Usage

<!-- UsageSnippet language="csharp" operationID="listComputeProviders" method="get" path="/api/v1/compute/catalog/providers" -->
```csharp
using MeetKai.MKA1;
using MeetKai.MKA1.Types.Components;

var sdk = new SDK(bearerAuth: "<YOUR_BEARER_TOKEN_HERE>");

var res = await sdk.ComputeCatalog.ListComputeProvidersAsync(limit: 50);

// handle response
```

### Parameters

| Parameter                                                           | Type                                                                | Required                                                            | Description                                                         |
| ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- |
| `Cursor`                                                            | *string*                                                            | :heavy_minus_sign:                                                  | N/A                                                                 |
| `Limit`                                                             | *long*                                                              | :heavy_minus_sign:                                                  | N/A                                                                 |
| `XOnBehalfOf`                                                       | *string*                                                            | :heavy_minus_sign:                                                  | Optional external end-user identifier forwarded by the API gateway. |

### Response

**[ListComputeProvidersResponse](../../Types/Requests/ListComputeProvidersResponse.md)**

### Errors

| Error Type                             | Status Code                            | Content Type                           |
| -------------------------------------- | -------------------------------------- | -------------------------------------- |
| MeetKai.MKA1.Types.Errors.APIException | 4XX, 5XX                               | \*/\*                                  |

## CreateComputeQuote

Create a quote

### Example Usage

<!-- UsageSnippet language="csharp" operationID="createComputeQuote" method="post" path="/api/v1/compute/catalog/quotes" -->
```csharp
using MeetKai.MKA1;
using MeetKai.MKA1.Types.Components;

var sdk = new SDK(bearerAuth: "<YOUR_BEARER_TOKEN_HERE>");

var res = await sdk.ComputeCatalog.CreateComputeQuoteAsync(body: new ComputeQuoteRequest() {
    Compute = new ComputeRequest() {
        Accelerator = "<value>",
        EphemeralDiskGb = 986693,
        GpuCount = 546670,
    },
    Container = new ComputeQuoteRequestContainer() {
        Image = "https://loremflickr.com/3170/1872?lock=3147859139793822",
    },
    ResourceType = ComputeResourceType.Job,
});

// handle response
```

### Parameters

| Parameter                                                            | Type                                                                 | Required                                                             | Description                                                          |
| -------------------------------------------------------------------- | -------------------------------------------------------------------- | -------------------------------------------------------------------- | -------------------------------------------------------------------- |
| `Body`                                                               | [ComputeQuoteRequest](../../Types/Components/ComputeQuoteRequest.md) | :heavy_check_mark:                                                   | N/A                                                                  |
| `XOnBehalfOf`                                                        | *string*                                                             | :heavy_minus_sign:                                                   | Optional external end-user identifier forwarded by the API gateway.  |

### Response

**[CreateComputeQuoteResponse](../../Types/Requests/CreateComputeQuoteResponse.md)**

### Errors

| Error Type                             | Status Code                            | Content Type                           |
| -------------------------------------- | -------------------------------------- | -------------------------------------- |
| MeetKai.MKA1.Types.Errors.APIException | 4XX, 5XX                               | \*/\*                                  |