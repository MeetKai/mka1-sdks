# ComputeVolumes

## Overview

### Available Operations

* [ListStandaloneVolumes](#liststandalonevolumes) - List organization volumes
* [CreateStandaloneVolume](#createstandalonevolume) - Create a standalone shared volume
* [DeleteStandaloneVolume](#deletestandalonevolume) - Permanently delete a standalone volume
* [GetStandaloneVolume](#getstandalonevolume) - Get a standalone volume
* [ListStandaloneVolumeAttachments](#liststandalonevolumeattachments) - List volume attachments

## ListStandaloneVolumes

List organization volumes

### Example Usage

<!-- UsageSnippet language="csharp" operationID="listStandaloneVolumes" method="get" path="/api/v1/compute/volumes" -->
```csharp
using MeetKai.MKA1;
using MeetKai.MKA1.Types.Components;

var sdk = new SDK(bearerAuth: "<YOUR_BEARER_TOKEN_HERE>");

var res = await sdk.ComputeVolumes.ListStandaloneVolumesAsync(limit: 50);

// handle response
```

### Parameters

| Parameter                                                                              | Type                                                                                   | Required                                                                               | Description                                                                            |
| -------------------------------------------------------------------------------------- | -------------------------------------------------------------------------------------- | -------------------------------------------------------------------------------------- | -------------------------------------------------------------------------------------- |
| `Status`                                                                               | [ComputeStandaloneVolumeState](../../Types/Components/ComputeStandaloneVolumeState.md) | :heavy_minus_sign:                                                                     | N/A                                                                                    |
| `Cursor`                                                                               | *string*                                                                               | :heavy_minus_sign:                                                                     | N/A                                                                                    |
| `Limit`                                                                                | *long*                                                                                 | :heavy_minus_sign:                                                                     | N/A                                                                                    |
| `XOnBehalfOf`                                                                          | *string*                                                                               | :heavy_minus_sign:                                                                     | Optional external end-user identifier forwarded by the API gateway.                    |

### Response

**[ListStandaloneVolumesResponse](../../Types/Requests/ListStandaloneVolumesResponse.md)**

### Errors

| Error Type                             | Status Code                            | Content Type                           |
| -------------------------------------- | -------------------------------------- | -------------------------------------- |
| MeetKai.MKA1.Types.Errors.APIException | 4XX, 5XX                               | \*/\*                                  |

## CreateStandaloneVolume

Create a standalone shared volume

### Example Usage

<!-- UsageSnippet language="csharp" operationID="createStandaloneVolume" method="post" path="/api/v1/compute/volumes" -->
```csharp
using MeetKai.MKA1;
using MeetKai.MKA1.Types.Components;

var sdk = new SDK(bearerAuth: "<YOUR_BEARER_TOKEN_HERE>");

var res = await sdk.ComputeVolumes.CreateStandaloneVolumeAsync(
    idempotencyKey: "<value>",
    body: new ComputeStandaloneVolumeCreate() {
        Name = "<value>",
    }
);

// handle response
```

### Parameters

| Parameter                                                                                | Type                                                                                     | Required                                                                                 | Description                                                                              |
| ---------------------------------------------------------------------------------------- | ---------------------------------------------------------------------------------------- | ---------------------------------------------------------------------------------------- | ---------------------------------------------------------------------------------------- |
| `IdempotencyKey`                                                                         | *string*                                                                                 | :heavy_check_mark:                                                                       | N/A                                                                                      |
| `Body`                                                                                   | [ComputeStandaloneVolumeCreate](../../Types/Components/ComputeStandaloneVolumeCreate.md) | :heavy_check_mark:                                                                       | N/A                                                                                      |
| `XOnBehalfOf`                                                                            | *string*                                                                                 | :heavy_minus_sign:                                                                       | Optional external end-user identifier forwarded by the API gateway.                      |

### Response

**[CreateStandaloneVolumeResponse](../../Types/Requests/CreateStandaloneVolumeResponse.md)**

### Errors

| Error Type                             | Status Code                            | Content Type                           |
| -------------------------------------- | -------------------------------------- | -------------------------------------- |
| MeetKai.MKA1.Types.Errors.APIException | 4XX, 5XX                               | \*/\*                                  |

## DeleteStandaloneVolume

Deletion bypasses tenant enablement and budget gates, but is refused while non-terminal attachments exist.

### Example Usage

<!-- UsageSnippet language="csharp" operationID="deleteStandaloneVolume" method="delete" path="/api/v1/compute/volumes/{id}" -->
```csharp
using MeetKai.MKA1;
using MeetKai.MKA1.Types.Components;

var sdk = new SDK(bearerAuth: "<YOUR_BEARER_TOKEN_HERE>");

var res = await sdk.ComputeVolumes.DeleteStandaloneVolumeAsync(id: "<id>");

// handle response
```

### Parameters

| Parameter                                                           | Type                                                                | Required                                                            | Description                                                         |
| ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- |
| `Id`                                                                | *string*                                                            | :heavy_check_mark:                                                  | N/A                                                                 |
| `XOnBehalfOf`                                                       | *string*                                                            | :heavy_minus_sign:                                                  | Optional external end-user identifier forwarded by the API gateway. |

### Response

**[DeleteStandaloneVolumeResponse](../../Types/Requests/DeleteStandaloneVolumeResponse.md)**

### Errors

| Error Type                             | Status Code                            | Content Type                           |
| -------------------------------------- | -------------------------------------- | -------------------------------------- |
| MeetKai.MKA1.Types.Errors.APIException | 4XX, 5XX                               | \*/\*                                  |

## GetStandaloneVolume

Get a standalone volume

### Example Usage

<!-- UsageSnippet language="csharp" operationID="getStandaloneVolume" method="get" path="/api/v1/compute/volumes/{id}" -->
```csharp
using MeetKai.MKA1;
using MeetKai.MKA1.Types.Components;

var sdk = new SDK(bearerAuth: "<YOUR_BEARER_TOKEN_HERE>");

var res = await sdk.ComputeVolumes.GetStandaloneVolumeAsync(id: "<id>");

// handle response
```

### Parameters

| Parameter                                                           | Type                                                                | Required                                                            | Description                                                         |
| ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- |
| `Id`                                                                | *string*                                                            | :heavy_check_mark:                                                  | N/A                                                                 |
| `XOnBehalfOf`                                                       | *string*                                                            | :heavy_minus_sign:                                                  | Optional external end-user identifier forwarded by the API gateway. |

### Response

**[GetStandaloneVolumeResponse](../../Types/Requests/GetStandaloneVolumeResponse.md)**

### Errors

| Error Type                             | Status Code                            | Content Type                           |
| -------------------------------------- | -------------------------------------- | -------------------------------------- |
| MeetKai.MKA1.Types.Errors.APIException | 4XX, 5XX                               | \*/\*                                  |

## ListStandaloneVolumeAttachments

List volume attachments

### Example Usage

<!-- UsageSnippet language="csharp" operationID="listStandaloneVolumeAttachments" method="get" path="/api/v1/compute/volumes/{id}/attachments" -->
```csharp
using MeetKai.MKA1;
using MeetKai.MKA1.Types.Components;
using MeetKai.MKA1.Types.Requests;

var sdk = new SDK(bearerAuth: "<YOUR_BEARER_TOKEN_HERE>");

ListStandaloneVolumeAttachmentsRequest req = new ListStandaloneVolumeAttachmentsRequest() {
    Id = "<id>",
};

var res = await sdk.ComputeVolumes.ListStandaloneVolumeAttachmentsAsync(req);

// handle response
```

### Parameters

| Parameter                                                                                                | Type                                                                                                     | Required                                                                                                 | Description                                                                                              |
| -------------------------------------------------------------------------------------------------------- | -------------------------------------------------------------------------------------------------------- | -------------------------------------------------------------------------------------------------------- | -------------------------------------------------------------------------------------------------------- |
| `request`                                                                                                | [ListStandaloneVolumeAttachmentsRequest](../../Types/Requests/ListStandaloneVolumeAttachmentsRequest.md) | :heavy_check_mark:                                                                                       | The request object to use for the request.                                                               |

### Response

**[ListStandaloneVolumeAttachmentsResponse](../../Types/Requests/ListStandaloneVolumeAttachmentsResponse.md)**

### Errors

| Error Type                             | Status Code                            | Content Type                           |
| -------------------------------------- | -------------------------------------- | -------------------------------------- |
| MeetKai.MKA1.Types.Errors.APIException | 4XX, 5XX                               | \*/\*                                  |